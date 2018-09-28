using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI2
{
    public class clsEntityDocument_DespatchDocumentReference2 : clsBaseEntidad2
    {
        public string Cs_pr_Document_DespatchDocumentReference_Id { get; set; }
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_tag_DespatchDocumentReference_ID { get; set; }
        public string Cs_tag_DocumentTypeCode { get; set; }
        //private clsEntityDatabaseLocal localDB;
        
        public clsEntityDocument_DespatchDocumentReference2 cs_pxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            if (valores.Count > 0)
            {
                Cs_pr_Document_DespatchDocumentReference_Id = valores[0];
                Cs_pr_Document_Id = valores[1];
                Cs_tag_DespatchDocumentReference_ID = valores[2];
                Cs_tag_DocumentTypeCode = valores[3];
                return this;
            }
            else
            {
                return null;
            }
            
        }

        public clsEntityDocument_DespatchDocumentReference2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_Document_DespatchDocumentReference";            
            cs_cmCampos.Add("cs_Document_DespatchDocumentReference_Id");
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i < 3; i++)//Número de campos
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Document_DespatchDocumentReference";
            cs_cmCampos_min.Add("cs_Document_DespatchDocumentReference_Id");
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i < 3; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
     
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_DespatchDocumentReference_Id);
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_tag_DespatchDocumentReference_ID);
            cs_cmValores.Add(Cs_tag_DocumentTypeCode);
        }

        public List<List<string>> cs_pxObtenerTodoPorId(string id)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id=" + id.ToString().Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                List<string> fila;
                while (datos.Read())
                {
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
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_DespatchDocumentReference2 cs_pxObtenerTodoPorId" + ex.ToString());
                return null;
            }
        }

        public List<clsEntityDocument_DespatchDocumentReference2> cs_pxObtenerTodoPorCabeceraId(string id)
        {
            List<clsEntityDocument_DespatchDocumentReference2> guia_remision;
            try
            {
                guia_remision = new List<clsEntityDocument_DespatchDocumentReference2>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id=" + id.ToString().Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntityDocument_DespatchDocumentReference2 entidad;
                while (datos.Read())
                {
                    entidad = new clsEntityDocument_DespatchDocumentReference2(conf);
                    entidad.Cs_pr_Document_DespatchDocumentReference_Id = cs_cmValores[0];
                    entidad.Cs_tag_DespatchDocumentReference_ID = cs_cmValores[1];
                    entidad.Cs_tag_DocumentTypeCode = cs_cmValores[2];
                    guia_remision.Add(entidad);
                }
                cs_pxConexion_basedatos.Close();
                return guia_remision;
            }
            catch (Exception)
            {
                //clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_DespatchDocumentReference2 cs_pxObtenerTodoPorCabeceraId" + ex.ToString());
                return null;
            }
        }

        public List<clsEntityDocument_DespatchDocumentReference2> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_DespatchDocumentReference2>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id =" + id.ToString().Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    var item = new clsEntityDocument_DespatchDocumentReference2(conf);
                    int count = 0;
                    foreach (var prop in item.GetType().GetProperties())
                    {
                        prop.SetValue(item, Convert.ChangeType(datos[count].ToString(), prop.PropertyType), null);
                        count++;
                    }
                    resultado.Add(item);
                }
                cs_pxConexion_basedatos.Close();
            }
            catch (Exception)
            {
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_DespatchDocumentReference2 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
            }
            return resultado;
        }
    }
}