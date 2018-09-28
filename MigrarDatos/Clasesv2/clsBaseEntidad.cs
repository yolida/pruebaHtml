using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI2
{

    public class clsBaseEntidad2
    {
        public clsBaseConfiguracion2 conf;
        public List<string> cs_cmCampos = new List<string>();
        protected List<string> cs_cmValores = new List<string>();
        public List<string> cs_cmCampos_min = new List<string>();
        protected List<string> cs_cmValores_min = new List<string>();
        public string cs_cmTabla = "";
        public string cs_cmTabla_min = "";
       
        /// <summary>
        /// Metodo para actualizar registros en base de datos.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public virtual bool cs_pxActualizar(bool obtener_mensaje_respuesta, bool tabla_tiene_foreign_key)
        {
            cs_pxActualizarEntidad();
            bool afectado = new clsBaseConexion2(conf).cs_pxActualizar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta, tabla_tiene_foreign_key);
            return afectado;
        }
        /// <summary>
        /// Metodo para actualizar registros en base de datos.Caso mysql.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public virtual bool cs_pxActualizar_min(bool obtener_mensaje_respuesta, bool tabla_tiene_foreign_key)
        {
            cs_pxActualizarEntidad();
            bool afectado = new clsBaseConexion2(conf).cs_pxActualizar(cs_cmTabla_min, cs_cmCampos_min, cs_cmValores_min, obtener_mensaje_respuesta,tabla_tiene_foreign_key);
            return afectado;
        }
        /// <summary>
        /// Metodo para insertar registros en base de datos.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public string cs_pxInsertar(bool obtener_mensaje_respuesta, bool tabla_tiene_foreign_key)
        {
            cs_pxActualizarEntidad();
            string afectado =  new clsBaseConexion2(conf).cs_pxInsertar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta, tabla_tiene_foreign_key);
            return afectado;
        }
        /// <summary>
        /// Metodo para insertar registros en base de datos.Caso mysql.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public string cs_pxInsertar_min(bool obtener_mensaje_respuesta, bool tabla_tiene_foreign_key)
        {
            cs_pxActualizarEntidad();
            string afectado = new clsBaseConexion2(conf).cs_pxInsertar(cs_cmTabla_min, cs_cmCampos_min, cs_cmValores_min, obtener_mensaje_respuesta,tabla_tiene_foreign_key);
            return afectado;
        }
        /// <summary>
        /// Metodo para eliminar registros en base de datos.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public bool cs_pxElimnar(bool obtener_mensaje_respuesta)
        {
            cs_pxActualizarEntidad();
            bool afectado = new clsBaseConexion2(conf).cs_pxEliminar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta);
            return afectado;
        }
        /// <summary>
        /// Metodo para eliminar registros en base de datos.Caso mysql
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public bool cs_pxElimnar_min(bool obtener_mensaje_respuesta)
        {
            cs_pxActualizarEntidad();
            bool afectado= new clsBaseConexion2(conf).cs_pxEliminar(cs_cmTabla_min, cs_cmCampos_min, cs_cmValores_min, obtener_mensaje_respuesta);
            return afectado;
        }
       
        protected virtual void cs_pxActualizarEntidad()
        {

        }
        public bool cs_pxValidar()
        {
            return !cs_pxValidarReporte().Contains("Error");
        }
        public virtual string cs_pxValidarReporte()
        {
            return "";
        }
    }
}
