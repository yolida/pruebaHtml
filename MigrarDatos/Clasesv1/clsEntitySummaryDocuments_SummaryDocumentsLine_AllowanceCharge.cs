using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
     public class clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1 : clsBaseEntidad1
    {
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id { get; set; }
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id { get; set; }
        public string Cs_tag_ChargeIndicator { get; set; }
        public string Cs_tag_Amount { get; set; }
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id);
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
            cs_cmValores.Add(Cs_tag_ChargeIndicator);
            cs_cmValores.Add(Cs_tag_Amount);
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge";
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id");
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 3; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge";
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id");
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 3; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        internal List<clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1> cs_fxObtenerTodoPorCabeceraId(string Id)
        {
            List<clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1> List_SummaryDocumentsLine_AllowanceCharge;
            try
            {
                List_SummaryDocumentsLine_AllowanceCharge = new List<clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_SummaryDocumentsLine_Id='" + Id.Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1 SummaryDocumentsLine_AllowanceCharge;
                while (datos.Read())
                {
                    SummaryDocumentsLine_AllowanceCharge = new clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1(conf);
                    SummaryDocumentsLine_AllowanceCharge.Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id = datos[0].ToString();
                    SummaryDocumentsLine_AllowanceCharge.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = datos[1].ToString();
                    SummaryDocumentsLine_AllowanceCharge.Cs_tag_ChargeIndicator = datos[2].ToString();
                    SummaryDocumentsLine_AllowanceCharge.Cs_tag_Amount = datos[3].ToString();
                    List_SummaryDocumentsLine_AllowanceCharge.Add(SummaryDocumentsLine_AllowanceCharge);
                }
                cs_pxConexion_basedatos.Close();
                return List_SummaryDocumentsLine_AllowanceCharge;
            }
            catch (Exception)
            {
               // System.Windows.Forms.MessageBox.Show(ex.ToString());
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
                return null;
            }
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_AllowanceCharge1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_AllowanceCharge_Id = valores[0];
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = valores[1];
            Cs_tag_ChargeIndicator = valores[2];
            Cs_tag_Amount = valores[3];
            return this;
        }
    }
}
