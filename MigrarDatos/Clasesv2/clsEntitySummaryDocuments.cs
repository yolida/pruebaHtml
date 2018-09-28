using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI2
{
    public class clsEntitySummaryDocuments2 : clsBaseEntidad2
    {
        public string Cs_pr_SummaryDocuments_Id { get; set; }
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
        public string Cs_pr_ExceptionSUNAT { get; set; }
        public string Cs_tag_DocumentCurrencyCode { get; set; }
        //private clsEntityDatabaseLocal localDB;
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_Id);
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
            cs_cmValores.Add(Cs_pr_ExceptionSUNAT);
            cs_cmValores.Add(Cs_tag_DocumentCurrencyCode);
        }

        public clsEntitySummaryDocuments2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_SummaryDocuments";
            cs_cmCampos.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }
            cs_cmTabla_min = "cs_SummaryDocuments";
            cs_cmCampos_min.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
       
        public clsEntitySummaryDocuments2 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            if (valores.Count > 0)
            {
                Cs_pr_SummaryDocuments_Id = valores[0];
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
                Cs_pr_ExceptionSUNAT = valores[13];
                Cs_tag_DocumentCurrencyCode = valores[14];
                return this;
            }
            else
            {
                return null;
            }
           
        }
      
        
    }
}
