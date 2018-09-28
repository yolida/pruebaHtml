using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para ComunicacionBaja_Generar.xaml
    /// </summary>
    public partial class ComunicacionBaja_Generar : Page
    {
        List<ComboBoxPares> tipos_comprobante = new List<ComboBoxPares>();
        List<ComboBoxPares> estados_scc = new List<ComboBoxPares>();
        List<ComboBoxPares> estados_sunat = new List<ComboBoxPares>();
        List<clsEntityDocument> registros;
        List<ReporteDocumento> lista_reporte;
        ReporteDocumento itemRow;
        string fecha_inicio_formato;
        string fecha_fin_formato;
        private clsEntityDatabaseLocal localDB;
        //Metodo constructor
        public ComunicacionBaja_Generar(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        //Evento de carga de la pagina.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Agregar valores al combobox de tipos de comprobante.
            tipos_comprobante.Add(new ComboBoxPares("", "Seleccione"));
            tipos_comprobante.Add(new ComboBoxPares("01", "Factura Electronica"));
            tipos_comprobante.Add(new ComboBoxPares("07", "Nota de Credito"));
            tipos_comprobante.Add(new ComboBoxPares("08", "Nota de Debito"));
            cboTipoComprobante.DisplayMemberPath = "_Value";
            cboTipoComprobante.SelectedValuePath = "_Key";
            cboTipoComprobante.SelectedIndex = 0;
            cboTipoComprobante.ItemsSource = tipos_comprobante;

            //Agregar valores la combobox de estado SCC
            estados_scc.Add(new ComboBoxPares("", "Seleccione"));
            estados_scc.Add(new ComboBoxPares("0", "Enviado"));
            estados_scc.Add(new ComboBoxPares("1", "Pendiente (Errores)"));
            estados_scc.Add(new ComboBoxPares("2", "Pendiente (Correcto)"));
            cboEstadoSCC.DisplayMemberPath = "_Value";
            cboEstadoSCC.SelectedValuePath = "_key";
            cboEstadoSCC.SelectedIndex = 0;
            cboEstadoSCC.ItemsSource = estados_scc;
            //Agregar valores al combobox de estados de sunat.
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

            actualizarGrilla();
        }
        //Cargar comprobantes segun filtro
        private void cs_pxCargarDgvComprobanteselectronicos(string tipo, string estadocomprobantescc, string estadocomprobantesunat, string fechainicio, string fechafin)
        {
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            bool AddToList;
            //Obtener el lista de comprobantes en comunicacion de baja.
            registros = new clsEntityDocument(localDB).cs_pxObtenerFiltroComunicacionBaja(tipo, estadocomprobantesunat, estadocomprobantescc, fechainicio, fechafin);
            lista_reporte = new List<ReporteDocumento>();
            if (registros.Count > 0)
            {
                //Recorrer los registros para rellenar el grid.
                foreach (var item in registros)
                {
                    AddToList = false;

                    if (item.Cs_tag_InvoiceTypeCode == "03" || item.Cs_tag_BillingReference_DocumentTypeCode == "03")
                    {
                        //si es boleta o nota asociada agregar solo si esta por enviar o aceptado
                        if (item.Cs_pr_EstadoSUNAT == "0" || item.Cs_pr_EstadoSUNAT == "2")
                        {
                            AddToList = true;
                        }
                    }
                    else
                    {
                        if (item.Cs_pr_EstadoSUNAT == "0")
                        {
                            AddToList = true;
                        }
                    }
                    if (AddToList)
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
            }          
            dgComprobantes.ItemsSource = lista_reporte;
        }
        //Evento Check de los items en la grilla.
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtner elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener objeto asociado a elemento seleccionado.
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento doc = (ReporteDocumento)dataGridRow.DataContext;
            if ((bool)checkBox.IsChecked)
            {
                doc.Check = true;
            }
            e.Handled = true;
        }
        //Evento Uncheck de los items en la grilla.
        private void chkDiscontinue_Unchecked(object sender, RoutedEventArgs e)
        {
            //Obtener elemento seleccionado.
            System.Windows.Controls.CheckBox checkBox = (System.Windows.Controls.CheckBox)e.OriginalSource;
            //Obtener objeto asociado a elemento seleccinado
            DataGridRow dataGridRow = VisualTreeHelpers.FindAncestor<DataGridRow>(checkBox);
            ReporteDocumento doc = (ReporteDocumento)dataGridRow.DataContext;

            if ((bool)checkBox.IsChecked == false)
            {
                doc.Check = false;
            }
            e.Handled = true;
        }
        //Evento click para enviar los comprobantes a comunicacion de baja.
        private void btnEnviarSunat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Recorrer las grilla para obtener los elementos seleccionados.
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        seleccionados.Add(item.Id);
                    }                  
                }
                if (seleccionados.Count > 0) {
                    //Confirmacion para enviar a comunicacion de baja los documentos seleccionados.
                    if (System.Windows.Forms.MessageBox.Show("¿Está seguro que desea enviar a comunicación de baja los documentos seleccionados?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        new clsNegocioCEComunicacionBaja(localDB).cs_pxProcesarComunicacionBaja(seleccionados,"0");
                        actualizarGrilla();
                    }
                }
                
            }
            catch(Exception)
            {
                clsBaseLog.cs_pxRegistarAdd("btnEnviarSunat");
            }
        }
        //Metodo para actualizar el contenido de la grilla.
        private void actualizarGrilla()
        {   
            //Obtener objetos asociados de los valores seleccionados en los combobox.
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
            cs_pxCargarDgvComprobanteselectronicos(cbpTC._Id, cbpESCC._Id, cbpES._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Evento click para Filtrar los comprobantes.
        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            actualizarGrilla();
        }
    }
}
