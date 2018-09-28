﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
   
    public class clsEntityDocument_Line_AdditionalComments1 : clsBaseEntidad1
    {
        public string Cs_pr_Document_Line_AdditionalComments_Id { get; set; }
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_pr_Document_Line_AdditionalComments_Reference_Id { get; set; }
        public string Cs_pr_TagNombre { get; set; }
        public string Cs_pr_TagValor { get; set; }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_Line_AdditionalComments_Id);
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_pr_Document_Line_AdditionalComments_Reference_Id);
            cs_cmValores.Add(Cs_pr_TagNombre);
            cs_cmValores.Add(Cs_pr_TagValor);
        }

        public clsEntityDocument_Line_AdditionalComments1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document_Line_AdditionalComments";
            cs_cmCampos.Add("cs_Document_Line_AdditionalComments_Id");
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i <= 3; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Document_Line_AdditionalComments";
            cs_cmCampos_min.Add("cs_Document_Line_AdditionalComments_Id");
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i <= 3; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        public clsEntityDocument_Line_AdditionalComments1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_Line_AdditionalComments_Id = valores[0];
            Cs_pr_Document_Id = valores[1];
            Cs_pr_Document_Line_AdditionalComments_Reference_Id = valores[2];
            Cs_pr_TagNombre = valores[3];
            Cs_pr_TagValor = valores[4];
            return this;
        }
        
        public List<clsEntityDocument_Line_AdditionalComments1> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_Line_AdditionalComments1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_Document_Line_Id ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    var item = new clsEntityDocument_Line_AdditionalComments1(conf);
                    int contador = 0;
                    foreach (var prop in item.GetType().GetProperties())
                    {
                        prop.SetValue(item, Convert.ChangeType(datos[contador].ToString(), prop.PropertyType), null);
                        contador++;
                    }
                    resultado.Add(item);
                }


                cs_pxConexion_basedatos.Close();
            }
            catch (Exception)
            {
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_Line_AdditionalComments1 cs_fxObtenerTodoPorCabeceraId " + ex.ToString());
            }
            return resultado;
        }
    }
}
