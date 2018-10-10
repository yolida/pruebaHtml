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
        List<Data_Documentos> data_Documentos;
        private Window padre;

        public Factura_Sunat(Window parent, Data_DatosFox datosFox, clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            padre = parent;
            localDB = local;
            Data_Documentos documentos  =   new Data_Documentos();
            _Documentos = (IData_Documentos)documentos;
            data_DatosFox   = datosFox;
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
                dgDocumentos.ItemsSource    =   await GetDocumentos();
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
                    string enviados = string.Empty;
                    ProgressDialogResult result = ProgressWindow.Execute(padre, "Procesando...", () => {
                        // AQUI  ME QUEDE DEBO ENVIAR A SUNAT UNO O MAS DOCUMENTOS SELECCIONADOS
                        //enviados = sendToSunat(seleccionados);
                    });
                    if (enviados.Trim().Length > 0)
                    {
                        CustomDialogWindow obj = new CustomDialogWindow();
                        obj.AdditionalDetailsText = "Los comprobantes enviados correctamente son:\n" + enviados;
                        obj.Buttons = CustomDialogButtons.OK;
                        obj.Caption = "Mensaje";
                        obj.DefaultButton = CustomDialogResults.OK;
                        // obj.FooterIcon = CustomDialogIcons.Shield;
                        // obj.FooterText = "This is a secure program";
                        obj.InstructionHeading = "Documentos enviados";
                        obj.InstructionIcon = CustomDialogIcons.Information;
                        obj.InstructionText = "Los comprobantes han sido enviados correctamente.";
                        CustomDialogResults objResults = obj.Show();
                    }
                    LoadGrid();

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Debe seleccionar un item");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Enviar a sunat factura" + ex.Message);
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
    }
   
}
