using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{

    public class clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1 : clsBaseEntidad1
    {
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id { get; set; }
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id { get; set; }
        public string Cs_tag_PaidAmount { get; set; }
        public string Cs_tag_InstructionID { get; set; }
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id);
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
            cs_cmValores.Add(Cs_tag_PaidAmount);
            cs_cmValores.Add(Cs_tag_InstructionID);
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_SummaryDocuments_SummaryDocumentsLine_BillingPayment";
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id");
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 3; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_SummaryDocuments_SummaryDocumentsLine_BillingPayment";
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id");
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 3; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        internal List<clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1> cs_fxObtenerTodoPorCabeceraId(string Id)
        {
            List<clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1> List_SummaryDocumentsLine_BillingPayment;
            try
            {
                List_SummaryDocumentsLine_BillingPayment = new List<clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_SummaryDocumentsLine_Id='" + Id.Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1 SummaryDocumentsLine_BillingPayment;
                while (datos.Read())
                {
                    SummaryDocumentsLine_BillingPayment = new clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1(conf);
                    SummaryDocumentsLine_BillingPayment.Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id = datos[0].ToString();
                    SummaryDocumentsLine_BillingPayment.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = datos[1].ToString();
                    SummaryDocumentsLine_BillingPayment.Cs_tag_PaidAmount = datos[2].ToString();
                    SummaryDocumentsLine_BillingPayment.Cs_tag_InstructionID = datos[3].ToString();
                    List_SummaryDocumentsLine_BillingPayment.Add(SummaryDocumentsLine_BillingPayment);
                }
                cs_pxConexion_basedatos.Close();
                return List_SummaryDocumentsLine_BillingPayment;
            }
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1" + ex.ToString());
                return null;
            }
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_BillingPayment1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_BillingPayment_Id = valores[0];
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = valores[1];
            Cs_tag_PaidAmount = valores[2];
            Cs_tag_InstructionID = valores[3];
            return this;
        }
    }
}
