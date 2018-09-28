using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FEI.Usuario
{
    public partial class frmResumendiarioVisorSUNAT : frmBaseFormularios
    {
        public string mensaje;
        private string id;

        public frmResumendiarioVisorSUNAT(string id)
        {
            InitializeComponent();
            this.id = id;
            //cabecera = new clsEntityDocument();
            //cabecera.cs_fxObtenerUnoPorId(this.id);
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVisorSUNAT_Load(object sender, EventArgs e)
        {

            try
            {
                clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(new clsBaseConfiguracion().Cs_pr_Declarant_Id);
                clsEntitySummaryDocuments rd = new clsEntitySummaryDocuments().cs_fxObtenerUnoPorId(this.id);
                txtDocumento.Text = rd.Cs_tag_ID;
                txtFechaemision.Text = rd.Cs_tag_IssueDate;
                txtRazonsocial.Text = declarante.Cs_pr_RazonSocial;
                txtRuc.Text = declarante.Cs_pr_Ruc;
            }
            catch(Exception ex)
            {
                clsBaseMensaje.cs_pxMsg("Error visor Sunat","Error al cargar el formulario");
                clsBaseLog.cs_pxRegistarAdd("frmVisorSUNAT_Load" + ex.ToString());
            }
           
            
            /*
            rbtEnvío.Checked = true;
            txtDocumentotipo.Text = clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(cabecera.Invoice_InvoiceTypeCode);
            txtRuc.Text = cabecera.AccountingSupplierParty_CustomerAssignedAccountID;
            txtFechaemision.Text = cabecera.Invoice_IssueDate;
            txtRazonsocial.Text = cabecera.AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName;
            txtSerienumero.Text = cabecera.Invoice_ID;
            if (cabecera.comprobante_xml_envio.Length<=0)
            {
                rbtRecepción.Enabled = false;
                btnDescargarXML_Recepción.Enabled = false;
            }*/
        }

        private void rbtEnvío_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                if (resumendiario. comprobanteestado_sunat != "2")
                {
                    pxMostrarDocumentoEnvío();
                    pxMostrarDocumentoRecepción();
                }
                else
                {
                    pxMostrarDocumentoEnvío();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pxMostrarDocumentoEnvío()
        {
            /*
            //string html_1 = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/> <style type=\"text/css\"> *{ font-family: Microsoft Sans Serif; font-size: 8.25pt; }body{border:1px solid; padding:0px; margin:0px;}.correcto{font-weight:bold;color:green;}.error{font-weight:bold;color:brown;}a{color:#000;font-weight:normal;text-decoration:none;border:1px solid #000; padding:3px 5px;background-color:#ddd; color:#000} div{ position: relative; width:1500px; display:absolute; }table{ border-top:1px solid #333;border-left:1px solid #333;border-spacing:0px !important;}table td{border-spacing:0px; border:0px solid #333;border-right:1px solid #333;border-bottom:1px solid #333;padding:3px;}table tr:nth-child(even) td{background-color:#ececec;}table tr:nth-child(odd) td{background-color:#fff;}.titulo{background-color:#C2D69B!important;padding: 5px 3px;}</style></head><body><div style=\"padding:7px 3px; border-bottom:1px solid; background-color:LightGoldenrodYellow;\"><a href=\"#\">Descargar documento</a></div><div style=\"padding:15px;\">xcontenidox</div></body></html>";
            string html_1 = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/> <style type=\"text/css\"> *{ font-family: Microsoft Sans Serif; font-size: 8.25pt; }body{border:1px solid; padding:0px; margin:0px;}.correcto{font-weight:bold;color:green;}.error{font-weight:bold;color:brown;}a{color:#000;font-weight:normal;text-decoration:none;border:1px solid #000; padding:3px 5px;background-color:#ddd; color:#000} div{ position: relative; width:1500px; display:absolute; }table{ border-top:1px solid #333;border-left:1px solid #333;border-spacing:0px !important;}table td{border-spacing:0px; border:0px solid #333;border-right:1px solid #333;border-bottom:1px solid #333;padding:3px;}table tr:nth-child(even) td{background-color:#ececec;}table tr:nth-child(odd) td{background-color:#fff;}.titulo{background-color:#c5d9f1!important;padding: 5px 3px;}</style></head><body><div style=\"padding:15px;\">xcontenidox</div></body></html>";
            string html_2 = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/> <style type=\"text/css\"> *{ font-family: Microsoft Sans Serif; font-size: 8.25pt; }body{border:1px solid; background-color:Gainsboro; padding:0px; margin:0px;}.correcto{font-weight:bold;color:green;}.error{font-weight:bold;color:brown;}a{color:#000;font-weight:normal;text-decoration:none;border:1px solid #000; padding:3px 5px;background-color:#ddd; color:#000}</style></head><body><div style=\"padding:7px 3px; border-bottom:1px solid; background-color:LightGoldenrodYellow;\"><a href=\"#\">Descargar documento</a></div><div style=\"padding-left:15px;padding-bottom:15px;\">xcontenidox</div></body></html>";
            if (rbtEnvío.Checked == true)
            {
                string preparar = new clsNegocioCEFactura().cs_pxGenerarXMLAString(id);
                preparar = preparar.Replace("<", "&lt;");
                preparar = preparar.Replace(">", "&gt;");
                wbrTextoPlano.DocumentText = html_1.Replace("xcontenidox", new clsNegocioValidar().cs_pxGenerarReporteAHTML(id));

                if (cabecera.comprobante_xml_envio != "")
                {
                    //wbrXML.DocumentText = html_2.Replace("xcontenidox", "<xmp>" + cabecera.comprobante_xml_envio + "</xmp>");
                    cs_pxLlenarArbol(cabecera.comprobante_xml_envio);
                }
                else
                {
                    //wbrXML.DocumentText = html_2.Replace("xcontenidox", "<xmp>" + new clsNegocioCEFactura().cs_pxGenerarXMLAString(id) + "</xmp>");
                    cs_pxLlenarArbol(new clsNegocioCEFactura().cs_pxGenerarXMLAString(id));
                }
            }*/
        }

        private void pxMostrarDocumentoRecepción()
        {
            /*
            string html_1 = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/> <style type=\"text/css\"> *{ font-family: Microsoft Sans Serif; font-size: 8.25pt; }body{border:1px solid; padding:0px; margin:0px;}.correcto{font-weight:bold;color:green;}.error{font-weight:bold;color:brown;}a{color:#000;font-weight:normal;text-decoration:none;border:1px solid #000; padding:3px 5px;background-color:#ddd; color:#000} div{ position: relative; width:1500px; display:absolute; }table{ border-top:1px solid #333;border-left:1px solid #333;border-spacing:0px !important;}table td{border-spacing:0px; border:0px solid #333;border-right:1px solid #333;border-bottom:1px solid #333;padding:3px;}table tr:nth-child(even) td{background-color:#ececec;}table tr:nth-child(odd) td{background-color:#fff;}.titulo{background-color:#c5d9f1!important;padding: 5px 3px;}</style></head><body><div style=\"padding:15px;\">xcontenidox</div></body></html>";
            if (rbtRecepción.Checked == true)
            {
                string preparar = cabecera.comprobante_xml_recepcion;
                preparar = preparar.Replace("<", "&lt;");
                preparar = preparar.Replace(">", "&gt;");
                wbrTextoPlano.DocumentText = html_1.Replace("xcontenidox",  cs_pxEstructuraCDR(cabecera.comprobante_xml_recepcion));
                cs_pxLlenarArbol(cabecera.comprobante_xml_recepcion);
            }*/
        }
        

        private void cs_pxLlenarArbol(string ContenidoXML)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(ContenidoXML);
                trvXML.Nodes.Clear();
                trvXML.Nodes.Add(new TreeNode("<" + xDoc.DocumentElement.Name + ">"));
                TreeNode tNode = new TreeNode();
                tNode = trvXML.Nodes[0];
                cs_ArbolAgregarElemento(xDoc.DocumentElement, tNode);
                trvXML.ExpandAll();
            }
            catch (XmlException xExc)
            {
                MessageBox.Show(xExc.Message);
                clsBaseLog.cs_pxRegistarAdd("cs_pxLlenarArbol - XML " + xExc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clsBaseLog.cs_pxRegistarAdd("cs_pxLlenarArbol " + ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void cs_ArbolAgregarElemento(XmlNode xmlNode, TreeNode treeNode)
        {
            try
            {
                XmlNode xNode;
                TreeNode tNode;
                XmlNodeList xNodeList;
                if (xmlNode.HasChildNodes)
                {
                    xNodeList = xmlNode.ChildNodes;
                    for (int x = 0; x <= xNodeList.Count - 1; x++)
                    {
                        xNode = xmlNode.ChildNodes[x];
                        treeNode.Nodes.Add(new TreeNode("<" + xNode.Name + ">"));
                        tNode = treeNode.Nodes[x];
                        cs_ArbolAgregarElemento(xNode, tNode);
                    }
                }
                else
                {
                    treeNode.Text = xmlNode.OuterXml.Trim();
                }
            }
            catch(Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd(" cs_ArbolAgregarElemento " + ex.ToString());
            }
           
        }

        private string cs_pxLeerXML_ConvertirAHTML(string ContenidoXML)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(ContenidoXML);
                return "<h1>CONTENIDO DE CDR</h1><h1>Fecha y hora: " + DateTime.Now.ToString() + "</h1>" + "<table cellspacing=\"0\"><tr><td>" + cs_pxAgregarElemento(xDoc.DocumentElement) + "</table>";

            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("cs_pxLeerXML_ConvertirAHTML " + ex.ToString());
                return null;
            }

        }

        private string cs_pxAgregarElemento(XmlNode xmlNode)
        {
            string salida = "";
            XmlNode xNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes)
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    xNode = xmlNode.ChildNodes[x];

                    string xvalor = "";
                    xvalor = xNode.Value;
                    salida += "" + xNode.Name + "/";
                    if (xvalor != null && xvalor.Trim().Length > 0)
                    {
                        salida += ": " + xvalor + "</td></tr><tr><td>";
                    }
                    else
                    {
                        salida += "";
                    }
                    
                    salida += cs_pxAgregarElemento(xNode);

                    //salida += "</" + xNode.Name + ">";
                }
            }
            salida = salida.Replace("<#text>", "");
            salida = salida.Replace("</#text>", "");
            salida = salida.Replace("/#text/", "");
            return salida;
        }

        private string cs_pxEstructuraCDR(string XML)
        {
            XML = XML.Replace("cbc:", "");
            XML = XML.Replace("cac:", "");
            XML = XML.Replace("ext:", "");
            XML = XML.Replace("ds:", "");
            return cs_pxLeerXML_ConvertirAHTML(XML);
        }


        private void cs_pxDescargarEstructura()
        {
            string descarga = "";
            string html_1 = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/> <style type=\"text/css\"> *{ font-family: Microsoft Sans Serif; font-size: 8.25pt; }body{border:1px solid; padding:0px; margin:0px;}.correcto{font-weight:bold;color:green;}.error{font-weight:bold;color:brown;}a{color:#000;font-weight:normal;text-decoration:none;border:1px solid #000; padding:3px 5px;background-color:#ddd; color:#000} div{ position: relative; width:1500px; display:absolute; }table{ border-top:1px solid #333;border-left:1px solid #333;border-spacing:0px !important;}table td{border-spacing:0px; border:0px solid #333;border-right:1px solid #333;border-bottom:1px solid #333;padding:3px;}table tr:nth-child(even) td{background-color:#ececec;}table tr:nth-child(odd) td{background-color:#fff;}.titulo{background-color:#C2D69B!important;padding: 5px 3px;}</style></head><body><div style=\"padding:7px 3px; border-bottom:1px solid; background-color:LightGoldenrodYellow;\"><a href=\"#\">Descargar documento</a></div><div style=\"padding:15px;\">xcontenidox</div></body></html>";
            if (rbtEnvío.Checked == true)
            {
                string preparar = new clsNegocioCEFactura().cs_pxGenerarXMLAString(id);
                preparar = preparar.Replace("<", "&lt;");
                preparar = preparar.Replace(">", "&gt;");
                descarga = html_1.Replace("xcontenidox", new clsNegocioValidar().cs_pxGenerarReporteAHTML(id));
            }
            DialogResult result = sfdDescargar.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = sfdDescargar.FileName;
                if (file.Substring(file.Length-5) != ".html")
                {
                    file = file + ".html";
                }
                try
                {
                    StreamWriter sw0 = new StreamWriter(file);
                    sw0.Write(descarga);
                    sw0.Close();
                }
                catch (IOException)
                {
                }
            }
        }

        private void cs_pxDescargarXML_Envío()
        {
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
                    sw0.Write(new clsNegocioCEFactura().cs_pxGenerarXMLAString(id));
                    sw0.Close();
                }
                catch (IOException)
                {
                }
            }
        }

        private void cs_pxDescargarXML_Recepción()
        {
            /*
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
                    sw0.Write(cabecera.comprobante_xml_recepcion);
                    sw0.Close();
                }
                catch (IOException)
                {
                }
            }*/
        }

        private void btnDescargarXML_Click(object sender, EventArgs e)
        {
            cs_pxDescargarXML_Envío();
        }

        private void btnDescargarXML_Recepción_Click(object sender, EventArgs e)
        {
            cs_pxDescargarXML_Recepción();
        }
    }
}