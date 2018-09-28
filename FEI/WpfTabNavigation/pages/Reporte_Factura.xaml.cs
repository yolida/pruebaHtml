using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Reportes de facturas.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Reporte_Factura.xaml
    /// </summary>
    public partial class Reporte_Factura : Page
    {
        List<ComboBoxPares> tipos_comprobante = new List<ComboBoxPares>();
        List<ComboBoxPares> estados_scc = new List<ComboBoxPares>();
        List<ComboBoxPares> estados_sunat = new List<ComboBoxPares>();
        List<ComboBoxPares> tipos_reporte = new List<ComboBoxPares>();
        List<clsEntityDocument> registros;
        List<ReporteDocumento> lista_reporte;
        ReporteDocumento itemRow;
        string fecha_inicio_formato;
        string fecha_fin_formato;
        private clsEntityDatabaseLocal localDB;
        //Metodo constructor
        public Reporte_Factura(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        //Evento de carga de la ventana.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Agregar valores a combobox de tipo reporte
            tipos_reporte.Add(new ComboBoxPares("0", "PDF"));
            tipos_reporte.Add(new ComboBoxPares("1", "CSV"));
            cboDownload.DisplayMemberPath = "_Value";
            cboDownload.SelectedValuePath = "_key";
            cboDownload.SelectedIndex = 0;
            cboDownload.ItemsSource = tipos_reporte;
            //Agregar valores a combobox de tipo de comprobante
            tipos_comprobante.Add(new ComboBoxPares("", "Seleccione"));
            tipos_comprobante.Add(new ComboBoxPares("01", "Factura Electronica"));
            tipos_comprobante.Add(new ComboBoxPares("07", "Nota de Credito"));
            tipos_comprobante.Add(new ComboBoxPares("08", "Nota de Debito"));
            cboTipoComprobante.DisplayMemberPath = "_Value";
            cboTipoComprobante.SelectedValuePath = "_Key";
            cboTipoComprobante.SelectedIndex = 0;
            cboTipoComprobante.ItemsSource = tipos_comprobante;
            //Agregar valores a combobox de tipo estados de SCC
            estados_scc.Add(new ComboBoxPares("", "Seleccione"));
            estados_scc.Add(new ComboBoxPares("0", "Enviado"));
            estados_scc.Add(new ComboBoxPares("1", "Pendiente (Errores)"));
            estados_scc.Add(new ComboBoxPares("2", "Pendiente (Correcto)"));
            cboEstadoSCC.DisplayMemberPath = "_Value";
            cboEstadoSCC.SelectedValuePath = "_key";
            cboEstadoSCC.SelectedIndex = 0;
            cboEstadoSCC.ItemsSource = estados_scc;
            //Agregar estados sunat a combobox.
            estados_sunat.Add(new ComboBoxPares("", "Seleccione"));
            estados_sunat.Add(new ComboBoxPares("0", "Aceptado"));
            estados_sunat.Add(new ComboBoxPares("1", "Rechazado"));
            estados_sunat.Add(new ComboBoxPares("2", "Sin estado"));
            estados_sunat.Add(new ComboBoxPares("3", "De Baja"));
      
            cboEstadoSunat.DisplayMemberPath = "_Value";
            cboEstadoSunat.SelectedValuePath = "_key";
            cboEstadoSunat.SelectedIndex = 0;
            cboEstadoSunat.ItemsSource = estados_sunat;
            datePick_inicio.Text = DateTime.Now.Date.ToString();
            datePick_fin.Text = DateTime.Now.Date.ToString();

            ComboBoxPares cbpTC = (ComboBoxPares)cboTipoComprobante.SelectedItem;
            ComboBoxPares cbpESCC = (ComboBoxPares)cboEstadoSCC.SelectedItem;
            ComboBoxPares cbpES = (ComboBoxPares)cboEstadoSunat.SelectedItem;

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
            cs_pxCargarDgvComprobanteselectronicos(cbpTC._Id, cbpESCC._Id, cbpES._Id,fecha_inicio_formato, fecha_fin_formato);
        }
        //Metodo de carga de comprobantes en la grilla
        private void cs_pxCargarDgvComprobanteselectronicos(string tipo, string estadocomprobantescc, string estadocomprobantesunat,string fechainicio, string fechafin)
        {
            dgComprobantes.ItemsSource = null;               
            dgComprobantes.Items.Clear();
            //Obtener los comprobantes de factura.
            registros = new clsEntityDocument(localDB).cs_pxObtenerFiltroPrincipal(tipo, estadocomprobantesunat, estadocomprobantescc, fechainicio, fechafin, "'01','07','08'",false);
            lista_reporte = new List<ReporteDocumento>();
            //lista_reporte = new ObservableCollection<Reporte>();
            if (registros != null)
            {
                //Recorrer los registros para llenar la grilla.
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
                    lista_reporte.Add(itemRow);
                }
            }
           
            dgComprobantes.ItemsSource = lista_reporte;        
        }
        //Evento para filtra los comprobantes.
        private void btnFiltro_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxPares cbpTC = (ComboBoxPares)cboTipoComprobante.SelectedItem;
            ComboBoxPares cbpESCC = (ComboBoxPares)cboEstadoSCC.SelectedItem;
            ComboBoxPares cbpES = (ComboBoxPares)cboEstadoSunat.SelectedItem;
            
            if (datePick_inicio.SelectedDate != null){

                DateTime fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato= fecha_inicio.ToString("yyyy-MM-dd");

            }else
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
            cs_pxCargarDgvComprobanteselectronicos(cbpTC._Id, cbpESCC._Id, cbpES._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento para descargar reporte.
        private void btnReporte_Click(object sender, RoutedEventArgs e)
        {
            if (lista_reporte.Count > 0){
                clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                switch (cboDownload.SelectedIndex)
                {
                    case 0:
                        clsBaseReporte.cs_pxReportePDF(lista_reporte, configuracion.cs_prRutareportesPDF + "\\FACTURAS-" + DateTime.Today.Date.ToShortDateString().Replace('/', '-') + "--" + DateTime.Now.ToShortTimeString().Replace(':','-') + ".pdf");
                        break;
                    case 1:
                        clsBaseReporte.cs_pxReporteCSV(lista_reporte, configuracion.cs_prRutareportesCSV + "\\FACTURAS-" + DateTime.Today.Date.ToShortDateString().Replace('/', '-') + "--" + DateTime.Now.ToShortTimeString().Replace(':','-') + ".csv");
                        break;

                }
            }else
            {
                clsBaseMensaje.cs_pxMsg("Error al generar reporte","Debe existir datos listados para generar el reporte.");
            }
           
        }
    }
}
