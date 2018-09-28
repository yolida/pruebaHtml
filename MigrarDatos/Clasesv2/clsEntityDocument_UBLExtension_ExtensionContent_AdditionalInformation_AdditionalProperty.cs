using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI2
{
    public class clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2 : clsBaseEntidad2
    {
        public string Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id { get; set; }
        public string Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id { get; set; }
        public string Cs_tag_ID { get; set; }
        public string Cs_tag_Name { get; set; }
        public string Cs_tag_Value { get; set; }

        //private clsEntityDatabaseLocal localDB;

        public clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2 cs_pxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion2(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            if (valores.Count > 0)
            {
                Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id = valores[0];
                Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id = valores[1];
                Cs_tag_ID = valores[2];
                Cs_tag_Name = valores[3];
                Cs_tag_Value = valores[4];
                return this;
            }
            else
            {
                return null;
            }
           
        }

        public clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2(clsBaseConfiguracion2 local)
        {
            conf = local;
            cs_cmTabla = "cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty";
            cs_cmCampos.Add("cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id");
            cs_cmCampos.Add("cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id");
            for (int i = 1; i < 4; i++)//Número de campos
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Doc_UBLExt_ExtContent_AdditInformation_AdditProperty";
            cs_cmCampos_min.Add("cs_Doc_UBLExt_ExtContent_AddiInformation_AdditProperty_Id");
            cs_cmCampos_min.Add("cs_Doc_UBLExt_ExtContent_AdditInformation_Id");
            for (int i = 1; i < 4; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }
       
        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty_Id);
            cs_cmValores.Add(Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id);
            cs_cmValores.Add(Cs_tag_ID);
            cs_cmValores.Add(Cs_tag_Name);
            cs_cmValores.Add(Cs_tag_Value);
        }

        public List<List<string>> cs_pxObtenerTodoPorId(string id)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id=" + id.ToString().Trim() + " ;";
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
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2  cs_pxObtenerTodoPorId" + ex.ToString());
                return null;
            }
        }       
        
        public List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id =" + id.ToString().Trim() + " ;";
                clsBaseConexion2 cn = new clsBaseConexion2(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    var item = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2(conf);
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
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalProperty2 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
            }
            return resultado;
        }
    }
}
