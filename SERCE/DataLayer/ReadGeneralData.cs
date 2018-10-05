using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ReadGeneralData
    {
        public DataTable GetDataTable(string storedProcedure)
        {
            DataTable dataTable             =   new DataTable();
            Connection connection           =   new Connection();
            SqlCommand sqlCommand           =   new SqlCommand();
            SqlDataAdapter sqlDataAdapter   =   new SqlDataAdapter();
            sqlCommand.CommandText          =   storedProcedure;
            sqlCommand.CommandType          =   CommandType.StoredProcedure;
            sqlCommand.Connection           =   connection.connectionString;
            sqlDataAdapter.SelectCommand    =   sqlCommand;
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public DataTable GetInternalDataTable(string storedProcedure)
        {
            DataTable dataTable             =   new DataTable();
            InternalConnection connection   =   new InternalConnection();
            SqlCommand sqlCommand           =   new SqlCommand();
            SqlDataAdapter sqlDataAdapter   =   new SqlDataAdapter();
            sqlCommand.CommandText          =   storedProcedure;
            sqlCommand.CommandType          =   CommandType.StoredProcedure;
            sqlCommand.Connection           =   connection.connectionString;
            sqlDataAdapter.SelectCommand    =   sqlCommand;
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public DataTable GetDataTable(string storedProcedure, string nameColumn1, Int16 id1)
        {
            DataTable dataTable             = new DataTable();
            Connection connection           = new Connection();
            SqlCommand sqlCommand           = new SqlCommand();
            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
            sqlCommand.CommandText          = storedProcedure;
            sqlCommand.CommandType          = CommandType.StoredProcedure;
            sqlCommand.Connection           = connection.connectionString;
            sqlDataAdapter.SelectCommand    = sqlCommand;

            SqlParameter parameter1     = new SqlParameter();
            parameter1.SqlDbType        = SqlDbType.SmallInt;
            parameter1.ParameterName    = nameColumn1;
            parameter1.Value            = id1;

            sqlCommand.Parameters.Add(parameter1);
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public DataTable GetDataTable(string storedProcedure, string nameColumn1, int id1)
        {
            DataTable dataTable             = new DataTable();
            Connection connection           = new Connection();
            SqlCommand sqlCommand           = new SqlCommand();
            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
            sqlCommand.CommandText          = storedProcedure;
            sqlCommand.CommandType          = CommandType.StoredProcedure;
            sqlCommand.Connection           = connection.connectionString;
            sqlDataAdapter.SelectCommand    = sqlCommand;

            SqlParameter parameter1         = new SqlParameter();
            parameter1.SqlDbType            = SqlDbType.Int;
            parameter1.ParameterName        = nameColumn1;
            parameter1.Value                = id1;

            sqlCommand.Parameters.Add(parameter1);
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        /// <summary>
        /// Obtención de un dataTable mediante un parámetro nvarchar y storeprocedure
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="nameColumn"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string storedProcedure, string nameColumn, string id)
        {
            DataTable dataTable             = new DataTable();
            Connection connection           = new Connection();
            SqlCommand sqlCommand           = new SqlCommand();
            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
            sqlCommand.CommandText          = storedProcedure;
            sqlCommand.CommandType          = CommandType.StoredProcedure;
            sqlCommand.Connection           = connection.connectionString;
            sqlDataAdapter.SelectCommand    = sqlCommand;

            SqlParameter parameter          = new SqlParameter();
            parameter.SqlDbType             = SqlDbType.NVarChar;
            parameter.ParameterName         = nameColumn;
            parameter.Value                 = id;

            sqlCommand.Parameters.Add(parameter);
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public string GetSingleValueSTRINGById(string storedProcedure, string nameColumn, Int16 id)
        {
            string value = string.Empty;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.SmallInt; // Tipo de dato smallint
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();
            value   = (string)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a string
            connection.Disconnect();

            return value;
        }

        /// <summary>
        /// Jorge Luis | 21/09/2018 | *
        /// Requiere que se le pase el valor de uniqueidentifier para que obtenga el valor de cabecera de documenmto
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="nameColumn"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetSingleValueINTById(string storedProcedure, string nameColumn, string id)
        {
            int value;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.NVarChar; // Tipo de dato NVarChar
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();
            value   = (int)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a int
            connection.Disconnect();

            return value;
        }

        public decimal GetSingleValueDECIMAL_3Ids(string storedProcedure, string nameColumn1, string id1, string nameColumn2, Int16 id2, string nameColumn3, Int16 id3)
        {
            decimal value;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter1     = new SqlParameter();
            parameter1.SqlDbType        = SqlDbType.NVarChar;
            parameter1.ParameterName    = nameColumn1;
            parameter1.Value            = id1;
            sqlCommand.Parameters.Add(parameter1);

            SqlParameter parameter2     = new SqlParameter();
            parameter2.SqlDbType        = SqlDbType.SmallInt;
            parameter2.ParameterName    = nameColumn2;
            parameter2.Value            = id2;
            sqlCommand.Parameters.Add(parameter2);

            SqlParameter parameter3     = new SqlParameter();
            parameter3.SqlDbType        = SqlDbType.SmallInt;
            parameter3.ParameterName    = nameColumn3;
            parameter3.Value            = id3;
            sqlCommand.Parameters.Add(parameter3);
            
            connection.Connect();
            value   = (decimal)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a string
            connection.Disconnect();

            return value;
        }

        public List<string> GetListValuesById(string storedProcedure, string nameColumn, string id)
        {
            List<string> values = new List<string>();
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.NVarChar; // Tipo de dato NVarChar
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                    values.Add(reader.GetString(0));
            }
            
            connection.Disconnect();

            return values;
        }
    }
}
