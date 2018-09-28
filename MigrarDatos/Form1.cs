using FEI1;
using FEI2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrarDatos
{
    public partial class Form1 : Form
    {
        public clsBaseConfiguracion1 conf1;
        public clsBaseConfiguracion2 conf2;
        public Form1()
        {
            InitializeComponent();
            txtDbmsdriver.Text = "SQL Server";
            txtdriver2.Text = "SQL Server";
            cboGestorBasedatos.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar conexion bd 1 y bd2
            #region bd1
            conf1 = new clsBaseConfiguracion1();
            conf1.cs_prDbms = cboGestorBasedatos.Text;
            conf1.cs_prDbmsdriver = txtDbmsdriver.Text;
            conf1.cs_prDbmsservidor = txtDbmsservidor.Text;
            conf1.cs_prDbmsservidorpuerto = txtDbmsservidorpuerto.Text;
            conf1.cs_prDbnombre = txtDbnombre.Text;
            conf1.cs_prDbusuario = txtDbusuario.Text;
            conf1.cs_prDbclave = txtDbclave.Text;

            clsBaseConexion1 con1 = new clsBaseConexion1(conf1);
            bool estado1 = con1.cs_fxConexionEstado();
            #endregion

            #region bd2
            conf2 = new clsBaseConfiguracion2();
            conf2.cs_prDbms = comboBox1.Text;
            conf2.cs_prDbmsdriver = txtdriver2.Text;
            conf2.cs_prDbmsservidor = txtsrv2.Text;
            conf2.cs_prDbmsservidorpuerto = txtport2.Text;
            conf2.cs_prDbnombre = txtName2.Text;
            conf2.cs_prDbusuario = txtUSER2.Text;
            conf2.cs_prDbclave = txtcontra2.Text;

            clsBaseConexion2 con2 = new clsBaseConexion2(conf2);
            bool estado2 = con2.cs_fxConexionEstado();
            #endregion

            if(estado1==true && estado2 == true)
            {
                button1.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
                            }
            else
            {
                string mensaje = string.Empty;
                if (estado1 == false)
                {
                    mensaje += " Conexion BD1 fallida.\n";
                }
                if (estado2 == false)
                {
                    mensaje += " Conexion BD2 fallida.";
                }
                MessageBox.Show("Revise los parametros de conexion:\n"+ mensaje,"Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //hay conexion en ambas
            //buscar documentos en base version 1 y enviar a base version 2.
            //listar comprobantes de fei 1
            List<clsEntityDocument1> registros_antiguos = new clsEntityDocument1(conf1).cs_pxObtenerTodosLosRegistros();
            int i = 0;
            foreach (clsEntityDocument1 item in registros_antiguos)
            {
               
                int percentage = (i + 1) * 100 / registros_antiguos.Count;
                backgroundWorker1.ReportProgress(percentage);
                i++;

                clsEntityDocument2 doc = new clsEntityDocument2(conf2);
                doc.Cs_pr_Document_Id = item.Cs_pr_Document_Id;
                doc.Cs_tag_ID = item.Cs_tag_ID;
                doc.Cs_tag_IssueDate = item.Cs_tag_IssueDate;
                doc.Cs_tag_InvoiceTypeCode = item.Cs_tag_InvoiceTypeCode;//No incluir en NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_DocumentCurrencyCode = item.Cs_tag_DocumentCurrencyCode;
                doc.Cs_tag_Discrepancy_ReferenceID = item.Cs_tag_Discrepancy_ReferenceID;//SOLO NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_Discrepancy_ResponseCode = item.Cs_tag_Discrepancy_ResponseCode;//SOLO NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_Discrepancy_Description = item.Cs_tag_Discrepancy_Description;//SOLO NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_BillingReference_ID = item.Cs_tag_BillingReference_ID;//SOLO NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_BillingReference_DocumentTypeCode = item.Cs_tag_BillingReference_DocumentTypeCode;//SOLO NOTAS DE DEBITO O CREDITO
                doc.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = item.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID;
                doc.Cs_tag_AccountingSupplierParty_AdditionalAccountID = item.Cs_tag_AccountingSupplierParty_AdditionalAccountID;
                doc.Cs_tag_AccountingSupplierParty_Party_PartyName_Name = item.Cs_tag_AccountingSupplierParty_Party_PartyName_Name;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_District = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_District;
                doc.Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode = item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode;
                doc.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = item.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName;
                doc.Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID = item.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID;
                doc.Cs_tag_AccountingCustomerParty_AdditionalAccountID = item.Cs_tag_AccountingCustomerParty_AdditionalAccountID;
                doc.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName = item.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName;
                doc.Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description = item.Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description; //SOLO BOLETA
                doc.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID = item.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID;
                doc.Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID = item.Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID;
                doc.Cs_pr_EstadoSUNAT = item.Cs_pr_EstadoSUNAT;
                doc.Cs_pr_EstadoSCC = item.Cs_pr_EstadoSCC;
                doc.Cs_pr_XML = item.Cs_pr_XML.Replace("'", " \" ") ;
                doc.Cs_pr_CDR = item.Cs_pr_CDR.Replace("'"," ");
                doc.comprobante_xml_ticket = item.comprobante_xml_ticket;
                doc.Cs_pr_ComentarioSUNAT = item.Cs_pr_ComentarioSUNAT.Replace("'", " ");
                doc.Cs_pr_Resumendiario = item.Cs_pr_Resumendiario;
                doc.comprobante_estadodocumentomodificacion = item.comprobante_estadodocumentomodificacion;
                doc.comprobante_fechaenviodocumento = item.comprobante_fechaenviodocumento;
                doc.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount = item.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount;
                doc.Cs_pr_ComunicacionBaja = item.Cs_pr_ComunicacionBaja;
                doc.Cs_pr_Empresa = item.Cs_pr_Empresa;
                doc.Cs_pr_Periodo = item.Cs_pr_Periodo;
                doc.Cs_Estado_EnvioCorreo = item.Cs_Estado_EnvioCorreo;
                doc.Cs_Email_Cliente = item.Cs_Email_Cliente;//agregado para email.
                doc.Cs_ResumenUltimo_Enviado = item.Cs_ResumenUltimo_Enviado;
                doc.Cs_TipoCambio = item.Cs_TipoCambio;
                doc.Cs_tag_PerceptionSystemCode = item.Cs_tag_PerceptionSystemCode;
                doc.Cs_tag_PerceptionPercent = item.Cs_tag_PerceptionPercent;
                string idDoc = doc.cs_pxInsertar(false, false);

                if (idDoc.Trim().Length > 0)
                {
                    //buscar additional 
                    List<clsEntityDocument_AdditionalComments1> Document_AdditionalComments = new clsEntityDocument_AdditionalComments1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    string idDocAdditional = "";
                    foreach (clsEntityDocument_AdditionalComments1 ac in Document_AdditionalComments)
                    {
                        if (ac.Cs_pr_TagNombre == "DatosCabecera")
                        {
                            clsEntityDocument_AdditionalComments2 ac2 = new clsEntityDocument_AdditionalComments2(conf2);
                            ac2.Cs_pr_Document_AdditionalComments_Id = ac.Cs_pr_Document_AdditionalComments_Id;
                            ac2.Cs_pr_Document_Id = idDoc;
                            ac2.Cs_pr_Document_AdditionalComments_Reference_Id = "";
                            ac2.Cs_pr_TagNombre = ac.Cs_pr_TagNombre;
                            ac2.Cs_pr_TagValor = ac.Cs_pr_TagValor;
                            idDocAdditional = ac2.cs_pxInsertar(false, true);
                        }
                    }

                    foreach (clsEntityDocument_AdditionalComments1 ac in Document_AdditionalComments)
                    {
                        if (ac.Cs_pr_TagNombre != "DatosCabecera")
                        {
                            clsEntityDocument_AdditionalComments2 ac2 = new clsEntityDocument_AdditionalComments2(conf2);
                            ac2.Cs_pr_Document_AdditionalComments_Id = ac.Cs_pr_Document_AdditionalComments_Id;
                            ac2.Cs_pr_Document_Id = idDoc;
                            ac2.Cs_pr_Document_AdditionalComments_Reference_Id = idDocAdditional;
                            ac2.Cs_pr_TagNombre = ac.Cs_pr_TagNombre;
                            ac2.Cs_pr_TagValor = ac.Cs_pr_TagValor;
                            ac2.cs_pxInsertar(false, true);
                        }
                    }
                    //Document_AdditionalComments reference
                    List<clsEntityDocument_AdditionalDocumentReference1> AdditionalDocumentReference = new clsEntityDocument_AdditionalDocumentReference1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_AdditionalDocumentReference1 adr in AdditionalDocumentReference)
                    {
                        clsEntityDocument_AdditionalDocumentReference2 adr2 = new clsEntityDocument_AdditionalDocumentReference2(conf2);
                        adr2.Cs_pr_Document_AdditionalDocumentReference_Id = adr.Cs_pr_Document_AdditionalDocumentReference_Id;
                        adr2.Cs_pr_Document_Id = idDoc;
                        adr2.Cs_tag_AdditionalDocumentReference_ID = adr.Cs_tag_AdditionalDocumentReference_ID;
                        adr2.Cs_tag_DocumentTypeCode = adr.Cs_tag_DocumentTypeCode;
                        adr2.cs_pxInsertar(false, true);
                    }

                    //despatch
                    List<clsEntityDocument_DespatchDocumentReference1> DespatchDocumentReference = new clsEntityDocument_DespatchDocumentReference1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_DespatchDocumentReference1 ddr in DespatchDocumentReference)
                    {
                        clsEntityDocument_DespatchDocumentReference2 ddr2 = new clsEntityDocument_DespatchDocumentReference2(conf2);
                        ddr2.Cs_pr_Document_DespatchDocumentReference_Id = ddr.Cs_pr_Document_DespatchDocumentReference_Id;
                        ddr2.Cs_pr_Document_Id = idDoc;
                        ddr2.Cs_tag_DespatchDocumentReference_ID = ddr.Cs_tag_DespatchDocumentReference_ID;
                        ddr2.Cs_tag_DocumentTypeCode = ddr.Cs_tag_DocumentTypeCode;
                    }
                    //tax total
                    List<clsEntityDocument_TaxTotal1> Document_TaxTotal = new clsEntityDocument_TaxTotal1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_TaxTotal1 dtt in Document_TaxTotal)
                    {
                        clsEntityDocument_TaxTotal2 dtt2 = new clsEntityDocument_TaxTotal2(conf2);
                        dtt2.Cs_pr_Document_TaxTotal_Id = dtt.Cs_pr_Document_TaxTotal_Id;
                        dtt2.Cs_pr_Document_Id = idDoc;
                        dtt2.Cs_tag_TaxAmount = dtt.Cs_tag_TaxAmount;
                        dtt2.Cs_tag_TaxSubtotal_TaxAmount = dtt.Cs_tag_TaxSubtotal_TaxAmount;
                        dtt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID = dtt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID;
                        dtt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name = dtt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name;
                        dtt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode = dtt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode;
                        dtt2.cs_pxInsertar(false, true);
                    }
                    // clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation1 
                    string idadditional = "";
                    List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation1> Document_UBLExtension_ExtensionContent_AdditionalInformation = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation1 duwai in Document_UBLExtension_ExtensionContent_AdditionalInformation)
                    {
                        clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation2 duwai2 = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation2(conf2);
                        duwai2.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id = duwai.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id;
                        duwai2.Cs_pr_Document_Id = idDoc;
                        idadditional = duwai2.cs_pxInsertar(false, true);
                    }

                    // clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal 
                    List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1> Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 amt in Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal)
                    {
                        clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal2 amt2 = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal2(conf2);
                        amt2.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id = amt.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id;
                        amt2.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id = idadditional;
                        amt2.Cs_tag_Id = amt.Cs_tag_Id;
                        amt2.Cs_tag_Name = amt.Cs_tag_Name;
                        amt2.Cs_tag_ReferenceAmount = amt.Cs_tag_ReferenceAmount;
                        amt2.Cs_tag_PayableAmount = amt.Cs_tag_PayableAmount;
                        amt2.Cs_tag_Percent = amt.Cs_tag_Percent;
                        amt2.Cs_tag_TotalAmount = amt.Cs_tag_TotalAmount;
                        amt2.Cs_tag_SchemeID = amt.Cs_tag_SchemeID;
                        amt2.cs_pxInsertar(false, true);
                    }
                    // clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty1 Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty
                    List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty1> Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty1 aip in Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty)
                    {
                        clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2 aip2 = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2(conf2);
                        aip2.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id = aip.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id;
                        aip2.Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id = idadditional;
                        aip2.Cs_tag_ID = aip.Cs_tag_ID;
                        aip2.Cs_tag_Name = aip.Cs_tag_Name;
                        aip2.Cs_tag_Value = aip.Cs_tag_Value;
                    }
                    // clsEntityDocument_Line1 Document_Line
                    List<clsEntityDocument_Line1> Document_Line = new clsEntityDocument_Line1(conf1).cs_fxObtenerTodoPorCabeceraId(item.Cs_pr_Document_Id);
                    foreach (clsEntityDocument_Line1 docline in Document_Line)
                    {
                        clsEntityDocument_Line2 docline2 = new clsEntityDocument_Line2(conf2);
                        docline2.Cs_pr_Document_Line_Id = docline.Cs_pr_Document_Line_Id;
                        docline2.Cs_pr_Document_Id = idDoc;
                        docline2.Cs_tag_InvoiceLine_ID = docline.Cs_tag_InvoiceLine_ID;
                        docline2.Cs_tag_InvoicedQuantity_unitCode = docline.Cs_tag_InvoicedQuantity_unitCode;
                        docline2.Cs_tag_invoicedQuantity = docline.Cs_tag_invoicedQuantity;
                        docline2.Cs_tag_LineExtensionAmount_currencyID = docline.Cs_tag_LineExtensionAmount_currencyID;
                        docline2.Cs_tag_PricingReference_AlternativeConditionPrice_PriceAmount_currencyID = docline.Cs_tag_PricingReference_AlternativeConditionPrice_PriceAmount_currencyID;
                        docline2.Cs_tag_PricingReference_AlternativeConditionPrice_PriceTypeCode = docline.Cs_tag_PricingReference_AlternativeConditionPrice_PriceTypeCode;
                        docline2.Cs_tag_Item_SellersItemIdentification = docline.Cs_tag_Item_SellersItemIdentification;
                        docline2.Cs_tag_Price_PriceAmount = docline.Cs_tag_Price_PriceAmount; ;
                        docline2.Cs_tag_AllowanceCharge_ChargeIndicator = docline.Cs_tag_AllowanceCharge_ChargeIndicator;
                        docline2.Cs_tag_AllowanceCharge_Amount = docline.Cs_tag_AllowanceCharge_Amount;
                        string idlinea = docline2.cs_pxInsertar(false, true);

                        List<clsEntityDocument_Line_AdditionalComments1> Line_AdditionalComments = new clsEntityDocument_Line_AdditionalComments1(conf1).cs_fxObtenerTodoPorCabeceraId(docline.Cs_pr_Document_Line_Id);
                        foreach (clsEntityDocument_Line_AdditionalComments1 dlac in Line_AdditionalComments)
                        {
                            clsEntityDocument_Line_AdditionalComments2 dlac2 = new clsEntityDocument_Line_AdditionalComments2(conf2);
                            dlac2.Cs_pr_Document_Line_AdditionalComments_Id = dlac.Cs_pr_Document_Line_AdditionalComments_Id;
                            dlac2.Cs_pr_Document_Id = idlinea;
                            dlac2.Cs_pr_Document_Line_AdditionalComments_Reference_Id = "";
                            dlac2.Cs_pr_TagNombre = dlac.Cs_pr_TagNombre;
                            dlac2.Cs_pr_TagValor = dlac.Cs_pr_TagValor;
                            dlac2.cs_pxInsertar(false, true);
                        }

                        List<clsEntityDocument_Line_Description1> Line_Description = new clsEntityDocument_Line_Description1(conf1).cs_fxObtenerTodoPorCabeceraId(docline.Cs_pr_Document_Line_Id);
                        foreach (clsEntityDocument_Line_Description1 lds in Line_Description)
                        {
                            clsEntityDocument_Line_Description2 lds2 = new clsEntityDocument_Line_Description2(conf2);
                            lds2.Cs_pr_Document_Line_Description_Id = lds.Cs_pr_Document_Line_Description_Id;
                            lds2.Cs_pr_Document_Line_Id = idlinea;
                            lds2.Cs_tag_Description = lds.Cs_tag_Description;
                            lds2.cs_pxInsertar(false, true);
                        }

                        List<clsEntityDocument_Line_PricingReference1> Line_PricingReference = new clsEntityDocument_Line_PricingReference1(conf1).cs_fxObtenerTodoPorCabeceraId(docline.Cs_pr_Document_Line_Id);
                        foreach (clsEntityDocument_Line_PricingReference1 lpr in Line_PricingReference)
                        {
                            clsEntityDocument_Line_PricingReference2 lpr2 = new clsEntityDocument_Line_PricingReference2(conf2);
                            lpr2.Cs_pr_Document_Line_PricingReference_Id = lpr.Cs_pr_Document_Line_PricingReference_Id;
                            lpr2.Cs_pr_Document_Line_Id = idlinea;
                            lpr2.Cs_tag_PriceAmount_currencyID = lpr.Cs_tag_PriceAmount_currencyID;
                            lpr2.Cs_tag_PriceTypeCode = lpr.Cs_tag_PriceTypeCode;
                            lpr2.cs_pxInsertar(false, true);
                        }

                        List<clsEntityDocument_Line_TaxTotal1> Document_Line_TaxTotal = new clsEntityDocument_Line_TaxTotal1(conf1).cs_fxObtenerTodoPorCabeceraId(docline.Cs_pr_Document_Line_Id);
                        foreach (clsEntityDocument_Line_TaxTotal1 dltt in Document_Line_TaxTotal)
                        {
                            clsEntityDocument_Line_TaxTotal2 dltt2 = new clsEntityDocument_Line_TaxTotal2(conf2);
                            dltt2.Cs_pr_Document_Line_TaxTotal_Id = dltt.Cs_pr_Document_Line_TaxTotal_Id;
                            dltt2.Cs_pr_Document_Line_Id = idlinea;
                            dltt2.Cs_tag_TaxAmount_currencyID = dltt.Cs_tag_TaxAmount_currencyID;
                            dltt2.Cs_tag_TaxSubtotal_TaxAmount_currencyID = dltt.Cs_tag_TaxSubtotal_TaxAmount_currencyID;
                            dltt2.Cs_tag_TaxSubtotal_TaxCategory_TaxExemptionReasonCode = dltt.Cs_tag_TaxSubtotal_TaxCategory_TaxExemptionReasonCode;
                            dltt2.Cs_tag_TaxSubtotal_TaxCategory_TierRange = dltt.Cs_tag_TaxSubtotal_TaxCategory_TierRange;
                            dltt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID = dltt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID;
                            dltt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name = dltt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name;
                            dltt2.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode = dltt.Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode;
                            dltt2.cs_pxInsertar(false, true);
                        }
                    }
                }
               
            }
            int y = 0;
            //insertar resumenes diarios
            List<clsEntitySummaryDocuments1> cs_fxObtenerResumenes = new clsEntitySummaryDocuments1(conf1).cs_fxObtenerResumenes();
            foreach (clsEntitySummaryDocuments1 cesd in cs_fxObtenerResumenes)
            {
               
                int percentage = (y + 1) * 100 / cs_fxObtenerResumenes.Count;
                backgroundWorker1.ReportProgress(percentage);
                y++;
                clsEntitySummaryDocuments2 cesd2 = new clsEntitySummaryDocuments2(conf2);
                cesd2.Cs_pr_SummaryDocuments_Id = cesd.Cs_pr_SummaryDocuments_Id;
                cesd2.Cs_tag_ID = cesd.Cs_tag_ID;
                cesd2.Cs_tag_ReferenceDate = cesd.Cs_tag_ReferenceDate;
                cesd2.Cs_tag_IssueDate = cesd.Cs_tag_IssueDate;
                cesd2.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = cesd.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID;
                cesd2.Cs_tag_AccountingSupplierParty_AdditionalAccountID = cesd.Cs_tag_AccountingSupplierParty_AdditionalAccountID;
                cesd2.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = cesd.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName;
                cesd2.Cs_pr_Ticket = cesd.Cs_pr_Ticket;
                cesd2.Cs_pr_EstadoSCC = cesd.Cs_pr_EstadoSCC;
                cesd2.Cs_pr_EstadoSUNAT = cesd.Cs_pr_EstadoSUNAT;
                cesd2.Cs_pr_ComentarioSUNAT = cesd.Cs_pr_ComentarioSUNAT.Replace("'", " ");
                cesd2.Cs_pr_XML = cesd.Cs_pr_XML;
                cesd2.Cs_pr_CDR = cesd.Cs_pr_CDR.Replace("'", " ");
                cesd2.Cs_pr_ExceptionSUNAT = cesd.Cs_pr_SummaryDocuments_Id;
                cesd2.Cs_tag_DocumentCurrencyCode = cesd.Cs_tag_DocumentCurrencyCode;
                string idsummary = cesd2.cs_pxInsertar(false, false);

                //buscar todos los documentos relacionados y actualizarlos.
                List<clsEntityDocument2> docs2 = new clsEntityDocument2(conf2).cs_pxObtenerPorResumenDiario_n(cesd.Cs_pr_SummaryDocuments_Id);
                foreach (clsEntityDocument2 docitem2 in docs2)
                {
                    docitem2.Cs_pr_Resumendiario = idsummary;
                    docitem2.cs_pxActualizar(false, false);
                }


                List<clsEntitySummaryDocuments_SummaryDocumentsLine1> Summary_Line = new clsEntitySummaryDocuments_SummaryDocumentsLine1(conf1).cs_fxObtenerTodoPorCabeceraId(cesd.Cs_pr_SummaryDocuments_Id);
                foreach (clsEntitySummaryDocuments_SummaryDocumentsLine1 sml in Summary_Line)
                {
                    clsEntitySummaryDocuments_SummaryDocumentsLine2 sml2 = new clsEntitySummaryDocuments_SummaryDocumentsLine2(conf2);
                    sml2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = sml.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id;
                    sml2.Cs_pr_SummaryDocuments_Id = idsummary;
                    sml2.Cs_tag_LineID = sml.Cs_tag_LineID;
                    sml2.Cs_tag_DocumentTypeCode = sml.Cs_tag_DocumentTypeCode;
                    sml2.Cs_tag_DocumentSerialID = sml.Cs_tag_DocumentSerialID;
                    sml2.Cs_tag_StartDocumentNumberID = sml.Cs_tag_StartDocumentNumberID;
                    sml2.Cs_tag_EndDocumentNumberID = sml.Cs_tag_EndDocumentNumberID;
                    sml2.Cs_tag_TotalAmount = sml.Cs_tag_TotalAmount;
                    string idsummarylinea = sml2.cs_pxInsertar(false, true);

                    List<clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1> Summary_Line_Allowance_Charge = new clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1(conf1).cs_fxObtenerTodoPorCabeceraId(sml.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
                    foreach (clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1 slac in Summary_Line_Allowance_Charge)
                    {
                        clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge2 slac2 = new clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge2(conf2);
                        slac2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id = slac.Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id;
                        slac2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = idsummarylinea;
                        slac2.Cs_tag_ChargeIndicator = slac.Cs_tag_ChargeIndicator;
                        slac2.Cs_tag_Amount = slac.Cs_tag_Amount;
                        slac2.cs_pxInsertar(false, true);
                    }
                    List<clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1> Summary_Line_Billing_Payment = new clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1(conf1).cs_fxObtenerTodoPorCabeceraId(sml.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
                    foreach (clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1 sdlbp in Summary_Line_Billing_Payment)
                    {
                        clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment2 sdlbp2 = new clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment2(conf2);
                        sdlbp2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id = sdlbp.Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id;
                        sdlbp2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = idsummarylinea;
                        sdlbp2.Cs_tag_PaidAmount = sdlbp.Cs_tag_PaidAmount;
                        sdlbp2.Cs_tag_InstructionID = sdlbp.Cs_tag_InstructionID;
                        sdlbp2.cs_pxInsertar(false, true);
                    }

                    List<clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1> Summay_Line_Tax_Total = new clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1(conf1).cs_fxObtenerTodoPorCabeceraId(sml.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
                    foreach (clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1 sltt in Summay_Line_Tax_Total)
                    {
                        clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal2 sltt2 = new clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal2(conf2);
                        sltt2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id = sltt.Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id;
                        sltt2.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = idsummarylinea;
                        sltt2.Cs_tag_TaxAmount = sltt.Cs_tag_TaxAmount;
                        sltt2.Cs_tag_TaxSubtotal_TaxAmount = sltt.Cs_tag_TaxSubtotal_TaxAmount;
                        sltt2.Cs_tag_TaxCategory_TaxScheme_ID = sltt.Cs_tag_TaxCategory_TaxScheme_ID;
                        sltt2.Cs_tag_TaxCategory_TaxScheme_Name = sltt.Cs_tag_TaxCategory_TaxScheme_Name;
                        sltt2.Cs_tag_TaxCategory_TaxScheme_TaxTypeCode = sltt.Cs_tag_TaxCategory_TaxScheme_TaxTypeCode;
                        sltt2.cs_pxInsertar(false, true);
                    }
                }

            }
            int w = 0;
            //voided documents
            List<clsEntityVoidedDocuments1> voideddocuments = new clsEntityVoidedDocuments1(conf1).cs_fxObtenerTodos();
            foreach (clsEntityVoidedDocuments1 vd in voideddocuments)
            {
                
                int percentage = (w + 1) * 100 / voideddocuments.Count;
                backgroundWorker1.ReportProgress(percentage);
                w++;

                clsEntityVoidedDocuments2 vd2 = new clsEntityVoidedDocuments2(conf2);
                vd2.Cs_pr_VoidedDocuments_Id = vd.Cs_pr_VoidedDocuments_Id;
                vd2.Cs_tag_ID = vd.Cs_tag_ID;
                vd2.Cs_tag_ReferenceDate = vd.Cs_tag_ReferenceDate;
                vd2.Cs_tag_IssueDate = vd.Cs_tag_IssueDate;
                vd2.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = vd.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID;
                vd2.Cs_tag_AccountingSupplierParty_AdditionalAccountID = vd.Cs_tag_AccountingSupplierParty_AdditionalAccountID;
                vd2.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = vd.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName;
                vd2.Cs_pr_Ticket = vd.Cs_pr_Ticket;
                vd2.Cs_pr_EstadoSCC = vd.Cs_pr_EstadoSCC;
                vd2.Cs_pr_EstadoSUNAT = vd.Cs_pr_EstadoSUNAT;
                vd2.Cs_pr_ComentarioSUNAT = vd.Cs_pr_ComentarioSUNAT.Replace("'", " "); 
                vd2.Cs_pr_XML = vd.Cs_pr_XML;
                vd2.Cs_pr_CDR = vd.Cs_pr_CDR.Replace("'", " ");
                vd2.Cs_pr_DocumentoRelacionado = vd.Cs_pr_VoidedDocuments_Id;
                vd2.Cs_pr_TipoContenido = "0";
                string idbaja = vd2.cs_pxInsertar(false, false);

                //buscar documentos relacionados por idbaja antiguo
                List<clsEntityDocument2> docdosbaja = new clsEntityDocument2(conf2).cs_pxObtenerPorComunicacionBaja_n(vd.Cs_pr_VoidedDocuments_Id);
                foreach (clsEntityDocument2 docdosb in docdosbaja)
                {
                    docdosb.Cs_pr_ComunicacionBaja = idbaja;
                    docdosb.cs_pxActualizar(false, false);
                }
                List<clsEntityVoidedDocuments_VoidedDocumentsLine1> vdline = new clsEntityVoidedDocuments_VoidedDocumentsLine1(conf1).cs_fxObtenerTodoPorCabeceraId(vd.Cs_pr_VoidedDocuments_Id);
                foreach (clsEntityVoidedDocuments_VoidedDocumentsLine1 vdlinea in vdline)
                {
                    clsEntityVoidedDocuments_VoidedDocumentsLine2 vdlinea2 = new clsEntityVoidedDocuments_VoidedDocumentsLine2(conf2);
                    vdlinea2.Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id = vdlinea.Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id;
                    vdlinea2.Cs_pr_VoidedDocuments_Id = idbaja;
                    vdlinea2.Cs_tag_LineID = vdlinea.Cs_tag_LineID;
                    vdlinea2.Cs_tag_DocumentTypeCode = vdlinea.Cs_tag_DocumentTypeCode;
                    vdlinea2.Cs_tag_DocumentSerialID = vdlinea.Cs_tag_DocumentSerialID;
                    vdlinea2.Cs_tag_DocumentNumberID = vdlinea.Cs_tag_DocumentNumberID;
                    //buscar id del doc en la bd2 
                    string idrelacionado = new clsEntityDocument2(conf2).cs_pxObtenerIdPorSerieCorrelativo(vdlinea.Cs_tag_DocumentSerialID + "-" + vdlinea.Cs_tag_DocumentNumberID);
                    vdlinea2.Cs_tag_VoidReasonDescription = vdlinea.Cs_tag_VoidReasonDescription;
                    vdlinea2.Cs_pr_IDDocumentoRelacionado = idrelacionado;
                    vdlinea2.cs_pxInsertar(false, true);
                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            button1.Enabled = true;
            MessageBox.Show("Migración de datos completada.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
