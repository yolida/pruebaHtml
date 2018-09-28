using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
    public class clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1 : clsBaseEntidad1
    {
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id { get; set; }
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id { get; set; }
        public string Cs_tag_TaxAmount { get; set; }
        public string Cs_tag_TaxSubtotal_TaxAmount { get; set; }
        public string Cs_tag_TaxCategory_TaxScheme_ID { get; set; }
        public string Cs_tag_TaxCategory_TaxScheme_Name { get; set; }
        public string Cs_tag_TaxCategory_TaxScheme_TaxTypeCode { get; set; }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id);
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
            cs_cmValores.Add(Cs_tag_TaxAmount);
            cs_cmValores.Add(Cs_tag_TaxSubtotal_TaxAmount);
            cs_cmValores.Add(Cs_tag_TaxCategory_TaxScheme_ID);
            cs_cmValores.Add(Cs_tag_TaxCategory_TaxScheme_Name);
            cs_cmValores.Add(Cs_tag_TaxCategory_TaxScheme_TaxTypeCode);
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_SummaryDocuments_SummaryDocumentsLine_TaxTotal";
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id");
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 6; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_SummaryDocuments_SummaryDocumentsLine_TaxTotal";
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id");
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            for (int i = 1; i < 6; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        internal List<clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1> cs_fxObtenerTodoPorCabeceraId(string Id)
        {
            List<clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1> List_SummaryDocumentsLine_TaxTotal;
            try
            {
                List_SummaryDocumentsLine_TaxTotal = new List<clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_SummaryDocumentsLine_Id='" + Id.Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1 SummaryDocumentsLine_TaxTotal;
                while (datos.Read())
                {
                    SummaryDocumentsLine_TaxTotal = new clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1(conf);
                    SummaryDocumentsLine_TaxTotal.Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id = datos[0].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = datos[1].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_tag_TaxAmount = datos[2].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_tag_TaxSubtotal_TaxAmount = datos[3].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_tag_TaxCategory_TaxScheme_ID = datos[4].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_tag_TaxCategory_TaxScheme_Name = datos[5].ToString();
                    SummaryDocumentsLine_TaxTotal.Cs_tag_TaxCategory_TaxScheme_TaxTypeCode = datos[6].ToString();
                    List_SummaryDocumentsLine_TaxTotal.Add(SummaryDocumentsLine_TaxTotal);
                }
                cs_pxConexion_basedatos.Close();
                return List_SummaryDocumentsLine_TaxTotal;
            }
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1 cs_fxObtenerTodoPorCabeceraId " + ex.ToString());
                return null;
            }
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine_TaxTotal1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_TaxTotal_Id = valores[0];
            Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = valores[1];
            Cs_tag_TaxAmount = valores[2];
            Cs_tag_TaxSubtotal_TaxAmount = valores[3];
            Cs_tag_TaxCategory_TaxScheme_ID = valores[4];
            Cs_tag_TaxCategory_TaxScheme_Name = valores[5];
            Cs_tag_TaxCategory_TaxScheme_TaxTypeCode = valores[6];
            return this;
        }
    }
}
