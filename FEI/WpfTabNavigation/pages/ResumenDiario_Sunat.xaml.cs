using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Enviar  resumen diario a sunat.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para ResumenDiario_Sunat.xaml
    /// </summary>
    public partial class ResumenDiario_Sunat : Page
    {
        List<clsEntitySummaryDocuments> registros;
        List<ReporteResumen> lista_reporte;
        ReporteResumen itemRow;

        List<clsEntityDocument> documentos;
        List<ReporteDocumento> lista_documentos;
        ReporteDocumento itemComprobante;

        List<ComboBoxPares> estados_sunat = new List<ComboBoxPares>();

        string fecha_inicio_formato;
        string fecha_fin_formato;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        ComboBoxPares cbpEstadoSunat;
        private clsEntityDatabaseLocal localDB;
        //Metodo constructor
        public ResumenDiario_Sunat(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        //Evento de carga de la ventana principal.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Agregar estados sunat al combobox Estado Sunat.
            estados_sunat.Add(new ComboBoxPares("", "Seleccione"));
            estados_sunat.Add(new ComboBoxPares("2", "Sin estado"));
            estados_sunat.Add(new ComboBoxPares("4", "En proceso"));
            estados_sunat.Add(new ComboBoxPares("5", "Ticket a Consultar"));
            cboEstadoSunat.DisplayMemberPath = "_Value";
            cboEstadoSunat.SelectedValuePath = "_key";
            cboEstadoSunat.SelectedIndex = 0;
            cboEstadoSunat.ItemsSource = estados_sunat;
            //Inicializar las fechas.
            datePick_inicio.Text = DateTime.Now.Date.ToString();
            datePick_fin.Text = DateTime.Now.Date.ToString();

            cbpEstadoSunat = (ComboBoxPares)cboEstadoSunat.SelectedItem;
            if (datePick_inicio.SelectedDate != null)
            {
                fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            if (datePick_fin.SelectedDate != null)
            {
                fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }
            //Cargar datos en la grilla
            cs_pxCargarDgvComprobanteselectronicos(cbpEstadoSunat._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Metodo para cargar la grilla de comprobantes resumenes diarios
        private void cs_pxCargarDgvComprobanteselectronicos(string estadocomprobantesunat, string fechainicio, string fechafin)
        {
            //Limpiar la grilla.
            dgComprobantesResumen.ItemsSource = null;
            dgComprobantesResumen.Items.Clear();
            int items = 0;
            //Obtener los registro segun filtro.
            registros = new clsEntitySummaryDocuments(localDB).cs_pxObtenerFiltroSecundario(estadocomprobantesunat, fechainicio, fechafin);
            lista_reporte = new List<ReporteResumen>();
            //Recorrer los registros
            foreach (var item in registros)
            {
                items=(int)new clsEntitySummaryDocuments(localDB).cs_fxObtenerResumenNumeroItems(item.Cs_pr_SummaryDocuments_Id);
                if (items > 0)
                {
                    itemRow = new ReporteResumen();
                    itemRow.Id = item.Cs_pr_SummaryDocuments_Id;
                    itemRow.FechaEmision = item.Cs_tag_ReferenceDate;
                    itemRow.FechaEnvio = item.Cs_tag_IssueDate;
                    itemRow.Comentario = item.Cs_pr_ComentarioSUNAT;
                    itemRow.Ticket = item.Cs_pr_Ticket;
                    itemRow.Archivo = item.Cs_tag_ID;
                    itemRow.EstadoSCC = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSCC)).ToUpper();
                    itemRow.EstadoSunat = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSUNAT)).ToUpper();
                    itemRow.EstadoSunatCodigo = item.Cs_pr_EstadoSUNAT;
                    lista_reporte.Add(itemRow);
                }else
                {
                    new clsEntitySummaryDocuments(localDB).cs_pxEliminarDocumento(item.Cs_pr_SummaryDocuments_Id);
                }
                
            }
            dgComprobantesResumen.ItemsSource = lista_reporte;
        }
        //Evento de cambio de seleccion en la grilla de resumenes diarios
        private void dgComprobantesResumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Obtener el elemento seleccionado en la grilla.
            DataGrid checkBox = (DataGrid)e.OriginalSource;
            //Obtner el objeto asociado a la fila seleccionada.
            ReporteResumen item = (ReporteResumen)checkBox.SelectedItem;
            if (item != null)
            {//Si objeto no es nulo Cargar los comprobantes asociados al resumen diario.
                Detalle.Content = "Detalle Resumen | " + item.Archivo;
                cs_pxCargarDgvComprobanteselectronicosPorResumen(item.Id);
            }
            else
            {
                Detalle.Content = "Detalle Resumen Diario";
            }

            //MessageBox.Show(item.Archivo+"-"+item.Id);
        }
        //Evento check para los comprobantes en la grilla de resumenes diarios
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado en la grilla.
            CheckBox checkBox = (CheckBox)e.OriginalSource;
            //Obtener el objeto asociado a la fila seleccionada.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteResumen resumen = (ReporteResumen)dataGridRow.DataContext;
            //Cambiar estado de objeto.
            if ((bool)checkBox.IsChecked)
            {
                resumen.Check = true;
            }
            e.Handled = true;
        }
        //Evento uncheck pra los comprobantes en la grilla de resumenes diarios 
        private void chkDiscontinue_Unchecked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado en la grilla.
            CheckBox checkBox = (CheckBox)e.OriginalSource;
            //Obtener el objeto asociado a la fila seleccionada.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteResumen resumen = (ReporteResumen)dataGridRow.DataContext;
            //Cambiar estado de objeto.
            if ((bool)checkBox.IsChecked == false)
            {
                resumen.Check = false;
            }
            e.Handled = true;
        }
        //Metodo para cargar los comprobantes dentro del resumen seleccionado
        private void cs_pxCargarDgvComprobanteselectronicosPorResumen(string idResumen)
        {
            //Limpiar grilla de documentos asociados
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            //Obtener los docuemntos asociados al resume selccionado
            documentos = new clsEntityDocument(localDB).cs_pxObtenerPorResumenDiario_n(idResumen);
            lista_documentos = new List<ReporteDocumento>();
            //Recorrer los documentos para rellenar la grilla
            foreach (var item in documentos)
            {
                itemComprobante = new ReporteDocumento();
                itemComprobante.Id = item.Cs_pr_Document_Id;
                itemComprobante.Tipo = item.Cs_tag_InvoiceTypeCode;
                itemComprobante.SerieNumero = item.Cs_tag_ID;
                itemComprobante.FechaEmision = item.Cs_tag_IssueDate;
                itemComprobante.FechaEnvio = item.comprobante_fechaenviodocumento;
                itemComprobante.Ruc = item.Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID;
                itemComprobante.RazonSocial = item.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName;
                itemComprobante.Comentario = item.Cs_pr_ComentarioSUNAT;
                itemComprobante.ComunicacionBaja = item.Cs_pr_ComunicacionBaja;
                itemComprobante.ResumenDiario = item.Cs_pr_Resumendiario;
                itemComprobante.DocumentoReferencia = item.Cs_tag_BillingReference_DocumentTypeCode;
                itemComprobante.TipoTexto = clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(item.Cs_tag_InvoiceTypeCode);
                itemComprobante.EstadoSCC = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSCC)).ToUpper();
                itemComprobante.EstadoSunat = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSUNAT)).ToUpper();
                itemComprobante.EstadoSunatCodigo = item.Cs_pr_EstadoSUNAT;
                lista_documentos.Add(itemComprobante);
            }
            dgComprobantes.ItemsSource = lista_documentos;
        }
        //Evento para filtrar los comprobantes.
        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            cbpEstadoSunat = (ComboBoxPares)cboEstadoSunat.SelectedItem;

            if (datePick_inicio.SelectedDate != null)
            {
                fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            if (datePick_fin.SelectedDate != null)
            {
                fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            cs_pxCargarDgvComprobanteselectronicos(cbpEstadoSunat._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento para refrescar la grilla
        private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            cbpEstadoSunat = (ComboBoxPares)cboEstadoSunat.SelectedItem;
            if (datePick_inicio.SelectedDate != null)
            {
                fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            if (datePick_fin.SelectedDate != null)
            {
                fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            cs_pxCargarDgvComprobanteselectronicos(cbpEstadoSunat._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento de envio de consulta de ticket para los comprobantes seleccionados
        private void btnTicket_Click(object sender, RoutedEventArgs e)
        {
            string no_procesados = "";
            int cantidad_seleccionados = 0;
            try
            {
                //Recorrer los elementos de la grilla para obtener los seleccionados.
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        cantidad_seleccionados++;
                        if (item.EstadoSunatCodigo == "5" && item.Ticket!="")
                        {
                            seleccionados.Add(item.Id);
                        }
                        else
                        {
                            no_procesados += item.Archivo + "\n";
                        }
                    }
                }
                //Si existen items seleccionados       
                if (cantidad_seleccionados > 0)
                { 
                    //Si existen items a procesar                
                    if (seleccionados.Count() > 0)
                    {
                        //Por cada seleccionado enviar la consulta de ticket.
                        foreach (var item in seleccionados)
                        {
                            new clsBaseSunat(localDB).cs_pxConsultarTicketRC(item.ToString(),true);
                        }
                        cbpEstadoSunat = (ComboBoxPares)cboEstadoSunat.SelectedItem;
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

                        cs_pxCargarDgvComprobanteselectronicos(cbpEstadoSunat._Id, fecha_inicio_formato, fecha_fin_formato);
                    }
                    //Si existen elementos no procesados.
                    if (no_procesados.Length > 0)
                    {
                        MessageBox.Show("Los siguientes resumenes no fueron procesados. Verifique ticket de consulta. \n" + no_procesados);
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un item");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Consulta de Ticket" + ex.Message);
            }
        }
        //Evento para enviar los resumenes diarios a la sunat.
        private void btnSunat_Click(object sender, RoutedEventArgs e)
        {
            string no_procesados = "";
            int cantidad_seleccionados = 0;
            try
            {
                //Recorrer los elementos de la grilla para obtener los seleccionados.
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    //Si estan seleccionados
                    if (item.Check == true)
                    {                       
                        if (item.EstadoSunatCodigo == "2") {
                            seleccionados.Add(item.Id);
                        }else
                        {
                            no_procesados += item.Archivo + "\n";
                        }
                        
                    }
                }
                //Si existen items seleccionados.
                if (cantidad_seleccionados > 0)
                {
                    //Si existen items a procesar.
                    if (seleccionados.Count > 0)
                    {
                        //Recorrer los elemtos a procesar y enviar a sunat
                        foreach (var item in seleccionados)
                        {
                            new clsBaseSunat(localDB).cs_pxEnviarRC(item.ToString(),true);
                        }

                        cbpEstadoSunat = (ComboBoxPares)cboEstadoSunat.SelectedItem;
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

                        cs_pxCargarDgvComprobanteselectronicos(cbpEstadoSunat._Id, fecha_inicio_formato, fecha_fin_formato);
                    }
                    //En caso existan elementos nno procesados
                    if (no_procesados.Length > 0)
                    {
                        MessageBox.Show("Los siguientes resumenes no fueron procesados. Estan en proceso o para consulta de ticket. \n" + no_procesados);
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un item");
                }


            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Envio a sunat resumen diario" + ex.Message);
            }
        }
    }
}
