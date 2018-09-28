﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
    public class clsEntitySummaryDocuments_Notes1 : clsBaseEntidad1
    {
        public string Cs_pr_SummaryDocuments_Notes_Id { get; set; }
        public string Cs_pr_SummaryDocuments_Id { get; set; }
        public string Cs_tag_Note { get; set; }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_Notes_Id);
            cs_cmValores.Add(Cs_pr_SummaryDocuments_Id);
            cs_cmValores.Add(Cs_tag_Note);
        }

        public clsEntitySummaryDocuments_Notes1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_SummaryDocuments_Notes";
            cs_cmCampos.Add("cs_SummaryDocuments_Notes_Id");
            cs_cmCampos.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 1; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }
            cs_cmTabla_min = "cs_SummaryDocuments_Notes";
            cs_cmCampos_min.Add("cs_SummaryDocuments_Notes_Id");
            cs_cmCampos_min.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 1; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        public clsEntitySummaryDocuments_Notes1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_SummaryDocuments_Notes_Id = valores[0];
            Cs_pr_SummaryDocuments_Id = valores[1];
            Cs_tag_Note = valores[2];
            return this;
        }

        public List<clsEntitySummaryDocuments_Notes1> cs_fxObtenerTodoPorSummaryId(string id)
        {
            var resultado = new List<clsEntitySummaryDocuments_Notes1>();
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cs_SummaryDocuments_Id ='" + id.ToString().Trim() + "';";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    int contador = 0;
                    var item = new clsEntitySummaryDocuments_Notes1(conf);
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
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments_Notes1 cs_fxObtenerTodoPorSummaryId " + ex.ToString());
            }
            return resultado;
        }
    }
}