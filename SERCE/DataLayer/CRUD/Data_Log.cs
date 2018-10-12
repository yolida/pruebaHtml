using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.CRUD
{
    public class Data_Log
    {
        public string   DetalleError    { get; set; }
        public DateTime Fecha           { get; set; }
        public int      IdUser_Empresa  { get; set; }
        public string   Comentario      { get; set; }
        
        public bool Create_Log()
        {
            Connection connection   =   new Connection();

            SqlCommand sqlCommand   =   new SqlCommand() {
                CommandText = "[dbo].[Create_Log]",
                CommandType =   CommandType.StoredProcedure,
                Connection  =   connection.connectionString
            };

            SqlParameter paramDetalleError      =   new SqlParameter() {
                SqlDbType       =   SqlDbType.NVarChar,
                ParameterName   =   "@DetalleError",
                Value           =   DetalleError,
            };
            sqlCommand.Parameters.Add(paramDetalleError);

            SqlParameter paramComentario        =   new SqlParameter() {
                SqlDbType       =   SqlDbType.NVarChar,
                ParameterName   =   "@Comentario",
                Value           =   Comentario
            };
            sqlCommand.Parameters.Add(paramComentario);

            SqlParameter paramIdUser_Empresa    =   new SqlParameter() {
                SqlDbType       =   SqlDbType.Int,
                ParameterName   =   "@IdUser_Empresa",
                Value           =   IdUser_Empresa
            };
            sqlCommand.Parameters.Add(paramIdUser_Empresa);

            SqlParameter paramComprobacion      =   new SqlParameter() {
                Direction       =   ParameterDirection.Output,
                SqlDbType       =   SqlDbType.Bit,
                ParameterName   =   "@Validation"
            };
            sqlCommand.Parameters.Add(paramComprobacion);
            
            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();

            return Convert.ToBoolean(sqlCommand.Parameters["@Validation"].Value.ToString());
        }
    }
}
