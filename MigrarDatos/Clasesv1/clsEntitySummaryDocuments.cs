using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
    public class clsEntitySummaryDocuments1 : clsBaseEntidad1
    {
        public string Cs_pr_SummaryDocuments_Id { get; set; }
        public string Cs_tag_ID { get; set; }
        public string Cs_tag_ReferenceDate { get; set; }
        public string Cs_tag_IssueDate { get; set; }
        public string Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_AdditionalAccountID { get; set; }
        public string Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName { get; set; }
        public string Cs_pr_Ticket { get; set; }
        public string Cs_pr_EstadoSCC { get; set; }
        public string Cs_pr_EstadoSUNAT { get; set; }
        public string Cs_pr_ComentarioSUNAT { get; set; }
        public string Cs_pr_XML { get; set; }
        public string Cs_pr_CDR { get; set; }
        public string Cs_pr_ExceptionSUNAT { get; set; }
        public string Cs_tag_DocumentCurrencyCode { get; set; }

        protected override void cs_pxActualizarEntidad()
        {
            cs_cmValores = new List<string>();
            cs_cmValores.Add(Cs_pr_SummaryDocuments_Id);
            cs_cmValores.Add(Cs_tag_ID);
            cs_cmValores.Add(Cs_tag_ReferenceDate);
            cs_cmValores.Add(Cs_tag_IssueDate);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_AdditionalAccountID);
            cs_cmValores.Add(Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName);
            cs_cmValores.Add(Cs_pr_Ticket);
            cs_cmValores.Add(Cs_pr_EstadoSCC);
            cs_cmValores.Add(Cs_pr_EstadoSUNAT);
            cs_cmValores.Add(Cs_pr_ComentarioSUNAT);
            cs_cmValores.Add(Cs_pr_XML);
            cs_cmValores.Add(Cs_pr_CDR);
            cs_cmValores.Add(Cs_pr_ExceptionSUNAT);
            cs_cmValores.Add(Cs_tag_DocumentCurrencyCode);
        }

        public clsEntitySummaryDocuments1(clsBaseConfiguracion1 conf1)
        {
            conf = conf1;
            cs_cmTabla = "cs_SummaryDocuments";
            cs_cmCampos.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos.Add("cp" + i.ToString());
            }
            cs_cmTabla_min = "cs_SummaryDocuments";
            cs_cmCampos_min.Add("cs_SummaryDocuments_Id");
            for (int i = 1; i <= 14; i++)
            {
                cs_cmCampos_min.Add("cp" + i.ToString());
            }
        }

        public clsEntitySummaryDocuments1 cs_fxObtenerUnoPorId(string id)
        {
            List<string> valores = new clsBaseConexion1(conf).cs_fxObtenerUnoPorId(cs_cmTabla, cs_cmCampos, id, false);
            Cs_pr_SummaryDocuments_Id = valores[0];
            Cs_tag_ID = valores[1];
            Cs_tag_ReferenceDate = valores[2];
            Cs_tag_IssueDate = valores[3];
            Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = valores[4];
            Cs_tag_AccountingSupplierParty_AdditionalAccountID = valores[5];
            Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = valores[6];
            Cs_pr_Ticket = valores[7];
            Cs_pr_EstadoSCC = valores[8];
            Cs_pr_EstadoSUNAT = valores[9];
            Cs_pr_ComentarioSUNAT = valores[10];
            Cs_pr_XML = valores[11];
            Cs_pr_CDR = valores[12];
            Cs_pr_ExceptionSUNAT = valores[13];
            Cs_tag_DocumentCurrencyCode = valores[14];
            return this;
        }
        public clsEntitySummaryDocuments1 cs_fxObtenerUnoPorTicket(string ticket)
        {
            clsEntitySummaryDocuments1 documento = new clsEntitySummaryDocuments1(conf);
            Int32 correlativo = 0;
            correlativo++;
            try
            {
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE cp7='" + ticket + "';";//Estado 
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();

                while (datos.Read())
                {
                    documento.Cs_pr_SummaryDocuments_Id = datos[0].ToString();
                    documento.Cs_tag_ID = datos[1].ToString();
                    documento.Cs_tag_ReferenceDate = datos[2].ToString();
                    documento.Cs_tag_IssueDate = datos[3].ToString();
                    documento.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = datos[4].ToString();
                    documento.Cs_tag_AccountingSupplierParty_AdditionalAccountID = datos[5].ToString();
                    documento.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = datos[6].ToString();
                    documento.Cs_pr_Ticket = datos[7].ToString();
                    documento.Cs_pr_EstadoSCC = datos[8].ToString();
                    documento.Cs_pr_EstadoSUNAT = datos[9].ToString();
                    documento.Cs_pr_ComentarioSUNAT = datos[10].ToString();
                    documento.Cs_pr_XML = datos[11].ToString();
                    documento.Cs_pr_CDR = datos[12].ToString();
                    documento.Cs_pr_ExceptionSUNAT = datos[13].ToString();
                    documento.Cs_tag_DocumentCurrencyCode = datos[14].ToString();
                }
                cs_pxConexion_basedatos.Close();
            }
            catch (Exception )
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments1 cs_fxObtenerUnoPorTicket" + ex.ToString());
            }
            return documento;
        }
      
        /// <summary>
        /// Obtener los resúmenes diarios de boletas en un rango de fechas.
        /// </summary>
        /// <param name="fecha_inicio">Fecha en formato: YYYY-MM-DD (Reference Date)</param>
        /// <param name="fecha_fin">Fecha en formato: YYYY-MM-DD (Reference Date)</param>
        /// <returns>Lista de de resumenes diarios</returns>
        public List<clsEntitySummaryDocuments1> cs_fxObtenerResumenes()
        {
            List<clsEntitySummaryDocuments1> tabla_contenidos = new List<clsEntitySummaryDocuments1>();
            try
            {              
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + cs_cmTabla + " WHERE 1=1";
                //sql += " AND cp2 >= '" + fecha_inicio + "' ";
                //sql += " AND cp2 <= '" + fecha_fin + "' ";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                clsEntitySummaryDocuments1 fila;
                while (datos.Read())
                {
                    fila = new clsEntitySummaryDocuments1(conf);
                    fila.Cs_pr_SummaryDocuments_Id = datos[0].ToString();
                    fila.Cs_tag_ID = datos[1].ToString();
                    fila.Cs_tag_ReferenceDate = datos[2].ToString();
                    fila.Cs_tag_IssueDate = datos[3].ToString();
                    fila.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID = datos[4].ToString();
                    fila.Cs_tag_AccountingSupplierParty_AdditionalAccountID = datos[5].ToString();
                    fila.Cs_tag_AccountingSupplierParty_Party_PartyLegalEntity_RegistrationName = datos[6].ToString();
                    fila.Cs_pr_Ticket = datos[7].ToString();
                    fila.Cs_pr_EstadoSCC = datos[8].ToString();
                    fila.Cs_pr_EstadoSUNAT = datos[9].ToString();
                    fila.Cs_pr_ComentarioSUNAT = datos[10].ToString();
                    fila.Cs_pr_XML = datos[11].ToString();
                    fila.Cs_pr_CDR = datos[12].ToString();
                    fila.Cs_pr_ExceptionSUNAT = datos[13].ToString();
                    fila.Cs_tag_DocumentCurrencyCode = datos[14].ToString();
                    tabla_contenidos.Add(fila);
                }
                cs_pxConexion_basedatos.Close();
                return tabla_contenidos;
            }
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments1 cs_fxObtenerResumenesPorRangoFecha" + ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Obtener la cantidad de items de resumen.
        /// </summary>
        /// <param name="Id">Id del Resumen</param>
        /// <returns>Número de items</returns>
        public Int64 cs_fxObtenerResumenNumeroItems(string Id)
        {
            Int64 filas = 0;
            List<string> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<string>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM cs_SummaryDocuments_SummaryDocumentsLine WHERE 1=1";
                sql += " AND cs_SummaryDocuments_SummaryDocumentsLine_Id = '" + Id + "' ";
                clsBaseConexion1 cn = new clsBaseConexion1(conf);
                OdbcConnection cs_pxConexion_basedatos = new OdbcConnection(cn.cs_prConexioncadenabasedatos);
                cs_pxConexion_basedatos.Open();
                datos = new OdbcCommand(sql, cs_pxConexion_basedatos).ExecuteReader();
                while (datos.Read())
                {
                    filas++;
                }
                cs_pxConexion_basedatos.Close();

                return filas;
            }
            catch (Exception)
            {
              //  clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
              //  clsBaseLog.cs_pxRegistarAdd("clsEntitySummaryDocuments1 cs_fxObtenerResumenNumeroItems" + ex.ToString());
                return 0;
            }
        }
       
    }
}
