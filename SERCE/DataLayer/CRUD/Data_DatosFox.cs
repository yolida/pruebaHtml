using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Modelos;

namespace DataLayer.CRUD
{
    public class Data_DatosFox
    {
        public Int16    IdDatosFox      { get; set; }

        public string   NombreModulo    { get; set; }

        public string   CodigoEmpresa   { get; set; }

        public string   Anio            { get; set; }

        public string   Ruta            { get; set; }

        public Data_DatosFox(Int16 idDatosFox)
        {
            IdDatosFox  =   idDatosFox;
        }

        public bool Read_DatosFox()
        {
            string storedProcedure  = "[sysfox].[Read_DatosFox]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

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
            
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    NombreModulo    = reader["NombreModulo"].ToString();
                    CodigoEmpresa   = reader["CodigoEmpresa"].ToString();
                    Anio            = reader["Anio"].ToString();
                    Ruta            = reader["Ruta"].ToString();
                }
            }

            connection.Disconnect();
            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }
    }
}
