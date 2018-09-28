﻿using FEI.ayuda;
using FEI.Base;
using FEI.CustomDialog;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para ReversionSunat_Retencion.xaml
    /// </summary>
    public partial class ReversionSunat_Retencion : Page
    {
        List<clsEntityVoidedDocuments> registros;
        List<ReporteResumen> lista_reporte;
        ReporteResumen itemRow;

        List<clsEntityRetention> documentos;
        List<ReporteRetention> lista_documentos;
        ReporteRetention itemComprobante;

        List<ComboBoxPares> estados_sunat = new List<ComboBoxPares>();

        string fecha_inicio_formato;
        string fecha_fin_formato;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        private Window VentanaPrincipal;
        private clsEntityDatabaseLocal localDB;
        public ReversionSunat_Retencion(Window parent, clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            VentanaPrincipal = parent;
            localDB = local;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datePick_inicio.Text = DateTime.Now.Date.ToString();
            datePick_fin.Text = DateTime.Now.Date.ToString();
            refrescarGrilla();
        }
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
            registros = new clsEntityVoidedDocuments(localDB).cs_pxObtenerFiltroSecundario(fechainicio, fechafin, "1");
            lista_reporte = new List<ReporteResumen>();
            if (registros != null)
            {
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
                Detalle.Content = "Detalle Reversión CRE | " + item.Archivo;
                cs_pxCargarDgvComprobanteselectronicosPorBaja(item.Id);
            }
            else
            {
                Detalle.Content = "Detalle Reversión CRE ";
            }
        }
        //Evento para cargar documentos segun comunicacion de baja.
        private void cs_pxCargarDgvComprobanteselectronicosPorBaja(string IdBaja)
        {
            //Limpiar lista de comprobantes de la grilla.
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            //Obtener los documentos asociados a la comunicacion de baja.
            documentos = new clsEntityRetention(localDB).cs_pxObtenerDocumentosPorComunicacionBaja_n(IdBaja);
            lista_documentos = new List<ReporteRetention>();
            if (documentos != null)
            {
                //Recorrer los registros obtenidos para rellenar la grilla.
                foreach (var item in documentos)
                {
                    itemComprobante = new ReporteRetention();
                    itemComprobante.Id = item.Cs_pr_Retention_id;
                    itemComprobante.SerieNumero = item.Cs_tag_Id;
                    itemComprobante.FechaEmision = item.Cs_tag_IssueDate;
                    itemComprobante.FechaEnvio = item.Cs_pr_FechaEnvio;
                    itemComprobante.Ruc = item.Cs_tag_ReceiveParty_PartyIdentification_Id;
                    itemComprobante.RazonSocial = item.Cs_tag_ReceiveParty_PartyLegalEntity_RegistrationName;
                    itemComprobante.Comentario = item.Cs_pr_ComentarioSUNAT;
                    itemComprobante.Reversion = IdBaja;
                    itemComprobante.EstadoSCC = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSCC)).ToUpper();
                    itemComprobante.EstadoSunat = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(item.Cs_pr_EstadoSUNAT)).ToUpper();
                    List<string> voided = new clsEntityVoidedDocuments_VoidedDocumentsLine(localDB).cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(item.Cs_pr_Retention_id, itemComprobante.Reversion);
                    if (voided != null)
                    {
                        itemComprobante.MotivoReversion = voided[1];//Motivo de baja de comprobantes
                    }
                    else
                    {
                        itemComprobante.MotivoReversion = "";//Motivo de baja de comprobantes
                    }

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
            string procesados = "";
            string ya_enviados = "";
            string no_enviados_motivo = "";
            int cantidad_seleccionados = 0;
            try
            {
                List<ReporteResumen> seleccionados = new List<ReporteResumen>();
                //Recorrer la lista para obtener los seleccionados.
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {   //Si el item fue seleccionado
                        cantidad_seleccionados++;
                        if (item.Ticket != "" || item.Comentario != "")
                        {
                            ya_enviados += " -> " + item.Archivo + " \n";
                        }
                        else
                        {
                            bool validar_motivos_baja = new clsEntityVoidedDocuments(localDB).cs_pxValidarMotivosDeBajaEnItems(item.Id);
                            if (validar_motivos_baja == true)
                            {
                                seleccionados.Add(item);
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
                    //Mostrar resumen de comprobantes procesados y no procesados.
                    comentario += ya_enviados + no_enviados_motivo;
                    if (comentario.Length > 0)
                    {
                        comentario = "";
                        if (ya_enviados.Length > 0)
                        {
                            comentario += "Ya enviadas:\n" + ya_enviados;
                        }
                        if (no_enviados_motivo.Length > 0)
                        {
                            comentario += "Sin motivos de baja" + no_enviados_motivo;
                        }
                        System.Windows.MessageBox.Show("Los siguientes resumen de reversiones no seran procesados.\n" + comentario, "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    //Si existen items selccionados.
                    if (seleccionados.Count > 0)
                    {
                        //string resultado = string.Empty;
                        ProgressDialogResult result = ProgressWindow.Execute(VentanaPrincipal, "Procesando...", () => {
                            procesados = sendToSunat(seleccionados);
                        });

                        refrescarGrilla();
                    }
                    if (procesados.Length > 0)
                    {
                        CustomDialogWindow obj = new CustomDialogWindow();
                        obj.AdditionalDetailsText = "Los siguientes comprobantes fueron enviados correctamente:\n" + procesados;
                        obj.Buttons = CustomDialogButtons.OK;
                        obj.Caption = "Mensaje";
                        obj.DefaultButton = CustomDialogResults.OK;
                        // obj.FooterIcon = CustomDialogIcons.Shield;
                        // obj.FooterText = "This is a secure program";
                        obj.InstructionHeading = "Documentos enviados";
                        obj.InstructionIcon = CustomDialogIcons.Information;
                        obj.InstructionText = "Los documentos se enviaron correctamente a SUNAT.";
                        CustomDialogResults objResults = obj.Show();

                        // System.Windows.MessageBox.Show("Las siguientes comunicaciones de baja fueron procesadas correctamente.\n" + procesados, "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Seleccione los items a procesar.", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("EnvioRA" + ex.ToString());
            }
        }
        private string sendToSunat(List<ReporteResumen> seleccionados)
        {
            string procesados = string.Empty;
            //Recorrer los seleccinoados para enviar a sunat.
            foreach (var item in seleccionados)
            {
                bool enviado = new clsBaseSunat(localDB).cs_pxEnviarRR(item.Id, true);
                if (enviado)
                {
                    procesados += item.Archivo + "\n";
                }
            }
            return procesados;
        }
        //Evento de consulta de ticket.
        private void btnTicket_Click(object sender, RoutedEventArgs e)
        {
            string no_procesados = "";
            int cantidad_seleccionados = 0;
            try
            {
                //Recorrer la lista para obtener los elementos seleccionados.
                List<ReporteResumen> seleccionados = new List<ReporteResumen>();
                foreach (var item in lista_reporte)
                {
                    //Recorrer la lista de items 
                    if (item.Check == true)
                    {
                        cantidad_seleccionados++;
                        if ((item.EstadoSunatCodigo == "5" || item.EstadoSunatCodigo == "4" || item.EstadoSunatCodigo == "2") && item.Ticket != "")
                        {
                            seleccionados.Add(item);
                        }
                        else
                        {
                            no_procesados += item.Archivo + "\n";
                        }
                    }
                }

                if (cantidad_seleccionados > 0)
                {
                    if (no_procesados.Length > 0)
                    {
                        System.Windows.MessageBox.Show("Los siguientes resumenes de reversion no seran procesados. Verifique ticket de consulta. \n" + no_procesados);
                    }
                    if (seleccionados.Count() > 0)
                    {
                        string resultado = string.Empty;
                        ProgressDialogResult result = ProgressWindow.Execute(VentanaPrincipal, "Procesando...", () => {
                            resultado = consultaTicket(seleccionados);
                        });

                        refrescarGrilla();

                        if (resultado.Trim().Length > 0)
                        {
                            CustomDialogWindow obj = new CustomDialogWindow();
                            obj.AdditionalDetailsText = "Los siguientes comprobantes se consultaron correctamente:\n" + resultado;
                            obj.Buttons = CustomDialogButtons.OK;
                            obj.Caption = "Mensaje";
                            obj.DefaultButton = CustomDialogResults.OK;
                            // obj.FooterIcon = CustomDialogIcons.Shield;
                            // obj.FooterText = "This is a secure program";
                            obj.InstructionHeading = "Documentos consultados ";
                            obj.InstructionIcon = CustomDialogIcons.Information;
                            obj.InstructionText = "Los tickets de los documentos enviados fueron consultados correctamente.";
                            CustomDialogResults objResults = obj.Show();
                        }
                    }
                    //Si existen elementos no procesados                
                }
                else
                {
                    System.Windows.MessageBox.Show("Seleccione los items a procesar.");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("EnvioRA" + ex.ToString());
            }
        }
        private string consultaTicket(List<ReporteResumen> seleccionados)
        {
            string retornar = string.Empty;
            if (seleccionados.Count() > 0)
            {
                //Recorrer los elementos seleccionados y enviar a sunat
                foreach (var item in seleccionados)
                {
                    bool procesado = new clsBaseSunat(localDB).cs_pxConsultarTicketRR(item.Ticket, true);
                    if (procesado == true)
                    {
                        retornar += item.Archivo + "\n";
                    }
                }
            }
            return retornar;
        }
        //Evento para agregar motivos de baja en los comprobantes.
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReporteRetention item = (ReporteRetention)dgComprobantes.SelectedItem;
                if (item != null)
                {
                    List<string> motivo = new clsEntityVoidedDocuments_VoidedDocumentsLine(localDB).cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(item.Id, item.Reversion);

                    BajaMotivo bajaMotivo = new BajaMotivo(motivo[0], localDB);
                    bajaMotivo.ShowDialog();
                    refrescarGrillaDocumentos(item.Reversion);
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("motivo baja " + ex.ToString());
            }
            //  DataGridRow filaseleccionada =(DataGridRow) dgComprobantes.SelectedItem;


        }

        private void btnDescartar_Click(object sender, RoutedEventArgs e)
        {
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
                        seleccionados.Add(item.Id);
                    }
                }

                if (cantidad_seleccionados > 0)
                {
                    if (seleccionados.Count() > 0)
                    {
                        if (System.Windows.Forms.MessageBox.Show("¿Está seguro que desea descartar los documentos seleccionados?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //Recorrer los elementos seleccionados y enviar a sunat
                            foreach (var item in seleccionados)
                            {
                                new clsNegocioCEComunicacionBaja(localDB).cs_pxDescartarDocumento(item.ToString(),"1");
                                // new clsBaseSunat().cs_pxConsultarTicket(item.ToString());
                            }
                        }
                        refrescarGrilla();
                    }
                    //Si existen elementos no procesados
                    /* if (no_procesados.Length > 0)
                     {
                         System.Windows.MessageBox.Show("Las siguientes comunicaciones de baja no fueron procesados. Verifique ticket de consulta. \n" + no_procesados);
                     }*/

                }
                else
                {
                    System.Windows.MessageBox.Show("Seleccione los items a procesar.");
                }

            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("DescartarReversionCRE" + ex.ToString());
            }
        }

        private void Page_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.F12);
            if (compare == 0)
            {
                AyudaPrincipal ayuda = new AyudaPrincipal("20");
                ayuda.ShowDialog();
            }
        }
    }
}
