using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEI.Extension
{
    public class Conexion
    {
        public bool result = false;
        public OdbcConnection odbcConnection;
        public bool Establecer_Conexion(string Cadena_Conexion)
        {
            
            try
            {
                odbcConnection = new OdbcConnection(Cadena_Conexion);
                odbcConnection.Open();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public bool Cerrar_Conexion()
        {

            try
            {
                odbcConnection.Close();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
