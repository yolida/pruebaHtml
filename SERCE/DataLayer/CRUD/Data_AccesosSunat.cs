using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class Data_AccesosSunat
    {
        public Data_AccesosSunat(int idAccesosSunat)
        {
            IdAccesosSunat = idAccesosSunat;
        }

        public int      IdAccesosSunat { get; set; }
        public string   CertificadoDigital { get; set; }
        public string   ClaveCertificado { get; set; }
        public string   UsuarioSol { get; set; }
        public string   ClaveSol { get; set; }
        public string   IdUsuario { get; set; }
        public Int16    IdDatosFox { get; set; }

        private string PassContrasenia = "w6nun3rTcDspjUCkc6Z6Sqf2wYHAR8xfAWWn5bdTHU2TaUUZ";

        public void Read_AccesosSunat()
        {
            string storedProcedure  = "[dbo].[Read_AccesosSunat]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdAccesosSunat    = new SqlParameter();
            paramIdAccesosSunat.SqlDbType       = SqlDbType.Int;
            paramIdAccesosSunat.ParameterName   = "@IdAccesosSunat";
            paramIdAccesosSunat.Value           = IdAccesosSunat;
            sqlCommand.Parameters.Add(paramIdAccesosSunat);

            SqlParameter paramPassContrasenia   = new SqlParameter();
            paramPassContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramPassContrasenia.ParameterName  = "@PassContrasenia";
            paramPassContrasenia.Value          = PassContrasenia;
            sqlCommand.Parameters.Add(paramPassContrasenia);

            connection.Connect();
            
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    IdAccesosSunat      =   Convert.ToInt32(reader["IdAccesosSunat"].ToString());
                    CertificadoDigital  =   reader["CertificadoDigital"].ToString();
                    ClaveCertificado    =   reader["ClaveCertificado"].ToString();
                    UsuarioSol          =   reader["UsuarioSol"].ToString();
                    ClaveSol            =   reader["ClaveSol"].ToString();          
                }
            }

            connection.Disconnect();
        }

        public bool Create_AccesosSunat()
        {
            string storedProcedure  = "[dbo].[Create_AccesosSunat]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;
            
            SqlParameter paramCertificadoDigital  = new SqlParameter();
            paramCertificadoDigital.SqlDbType     = SqlDbType.NVarChar;
            paramCertificadoDigital.ParameterName = "@CertificadoDigital";
            paramCertificadoDigital.Value         = CertificadoDigital;
            sqlCommand.Parameters.Add(paramCertificadoDigital);

            SqlParameter paramClaveCertificado  = new SqlParameter();
            paramClaveCertificado.SqlDbType     = SqlDbType.NVarChar;
            paramClaveCertificado.ParameterName = "@ClaveCertificado";
            paramClaveCertificado.Value         = ClaveCertificado;
            sqlCommand.Parameters.Add(paramClaveCertificado);

            SqlParameter paramUsuarioSol    = new SqlParameter();
            paramUsuarioSol.SqlDbType       = SqlDbType.NVarChar;
            paramUsuarioSol.ParameterName   = "@UsuarioSol";
            paramUsuarioSol.Value           = UsuarioSol;
            sqlCommand.Parameters.Add(paramUsuarioSol);

            SqlParameter paramClaveSol      = new SqlParameter();
            paramClaveSol.SqlDbType         = SqlDbType.NVarChar;
            paramClaveSol.ParameterName     = "@ClaveSol";
            paramClaveSol.Value             = ClaveSol;
            sqlCommand.Parameters.Add(paramClaveSol);

            SqlParameter paramPassContrasenia   = new SqlParameter();
            paramPassContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramPassContrasenia.ParameterName  = "@PassContrasenia";
            paramPassContrasenia.Value          = PassContrasenia;
            sqlCommand.Parameters.Add(paramPassContrasenia);

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
