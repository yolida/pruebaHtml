using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI2
{
  
    public class clsEntityVoidedDocuments_VoidedDocumentsLine2 : clsBaseEntidad2
    {
        public string Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id { get; set; }
        public string Cs_pr_VoidedDocuments_Id { get; set; }
        public string Cs_tag_LineID { get; set; }
        public string Cs_tag_DocumentTypeCode { get; set; }
        public string Cs_tag_DocumentSerialID { get; set; }
        public string Cs_tag_DocumentNumberID { get; set; }
        public string Cs_tag_VoidReasonDescription { get; set; }
        public string Cs_pr_IDDocumentoRelacionado { get; set; }//ID de cabecera de COMPROBANTES (Factura, boleta)
        //private clsEntityDatabaseLocal localDB;
        public clsEntityVoidedDocuments_VoidedDocumentsLine2 cs_fxObtenerUnoPorId(string Id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, Id, false);
            if (valores.Count > 0)
            {
                Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id = valores[0];
                Cs_pr_VoidedDocuments_Id = valores[1];
                Cs_tag_LineID = valores[2];
                Cs_tag_DocumentTypeCode = valores[3];
                Cs_tag_DocumentSerialID = valores[4];
                Cs_tag_DocumentNumberID = valores[5];
                Cs_tag_VoidReasonDescription = valores[6];
                Cs_pr_IDDocumentoRelacionado = valores[7];
                return this;
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// Devuelve un item de comunicación de baja.
        /// </summary>
        /// <param name="Id_documentoprincipal">ID del documento que se da de baja.</param>
        /// <param name="Id_documentorelacionado">ID del registro de comunicicación de baja relacionado.</param>
        /// <returns></returns>
        public List<string> cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(string Id_documentoprincipal, string Id_documentorelacionado)
        {
            List<string> registros = new List<string>();
           // clsEntityVoidedDocuments_VoidedDocumentsLine2 registro = new clsEntityVoidedDocuments_VoidedDocumentsLine2(localDB);
            OdbcDataReader datos = null;
            try
            {
                
                string sql = "SELECT cs_VoidedDocuments_VoidedDocumentsLine_Id,cp5 FROM " + cs_cmTabla + " WHERE cs_VoidedDocuments_Id =" + Id_documentorelacionado + " AND cp6='" + Id_documentoprincipal + "';";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
            }
            catch (Exception)
            {
              //  System.Windows.Forms.MessageBox.Show(EX.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntityVoidedDocuments_VoidedDocumentsLine2 cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado " + EX.ToString());
            }
            int count = 0;
            while (datos.Read())
            {
                count++;              
               registros.Add(datos[0].ToString());//id linea
                registros.Add(datos[1].ToString());//motivo
                //registro.Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id = datos[0].ToString();
                //registro.Cs_pr_VoidedDocuments_Id = datos[1].ToString();
                //registro.Cs_tag_LineID = datos[2].ToString();
                //registro.Cs_tag_DocumentTypeCode = datos[3].ToString();
                //registro.Cs_tag_DocumentSerialID = datos[4].ToString();
                //registro.Cs_tag_DocumentNumberID = datos[5].ToString();
                //registro.Cs_tag_VoidReasonDescription = datos[6].ToString();
                //registro.Cs_pr_IDDocumentoRelacionado = datos[7].ToString();
                break;
            }
            if (registros.Count <= 0)
            {
                return null;
            }


            return registros;
        }

        internal List<clsEntityVoidedDocuments_VoidedDocumentsLine2> cs_fxObtenerTodoPorCabeceraId(string cs_pr_PK_VoidedDocuments_Id)
        {
            List<clsEntityVoidedDocuments_VoidedDocumentsLine2> comprobante_detalle;
            try
            {
                comprobante_detalle = new List<clsEntityVoidedDocuments_VoidedDocumentsLine2>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_VoidedDocuments_Id =" + cs_pr_PK_VoidedDocuments_Id.ToString().Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                clsEntityVoidedDocuments_VoidedDocumentsLine2 detalle;
                while (datos.Read())
                {
                    detalle = new clsEntityVoidedDocuments_VoidedDocumentsLine2(conf);
                    detalle.Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id = datos[0].ToString();
                    detalle.Cs_pr_VoidedDocuments_Id = datos[1].ToString();
                    detalle.Cs_tag_LineID = datos[2].ToString();
                    detalle.Cs_tag_DocumentTypeCode = datos[3].ToString();
                    detalle.Cs_tag_DocumentSerialID = datos[4].ToString();
                    detalle.Cs_tag_DocumentNumberID = datos[5].ToString();
                    detalle.Cs_tag_VoidReasonDescription = datos[6].ToString();
                    detalle.Cs_pr_IDDocumentoRelacionado = datos[7].ToString();
                    comprobante_detalle.Add(detalle);
                }
                cs_pxConexion_basedatos.Close();
                return comprobante_detalle;
            }
            catch (Exception)
            {
              //  clsBaseLog.cs_pxRegistarAdd("clsEntityVoidedDocuments_VoidedDocumentsLine2 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
                return null;
            }
        }

        public void cs_fxDescartarDocumento(string Id_documentoprincipal, string Id_documentorelacionado, string tipoContiene)
        {
            try
            {
                List<string> registro = new clsEntityVoidedDocuments_VoidedDocumentsLine2(conf).cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(Id_documentoprincipal, Id_documentorelacionado);
                if (tipoContiene == "0")
                {
                    clsEntityDocument2 documentoprincipal = new clsEntityDocument2(conf).cs_fxObtenerUnoPorId(Id_documentoprincipal);
                    documentoprincipal.Cs_pr_ComunicacionBaja = "";
                    documentoprincipal.cs_pxActualizar(false, false);
                }
               
                clsEntityVoidedDocuments_VoidedDocumentsLine2 linea = new clsEntityVoidedDocuments_VoidedDocumentsLine2(conf).cs_fxObtenerUnoPorId(registro[0]);
                linea.cs_pxElimnar(false);
            }
            catch (Exception) {
                //clsBaseMensaje.cs_pxMsg("Error comunicacion de baja","Se ha producido un error al descartar los documentos.");
               // clsBaseLog.cs_pxRegistarAdd("clsEntityVoidedDocuments_VoidedDocumentsLine2 cs_fxDescartarDocumento " + ex.ToString());
            }
           
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id);
            cs_cmValores.Add(Cs_pr_VoidedDocuments_Id);
            cs_cmValores.Add(Cs_tag_LineID);
            cs_cmValores.Add(Cs_tag_DocumentTypeCode);
            cs_cmValores.Add(Cs_tag_DocumentSerialID);
            cs_cmValores.Add(Cs_tag_DocumentNumberID);
            cs_cmValores.Add(Cs_tag_VoidReasonDescription);
            cs_cmValores.Add(Cs_pr_IDDocumentoRelacionado);
        }
        
        public clsEntityVoidedDocuments_VoidedDocumentsLine2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_VoidedDocuments_VoidedDocumentsLine";
            cs_cmCampos.Add("cs_VoidedDocuments_VoidedDocumentsLine_Id");
            cs_cmCampos.Add("cs_VoidedDocuments_Id");
            for (int i = 1; i < 7; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_VoidedDocuments_VoidedDocumentsLine";
            cs_cmCampos_min.Add("cs_VoidedDocuments_VoidedDocumentsLine_Id");
            cs_cmCampos_min.Add("cs_VoidedDocuments_Id");
            for (int i = 1; i < 7; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
       
    }
}
