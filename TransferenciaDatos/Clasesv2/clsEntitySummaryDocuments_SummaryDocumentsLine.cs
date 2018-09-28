
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI2
{

    public class clsEntitySummaryDocuments_SummaryDocumentsLine2 : clsBaseEntidad2
    {
        public string Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id { get; set; }
        public string Cs_pr_SummaryDocuments_Id { get; set; }
        public string Cs_tag_LineID { get; set; }
        public string Cs_tag_DocumentTypeCode { get; set; }
        public string Cs_tag_DocumentSerialID { get; set; }
        public string Cs_tag_StartDocumentNumberID { get; set; }
        public string Cs_tag_EndDocumentNumberID { get; set; }
        public string Cs_tag_TotalAmount { get; set; }
        //private clsEntityDatabaseLocal localDB;
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id);
            cs_cmValores.Add(Cs_pr_SummaryDocuments_Id);
            cs_cmValores.Add(Cs_tag_LineID);
            cs_cmValores.Add(Cs_tag_DocumentTypeCode);
            cs_cmValores.Add(Cs_tag_DocumentSerialID);
            cs_cmValores.Add(Cs_tag_StartDocumentNumberID);
            cs_cmValores.Add(Cs_tag_EndDocumentNumberID);
            cs_cmValores.Add(Cs_tag_TotalAmount);
        }

        internal List<clsEntitySummaryDocuments_SummaryDocumentsLine2> cs_fxObtenerTodoPorCabeceraId(string Id)
        {
            List<clsEntitySummaryDocuments_SummaryDocumentsLine2> List_SummaryDocumentsLine;
            try
            {
                List_SummaryDocumentsLine = new List<clsEntitySummaryDocuments_SummaryDocumentsLine2>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_Id=" + Id.Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntitySummaryDocuments_SummaryDocumentsLine2 SummaryDocumentsLine;
                while (datos.Read())
                {
                    SummaryDocumentsLine = new clsEntitySummaryDocuments_SummaryDocumentsLine2(conf);
                    SummaryDocumentsLine.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = datos[0].ToString();
                    SummaryDocumentsLine.Cs_pr_SummaryDocuments_Id = datos[1].ToString();
                    SummaryDocumentsLine.Cs_tag_LineID = datos[2].ToString();
                    SummaryDocumentsLine.Cs_tag_DocumentTypeCode = datos[3].ToString();
                    SummaryDocumentsLine.Cs_tag_DocumentSerialID = datos[4].ToString();
                    SummaryDocumentsLine.Cs_tag_StartDocumentNumberID = datos[5].ToString();
                    SummaryDocumentsLine.Cs_tag_EndDocumentNumberID = datos[6].ToString();
                    SummaryDocumentsLine.Cs_tag_TotalAmount = datos[7].ToString();
                    List_SummaryDocumentsLine.Add(SummaryDocumentsLine);
                }
                cs_pxConexion_basedatos.Close();
                return List_SummaryDocumentsLine;
            }
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_SummaryDocumentsLine2 cs_fxObtenerTodoPorCabeceraId " + ex.ToString());
                return null;
            }
        }

        public List<clsEntitySummaryDocuments_SummaryDocumentsLine2> cs_fxObtenerTodoPorCabeceraIdYSerieYTipo(string CabeceraId, string Serie, string Tipo)
        {
            List<clsEntitySummaryDocuments_SummaryDocumentsLine2> List_SummaryDocumentsLine;
            try
            {
                List_SummaryDocumentsLine = new List<clsEntitySummaryDocuments_SummaryDocumentsLine2>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_Id=" + CabeceraId.Trim() + "  AND cp3 = '" + Serie + "' AND cp2 = '"+Tipo+"';";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntitySummaryDocuments_SummaryDocumentsLine2 SummaryDocumentsLine;
                while (datos.Read())
                {
                    SummaryDocumentsLine = new clsEntitySummaryDocuments_SummaryDocumentsLine2(conf);
                    SummaryDocumentsLine.Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = datos[0].ToString();
                    SummaryDocumentsLine.Cs_pr_SummaryDocuments_Id = datos[1].ToString();
                    SummaryDocumentsLine.Cs_tag_LineID = datos[2].ToString();
                    SummaryDocumentsLine.Cs_tag_DocumentTypeCode = datos[3].ToString();
                    SummaryDocumentsLine.Cs_tag_DocumentSerialID = datos[4].ToString();
                    SummaryDocumentsLine.Cs_tag_StartDocumentNumberID = datos[5].ToString();
                    SummaryDocumentsLine.Cs_tag_EndDocumentNumberID = datos[6].ToString();
                    SummaryDocumentsLine.Cs_tag_TotalAmount = datos[7].ToString();
                    List_SummaryDocumentsLine.Add(SummaryDocumentsLine);
                }
                cs_pxConexion_basedatos.Close();
                return List_SummaryDocumentsLine;
            }
            catch (Exception)
            {
              //  clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
              //  clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_SummaryDocumentsLine2 cs_fxObtenerTodoPorCabeceraIdYSerieYTipo" + ex.ToString());
                return null;
            }
        }

        public clsEntitySummaryDocuments_SummaryDocumentsLine2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_SummaryDocuments_SummaryDocumentsLine";
            cs_cmCampos.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            cs_cmCampos.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 6; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_SummaryDocuments_SummaryDocumentsLine";
            cs_cmCampos_min.Add("cs_SummaryDocuments_SummaryDocumentsLine_Id");
            cs_cmCampos_min.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 6; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
       
        public clsEntitySummaryDocuments_SummaryDocumentsLine2 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            if (valores.Count > 0)
            {
                Cs_pr_SummaryDocuments_SummaryDocumentsLine_Id = valores[0];
                Cs_pr_SummaryDocuments_Id = valores[1];
                Cs_tag_LineID = valores[2];
                Cs_tag_DocumentTypeCode = valores[3];
                Cs_tag_DocumentSerialID = valores[4];
                Cs_tag_StartDocumentNumberID = valores[5];
                Cs_tag_EndDocumentNumberID = valores[6];
                Cs_tag_TotalAmount = valores[7];
                return this;
            }
            else
            {
                return null;
            }         
        }
    }
}
