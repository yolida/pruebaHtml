﻿using BusinessLayer;
using DataLayer;
using DataLayer.CRUD;
using FEI.ayuda;
using FEI.Base;
using FEI.CustomDialog;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using CheckBox = System.Windows.Controls.CheckBox;

namespace FEI.pages
{
    public partial class Factura_Sunat : Page
    {
        List<ComboBoxPares> tipos_comprobante = new List<ComboBoxPares>();
        List<clsEntityDocument> registros;
        //List<ReporteDocumento> lista_reporte;
        ReporteDocumento itemRow;
        ComboBoxPares cbpTipoComprobante;
        string fecha_inicio_formato;
        string fecha_fin_formato;
        clsEntityDatabaseLocal localDB;

        ReadGeneralData readGeneralData =   new ReadGeneralData();
        private readonly IData_Documentos _Documentos;
        Data_DatosFox data_DatosFox;
        Data_Usuario data_Usuario;
        List<Data_Documentos> data_Documentos   =   new List<Data_Documentos>();
        Data_Log data_Log;
        private Window padre;

        public Factura_Sunat(Window parent, Data_Usuario usuario)
        {
            InitializeComponent();
            padre = parent;
            Data_Documentos documentos  =   new Data_Documentos();
            _Documentos     =   (IData_Documentos)documentos;
            data_Usuario    =   usuario;

            data_DatosFox   =   new Data_DatosFox(data_Usuario.IdDatosFox);
            data_DatosFox.Read_DatosFox();
        }
        //Evento de carga de la ventana principal.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Mouse.OverrideCursor    =   System.Windows.Input.Cursors.Wait;

                DataTable dataTable     =   readGeneralData.GetDataTable("[dbo].[Read_TipoDocumentos]");
                DataRow row             =   dataTable.NewRow();
                row["Descripcion"]      =   "Todos los documentos";
                row["IdTipoDocumento"]  =   0;
                dataTable.Rows.Add(row);

                var items           =   (dataTable as IListSource).GetList();
                lstTipoDocumento.ItemsSource        =   items;
                lstTipoDocumento.DisplayMemberPath  =   "Descripcion";
                lstTipoDocumento.SelectedValuePath  =   "IdTipoDocumento";
                lstTipoDocumento.SelectedIndex      =   dataTable.Rows.Count - 1;

                datePick_inicio.Text    =   DateTime.Now.Date.ToString();
                datePick_fin.Text       =   DateTime.Now.Date.ToString();

                LoadGrid();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"La base de datos ha sido alterada, contacte con soporte. Detalle: {ex}", "Base de datos alterada", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }
        public async void LoadGrid()
        {
            dgDocumentos.ItemsSource    =   null;
            dgDocumentos.Items.Clear();

            try
            {
                Mouse.OverrideCursor        =   System.Windows.Input.Cursors.Wait;
                data_Documentos             =   await GetDocumentos();
                dgDocumentos.ItemsSource    =   data_Documentos;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Ha ocurrido un error al cargar los registros, detalle del error: {ex}", 
                    "Error al cargar los datos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally {
                Mouse.OverrideCursor = null;
            }
        }

        public async Task<List<Data_Documentos>> GetDocumentos()
        {
            var listDocumentos  =   new List<Data_Documentos>();
            try
            {
                listDocumentos  =   await _Documentos.GetListFiltered(data_DatosFox.IdDatosFox, DateTime.Parse(datePick_inicio.SelectedDate.ToString()), 
                                    DateTime.Parse(datePick_fin.SelectedDate.ToString()), int.Parse(lstTipoDocumento.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                listDocumentos  =   new List<Data_Documentos>();
            }

            return listDocumentos;
        }
        private void chkCell_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox               =   (CheckBox)e.OriginalSource;
            DataGridRow dataGridRow         =   VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            Data_Documentos data_Documentos =   (Data_Documentos)dataGridRow.DataContext;
            data_Documentos.Selectable      =   true;
        }

        private void chkCell_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox               =   (CheckBox)e.OriginalSource;
            DataGridRow dataGridRow         =   VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            Data_Documentos data_Documentos =   (Data_Documentos)dataGridRow.DataContext;
            data_Documentos.Selectable      =   false;
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Data_Documentos> selected_data_Documentos = new List<Data_Documentos>();
                foreach (var data_Documento in data_Documentos)
                {
                    if (data_Documento.Selectable == true)
                        selected_data_Documentos.Add(data_Documento);
                }

                if (selected_data_Documentos.Count() > 0)
                {
                    string enviados     =   string.Empty;
                    string noEnviados   =   string.Empty;
                    string mensajeFinal =   string.Empty;

                    ProgressDialogResult result = ProgressWindow.Execute(padre, "Procesando...", () => {
                        foreach (var selected_data_Documento in selected_data_Documentos)
                        {
                            ProcesarEnvio procesarEnvio =   new ProcesarEnvio(data_Usuario, selected_data_Documento.IdDocumento);
                            procesarEnvio.Post();
                        }
                    });
                    
                    foreach (var selected_data_Documento in selected_data_Documentos)
                    {
                        if (selected_data_Documento.EnviadoSunat == true)
                        {
                            enviados    +=  $", {selected_data_Documento.SerieCorrelativo}";
                        }
                        else
                        {
                            noEnviados  +=  $", {selected_data_Documento.SerieCorrelativo}";
                        }
                    }

                    if (string.IsNullOrEmpty(enviados)) //  Ningún enviado, puros rechazados como voz
                        mensajeFinal    =   $"No se pudo enviar ningún documento, los documentos rechazados son:\n {noEnviados}";

                    if (!string.IsNullOrEmpty(enviados) && string.IsNullOrEmpty(noEnviados))    //  Sin ningún documento rechazado
                        mensajeFinal    =   $"Se ha enviado a Sunat el(los) documento(s):\n {enviados}";

                    if (!string.IsNullOrEmpty(enviados) && !string.IsNullOrEmpty(noEnviados))   //  Con al menos un documento rechazado
                        mensajeFinal    =   $"Se ha enviado a Sunat el(los) documento(s):\n {enviados} y se han rechazado los siguientes documentos:\n {noEnviados}";

                    CustomDialogWindow customDialogWindow       =   new CustomDialogWindow();
                    customDialogWindow.Buttons                  =   CustomDialogButtons.OK;
                    customDialogWindow.Caption                  =   "Mensaje";
                    customDialogWindow.DefaultButton            =   CustomDialogResults.OK;
                    customDialogWindow.InstructionHeading       =   "Resultados del envío a Sunat";
                    customDialogWindow.InstructionIcon          =   CustomDialogIcons.Information;
                    customDialogWindow.InstructionText          =   mensajeFinal;
                    CustomDialogResults customDialogResults     =   customDialogWindow.Show();

                    LoadGrid();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Debe seleccionar al menos un documento");
            }
            catch (Exception ex)
            {
                var msg =   string.Concat(ex.InnerException?.Message,   ex.Message);
                data_Log = new Data_Log() { DetalleError = $"Detalle del error: {msg}", Comentario = "Error al enviar el documento a sunat desde la interfaz", IdUser_Empresa = data_Usuario.IdUser_Empresa };
                data_Log.Create_Log();
            }
        }
        
        private void btnConsultar_Click(object sender, RoutedEventArgs e)   =>  LoadGrid();
           
        private string sendToSunat(List<ReporteDocumento> seleccionados)
        {
            string retornar = string.Empty;
            //Por cada elemento seleccionado se envia a la sunat.
            foreach (var item in seleccionados)
            {
                bool resultado = new clsBaseSunat(localDB).cs_pxEnviarCE(item.Id,true);
                if (resultado)
                {
                    retornar += item.SerieNumero + "\n";
                }
            }
            return retornar;
        }

        private void DetalleItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReporteDocumento item = (ReporteDocumento)dgDocumentos.SelectedItem;
                if (item != null)
                {
                    frmDetalleComprobante Formulario = new frmDetalleComprobante(item.Id,localDB);
                    Formulario.ShowDialog();
                    if (Formulario.DialogResult.HasValue && Formulario.DialogResult.Value)
                    {
                        //cargarDataGrid();
                    }
                    // refrescarGrillaDocumentos(item.ComunicacionBaja);
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("detalle item " + ex.ToString());
            }
        }

        private void XMLEnvio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReporteDocumento item = (ReporteDocumento)dgDocumentos.SelectedItem;
                if (item != null)
                {
                    SaveFileDialog sfdDescargar = new SaveFileDialog();
                    DialogResult result = sfdDescargar.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string file = sfdDescargar.FileName;
                        if (file.Substring(file.Length - 4) != ".xml")
                        {
                            file = file + ".xml";
                        }
                        try
                        {
                            clsEntityDocument cabecera = new clsEntityDocument(localDB).cs_fxObtenerUnoPorId(item.Id);
                            string xml = string.Empty;

                            switch (cabecera.Cs_tag_InvoiceTypeCode)
                            {
                                case "01":
                                    xml = new clsNegocioCEFactura(localDB).cs_pxGenerarXMLAString(item.Id);
                                    break;
                                case "03":
                                    xml = new clsNegocioCEBoleta(localDB).cs_pxGenerarXMLAString(item.Id);
                                    break;
                                case "07":
                                    xml = new clsNegocioCENotaCredito(localDB).cs_pxGenerarXMLAString(item.Id);
                                    break;
                                case "08":
                                    xml = new clsNegocioCENotaDebito(localDB).cs_pxGenerarXMLAString(item.Id);
                                    break;
                            }
                            StreamWriter sw0 = new StreamWriter(file);
                            sw0.Write(xml);
                            sw0.Close();
                        }
                        catch (Exception ex)
                        {
                            clsBaseLog.cs_pxRegistarAdd("generar xml envio " + ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("xml envio gen " + ex.ToString());
            }
        }

        private void XMLRecepcion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReporteDocumento item = (ReporteDocumento)dgDocumentos.SelectedItem;
                if (item != null)
                {
                    clsEntityDocument cabecera = new clsEntityDocument(localDB).cs_fxObtenerUnoPorId(item.Id);
                    SaveFileDialog sfdDescargar = new SaveFileDialog();
                    DialogResult result = sfdDescargar.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string file = sfdDescargar.FileName;
                        if (file.Substring(file.Length - 4) != ".xml")
                        {
                            file = file + ".xml";
                        }
                        try
                        {
                            StreamWriter sw0 = new StreamWriter(file);
                            sw0.Write(cabecera.Cs_pr_CDR);
                            sw0.Close();
                        }
                        catch (IOException)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("xml recep gen" + ex.ToString());
            }
        }
        private void chkAll_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (data_Documentos.Count > 0)
                {
                    foreach (Data_Documentos data_Documento in data_Documentos)
                        data_Documento.Selectable   =   true;

                    dgDocumentos.ItemsSource    =   null;
                    dgDocumentos.Items.Clear();
                    dgDocumentos.ItemsSource    =   data_Documentos;
                }
                else
                {
                    e.Handled           =   false;
                    chkAll.IsChecked    =   false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show($"Error al seleccionar todo, detalle del error: {ex}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void chkAll_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (data_Documentos.Count > 0)
                {
                    foreach (Data_Documentos data_Documento in data_Documentos)
                        data_Documento.Selectable   =   false;

                    dgDocumentos.ItemsSource    =   null;
                    dgDocumentos.Items.Clear();
                    dgDocumentos.ItemsSource    =   data_Documentos;
                }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show($"Error al deseleccionar todo, detalle del error: {ex}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.F12);
            if (compare == 0)
            {
                AyudaPrincipal ayuda = new AyudaPrincipal("10");
                ayuda.ShowDialog();
            }
        }

        private void btnDescargarXML_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Data_Documentos> selected_data_Documentos = new List<Data_Documentos>();
                foreach (var data_Documento in data_Documentos)
                {
                    if (data_Documento.Selectable == true)
                        selected_data_Documentos.Add(data_Documento);
                }

                if (selected_data_Documentos.Count() > 0)
                {
                    string enviados     =   string.Empty;
                    string noEnviados   =   string.Empty;
                    string mensajeFinal =   string.Empty;

                    ProgressDialogResult result = ProgressWindow.Execute(padre, "Procesando...", () => {
                        foreach (var selected_data_Documento in selected_data_Documentos)
                        {
                            ProcesarEnvio procesarEnvio =   new ProcesarEnvio(data_Usuario, selected_data_Documento.IdDocumento);
                            procesarEnvio.Post();
                        }
                    });
                    
                    foreach (var selected_data_Documento in selected_data_Documentos)
                    {
                        if (selected_data_Documento.EnviadoSunat == true)
                        {
                            enviados    +=  $", {selected_data_Documento.SerieCorrelativo}";
                        }
                        else
                        {
                            noEnviados  +=  $", {selected_data_Documento.SerieCorrelativo}";
                        }
                    }

                    if (string.IsNullOrEmpty(enviados)) //  Ningún enviado, puros rechazados como voz
                        mensajeFinal    =   $"No se pudo enviar ningún documento, los documentos rechazados son:\n {noEnviados}";

                    if (!string.IsNullOrEmpty(enviados) && string.IsNullOrEmpty(noEnviados))    //  Sin ningún documento rechazado
                        mensajeFinal    =   $"Se ha enviado a Sunat el(los) documento(s):\n {enviados}";

                    if (!string.IsNullOrEmpty(enviados) && !string.IsNullOrEmpty(noEnviados))   //  Con al menos un documento rechazado
                        mensajeFinal    =   $"Se ha enviado a Sunat el(los) documento(s):\n {enviados} y se han rechazado los siguientes documentos:\n {noEnviados}";

                    CustomDialogWindow customDialogWindow       =   new CustomDialogWindow();
                    customDialogWindow.Buttons                  =   CustomDialogButtons.OK;
                    customDialogWindow.Caption                  =   "Mensaje";
                    customDialogWindow.DefaultButton            =   CustomDialogResults.OK;
                    customDialogWindow.InstructionHeading       =   "Resultados del envío a Sunat";
                    customDialogWindow.InstructionIcon          =   CustomDialogIcons.Information;
                    customDialogWindow.InstructionText          =   mensajeFinal;
                    CustomDialogResults customDialogResults     =   customDialogWindow.Show();

                    LoadGrid();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Debe seleccionar al menos un documento");
            }
            catch (Exception ex)
            {
                var msg =   string.Concat(ex.InnerException?.Message,   ex.Message);
                data_Log = new Data_Log() { DetalleError = $"Detalle del error: {msg}", Comentario = "Error al enviar el documento a sunat desde la interfaz", IdUser_Empresa = data_Usuario.IdUser_Empresa };
                data_Log.Create_Log();
            }
        }
    }
   
}
