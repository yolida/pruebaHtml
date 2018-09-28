using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FEI1
{
    public class clsEntityDocument_Line1 : clsBaseEntidad1
    {
        public string Cs_pr_Document_Line_Id { get; set; }
        public string Cs_pr_Document_Id { get; set; }
        public string Cs_tag_InvoiceLine_ID { get; set; }
        public string Cs_tag_InvoicedQuantity_unitCode { get; set; }///>>asdasdrevisar 2000
        public string Cs_tag_invoicedQuantity { get; set; }
        public string Cs_tag_LineExtensionAmount_currencyID { get; set; }
        public string Cs_tag_PricingReference_AlternativeConditionPrice_PriceAmount_currencyID { get; set; }
        public string Cs_tag_PricingReference_AlternativeConditionPrice_PriceTypeCode { get; set; }
        public string Cs_tag_Item_SellersItemIdentification { get; set; }
        public string Cs_tag_Price_PriceAmount{ get; set; }
        public string Cs_tag_AllowanceCharge_ChargeIndicator { get; set; }
        public string Cs_tag_AllowanceCharge_Amount { get; set; }

        public clsEntityDocument_Line1 cs_pxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_Document_Line_Id = valores[0];
            Cs_pr_Document_Id = valores[1];
            Cs_tag_InvoiceLine_ID = valores[2];
            Cs_tag_InvoicedQuantity_unitCode = valores[3];
            Cs_tag_invoicedQuantity = valores[4];
            Cs_tag_LineExtensionAmount_currencyID = valores[5];
            Cs_tag_PricingReference_AlternativeConditionPrice_PriceAmount_currencyID = valores[6];
            Cs_tag_PricingReference_AlternativeConditionPrice_PriceTypeCode = valores[7];
            Cs_tag_Item_SellersItemIdentification = valores[8];
            Cs_tag_Price_PriceAmount = valores[9];
            Cs_tag_AllowanceCharge_ChargeIndicator = valores[10];
            Cs_tag_AllowanceCharge_Amount = valores[11];
            return this;
        }

        public clsEntityDocument_Line1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_Document_Line";        
            cs_cmCampos.Add("cs_Document_Line_Id");
            cs_cmCampos.Add("cs_Document_Id");
            for (int i = 1; i < 11; i++)//Número de campos
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }

            cs_cmTabla_min = "cs_Document_Line";
            cs_cmCampos_min.Add("cs_Document_Line_Id");
            cs_cmCampos_min.Add("cs_Document_Id");
            for (int i = 1; i < 11; i++)//Número de campos
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_Document_Line_Id);
            cs_cmValores.Add(Cs_pr_Document_Id);
            cs_cmValores.Add(Cs_tag_InvoiceLine_ID);
            cs_cmValores.Add(Cs_tag_InvoicedQuantity_unitCode);
            cs_cmValores.Add(Cs_tag_invoicedQuantity);
            cs_cmValores.Add(Cs_tag_LineExtensionAmount_currencyID);
            cs_cmValores.Add(Cs_tag_PricingReference_AlternativeConditionPrice_PriceAmount_currencyID);
            cs_cmValores.Add(Cs_tag_PricingReference_AlternativeConditionPrice_PriceTypeCode);
            cs_cmValores.Add(Cs_tag_Item_SellersItemIdentification);
            cs_cmValores.Add(Cs_tag_Price_PriceAmount);
            cs_cmValores.Add(Cs_tag_AllowanceCharge_ChargeIndicator);
            cs_cmValores.Add(Cs_tag_AllowanceCharge_Amount);
        }

        public List<List<string>> cs_pxObtenerTodoPorId(string id)
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
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_Line1 cs_pxObtenerTodoPorId " + ex.ToString());
                return null;
            }
        }

        public List<clsEntityDocument_Line1> cs_fxObtenerTodoPorCabeceraId(string id)
        {
            var resultado = new List<clsEntityDocument_Line1>();
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
                    int contador = 0;
                    var item = new clsEntityDocument_Line1(conf);
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
               // clsBaseLog.cs_pxRegistarAdd("clsEntityDocument_Line1 cs_fxObtenerTodoPorCabeceraId" + ex.ToString());
            }
            return resultado;
        }

       
    }
}
