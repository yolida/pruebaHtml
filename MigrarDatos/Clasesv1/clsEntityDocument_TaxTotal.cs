using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI1
{
    public class clsEntityDocument_TaxTotal1 : clsBaseEntidad1
    {
        public string Cs_pr_Document_TaxTotal_Id { get; set; }
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_tag_TaxAmount { get; set; }
        public string Cs_tag_TaxSubtotal_TaxAmount { get; set; }
        public string Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID { get; set; }
        public string Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name { get; set; }
        public string Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode { get; set; }
        
        public clsEntityDocument_TaxTotal1 cs_pxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_TaxTotal_Id = valores[0];
            Cs_pr_Document_Id = valores[1];
            Cs_tag_TaxAmount = valores[2];
            Cs_tag_TaxSubtotal_TaxAmount = valores[3];
            Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID = valores[4];
            Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name = valores[5];
            Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode = valores[6];
            return this;
        }

        public clsEntityDocument_TaxTotal1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document_TaxTotal";
            cs_cmCampos.Add("cs_Document_TaxTotal_Id");
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i < 6; i++)//Número de campos
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Document_TaxTotal";
            cs_cmCampos_min.Add("cs_Document_TaxTotal_Id");
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i < 6; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_TaxTotal_Id);
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_tag_TaxAmount);
            cs_cmValores.Add(Cs_tag_TaxSubtotal_TaxAmount);
            cs_cmValores.Add(Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_ID);
            cs_cmValores.Add(Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_Name);
            cs_cmValores.Add(Cs_tag_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode);
        }

        public List<List<string>> cs_pxObtenerTodoPorCabeceraId(string id)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id ='" + id.ToString().Trim() + "';";
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
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_TaxTotal1 cs_pxObtenerTodoPorCabeceraId " + ex.ToString());
                return null;
            }
        }

     
        public List<clsEntityDocument_TaxTotal1> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_TaxTotal1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    var item = new clsEntityDocument_TaxTotal1(conf);
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
            catch (Exception )
            {
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_TaxTotal1 cs_fxObtenerTodoPorCabeceraId " + ex.ToString());
            }
            return resultado;
        }
    }
}
