using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataLayer.CRUD
{
    public class Data_Documentos: IData_Documentos
    {
        public string   IdDocumento         { get; set; }

        public string   NombreModulo        { get; set; }
        public string   CodigoEmpresa       { get; set; }
        public string   Ruta                { get; set; }
        public int      IdEmisor            { get; set; }
        public string   TipoDocumento     { get; set; }
        public DateTime FechaRegistro       { get; set; }
        public DateTime FechaEmisionSUNAT   { get; set; }
        public Boolean  EnviadoSunat        { get; set; }
        public Boolean  EnviadoServer       { get; set; }
        public Boolean  EnviadoEmailCliente { get; set; }
        public string   EstadoSunat         { get; set; }
        public string   ComentarioDocumento { get; set; }
        public string   SerieCorrelativo    { get; set; }
        public string   CdrSunat            { get; set; }
        public Boolean  Eliminado           { get; set; }
        public Boolean  Anulado             { get; set; }
        public int      IdCabeceraDocumento { get; set; }
        
        public Data_Documentos(string idDocumento)
        {   
            IdDocumento =   idDocumento; 
        }

        public Data_Documentos()
        {
        }
        
        public void Read_Documento()
        {
            string storedProcedure  = "[dbo].[Read_Documento]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = storedProcedure,
                CommandType = CommandType.StoredProcedure,
                Connection  = connection.connectionString
            };

            SqlParameter paramIdDocumento = new SqlParameter
            {
                SqlDbType       = SqlDbType.NVarChar,
                ParameterName   = "@IdDocumento",
                Value           = IdDocumento
            };
            sqlCommand.Parameters.Add(paramIdDocumento);
            
            connection.Connect();
            
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    NombreModulo        = reader["NombreModulo"].ToString();
                    CodigoEmpresa       = reader["CodigoEmpresa"].ToString();
                    Ruta                = reader["Ruta"].ToString();
                    IdEmisor            = Convert.ToInt32(reader["IdEmisor"].ToString());
                    TipoDocumento       = reader["TipoDocumento"].ToString();
                    try
                    {
                        FechaRegistro   = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    }
                    catch (Exception)
                    {
                        FechaRegistro   = Convert.ToDateTime("1900-01-01");
                    }
                    try
                    {
                        FechaEmisionSUNAT   = Convert.ToDateTime(reader["FechaEmisionSUNAT"].ToString());
                    }
                    catch (Exception)
                    {
                        FechaEmisionSUNAT   = Convert.ToDateTime("1900-01-01");
                    }
                    EnviadoSunat        = Convert.ToBoolean(reader["EnviadoSunat"].ToString());
                    EnviadoServer       = Convert.ToBoolean(reader["EnviadoServer"].ToString());
                    EnviadoEmailCliente = Convert.ToBoolean(reader["EnviadoEmailCliente"].ToString());
                    EstadoSunat         = reader["EstadoSunat"].ToString();
                    ComentarioDocumento = reader["ComentarioDocumento"].ToString();
                    SerieCorrelativo    = reader["SerieCorrelativo"].ToString();
                    //XmlFirmado          = reader["XmlFirmado"].ToString(); Evitado debido a su extensidad, consultarlo en su debido query
                    CdrSunat            = reader["CdrSunat"].ToString();
                    Eliminado           = Convert.ToBoolean(reader["Eliminado"].ToString());
                    Anulado             = Convert.ToBoolean(reader["Anulado"].ToString());
                    IdCabeceraDocumento = Convert.ToInt32(reader["IdCabeceraDocumento"].ToString());
                }
            }

            connection.Disconnect();
        }

        async Task<List<Data_Documentos>> IData_Documentos.GetListFiltered(DateTime Start_FechaRegistro, DateTime End_FechaRegistro)
        {
            var task    =   Task.Factory.StartNew(()   =>
            { 
                List <Data_Documentos> data_Documentos   = new List<Data_Documentos>();

                DataTable dataTable             = new DataTable();
                Connection connection           = new Connection();
                SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = "[dbo].[Read_List_Documento_By_Filters]",
                    CommandType = CommandType.StoredProcedure,
                    Connection  = connection.connectionString
                };
                sqlDataAdapter.SelectCommand    = sqlCommand;

                SqlParameter parameterStart_FechaRegistro = new SqlParameter
                {
                    SqlDbType       = SqlDbType.DateTime,
                    ParameterName   = "@Start_FechaRegistro",
                    Value           = Start_FechaRegistro
                };
                sqlCommand.Parameters.Add(parameterStart_FechaRegistro);

                SqlParameter parameterEnd_FechaRegistro = new SqlParameter
                {
                    SqlDbType       = SqlDbType.DateTime,
                    ParameterName   = "@End_FechaRegistro",
                    Value           = End_FechaRegistro
                };
                sqlCommand.Parameters.Add(parameterEnd_FechaRegistro);

                connection.Connect();
                sqlDataAdapter.Fill(dataTable);
                connection.Disconnect();

                DataRow row;

                Data_Documentos data_Documento;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    row = dataTable.Rows[i];
                    data_Documento  =   new Data_Documentos();
                    data_Documento.NombreModulo        = row["NombreModulo"].ToString();
                    data_Documento.CodigoEmpresa       = row["CodigoEmpresa"].ToString();
                    data_Documento.Ruta                = row["Ruta"].ToString();
                    data_Documento.IdEmisor            = Convert.ToInt32(row["IdEmisor"].ToString());
                    data_Documento.TipoDocumento       = row["TipoDocumento"].ToString();
                    try
                    {
                        data_Documento.FechaRegistro   = Convert.ToDateTime(row["FechaRegistro"].ToString());
                    }
                    catch (Exception)
                    {
                        data_Documento.FechaRegistro   = Convert.ToDateTime("1900-01-01");
                    }
                    try
                    {
                        data_Documento.FechaEmisionSUNAT   = Convert.ToDateTime(row["FechaEmisionSUNAT"].ToString());
                    }
                    catch (Exception)
                    {
                        data_Documento.FechaEmisionSUNAT   = Convert.ToDateTime("1900-01-01");
                    }
                    data_Documento.EnviadoSunat        = Convert.ToBoolean(row["EnviadoSunat"].ToString());
                    data_Documento.EnviadoServer       = Convert.ToBoolean(row["EnviadoServer"].ToString());
                    data_Documento.EnviadoEmailCliente = Convert.ToBoolean(row["EnviadoEmailCliente"].ToString());
                    data_Documento.EstadoSunat         = row["EstadoSunat"].ToString();
                    data_Documento.ComentarioDocumento = row["ComentarioDocumento"].ToString();
                    data_Documento.SerieCorrelativo    = row["SerieCorrelativo"].ToString();
                    data_Documento.CdrSunat            = row["CdrSunat"].ToString();
                    data_Documento.Eliminado           = Convert.ToBoolean(row["Eliminado"].ToString());
                    data_Documento.Anulado             = Convert.ToBoolean(row["Anulado"].ToString());
                    data_Documento.IdCabeceraDocumento = Convert.ToInt32(row["IdCabeceraDocumento"].ToString());

                    data_Documentos.Add(data_Documento);
                }
                return data_Documentos;
            });

            return await task;
        }

        public List<Data_Documentos> pruebaSimple(DateTime Start_FechaRegistro, DateTime End_FechaRegistro)
        {
            List<Data_Documentos> data_Documentos = new List<Data_Documentos>();

            DataTable dataTable = new DataTable();
            Connection connection = new Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "[dbo].[Read_List_Documento_By_Filters]",
                CommandType = CommandType.StoredProcedure,
                Connection = connection.connectionString
            };
            sqlDataAdapter.SelectCommand = sqlCommand;

            SqlParameter parameterStart_FechaRegistro = new SqlParameter
            {
                SqlDbType = SqlDbType.DateTime,
                ParameterName = "@Start_FechaRegistro",
                Value = Start_FechaRegistro
            };
            sqlCommand.Parameters.Add(parameterStart_FechaRegistro);

            SqlParameter parameterEnd_FechaRegistro = new SqlParameter
            {
                SqlDbType = SqlDbType.DateTime,
                ParameterName = "@End_FechaRegistro",
                Value = End_FechaRegistro
            };
            sqlCommand.Parameters.Add(parameterEnd_FechaRegistro);

            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            DataRow row;

            Data_Documentos data_Documento;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                row = dataTable.Rows[i];
                data_Documento = new Data_Documentos();
                NombreModulo = row["NombreModulo"].ToString();
                CodigoEmpresa = row["CodigoEmpresa"].ToString();
                Ruta = row["Ruta"].ToString();
                IdEmisor = Convert.ToInt32(row["IdEmisor"].ToString());
                TipoDocumento = row["TipoDocumento"].ToString();
                try
                {
                    FechaRegistro = Convert.ToDateTime(row["FechaRegistro"].ToString());
                }
                catch (Exception)
                {
                    FechaRegistro = Convert.ToDateTime("1900-01-01");
                }
                try
                {
                    FechaEmisionSUNAT = Convert.ToDateTime(row["FechaEmisionSUNAT"].ToString());
                }
                catch (Exception)
                {
                    FechaEmisionSUNAT = Convert.ToDateTime("1900-01-01");
                }
                EnviadoSunat = Convert.ToBoolean(row["EnviadoSunat"].ToString());
                EnviadoServer = Convert.ToBoolean(row["EnviadoServer"].ToString());
                EnviadoEmailCliente = Convert.ToBoolean(row["EnviadoEmailCliente"].ToString());
                EstadoSunat = row["EstadoSunat"].ToString();
                ComentarioDocumento = row["ComentarioDocumento"].ToString();
                SerieCorrelativo = row["SerieCorrelativo"].ToString();
                CdrSunat = row["CdrSunat"].ToString();
                Eliminado = Convert.ToBoolean(row["Eliminado"].ToString());
                Anulado = Convert.ToBoolean(row["Anulado"].ToString());
                IdCabeceraDocumento = Convert.ToInt32(row["IdCabeceraDocumento"].ToString());

                data_Documentos.Add(data_Documento);
            }
            return data_Documentos;
        }
    }
}
