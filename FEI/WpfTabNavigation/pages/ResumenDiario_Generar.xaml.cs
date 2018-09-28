using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Generar resumen diario.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para ResumenDiario_Generar.xaml
    /// </summary>
    public partial class ResumenDiario_Generar : Page
    {
        List<clsEntityDocument> registros;
        List<ReporteDocumento> lista_reporte;
        ReporteDocumento itemRow;
        string fecha_inicio_formato;
        string fecha_fin_formato;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        private clsEntityDatabaseLocal localDB;
        //Metodo constructor
        public ResumenDiario_Generar(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        //Evento de carga de la ventan principal
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datePick_inicio.Text = DateTime.Now.Date.ToString();
            datePick_fin.Text = DateTime.Now.Date.ToString();

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
            cs_pxCargarDgvComprobanteselectronicos(fecha_inicio_formato, fecha_fin_formato);
        }
        //Metodo para cargar los comprobantes en la grilla
        private void cs_pxCargarDgvComprobanteselectronicos(string fechainicio, string fechafin)
        {
            //Limpiar la grilla de comprobantes.
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            registros = new clsEntityDocument(localDB).cs_pxObtenerFiltroPrincipal("", "", "2", fechainicio, fechafin, "'03','07','08'", true);
            lista_reporte = new List<ReporteDocumento>();
            //lista_reporte = new ObservableCollection<Reporte>();
            //Recorrer los registros para rellenar la grilla.
            foreach (var item in registros)
            {
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
                itemRow.ResumenDiarioTexto = "SIN ESTADO";
                lista_reporte.Add(itemRow);
            }
            dgComprobantes.ItemsSource = lista_reporte;
        }
        //Evento check para los items de la grilla.
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado en la grilla.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtner la fila seleccionada y el objeto asociado.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento doc = (ReporteDocumento)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked)
            {
                doc.Check = true;
            }
            //e.Handled = true;
        }
        //Evento uncheck para los items de la grilla.
        private void chkDiscontinue_Unchecked(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento produit = (ReporteDocumento)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked == false)
            {
                produit.Check = false;
            }
           // e.Handled = true;
        }
        //Evento click para consultar el filtro de comprobantes
        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
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
            cs_pxCargarDgvComprobanteselectronicos(fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento de envio de comprobantes a resumen diario
        private void btnEnviarAResumen_Click(object sender, RoutedEventArgs e)
        {
            try
            {         
                //Recorrer la grilla para buscar los elementos seleccionados     
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        seleccionados.Add(item.Id);
                    }
                }
                //Si existen seleccionados a procesar
                if (seleccionados.Count() > 0)
                {
                    //Confirmacion para agregar.
                    if (System.Windows.Forms.MessageBox.Show("¿Está seguro que desea enviar a resumen diario los documentos seleccionados?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        new clsNegocioCEResumenDiario(localDB).cs_pxProcesarResumenDiario(seleccionados);            
                    }
                    
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

                    cs_pxCargarDgvComprobanteselectronicos(fecha_inicio_formato, fecha_fin_formato);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Debe seleccionar un item");
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Enviar comprobantes a resumen diario" + ex.Message);
            }

        }
    }
}
