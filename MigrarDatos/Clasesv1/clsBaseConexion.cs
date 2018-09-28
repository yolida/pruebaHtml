using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;



namespace FEI1
{    
    public class clsBaseConexion1
    {
        private clsBaseConfiguracion1 cs_cmConfiguracion;
        private OdbcConnection cs_cmConexion;

        public clsBaseConexion1(clsBaseConfiguracion1 conf)
        {
            cs_cmConfiguracion = conf;
            cs_cmConexion = new OdbcConnection(cs_prConexioncadenabasedatos);
        }
        /// <summary>
        /// Metodo que retorna la cadena de conexion del servidor para ODBC.
        /// </summary>
        public string cs_prConexioncadenaservidor
        {
            get
            {
                string cadena = "";
              
                 
                cadena = "Driver={" + cs_cmConfiguracion.cs_prDbmsdriver + "};Server=" + cs_cmConfiguracion.cs_prDbmsservidor + "," + cs_cmConfiguracion.cs_prDbmsservidorpuerto + ";Uid=" + cs_cmConfiguracion.cs_prDbusuario + ";Pwd=" + cs_cmConfiguracion.cs_prDbclave + ";";
                     
                return cadena;
            }
        }
        /// <summary>
        /// Metodo que retorna la cadena de conexion a base de datos en ODBC
        /// </summary>
        public string cs_prConexioncadenabasedatos
        {
            get
            {
                string cadena = "";                                
                cadena = "Driver={" + cs_cmConfiguracion.cs_prDbmsdriver + "};Server=" + cs_cmConfiguracion.cs_prDbmsservidor + "," + cs_cmConfiguracion.cs_prDbmsservidorpuerto + ";Database=" + cs_cmConfiguracion.cs_prDbnombre + ";Uid=" + cs_cmConfiguracion.cs_prDbusuario + ";Pwd=" + cs_cmConfiguracion.cs_prDbclave + ";";                   
                return cadena;
            }
        }
        /// <summary>
        /// Metodo para obtener un registro de base de datos.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="id"></param>
        /// <param name="obtener_mensaje_respuesta"></param>
        /// <returns>Listado de valores del registro</returns>
        public List<string> cs_fxObtenerUnoPorId(string tabla, List<string> campos, string id, bool obtener_mensaje_respuesta)
        {
            List<string> valores = new List<string>();
            try
            {
                string sql = "SELECT * FROM " + tabla + " WHERE " + campos[0] + " = '" + id + "'";
                cs_cmConexion.Open();
                OdbcDataReader odr = new OdbcCommand(sql, cs_cmConexion).ExecuteReader();
                while (odr.Read())
                {
                    for (int i = 0; i < campos.Count; i++)
                    {
                        valores.Add(odr[i].ToString().Trim());
                    }
                }
                cs_cmConexion.Close();
            }
            catch 
            {
            }
            return valores;
        }
        /// <summary>
        /// Metodo para actualizar un registro de la base de datos, opcional muestra mensaje de confirmacion.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="valores"></param>
        /// <param name="obtener_mensaje_respuesta"></param>
        public void cs_pxActualizar(string tabla, List<string> campos, List<string> valores, bool obtener_mensaje_respuesta)
        {
            try
            {
                string sql = "";
                for (int i = 1; i < campos.Count; i++)
                {
                    sql += " " + campos[i] + "='" + valores[i].Replace("'", "''") + "',";

                }
                sql = "UPDATE " + tabla + " SET " + sql.Substring(1, sql.Length - 2) + " WHERE " + campos[0] + "='" + valores[0] + "';";
                cs_cmConexion.Open();
                new OdbcCommand(sql, cs_cmConexion).ExecuteReader();
                cs_cmConexion.Close();
                if (obtener_mensaje_respuesta)
                {
                    //clsBaseMensaje.cs_pxMsgOk("OKE5");
                }
            }
            catch (Exception)
            {
               // System.Windows.Forms.MessageBox.Show(ex.ToString());
               // clsBaseMensaje.cs_pxMsgEr("ERR5", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsBaseConexion1 cs_pxActualizar " + tabla + " " + ex.ToString());
            }
        }
        /// <summary>
        /// Metodo para eliminar un registro de base de datos.Opcional mostrar mensaje de exito de operacion.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="valores"></param>
        /// <param name="obtener_mensaje_respuesta"></param>
        public void cs_pxEliminar(string tabla, List<string> campos, List<string> valores, bool obtener_mensaje_respuesta)
        {
            try
            {
                string sql = "DELETE FROM " + tabla + " WHERE " + campos[0] + "='" + valores[0] + "';";
                cs_cmConexion.Open();
                new OdbcCommand(sql, cs_cmConexion).ExecuteReader();
                cs_cmConexion.Close();
                if (obtener_mensaje_respuesta)
                {
                   // clsBaseMensaje.cs_pxMsgOk("OKE7");
                }
            }
            catch (Exception)
            {
                //clsBaseMensaje.cs_pxMsgEr("ERR7", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsBaseConexion1 cs_pxEliminar " + tabla + " " + ex.ToString());
            }
        }
        /// <summary>
        /// Metodo para insertar un registro en base de datos.Opcional mensaje de confirmacion de resultado.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="valores"></param>
        /// <param name="obtener_mensaje_respuesta"></param>
        public void cs_pxInsertar(string tabla, List<string> campos, List<string> valores, bool obtener_mensaje_respuesta)
        {
            try
            {
                string sql = "", sql_campos = "", sql_valores = "";

                for (int i = 0; i < campos.Count; i++)
                {
                    sql_campos += " " + campos[i] + ",";
                    sql_valores += " '" + valores[i] + "',";
                }

                sql = "INSERT INTO " + tabla + " (" + sql_campos.Substring(1, sql_campos.Length - 2) + ") VALUES (" + sql_valores.Substring(1, sql_valores.Length - 2) + ");";
                cs_cmConexion.Open();
                new OdbcCommand(sql, cs_cmConexion).ExecuteReader();
                cs_cmConexion.Close();
                if (obtener_mensaje_respuesta)
                {
                  //  clsBaseMensaje.cs_pxMsgOk("OKE5");

                }
            }
            catch (Exception)
            {
               
                //clsBaseMensaje.cs_pxMsgEr("ERR5", ex.ToString());
                //clsBaseLog.cs_pxRegistarAdd("clsBaseConexion1 cs_pxInsertar :" + tabla + " " + ex.ToString());
            }
        }
        /// <summary>
        /// Metodo para obtener todos los registros de una tabla en base de datos.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="valores"></param>
        /// <param name="obtener_mensaje_respuesta"></param>
        /// <returns>Lista de listas de registros.</returns>
        public List<List<string>> cs_fxSeleccionartodo(string tabla, List<string> campos, List<string> valores, bool obtener_mensaje_respuesta)
        {
            List<List<string>> tabla_contenidos;
            try
            {
                tabla_contenidos = new List<List<string>>();
                OdbcDataReader datos = null;
                string sql = "SELECT * FROM " + tabla;
                cs_cmConexion.Open();
                datos = new OdbcCommand(sql, cs_cmConexion).ExecuteReader();
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
                cs_cmConexion.Close();
                return tabla_contenidos;
            }
            catch (Exception)
            {
               // clsBaseMensaje.cs_pxMsgEr("ERR6", ex.ToString());
               // clsBaseLog.cs_pxRegistarAdd("clsBaseConexion1 cs_fxSeleccionartodo :" + tabla + " " + ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// Metodo para obtener el estado de conexion con el servidor.
        /// </summary>
        /// <returns>TRUE / FALSE segun sea el caso para activo/inactivo</returns>
        public bool cs_fxConexionEstadoServidor()
        {
            OdbcConnection cnserver = null;

            cnserver = new OdbcConnection(cs_prConexioncadenaservidor);
            
            bool respuesta = false;
            try
            {
                cnserver.ConnectionTimeout = 1;
                cnserver.Open();
                respuesta = true;
            }
            catch (Exception)
            {
              //  clsBaseLog.cs_pxRegistarAdd("clsBaseConexionServidor: conexionEstado->" + es.ToString());
                respuesta = false;
            }
            finally
            {
                cnserver.Close();
                cnserver.Dispose();
            }

            return respuesta;
        }
        /// <summary>
        /// Metodo para obtener el estado de conexion a base de datos.
        /// </summary>
        /// <returns>True/False para activo e inactivo respectivamente</returns>
        public bool cs_fxConexionEstado()
        {
            OdbcConnection cn = new OdbcConnection(cs_prConexioncadenabasedatos);
            bool respuesta = false;
            try
            {
                cn.ConnectionTimeout = 3;
                cn.Open();
                respuesta = true;
            }
            catch (Exception)
            {
               // clsBaseLog.cs_pxRegistarAdd("clsBaseConexion1: conexionEstado->"+ex.ToString());
                respuesta = false;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return respuesta;
        }
    }
}
