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
        public Int16    IdDatosFox          { get; set; }
        public string   NombreModulo        { get; set; }
        public string   CodigoEmpresa       { get; set; }
        public string   Ruta                { get; set; }
        public int      IdEmisor            { get; set; }
        public string   TipoDocumento       { get; set; }
        public DateTime FechaRegistro       { get; set; }
        public DateTime FechaEmisionSUNAT   { get; set; }
        public Boolean  EnviadoSunat        { get; set; }
        public Boolean  EnviadoServer       { get; set; }
        public Boolean  EnviadoEmailCliente { get; set; }
        public string   TextEnviadoSunat    { get; set; }
        public string   TextEnviadoServer   { get; set; }
        public string   TextEnviadoEmailCliente { get; set; }
        public string   EstadoSunat         { get; set; }
        public string   ComentarioDocumento { get; set; }
        public string   SerieCorrelativo    { get; set; }
        public string   CdrSunat            { get; set; }
        public Boolean  Eliminado           { get; set; }
        public Boolean  Anulado             { get; set; }
        public string   TDDescripcion       { get; set; }
        public int      IdCabeceraDocumento { get; set; }
        public bool     ComunicacionBaja    { get; set; }
        public string  TextComunicacionBaja { get; set; }
        public string   XmlFirmado          { get; set; }
        public bool Selectable { get; set; }

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
            
            using (SqlDataReader reader =   sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    NombreModulo        =   reader["NombreModulo"].ToString();
                    CodigoEmpresa       =   reader["CodigoEmpresa"].ToString();
                    Ruta                =   reader["Ruta"].ToString();
                    IdEmisor            =   Convert.ToInt32(reader["IdEmisor"].ToString());
                    TipoDocumento       =   reader["TipoDocumento"].ToString();

                    #region FechaRegistro
                    try
                    {
                        FechaRegistro   = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    }
                    catch (Exception)
                    {
                        FechaRegistro   = Convert.ToDateTime("1900-01-01");
                    }
                    #endregion FechaRegistro

                    #region FechaEmisionSUNAT
                    try
                    {
                        FechaEmisionSUNAT   = Convert.ToDateTime(reader["FechaEmisionSUNAT"].ToString());
                    }
                    catch (Exception)
                    {
                        FechaEmisionSUNAT   = Convert.ToDateTime("1900-01-01");
                    }
                    #endregion FechaEmisionSUNAT

                    EnviadoSunat        =   Convert.ToBoolean(reader["EnviadoSunat"].ToString());
                    EnviadoServer       =   Convert.ToBoolean(reader["EnviadoServer"].ToString());
                    EnviadoEmailCliente =   Convert.ToBoolean(reader["EnviadoEmailCliente"].ToString());
                    EstadoSunat         =   reader["EstadoSunat"].ToString();
                    ComentarioDocumento =   reader["ComentarioDocumento"].ToString();
                    SerieCorrelativo    =   reader["SerieCorrelativo"].ToString();
                    CdrSunat            =   reader["CdrSunat"].ToString();
                    Eliminado           =   Convert.ToBoolean(reader["Eliminado"].ToString());
                    Anulado             =   Convert.ToBoolean(reader["Anulado"].ToString());
                    TDDescripcion       =   reader["TDDescripcion"].ToString();
                    IdCabeceraDocumento =   Convert.ToInt32(reader["IdCabeceraDocumento"].ToString());
                    ComunicacionBaja    =   Convert.ToBoolean(reader["ComunicacionBaja"].ToString());
                }
            }

            connection.Disconnect();
        }

        async Task<List<Data_Documentos>> IData_Documentos.GetListFiltered(Int16 IdDatosFox, DateTime Start_FechaRegistro, DateTime End_FechaRegistro, int idTipoDocumento)
        {
            var task    =   Task.Factory.StartNew(()   =>
            { 
                List <Data_Documentos> data_Documentos   = new List<Data_Documentos>();
                string procedure    =   string.Empty;
                if (idTipoDocumento != 0)
                    procedure   =   "[dbo].[Read_List_Documento_By_TipoDocumento]";
                else
                    procedure   =   "[dbo].[Read_List_Documento_By_Filters]";

                DataTable dataTable             = new DataTable();
                Connection connection           = new Connection();
                SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = procedure,
                    CommandType = CommandType.StoredProcedure,
                    Connection  = connection.connectionString
                };
                sqlDataAdapter.SelectCommand    =   sqlCommand;

                SqlParameter parameterIdDatosFox    =   new SqlParameter
                {
                    SqlDbType       = SqlDbType.SmallInt,
                    ParameterName   = "@IdDatosFox",
                    Value           = IdDatosFox
                };
                sqlCommand.Parameters.Add(parameterIdDatosFox);

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

                SqlParameter parameteridTipoDocumento = new SqlParameter
                {
                    SqlDbType       = SqlDbType.Int,
                    ParameterName   = "@idTipoDocumento",
                    Value           = idTipoDocumento
                };
                sqlCommand.Parameters.Add(parameteridTipoDocumento);

                connection.Connect();
                sqlDataAdapter.Fill(dataTable);
                connection.Disconnect();

                DataRow row;

                Data_Documentos data_Documento;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    row = dataTable.Rows[i];
                    data_Documento  =   new Data_Documentos();
                    data_Documento.NombreModulo         =   row["NombreModulo"].ToString();
                    data_Documento.CodigoEmpresa        =   row["CodigoEmpresa"].ToString();
                    data_Documento.Ruta                 =   row["Ruta"].ToString();
                    data_Documento.IdEmisor             =   Convert.ToInt32(row["IdEmisor"].ToString());
                    data_Documento.TipoDocumento        =   row["TipoDocumento"].ToString();

                    #region FechaRegistro
                    try
                    {
                        data_Documento.FechaRegistro   = Convert.ToDateTime(row["FechaRegistro"].ToString());
                    }
                    catch (Exception)
                    {
                        data_Documento.FechaRegistro   = Convert.ToDateTime("1900-01-01");
                    }
                    #endregion FechaRegistro

                    #region FechaEmisionSUNAT
                    try
                    {
                        data_Documento.FechaEmisionSUNAT   = Convert.ToDateTime(row["FechaEmisionSUNAT"].ToString());
                    }
                    catch (Exception)
                    {
                        data_Documento.FechaEmisionSUNAT   = Convert.ToDateTime("1900-01-01");
                    }
                    #endregion FechaEmisionSUNAT

                    #region EnviadoSunat
                    data_Documento.EnviadoSunat        = Convert.ToBoolean(row["EnviadoSunat"].ToString());
                    if (data_Documento.EnviadoSunat)
                        data_Documento.TextEnviadoSunat = "Enviado";
                    else
                        data_Documento.TextEnviadoSunat = "No enviado";
                    #endregion EnviadoSunat

                    #region EnviadoServer
                    data_Documento.EnviadoServer       = Convert.ToBoolean(row["EnviadoServer"].ToString());
                    if (data_Documento.EnviadoServer)
                        data_Documento.TextEnviadoServer = "Enviado";
                    else
                        data_Documento.TextEnviadoServer = "No enviado";
                    #endregion EnviadoServer

                    #region EnviadoEmailCliente
                    data_Documento.EnviadoEmailCliente  =   Convert.ToBoolean(row["EnviadoEmailCliente"].ToString());

                    #endregion EnviadoEmailCliente

                    data_Documento.EstadoSunat          =   row["EstadoSunat"].ToString();
                    data_Documento.ComentarioDocumento  =   row["ComentarioDocumento"].ToString();
                    data_Documento.SerieCorrelativo     =   row["SerieCorrelativo"].ToString();
                    data_Documento.CdrSunat             =   row["CdrSunat"].ToString();
                    data_Documento.Eliminado            =   Convert.ToBoolean(row["Eliminado"].ToString());
                    data_Documento.Anulado              =   Convert.ToBoolean(row["Anulado"].ToString());
                    data_Documento.TDDescripcion        =   row["TDDescripcion"].ToString();
                    data_Documento.IdCabeceraDocumento  =   Convert.ToInt32(row["IdCabeceraDocumento"].ToString());

                    #region ComunicacionBaja
                    data_Documento.ComunicacionBaja     =   Convert.ToBoolean(row["ComunicacionBaja"].ToString());
                    if (data_Documento.ComunicacionBaja)
                        data_Documento.TextComunicacionBaja =   "Si";
                    else
                        data_Documento.TextComunicacionBaja =   "No";
                    #endregion ComunicacionBaja
                    data_Documento.Selectable           =   false;
                    data_Documentos.Add(data_Documento);
                }
                return data_Documentos;
            });

            return await task;
        }

        public bool Update_Documento_XML(string xmlFirmado)
        {
            Connection connection   =   new Connection();

            SqlCommand sqlCommand   =   new SqlCommand() {
                CommandText     =   "[dbo].[Update_Documento_XML]",
                CommandType     =   CommandType.StoredProcedure,
                Connection      =   connection.connectionString
            };

            SqlParameter paramIdDocumento   =   new SqlParameter() {
                SqlDbType       =   SqlDbType.NVarChar,
                ParameterName   =   "@IdDocumento",
                Value           =   IdDocumento
            };

            SqlParameter paramXmlFirmado    =   new SqlParameter() {
                SqlDbType       =   SqlDbType.NVarChar,
                ParameterName   =   "@XmlFirmado",
                Value           =   xmlFirmado
            };

            SqlParameter paramComprobacion  =   new SqlParameter() {
                Direction       =   ParameterDirection.Output,
                SqlDbType       =   SqlDbType.Bit,
                ParameterName   =   "Validation"
            };

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();
    
            return Convert.ToBoolean(sqlCommand.Parameters[""]);
        }
    }
}
