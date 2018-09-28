using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class Data_AccesosSunat
    {
        public Data_AccesosSunat(int idEmisor)
        {
            IdEmisor = idEmisor;
        }

        public int      IdEmisor{ get; set; }

        public int      IdAccesosSunat { get; set; }
        public string   CertificadoDigital { get; set; }
        public string   ClaveCertificado { get; set; }
        public string   UsuarioSol { get; set; }
        public string   ClaveSol { get; set; }
        public string   Usuario { get; set; }
        public string   Contrasenia { get; set; }

        public void Read_AccesosSunat()
        {
            string storedProcedure  = "[dbo].[Read_AccesosSunat]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdEmisor  = new SqlParameter();
            paramIdEmisor.SqlDbType     = SqlDbType.NVarChar;
            paramIdEmisor.ParameterName = "@IdEmisor";
            paramIdEmisor.Value         = IdEmisor;
            sqlCommand.Parameters.Add(paramIdEmisor);

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
                    Usuario             =   reader["Usuario"].ToString();             
                }
            }

            connection.Disconnect();
        }
    }
}
