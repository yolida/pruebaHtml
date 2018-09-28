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
/// Cambio de interfaz - Comunicacion de baja
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para ComunicacionBaja_Sunat.xaml
    /// </summary>
    public partial class ComunicacionBaja_Sunat : Page
    {
        List<clsEntityVoidedDocuments> registros;
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
        clsEntityDatabaseLocal localDB;
        // ComboBoxPares cbpEstadoSunat;
        // Metodo constructor
        public ComunicacionBaja_Sunat(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        // Evento de carga de la pagina.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datePick_inicio.Text = DateTime.Now.Date.ToString();
            datePick_fin.Text = DateTime.Now.Date.ToString();
            refrescarGrilla();          
        }
        //Metodo para refrescar la grilla secundaria segun el id de la comunicacion de baja
        private void refrescarGrillaDocumentos(string IdComunicacionBaja)
        {
            cs_pxCargarDgvComprobanteselectronicosPorBaja(IdComunicacionBaja);
        }
        //Metodo para refrescar la grilla.
        private void refrescarGrilla()
        {
            //Si la fecha de inicio esta seleccionada
            if (datePick_inicio.SelectedDate != null)
            {
                fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            //Si la fecha de fin esta seleccionada
            if (datePick_fin.SelectedDate != null)
            {
                fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }

            cs_pxCargarDgvComprobanteselectronicos(fecha_inicio_formato, fecha_fin_formato);
        }
        //Metodo para refrescar la grilla principal de comunicaciones de baja
        private void cs_pxCargarDgvComprobanteselectronicos(string fechainicio, string fechafin)
        {
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            dgComprobantesBaja.ItemsSource = null;
            dgComprobantesBaja.Items.Clear();
            //Obtener los registros de comunicacion de baja.
            registros = new clsEntityVoidedDocuments(localDB).cs_pxObtenerFiltroSecundario(fechainicio, fechafin,"0");
            lista_reporte = new List<ReporteResumen>();
            if (registros.Count > 0) {
                //Recorre los registros y rellenar el grid
                foreach (var item in registros)
                {
                    itemRow = new ReporteResumen();
                    itemRow.Id = item.Cs_pr_VoidedDocuments_Id;
                    itemRow.FechaEmision = item.Cs_tag_ReferenceDate;
                    itemRow.FechaEnvio = item.Cs_tag_IssueDate;
                    itemRow.Comentario = item.Cs_pr_ComentarioSUNAT;
                    itemRow.Ticket = item.Cs_pr_Ticket;
                    itemRow.Archivo = item.Cs_tag_ID;
                    itemRow.EstadoSCC = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSCC)).ToUpper();
                    itemRow.EstadoSunat = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSUNAT)).ToUpper();
                    itemRow.EstadoSunatCodigo = item.Cs_pr_EstadoSUNAT;
                    lista_reporte.Add(itemRow);
                }
            }
          
            dgComprobantesBaja.ItemsSource = lista_reporte;
        }
        //Evento de consulta de documentos.
        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            refrescarGrilla();
        }
        //Evento de cambio de item seleccionado.
        private void dgComprobantesBaja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Obtener elemento selccionado.
            System.Windows.Controls.DataGrid checkBox = (System.Windows.Controls.DataGrid)e.OriginalSource;
            //Obtener objeto asociado al elemento seleccionado.
            ReporteResumen item = (ReporteResumen)checkBox.SelectedItem;
            if (item != null)
            {
                Detalle.Content = "Detalle Comunicacion de Baja | " + item.Archivo;
                cs_pxCargarDgvComprobanteselectronicosPorBaja(item.Id);
            }
            else
            {
                Detalle.Content = "Detalle Comunicacion de Baja";
            }
        }
        //Evento para cargar documentos segun comunicacion de baja.
        private void cs_pxCargarDgvComprobanteselectronicosPorBaja(string IdBaja)
        {
            //Limpiar lista de comprobantes de la grilla.
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            //Obtener los documentos asociados a la comunicacion de baja.
            documentos = new clsEntityDocument(localDB).cs_pxObtenerDocumentosPorComunicacionBaja_n(IdBaja);
            lista_documentos = new List<ReporteDocumento>();
            if (documentos.Count > 0) {
                //Recorrer los registros obtenidos para rellenar la grilla.
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
                    itemComprobante.ComunicacionBajaMotivo = new clsEntityVoidedDocuments_VoidedDocumentsLine(localDB).cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(item.Cs_pr_Document_Id, item.Cs_pr_ComunicacionBaja)[1];//Motivo de baja de comprobantes
                    lista_documentos.Add(itemComprobante);
                }
            }
           
            dgComprobantes.ItemsSource = lista_documentos;
        }
        //Evento de cambio de estado en el checkbox check
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtener elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener objeto asociado al elemento seleccionado
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteResumen resumen = (ReporteResumen)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked)
            {
                resumen.Check = true;
            }
            e.Handled = true;
        }
        //Evento de cambio de estado en el checkbox uncheck
        private void chkDiscontinue_Unchecked(object sender, RoutedEventArgs e)
        {
            //Obtener elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener el objeto asociado al elemento seleccionado.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteResumen resumen = (ReporteResumen)dataGridRow.DataContext;

            if (checkBox.IsChecked == false)
            {
                resumen.Check = false;
            }
            e.Handled = true;
        }
        //Evento para refrescar la grilla.
        private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            refrescarGrilla();
        }
        //Evento de envio a sunat de la comunicacion de baja.
        private void btnSunat_Click(object sender, RoutedEventArgs e)
        {
            string comentario = "";
            string ya_enviados = "";
            string no_enviados_motivo = "";
            int cantidad_seleccionados = 0;
            try
            {
                List<string> seleccionados = new List<string>();
                //Recorrer la lista para obtener los seleccionados.
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {   //Si el item fue seleccionado
                        cantidad_seleccionados++;
                        if (item.Ticket!= "" || item.Comentario != "")
                        {
                            ya_enviados += " -> " + item.Archivo + " \n";
                        }
                        else
                        {
                            bool validar_motivos_baja = new clsEntityVoidedDocuments(localDB).cs_pxValidarMotivosDeBajaEnItems(item.Id);
                            if (validar_motivos_baja == true)
                            {
                                seleccionados.Add(item.Id);
                            }
                            else
                            {
                                no_enviados_motivo += " -> " + item.Archivo + " \n";
                            }
                        }

                    }
                }
                //SI existen documentos seleccionados.
                if (cantidad_seleccionados > 0)
                {   
                    //Si existen items selccionados.
                    if (seleccionados.Count > 0)
                    {
                        //Recorrer los seleccinoados para enviar a sunat.
                        foreach (var item in seleccionados)
                        {
                            new clsBaseSunat(localDB).cs_pxEnviarRA(item.ToString(),true);
                        }             
                        refrescarGrilla();
                    }
                    //Mostrar resumen de comprobantes procesados y no procesados.
                    comentario += ya_enviados + no_enviados_motivo;
                    if (comentario.Length > 0)
                    {
                        comentario = "";
                        if (ya_enviados.Length > 0)
                        {
                            comentario += "Ya enviadas:\n" + ya_enviados;
                        }
                        if (no_enviados_motivo.Length>0)
                        {
                            comentario += "Sin motivos de baja" + no_enviados_motivo;
                        }

                        System.Windows.MessageBox.Show("Las siguientes comunicaciones de baja no fueron procesadas.\n" + comentario);
                    }

                }
                else
                {
                    System.Windows.MessageBox.Show("Debe seleccionar un item");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("EnvioRA"+ ex.ToString());
            }
        }
        //Evento de consulta de ticket.
        private void btnTicket_Click(object sender, RoutedEventArgs e)
        {
            string no_procesados = "";
            int cantidad_seleccionados = 0;
            try
            {
                //Recorrer la lista para obtener los elementos seleccionados.
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    //Recorrer la lista de items 
                    if (item.Check == true)
                    {
                        cantidad_seleccionados++;
                        if (item.EstadoSunatCodigo == "5" && item.Ticket != "")
                        {
                            seleccionados.Add(item.Ticket);
                        }
                        else
                        {
                            no_procesados += item.Archivo + "\n";
                        }
                    }
                }

                if (cantidad_seleccionados > 0)
                {
                    if (seleccionados.Count() > 0)
                    {
                        //Recorrer los elementos seleccionados y enviar a sunat
                        foreach (var item in seleccionados)
                        {
                            new clsBaseSunat(localDB).cs_pxConsultarTicket(item.ToString(),true);
                        }
                        refrescarGrilla();
                    }
                    //Si existen elementos no procesados
                    if (no_procesados.Length > 0)
                    {
                        System.Windows.MessageBox.Show("Las siguientes comunicaciones de baja no fueron procesados. Verifique ticket de consulta. \n" + no_procesados);
                    }

                }
                else
                {
                    System.Windows.MessageBox.Show("Debe seleccionar un item");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("EnvioRA" + ex.ToString());
            }
        }      
        //Evento para agregar motivos de baja en los comprobantes.
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
          //  DataGridRow filaseleccionada =(DataGridRow) dgComprobantes.SelectedItem;
            ReporteDocumento item = (ReporteDocumento)dgComprobantes.SelectedItem;
            if (item != null)
            {
                BajaMotivo bajaMotivo = new BajaMotivo(new clsEntityVoidedDocuments_VoidedDocumentsLine(localDB).cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(item.Id, item.ComunicacionBaja)[0], localDB);
                bajaMotivo.ShowDialog();
                refrescarGrillaDocumentos(item.ComunicacionBaja);
            }
           
        }
    }
}
