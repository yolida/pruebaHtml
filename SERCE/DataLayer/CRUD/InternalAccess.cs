using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class InternalAccess
    {
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public void Read_InternalAccess()
        {
            string storedProcedure          =   "[dbo].[Read_DataAccess]";
            InternalConnection connection   =   new InternalConnection();
            SqlCommand sqlCommand           =   new SqlCommand();
            sqlCommand.CommandText          =   storedProcedure;
            sqlCommand.CommandType          =   CommandType.StoredProcedure;
            sqlCommand.Connection           =   connection.connectionString;

            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Servidor    =   reader["Servidor"].ToString();
                    Usuario     =   reader["Usuario"].ToString();
                    Contrasenia =   reader["Contrasenia"].ToString();             
                }
            }

            connection.Disconnect();
        }

        public bool Alter_InternalAccess(string storedProcedure)
        {   // para la escritura y actualización
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramServidor  = new SqlParameter();
            paramServidor.SqlDbType     = SqlDbType.NVarChar;
            paramServidor.ParameterName = "@Servidor";
            paramServidor.Value         = Servidor;
            sqlCommand.Parameters.Add(paramServidor);

            SqlParameter paramUsuario  = new SqlParameter();
            paramUsuario.SqlDbType     = SqlDbType.NVarChar;
            paramUsuario.ParameterName = "@Usuario";
            paramUsuario.Value         = Usuario;
            sqlCommand.Parameters.Add(paramUsuario);

            SqlParameter paramContrasenia  = new SqlParameter();
            paramContrasenia.SqlDbType     = SqlDbType.NVarChar;
            paramContrasenia.ParameterName = "@Contrasenia";
            paramContrasenia.Value         = Contrasenia;
            sqlCommand.Parameters.Add(paramContrasenia);

            SqlParameter paramComprobacion  = new SqlParameter();
            paramComprobacion.Direction     = ParameterDirection.Output;
            paramComprobacion.SqlDbType     = SqlDbType.Bit;
            paramComprobacion.ParameterName = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);
            
            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();

            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }
    }
}
