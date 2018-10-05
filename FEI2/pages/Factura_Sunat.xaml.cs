using DataLayer;
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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

namespace FEI.pages
{
    public partial class Factura_Sunat : Page
    {
        List<ComboBoxPares> tipos_comprobante = new List<ComboBoxPares>();
        List<clsEntityDocument> registros;
        List<ReporteDocumento> lista_reporte;
        ReporteDocumento itemRow;
        ComboBoxPares cbpTipoComprobante;
        string fecha_inicio_formato;
        string fecha_fin_formato;
        clsEntityDatabaseLocal localDB;

        ReadGeneralData readGeneralData =   new ReadGeneralData();
        private Window padre;

        public Factura_Sunat(Window parent,clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            padre = parent;
            localDB = local;
        }
        //Evento de carga de la ventana principal.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dataTable =   readGeneralData.GetDataTable("[dbo].[Read_TipoDocumentos]");
                var items           =   (dataTable as IListSource).GetList();
                lstTipoComprobante.ItemsSource          =   items;
                lstTipoComprobante.DisplayMemberPath    =   "Descripcion";
                lstTipoComprobante.SelectedValuePath    =   "IdTipoDocumento";
                lstTipoComprobante.SelectedIndex        =   0;

                datePick_inicio.Text = DateTime.Now.Date.ToString();
                datePick_fin.Text = DateTime.Now.Date.ToString();
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("La base de datos ha sido alterada, contacte con soporte.", "Base de datos alterada", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void AddBlackOutDates(DatePicker dp, int offset)
        {
            Dictionary<CalendarDateRange, string> blackoutDatesTextLookup = new Dictionary<CalendarDateRange, string>();
            for (int i = 0; i < offset; i++)
            {
                CalendarDateRange range = new CalendarDateRange(DateTime.Now.AddDays(i));
                dp.BlackoutDates.Add(range);
                blackoutDatesTextLookup.Add(range, string.Format("This is a simulated BlackOut date {0}", range.Start.ToLongDateString()));
            }
            dp.SetValue(CalendarProps.BlackOutDatesTextLookupProperty, blackoutDatesTextLookup);
        }
        //Metodo para cargar la grilla del listado de comprobantes.
        private void cs_pxCargarDgvComprobanteselectronicos(string tipo, string fechainicio, string fechafin)
        {
            dgComprobantesFactura.ItemsSource = null;
            dgComprobantesFactura.Items.Clear();
            //Obtener los registros para facturas.

            //clsBaseLog.cs_pxRegistarAdd(localDB.cs_prConexioncadenabasedatos()+" "+fechainicio +" "+fechafin+" " +tipo );
            registros = new clsEntityDocument(localDB).cs_pxObtenerFiltroEnvioSunatFacturas(tipo, "2", "", fechainicio, fechafin, "'01','07','08'", false);
            lista_reporte = new List<ReporteDocumento>();
           // clsBaseLog.cs_pxRegistarAdd(registros.Count.ToString());
            //Recorrer los registros para rellenar el grid.
            if (registros != null)
            {
                foreach (var item in registros) // Se instacia todos los atributos de la clase ReporteDocumento, para los documentos
                {
                   /* bool verificar = new clsNegocioValidar(localDB).cs_pxVerificarComprobante(item.Cs_pr_Document_Id);
                    if (!verificar)
                    {
                        item.Cs_pr_EstadoSCC = "01";
                    }*/
                    itemRow = new ReporteDocumento();
                    itemRow.Id = item.Cs_pr_Document_Id;
                    itemRow.Tipo = item.Cs_tag_InvoiceTypeCode;
                    itemRow.SerieNumero = item.Cs_tag_ID;
                    itemRow.FechaEmision = item.Cs_tag_IssueDate;
                    itemRow.FechaEnvio = item.comprobante_fechaenviodocumento;
                    itemRow.Ruc = item.Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID;
                    itemRow.RazonSocial = item.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName;
                    itemRow.Comentario = item.Cs_pr_ComentarioSUNAT;
                    itemRow.ComunicacionBaja = item.Cs_pr_ComunicacionBaja;
                    itemRow.ResumenDiario = item.Cs_pr_Resumendiario;
                    itemRow.DocumentoReferencia = item.Cs_tag_BillingReference_DocumentTypeCode;
                    itemRow.TipoTexto = clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(item.Cs_tag_InvoiceTypeCode);
                    itemRow.EstadoSCC = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSCC)).ToUpper();
                    itemRow.EstadoSunat = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSUNAT)).ToUpper();
                    lista_reporte.Add(itemRow);
                }
            }
            dgComprobantesFactura.ItemsSource = lista_reporte;
        }
        //Evento check para cada item del listado.
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener la fila seleccionada y objeto asociado.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento comprobante = (ReporteDocumento)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked)
            {
                comprobante.Check = true;
            }
            e.Handled = true;
        }
        //Evento uncheck para cada item del listado.
        private void chkDiscontinue_Unchecked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener la fila seleccionada y objeto asociado.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento comprobante = (ReporteDocumento)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked == false)
            {
                comprobante.Check = false;
            }
            e.Handled = true;
        }
        //Evento click para consulta sobre filtro.
        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            refrescarGrilla();
        }
        private void refrescarGrilla()
        {
            cbpTipoComprobante = (ComboBoxPares)lstTipoComprobante.SelectedItem;
            if (datePick_inicio.SelectedDate != null)
            {
                DateTime fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            if (datePick_fin.SelectedDate != null)
            {
                DateTime fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }
            //Cargar comrpbantes segun filtro.
            cs_pxCargarDgvComprobanteselectronicos(cbpTipoComprobante._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento envio a sunat de comprobantes.
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Recorrer la grilla para obtener los documentos seleccionados de la grilla.
                List<ReporteDocumento> seleccionados = new List<ReporteDocumento>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        seleccionados.Add(item); // Almacena todo un ReporteDocumento, se llena con todos los datos de esas clases, consume muchos 
                    }   // ciclos de reloj
                }
                //If existen los elementos seleccionados.
                if (seleccionados.Count() > 0)
                {
                    string enviados = string.Empty;
                    ProgressDialogResult result = ProgressWindow.Execute(padre, "Procesando...", () => {
                        //enviados = sendToSunat(seleccionados);
                        enviados = sendToSunat(seleccionados);
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
                    refrescarGrilla();
                   
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

        private string sendToSunatTest(List<ReporteDocumento> seleccionados)
        {
            string retornar = string.Empty;
            //Por cada elemento seleccionado se envia a la sunat.
            foreach (var item in seleccionados)
            {
                bool resultado = new clsBaseSunat(localDB).cs_pxEnviarCE(item.Id, true);
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
                ReporteDocumento item = (ReporteDocumento)dgComprobantesFactura.SelectedItem;
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
                ReporteDocumento item = (ReporteDocumento)dgComprobantesFactura.SelectedItem;
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
                ReporteDocumento item = (ReporteDocumento)dgComprobantesFactura.SelectedItem;
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
                if (lista_reporte.Count > 0)
                {
                    //checkall
                    foreach (ReporteDocumento item in lista_reporte)
                    {
                        item.Check = true;
                    }
                    dgComprobantesFactura.ItemsSource = null;
                    dgComprobantesFactura.Items.Clear();
                    dgComprobantesFactura.ItemsSource = lista_reporte;
                }
            }
            catch
            {

            }

        }

        private void chkAll_Unchecked(object sender, RoutedEventArgs e)
        {

            try
            {
                if (lista_reporte.Count > 0)
                {
                    //checkall
                    foreach (ReporteDocumento item in lista_reporte)
                    {
                        item.Check = false;
                    }
                    dgComprobantesFactura.ItemsSource = null;
                    dgComprobantesFactura.Items.Clear();
                    dgComprobantesFactura.ItemsSource = lista_reporte;
                }
            }
            catch
            {

            }
        }

        private void btnDescartar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Verificar si hay elementos seleccionados              
                List<ReporteDocumento> seleccionados = new List<ReporteDocumento>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        seleccionados.Add(item);
                    }
                }

                if (seleccionados.Count > 0)
                {
                    if (System.Windows.Forms.MessageBox.Show("¿Está seguro que desea descartar los documentos seleccionados?\nEstos documentos serán eliminados completamente de la base de datos.", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        foreach (ReporteDocumento row in seleccionados)
                        {                            
                            bool resultado = new clsEntityDocument(localDB).cs_pxEliminarDocumento(row.Id);
                            if (resultado == true)
                            {
                                mensaje += row.SerieNumero+"\n";
                            }                                                      
                        }

                        if (mensaje.Length > 0)
                        {
                            CustomDialogWindow obj = new CustomDialogWindow();
                            obj.AdditionalDetailsText = "Los comprobantes son:\n" + mensaje;
                            obj.Buttons = CustomDialogButtons.OK;
                            obj.Caption = "Mensaje";
                            obj.DefaultButton = CustomDialogResults.OK;
                            // obj.FooterIcon = CustomDialogIcons.Shield;
                            // obj.FooterText = "This is a secure program";
                            obj.InstructionHeading = "Documentos eliminados";
                            obj.InstructionIcon = CustomDialogIcons.Information;
                            obj.InstructionText = "Los documentos se eliminaron correctamente de la base de datos.";
                            CustomDialogResults objResults = obj.Show();
                           // System.Windows.Forms.MessageBox.Show("Los siguientes documentos se eliminaron correctamente de la base de datos.\n"+mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        refrescarGrilla();

                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("delete factura" + ex.ToString());
                //clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
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
