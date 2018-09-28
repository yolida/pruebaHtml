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
/// Cambio de interfaz - Envio a sunat de facturas y notas relacionadas.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Factura_Sunat.xaml
    /// </summary>
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
        //Metodo constructor
        public Factura_Sunat(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
        }
        //Evento de carga de la ventana principal.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //agregar los valores para tipo de comprobante.
            tipos_comprobante.Add(new ComboBoxPares("", "Seleccione"));
            tipos_comprobante.Add(new ComboBoxPares("01", "Factura Electronica"));
            tipos_comprobante.Add(new ComboBoxPares("07", "Nota de Credito"));
            tipos_comprobante.Add(new ComboBoxPares("08", "Nota de Debito"));
            cboTipoComprobante.DisplayMemberPath = "_Value";
            cboTipoComprobante.SelectedValuePath = "_Key";
            cboTipoComprobante.SelectedIndex = 0;
            cboTipoComprobante.ItemsSource = tipos_comprobante;
            
            cbpTipoComprobante = (ComboBoxPares)cboTipoComprobante.SelectedItem;
            //Si la fecha de inicio esta seleccionada.
            if (datePick_inicio.SelectedDate != null)
            {
                DateTime fecha_inicio = (DateTime)datePick_inicio.SelectedDate;
                fecha_inicio_formato = fecha_inicio.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_inicio_formato = string.Empty;
            }
            //Si la fecha de fin esta seleccionada.
            if (datePick_fin.SelectedDate != null)
            {
                DateTime fecha_fin = (DateTime)datePick_fin.SelectedDate;
                fecha_fin_formato = fecha_fin.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha_fin_formato = string.Empty;
            }
            //Cargar comprobantes segun el filtro.
            cs_pxCargarDgvComprobanteselectronicos(cbpTipoComprobante._Id, fecha_inicio_formato, fecha_fin_formato);
        }
        //Metodo para cargar la grilla del listado de comprobantes.
        private void cs_pxCargarDgvComprobanteselectronicos(string tipo, string fechainicio, string fechafin)
        {
            dgComprobantesFactura.ItemsSource = null;
            dgComprobantesFactura.Items.Clear();
            //Obtener los registros para facturas.
            registros = new clsEntityDocument(localDB).cs_pxObtenerFiltroPrincipal(tipo, "2", "2", fechainicio, fechafin, "'01','07','08'", false);
            lista_reporte = new List<ReporteDocumento>();
            //Recorrer los registros para rellenar el grid.
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
            dgComprobantesFactura.ItemsSource = lista_reporte;
        }
        //Evento check para cada item del listado.
        private void chkDiscontinue_Checked(object sender, RoutedEventArgs e)
        {
            //Obtener el elemento seleccionado.
            CheckBox checkBox = (CheckBox)e.OriginalSource;
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
            CheckBox checkBox = (CheckBox)e.OriginalSource;
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
            cbpTipoComprobante = (ComboBoxPares)cboTipoComprobante.SelectedItem;
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
            cs_pxCargarDgvComprobanteselectronicos(cbpTipoComprobante._Id, fecha_inicio_formato, fecha_inicio_formato);
        }
        //Evento envio a sunat de comprobantes.
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            /*var images = new BitmapImage();
            images.BeginInit();
            images.UriSource = new Uri(@"/FEIv2;component/images/loader.gif", UriKind.RelativeOrAbsolute);
            images.EndInit();
            ImageBehavior.SetAnimatedSource(image, images);
            ImageBehavior.SetRepeatBehavior(image, RepeatBehavior.Forever);*/

            try
            {
                //Recorrer la grilla para obtener los documentos seleccionados de la grilla.
                List<string> seleccionados = new List<string>();
                foreach (var item in lista_reporte)
                {
                    if (item.Check == true)
                    {
                        seleccionados.Add(item.Id);
                    }
                }
                //If existen los elementos seleccionados.
                if (seleccionados.Count() > 0)
                {
                    //Por cada elemento seleccionado se envia a la sunat.
                    foreach (var item in seleccionados)
                    {
                        new clsBaseSunat(localDB).cs_pxEnviarCE(item.ToString(),true);
                    }
                    cbpTipoComprobante = (ComboBoxPares)cboTipoComprobante.SelectedItem;
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

                    cs_pxCargarDgvComprobanteselectronicos(cbpTipoComprobante._Id, fecha_inicio_formato, fecha_fin_formato);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un item");
                }
               
                /*var images_2 = new BitmapImage();
                ImageBehavior.SetAnimatedSource(image, images_2);

                var imagess = new BitmapImage();
                imagess.BeginInit();
                imagess.UriSource = new Uri(@"/FEIv2;component/images/send.png", UriKind.RelativeOrAbsolute);
                imagess.EndInit();
                image.Source = imagess;*/

            }
            catch (Exception ex)
            {
               /* var imagess = new BitmapImage();
                imagess.BeginInit();
                imagess.UriSource = new Uri(@"/FEIv2;component/images/send.png", UriKind.RelativeOrAbsolute);
                imagess.EndInit();
                image.Source = imagess;*/
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Enviar a sunat factura"+ex.Message);
            }
        }

    }
}
