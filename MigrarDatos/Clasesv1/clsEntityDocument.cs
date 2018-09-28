using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI1
{  
    public class clsEntityDocument1:clsBaseEntidad1
    {
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_tag_ID { get; set; }
        public string Cs_tag_IssueDate { get; set; }
        public string Cs_tag_InvoiceTypeCode { get; set; }//No incluir en NOTAS DE DEBITO O CREDITO
        public string Cs_tag_DocumentCurrencyCode { get; set; }
        public string Cs_tag_Discrepancy_ReferenceID { get; set; }//SOLO NOTAS DE DEBITO O CREDITO
        public string Cs_tag_Discrepancy_ResponseCode { get; set; }//SOLO NOTAS DE DEBITO O CREDITO
        public string Cs_tag_Discrepancy_Description { get; set; }//SOLO NOTAS DE DEBITO O CREDITO
        public string Cs_tag_BillingReference_ID { get; set; }//SOLO NOTAS DE DEBITO O CREDITO
        public string Cs_tag_BillingReference_DocumentTypeCode { get; set; }//SOLO NOTAS DE DEBITO O CREDITO
        public string Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_AdditionalAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PartyName_Name { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_District { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName { get; set; }
        public string Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID { get; set; }
        public string Cs_tag_AccountingCustomerParty_AdditionalAccountID { get; set; }
        public string Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName { get; set; }
        public string Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description { get; set; } //SOLO BOLETA
        public string Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID { get; set; }
        public string Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID { get; set; }
        public string Cs_pr_EstadoSUNAT { get; set; }
        public string Cs_pr_EstadoSCC { get; set; }
        public string Cs_pr_XML { get; set; }
        public string Cs_pr_CDR { get; set; }
        public string comprobante_xml_ticket { get; set; }
        public string Cs_pr_ComentarioSUNAT { get; set; }
        public string Cs_pr_Resumendiario { get; set; }
        public string comprobante_estadodocumentomodificacion { get; set; }
        public string comprobante_fechaenviodocumento { get; set; }
        public string Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount { get; set; }//Elemento que no estra en el pdf de estructura SUNAT
        public string Cs_pr_ComunicacionBaja { get; set; }//37
        public string Cs_pr_Empresa { get; set; }//38
        public string Cs_pr_Periodo { get; set; }//39
        public string Cs_Estado_EnvioCorreo { get; set; }//40
        public string Cs_Email_Cliente { get; set; }//41
        public string Cs_ResumenUltimo_Enviado { get; set; }//42
        public string Cs_TipoCambio { get; set; }//43
        public string Cs_tag_PerceptionSystemCode { get; set; }//44
        public string Cs_tag_PerceptionPercent { get; set; }//45

        public clsEntityDocument1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_Id = valores[0];
            Cs_tag_ID = valores[1];
            Cs_tag_IssueDate = valores[2];
            Cs_tag_InvoiceTypeCode = valores[3];//No incluir en NOTAS DE DEBITO O CREDITO
            Cs_tag_DocumentCurrencyCode = valores[4];
            Cs_tag_Discrepancy_ReferenceID = valores[5];//SOLO NOTAS DE DEBITO O CREDITO
            Cs_tag_Discrepancy_ResponseCode = valores[6];//SOLO NOTAS DE DEBITO O CREDITO
            Cs_tag_Discrepancy_Description = valores[7];//SOLO NOTAS DE DEBITO O CREDITO
            Cs_tag_BillingReference_ID = valores[8];//SOLO NOTAS DE DEBITO O CREDITO
            Cs_tag_BillingReference_DocumentTypeCode = valores[9];//SOLO NOTAS DE DEBITO O CREDITO
            Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = valores[10];
            Cs_tag_AccountingSupplierParty_AdditionalAccountID = valores[11];
            Cs_tag_AccountingSupplierParty_Party_PartyName_Name = valores[12];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID = valores[13];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName = valores[14];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName = valores[15];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName = valores[16];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity = valores[17];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_District = valores[18];
            Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode = valores[19];
            Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = valores[20];
            Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID = valores[21];
            Cs_tag_AccountingCustomerParty_AdditionalAccountID = valores[22];
            Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName = valores[23];
            Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description = valores[24]; //SOLO BOLETA
            Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID = valores[25];
            Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID = valores[26];
            Cs_pr_EstadoSUNAT = valores[27];
            Cs_pr_EstadoSCC = valores[28];
            Cs_pr_XML = valores[29];
            Cs_pr_CDR = valores[30];
            comprobante_xml_ticket = valores[31];
            Cs_pr_ComentarioSUNAT = valores[32];
            Cs_pr_Resumendiario = valores[33];
            comprobante_estadodocumentomodificacion = valores[34];
            comprobante_fechaenviodocumento = valores[35];
            Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount = valores[36];
            Cs_pr_ComunicacionBaja = valores[37];
            Cs_pr_Empresa = valores[38];
            Cs_pr_Periodo = valores[39];
            Cs_Estado_EnvioCorreo = valores[40];
            Cs_Email_Cliente = valores[41];//agregado para email.
            Cs_ResumenUltimo_Enviado = valores[42];
            Cs_TipoCambio = valores[43];
            Cs_tag_PerceptionSystemCode = valores[44];
            Cs_tag_PerceptionPercent = valores[45];
            return this;
        }

        public clsEntityDocument1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document";
            cs_cmTabla_min = "cs_Document";
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i <= 45; i++)//Número de campos
            {
                cs_cmCampos.Add("cp"+i.ToString());
            }
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i <= 45; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_tag_ID);
            cs_cmValores.Add(Cs_tag_IssueDate);
            cs_cmValores.Add(Cs_tag_InvoiceTypeCode);//No incluir en NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_DocumentCurrencyCode);
            cs_cmValores.Add(Cs_tag_Discrepancy_ReferenceID);//SOLO NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_Discrepancy_ResponseCode);//SOLO NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_Discrepancy_Description);//SOLO NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_BillingReference_ID);//SOLO NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_BillingReference_DocumentTypeCode);//SOLO NOTAS DE DEBITO O CREDITO
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_AdditionalAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PartyName_Name);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_District);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName);
            cs_cmValores.Add(Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID);
            cs_cmValores.Add(Cs_tag_AccountingCustomerParty_AdditionalAccountID);
            cs_cmValores.Add(Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName);
            cs_cmValores.Add(Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description); //SOLO BOLETA
            cs_cmValores.Add(Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID);
            cs_cmValores.Add(Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID);
            cs_cmValores.Add(Cs_pr_EstadoSUNAT);
            cs_cmValores.Add(Cs_pr_EstadoSCC);
            cs_cmValores.Add(Cs_pr_XML);
            cs_cmValores.Add(Cs_pr_CDR);
            cs_cmValores.Add(comprobante_xml_ticket);
            cs_cmValores.Add(Cs_pr_ComentarioSUNAT);
            cs_cmValores.Add(Cs_pr_Resumendiario);
            cs_cmValores.Add(comprobante_estadodocumentomodificacion);
            cs_cmValores.Add(comprobante_fechaenviodocumento);
            cs_cmValores.Add(Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount);
            cs_cmValores.Add(Cs_pr_ComunicacionBaja);//37
            cs_cmValores.Add(Cs_pr_Empresa);//38
            cs_cmValores.Add(Cs_pr_Periodo);//39
            cs_cmValores.Add(Cs_Estado_EnvioCorreo);//40
            cs_cmValores.Add(Cs_Email_Cliente);//41
            cs_cmValores.Add(Cs_ResumenUltimo_Enviado);//42
            cs_cmValores.Add(Cs_TipoCambio);//43
            cs_cmValores.Add(Cs_tag_PerceptionSystemCode);//44
            cs_cmValores.Add(Cs_tag_PerceptionPercent);//45

        }

        public List<List<string>> cs_pxObtenerPorResumenDiario(string id)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE 1=1";
                //sql += " AND cp3 ='" + clsBaseUtil1.cs_fxComprobantesElectronicos_codigo(comprobantetipo) + "' ";
                sql += " AND cp33 ='" + id + "' ";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                List<string> fila;
                while (datos.Read())
                {
                    //Devuelve los datos en el mismo orden que aparecen en la tabla. Considerar al llenar el datagridview.
                    fila = new List<string>();
                    for (int i = 0; i < datos.FieldCount; i++)
                    {
                        fila.Add(datos[i].ToString().Trim());
                    }
                    tabla_contenidos.Add(fila);
                }
                cs_pxConexion_basedatos.Close();
                return tabla_contenidos;
            }
            catch (Exception)
            {
                //clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument2 cs_pxObtenerPorResumenDiario " + ex.ToString());
                return null;
            }
        }
        public List<string> cs_pxOrdenarAscendente(List<string> ids)
        {
            List<string> ordenado;
            try
            {
                ordenado = new List<string>();
                string comas = string.Join(",", ids.ToArray());
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE 1=1";
                //sql += " AND cp3 ='" + clsBaseUtil1.cs_fxComprobantesElectronicos_codigo(comprobantetipo) + "' ";
                sql += " AND cs_Document_Id IN (" + comas + ")";
                sql += " ORDER BY  cp1 ASC";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    ordenado.Add(datos[0].ToString().Trim());
                }
                cs_pxConexion_basedatos.Close();
                return ordenado;
            }
            catch (Exception)
            {
                //clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd(" clsEntityDocument2 cs_pxOrdenarAscendente " + ex.ToString());
                return null;
            }
        }      
        
        internal List<clsEntityDocument1> cs_pxObtenerTodosLosRegistros()
        {
            List<clsEntityDocument1> documentos = new List<clsEntityDocument1>();
            try
            {            
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE 1=1";           
                //sql += " AND cp2 >= '" + fecha_inicio + "' ";
                //sql += " AND cp2 <= '" + fecha_fin + "' ";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntityDocument1 item;
                while (datos.Read())
                {
                    item = new clsEntityDocument1(conf);
                    item.Cs_pr_Document_Id = datos[0].ToString();
                    item.Cs_tag_ID = datos[1].ToString();
                    item.Cs_tag_IssueDate = datos[2].ToString();
                    item.Cs_tag_InvoiceTypeCode = datos[3].ToString();//No incluir en NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_DocumentCurrencyCode = datos[4].ToString();
                    item.Cs_tag_Discrepancy_ReferenceID = datos[5].ToString();//SOLO NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_Discrepancy_ResponseCode = datos[6].ToString();//SOLO NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_Discrepancy_Description = datos[7].ToString();//SOLO NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_BillingReference_ID = datos[8].ToString();//SOLO NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_BillingReference_DocumentTypeCode = datos[9].ToString();//SOLO NOTAS DE DEBITO O CREDITO
                    item.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = datos[10].ToString();
                    item.Cs_tag_AccountingSupplierParty_AdditionalAccountID = datos[11].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PartyName_Name = datos[12].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_ID = datos[13].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_StreetName = datos[14].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CitySubdivisionName = datos[15].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CityName = datos[16].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_CountrySubentity = datos[17].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_District = datos[18].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PostalAddress_Country_IdentificationCode = datos[19].ToString();
                    item.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = datos[20].ToString();
                    item.Cs_tag_AccountingCustomerParty_CustomerAssignedAccountID = datos[21].ToString();
                    item.Cs_tag_AccountingCustomerParty_AdditionalAccountID = datos[22].ToString();
                    item.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName = datos[23].ToString();
                    item.Cs_tag_AccountingCustomerParty_Party_PhysicalLocation_Description = datos[24].ToString(); //SOLO BOLETA
                    item.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_currencyID = datos[25].ToString();
                    item.Cs_tag_LegalMonetaryTotal_PayableAmount_currencyID = datos[26].ToString();
                    item.Cs_pr_EstadoSUNAT = datos[27].ToString();
                    item.Cs_pr_EstadoSCC = datos[28].ToString();
                    item.Cs_pr_XML = datos[29].ToString();
                    item.Cs_pr_CDR = datos[30].ToString();
                    item.comprobante_xml_ticket = datos[31].ToString();
                    item.Cs_pr_ComentarioSUNAT = datos[32].ToString();
                    item.Cs_pr_Resumendiario = datos[33].ToString();
                    item.comprobante_estadodocumentomodificacion = datos[34].ToString();
                    item.comprobante_fechaenviodocumento = datos[35].ToString();
                    item.Cs_tag_LegalMonetaryTotal_ChargeTotalAmount_AllowanceTotalAmount = datos[36].ToString();
                    item.Cs_pr_ComunicacionBaja = datos[37].ToString();
                    item.Cs_pr_Empresa = datos[38].ToString();
                    item.Cs_pr_Periodo = datos[39].ToString();
                    item.Cs_Estado_EnvioCorreo = datos[40].ToString();
                    item.Cs_Email_Cliente = datos[41].ToString();
                    item.Cs_ResumenUltimo_Enviado = datos[42].ToString();
                    item.Cs_TipoCambio = datos[43].ToString();
                    item.Cs_tag_PerceptionSystemCode = datos[44].ToString();
                    item.Cs_tag_PerceptionPercent = datos[45].ToString();
                    documentos.Add(item);
                }
                cs_pxConexion_basedatos.Close();
               
            }
            catch (Exception ex)
            {
                clsBaseLog1.cs_pxRegistarAdd1("1 obtener todos" + ex.ToString());
            }
            return documentos;
        }
    }
}
