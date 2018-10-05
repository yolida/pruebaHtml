using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class Data_Usuario
    {
        public string IdUsuario { get; set; }
        public string Contrasenia { get; set; }
        public Int16 IdRol { get; set; }  // Aún no se le dará uso
        public Int16 IdDatosFox { get; set; }
        private string PassContrasenia  = "8xfCkc6Z6SnTHU2TaUUZqf2wYHAAWWn5un3rTcDspjURbdw6";
        
        public bool Alter_Usuario(string storedProcedure)
        {
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdUsuario         = new SqlParameter();
            paramIdUsuario.SqlDbType            = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName        = "@IdUsuario";
            paramIdUsuario.Value                = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);
            
            SqlParameter paramPassContrasenia   = new SqlParameter();
            paramPassContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramPassContrasenia.ParameterName  = "@PassContrasenia";
            paramPassContrasenia.Value          = PassContrasenia;
            sqlCommand.Parameters.Add(paramPassContrasenia);

            SqlParameter paramContrasenia       = new SqlParameter();
            paramContrasenia.SqlDbType          = SqlDbType.NVarChar;
            paramContrasenia.ParameterName      = "@Contrasenia";
            paramContrasenia.Value              = Contrasenia;
            sqlCommand.Parameters.Add(paramContrasenia);

            SqlParameter paramIdRol             = new SqlParameter();
            paramIdRol.SqlDbType                = SqlDbType.SmallInt;
            paramIdRol.ParameterName            = "@IdRol";
            paramIdRol.Value                    = IdRol;
            sqlCommand.Parameters.Add(paramIdRol);

            SqlParameter paramComprobacion      = new SqlParameter();
            paramComprobacion.Direction         = ParameterDirection.Output;
            paramComprobacion.SqlDbType         = SqlDbType.Bit;
            paramComprobacion.ParameterName     = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();

            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }

        public bool Security_Authenticate_Usuario()
        {
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = "[dbo].[Security_Authenticate_Usuario]";
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdUsuario         = new SqlParameter();
            paramIdUsuario.SqlDbType            = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName        = "@IdUsuario";
            paramIdUsuario.Value                = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);
            
            SqlParameter paramPassContrasenia   = new SqlParameter();
            paramPassContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramPassContrasenia.ParameterName  = "@PassContrasenia";
            paramPassContrasenia.Value          = PassContrasenia;
            sqlCommand.Parameters.Add(paramPassContrasenia);

            SqlParameter paramContrasenia       = new SqlParameter();
            paramContrasenia.SqlDbType          = SqlDbType.NVarChar;
            paramContrasenia.ParameterName      = "@Contrasenia";
            paramContrasenia.Value              = Contrasenia;
            sqlCommand.Parameters.Add(paramContrasenia);

            SqlParameter paramComprobacion      = new SqlParameter();
            paramComprobacion.Direction         = ParameterDirection.Output;
            paramComprobacion.SqlDbType         = SqlDbType.Bit;
            paramComprobacion.ParameterName     = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();

            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }

        public bool Create_User_Empresa()
        {
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = "[dbo].[Create_User_Empresa]";
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdUsuario         = new SqlParameter();
            paramIdUsuario.SqlDbType            = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName        = "@IdUsuario";
            paramIdUsuario.Value                = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);

            SqlParameter paramIdDatosFox  = new SqlParameter();
            paramIdDatosFox.SqlDbType     = SqlDbType.SmallInt;
            paramIdDatosFox.ParameterName = "@IdDatosFox";
            paramIdDatosFox.Value         = IdDatosFox;
            sqlCommand.Parameters.Add(paramIdDatosFox);

            SqlParameter paramComprobacion      = new SqlParameter();
            paramComprobacion.Direction         = ParameterDirection.Output;
            paramComprobacion.SqlDbType         = SqlDbType.Bit;
            paramComprobacion.ParameterName     = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();

            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }
    }
}
