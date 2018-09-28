using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
   
    public class clsEntityDocument_AdditionalComments1 : clsBaseEntidad1
    {
        public string Cs_pr_Document_AdditionalComments_Id { get; set; }
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_pr_Document_AdditionalComments_Reference_Id { get; set; }
        public string Cs_pr_TagNombre { get; set; }
        public string Cs_pr_TagValor { get; set; }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_AdditionalComments_Id);
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_pr_Document_AdditionalComments_Reference_Id);
            cs_cmValores.Add(Cs_pr_TagNombre);
            cs_cmValores.Add(Cs_pr_TagValor);
        }

        public clsEntityDocument_AdditionalComments1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document_AdditionalComments";
            cs_cmCampos.Add("cs_Document_AdditionalComments_Id");
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i <= 3; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Document_AdditionalComments";
            cs_cmCampos_min.Add("cs_Document_AdditionalComments_Id");
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i <= 3; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        public clsEntityDocument_AdditionalComments1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_AdditionalComments_Id = valores[0];
            Cs_pr_Document_Id = valores[1];
            Cs_pr_Document_AdditionalComments_Reference_Id = valores[2];
            Cs_pr_TagNombre = valores[3];
            Cs_pr_TagValor = valores[4];
            return this;
        }

        public List<clsEntityDocument_AdditionalComments1> cs_fxObtenerRaizXML(string id)
        {
            List<clsEntityDocument_AdditionalComments1> resultado = new List<clsEntityDocument_AdditionalComments1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Id ='" + id.ToString().Trim() + "' AND cp1='';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntityDocument_AdditionalComments1 item;
                while (datos.Read())
                {
                    item = new clsEntityDocument_AdditionalComments1(conf);
                    item.Cs_pr_Document_AdditionalComments_Id = datos[0].ToString();
                    item.Cs_pr_Document_Id = datos[1].ToString();
                    item.Cs_pr_Document_AdditionalComments_Reference_Id = datos[2].ToString();
                    item.Cs_pr_TagNombre = datos[3].ToString();
                    item.Cs_pr_TagValor = datos[4].ToString();
                    resultado.Add(item);
                }
                cs_pxConexion_basedatos.Close();
            }
            catch (Exception)
            {
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_AdditionalComments1 cs_fxObtenerRaizXML" + ex.ToString());
            }
            return resultado;
        }

        public List<clsEntityDocument_AdditionalComments1> cs_fxObtenerTodoPorIdReferencia(string id)
        {
            List<clsEntityDocument_AdditionalComments1> resultado = new List<clsEntityDocument_AdditionalComments1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cp1 ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntityDocument_AdditionalComments1 item;
                while (datos.Read())
                {
                    item = new clsEntityDocument_AdditionalComments1(conf);
                    item.Cs_pr_Document_AdditionalComments_Id = datos[0].ToString();
                    item.Cs_pr_Document_Id = datos[1].ToString();
                    item.Cs_pr_Document_AdditionalComments_Reference_Id = datos[2].ToString();
                    item.Cs_pr_TagNombre = datos[3].ToString();
                    item.Cs_pr_TagValor = datos[4].ToString();
                    resultado.Add(item);
                }
                cs_pxConexion_basedatos.Close();
            }
            catch (Exception)
            {
                //clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_AdditionalComments1 cs_fxObtenerTodoPorIdReferencia " + ex.ToString());
            }
            return resultado;
        }


        public string cs_fxObtenerXML(string Id)
        {
            string resultado = string.Empty;
            try
            {
                List<clsEntityDocument_AdditionalComments1> Nodos = new clsEntityDocument_AdditionalComments1(conf).cs_fxObtenerRaizXML(Id);
                foreach (var Nodo in Nodos)
                {
                    resultado += "<" + Nodo.Cs_pr_TagNombre + ">" + cs_fxBusquedaEnProfundidad(Nodo.Cs_pr_Document_AdditionalComments_Id) + "</" + Nodo.Cs_pr_TagNombre + ">";
                }
            }
            catch (Exception)
            {
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_AdditionalComments1 cs_fxObtenerXML" + ex.ToString());
            }
            
            return resultado;
        }

        private string cs_fxBusquedaEnProfundidad(string Id)
        {
            //fe-955
            string resultado = string.Empty;
            try{
                List<clsEntityDocument_AdditionalComments1> Nodos = new clsEntityDocument_AdditionalComments1(conf).cs_fxObtenerTodoPorIdReferencia(Id);
                foreach (var Nodo in Nodos)
                {
                    resultado += "<" + Nodo.Cs_pr_TagNombre + "><![CDATA[";
                    resultado += Nodo.Cs_pr_TagValor + cs_fxBusquedaEnProfundidad(Nodo.Cs_pr_Document_AdditionalComments_Id);
                    resultado += "]]></" + Nodo.Cs_pr_TagNombre + ">";
                }
            }
            catch (Exception){
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_AdditionalComments1 cs_fxBusquedaEnProfundidad" + ex.ToString());
            }
           
            return resultado;
        }
        public List<clsEntityDocument_AdditionalComments1> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_AdditionalComments1>();
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
                    var item = new clsEntityDocument_AdditionalComments1(conf);
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
              //  clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_AdditionalComments1 cs_fxObtenerTodoPorCabeceraId " + ex.ToString());
            }
            return resultado;
        }
    }
}
