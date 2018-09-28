using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI1
{
    public class clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 : clsBaseEntidad1
    {
        public string Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id { get; set; }
        public string Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id { get; set; }
        public string Cs_tag_Id { get; set; }
        public string Cs_tag_Name { get; set; }
        public string Cs_tag_ReferenceAmount { get; set; }
        public string Cs_tag_PayableAmount { get; set; }
        public string Cs_tag_Percent { get; set; }
        public string Cs_tag_TotalAmount { get; set; }
        //jordy amaro 02/11/16 Fe-832
        //Agregado propiedad para permitir tag de percepcion
        public string Cs_tag_SchemeID { get; set; }

        public clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 cs_pxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id = valores[0];
            Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id = valores[1];
            Cs_tag_Id = valores[2];
            Cs_tag_Name = valores[3];
            Cs_tag_ReferenceAmount = valores[4];
            Cs_tag_PayableAmount = valores[5];
            Cs_tag_Percent = valores[6];
            Cs_tag_TotalAmount = valores[7];
            Cs_tag_SchemeID = valores[8];
            return this;
        }

        public clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal";         
            cs_cmCampos.Add("cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id");
            cs_cmCampos.Add("cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id");
            for (int i = 1; i < 8; i++)//Número de campos
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }
          
            cs_cmTabla_min = "cs_Doc_UBLExt_ExtContent_AdditInformation_AdditMonetaryTotal";
            cs_cmCampos_min.Add("cs_Doc_UBLExt_ExtContent_AdditInformation_AdditMonetaryTotal_Id");
            cs_cmCampos_min.Add("cs_Doc_UBLExt_ExtContent_AdditInformation_Id");
            for (int i = 1; i < 8; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal_Id);
            cs_cmValores.Add(Cs_pr_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id);
            cs_cmValores.Add(Cs_tag_Id);
            cs_cmValores.Add(Cs_tag_Name);
            cs_cmValores.Add(Cs_tag_ReferenceAmount);
            cs_cmValores.Add(Cs_tag_PayableAmount);
            cs_cmValores.Add(Cs_tag_Percent);
            cs_cmValores.Add(Cs_tag_TotalAmount);
            cs_cmValores.Add(Cs_tag_SchemeID);
        }

        public List<List<string>> cs_pxObtenerTodoPorCabeceraId(string id)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
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
            catch (Exception )
            {
                //clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 cs_pxObtenerTodoPorCabeceraId " + ex.ToString());
                return null;
            }
        }

      

        public List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_UBLExtension_ExtensionContent_AdditionalInformation_Id ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    var item = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1(conf);
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
              //  clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal1 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
            }
            return resultado;
        }
    }
}
