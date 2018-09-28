using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class Data_Documentos
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


        public void Read_Documento()
        {
            string storedProcedure  = "[dbo].[Read_Documento]";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdDocumento  = new SqlParameter();
            paramIdDocumento.SqlDbType     = SqlDbType.NVarChar;
            paramIdDocumento.ParameterName = "@IdDocumento";
            paramIdDocumento.Value         = IdDocumento;
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
                    { FechaRegistro         = Convert.ToDateTime(reader["FechaRegistro"].ToString()); }
                    catch (Exception)
                    { FechaRegistro         = Convert.ToDateTime("1900-01-01"); }
                    try
                    { FechaEmisionSUNAT     = Convert.ToDateTime(reader["FechaEmisionSUNAT"].ToString()); }
                    catch (Exception)
                    { FechaEmisionSUNAT     = Convert.ToDateTime("1900-01-01"); }
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
    }
}
