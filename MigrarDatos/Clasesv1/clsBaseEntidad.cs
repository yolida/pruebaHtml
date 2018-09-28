using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Runtime.InteropServices;

namespace FEI1
{
    public class clsBaseEntidad1
    {
        public clsBaseConfiguracion1 conf;
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
        public virtual void cs_pxActualizar(bool obtener_mensaje_respuesta)
        {
            cs_pxActualizarEntidad();
            new clsBaseConexion1(conf).cs_pxActualizar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta);
        }
       
        /// <summary>
        /// Metodo para insertar registros en base de datos.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public void cs_pxInsertar(bool obtener_mensaje_respuesta)
        {
            cs_pxActualizarEntidad();
            new clsBaseConexion1(conf).cs_pxInsertar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta);
        }
        
        /// <summary>
        /// Metodo para eliminar registros en base de datos.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
        public void cs_pxElimnar(bool obtener_mensaje_respuesta)
        {
            cs_pxActualizarEntidad();
            new clsBaseConexion1(conf).cs_pxEliminar(cs_cmTabla, cs_cmCampos, cs_cmValores, obtener_mensaje_respuesta);
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
