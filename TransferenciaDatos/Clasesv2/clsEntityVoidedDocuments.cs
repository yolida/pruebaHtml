using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI2
{
    public class clsEntityVoidedDocuments2 : clsBaseEntidad2
    {
        public string Cs_pr_VoidedDocuments_Id { get; set; }
        public string Cs_tag_ID { get; set; }
        public string Cs_tag_ReferenceDate { get; set; }
        public string Cs_tag_IssueDate { get; set; }
        public string Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_AdditionalAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName { get; set; }
        public string Cs_pr_Ticket { get; set; }
        public string Cs_pr_EstadoSCC { get; set; }
        public string Cs_pr_EstadoSUNAT { get; set; }
        public string Cs_pr_ComentarioSUNAT { get; set; }
        public string Cs_pr_XML { get; set; }
        public string Cs_pr_CDR { get; set; }
        public string Cs_pr_DocumentoRelacionado { get; set; }
        public string Cs_pr_TipoContenido { get; set; }

        //private clsEntityDatabaseLocal localDB;
        public clsEntityVoidedDocuments2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_VoidedDocuments";
            cs_cmCampos.Add("cs_VoidedDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_VoidedDocuments";
            cs_cmCampos_min.Add("cs_VoidedDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
      

        public clsEntityVoidedDocuments2 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            if (valores.Count > 0)
            {
                Cs_pr_VoidedDocuments_Id = valores[0];
                Cs_tag_ID = valores[1];
                Cs_tag_ReferenceDate = valores[2];
                Cs_tag_IssueDate = valores[3];
                Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = valores[4];
                Cs_tag_AccountingSupplierParty_AdditionalAccountID = valores[5];
                Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = valores[6];
                Cs_pr_Ticket = valores[7];
                Cs_pr_EstadoSCC = valores[8];
                Cs_pr_EstadoSUNAT = valores[9];
                Cs_pr_ComentarioSUNAT = valores[10];
                Cs_pr_XML = valores[11];
                Cs_pr_CDR = valores[12];
                Cs_pr_DocumentoRelacionado = valores[13];
                Cs_pr_TipoContenido = valores[14];
                return this;
            }
            else
            {
                return null;
            }
            
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_VoidedDocuments_Id);
            cs_cmValores.Add(Cs_tag_ID);
            cs_cmValores.Add(Cs_tag_ReferenceDate);
            cs_cmValores.Add(Cs_tag_IssueDate);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_AdditionalAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName);
            cs_cmValores.Add(Cs_pr_Ticket);
            cs_cmValores.Add(Cs_pr_EstadoSCC);
            cs_cmValores.Add(Cs_pr_EstadoSUNAT);
            cs_cmValores.Add(Cs_pr_ComentarioSUNAT);
            cs_cmValores.Add(Cs_pr_XML);
            cs_cmValores.Add(Cs_pr_CDR);
            cs_cmValores.Add(Cs_pr_DocumentoRelacionado);
            cs_cmValores.Add(Cs_pr_TipoContenido);
        }
        public List<clsEntityVoidedDocuments2> cs_fxObtenerTodos()
        {
            List<clsEntityVoidedDocuments2> documentos = new List<clsEntityVoidedDocuments2>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " ;";//Estado SCC
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntityVoidedDocuments2 documento;
                while (datos.Read())
                {
                    documento = new clsEntityVoidedDocuments2(conf);
                    documento.Cs_pr_VoidedDocuments_Id = datos[0].ToString();
                    documento.Cs_tag_ID = datos[1].ToString();
                    documento.Cs_tag_ReferenceDate = datos[2].ToString();
                    documento.Cs_tag_IssueDate = datos[3].ToString();
                    documento.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = datos[4].ToString();
                    documento.Cs_tag_AccountingSupplierParty_AdditionalAccountID = datos[5].ToString();
                    documento.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = datos[6].ToString();
                    documento.Cs_pr_Ticket = datos[7].ToString();
                    documento.Cs_pr_EstadoSCC = datos[8].ToString();
                    documento.Cs_pr_EstadoSUNAT = datos[9].ToString();
                    documento.Cs_pr_ComentarioSUNAT = datos[10].ToString();
                    documento.Cs_pr_XML = datos[11].ToString();
                    documento.Cs_pr_CDR = datos[12].ToString();
                    documento.Cs_pr_DocumentoRelacionado = datos[13].ToString();
                    documentos.Add(documento);
                }
                cs_pxConexion_basedatos.Close();
            }
            catch (Exception)
            {
                //  clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
                //  clsBaseLog.cs_pxRegistarAdd("clsEntityVoidedDocuments1 cs_fxObtenerUnoPorTicket" + ex.ToString());
            }
            return documentos;
        }
    }
}
