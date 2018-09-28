using Models.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataLayer.CRUD
{
    public class Data_DocumentoDetalle: DetalleDocumento
    {
        public Data_DocumentoDetalle(int idCabeceraDocumento)
        {
            IdCabeceraDocumento = idCabeceraDocumento;
        }

        public int IdCabeceraDocumento { get; set; }


        public List<DetalleDocumento> Read_DocumentoDetalle()
        {
            List<DetalleDocumento> detalleDocumentos = new List<DetalleDocumento>();

            ReadGeneralData readGeneralData;
            readGeneralData     = new ReadGeneralData();
            DataTable dataTableDocumentoDetalle = readGeneralData.GetDataTable("[dbo].[Read_DocumentoDetalle]", "@IdCabeceraDocumento", IdCabeceraDocumento);

            int cantidadLineas  =   0;

            cantidadLineas      =   dataTableDocumentoDetalle.Rows.Count;

            DataRow row;

            DetalleDocumento detalleDocumento;

            for (int i = 0; i < cantidadLineas; i++)
            {
                row =   dataTableDocumentoDetalle.Rows[i];
                detalleDocumento    =   new DetalleDocumento() {
                    IdDocumentoDetalle  =   Convert.ToInt32(row["IdDocumentoDetalle"].ToString()),
                    NumeroOrden         =   Convert.ToInt32(row["NumeroOrden"].ToString()),
                    ValorVenta          =   Convert.ToDecimal(row["ValorVenta"].ToString()),
                    Moneda              =   row["Moneda"].ToString(),
                    Cantidad            =   Convert.ToDecimal(row["Cantidad"]),
                    UnidadMedida        =   row["UnidadMedida"].ToString(),
                    CodigoItem          =   row["CodigoItem"].ToString(),
                    TipoPrecio          =   row["TipoPrecio"].ToString(),
                    Descuento           =   Convert.ToDecimal(row["Descuento"].ToString()),
                    TotalVenta          =   Convert.ToDecimal(row["TotalVenta"].ToString()),
                    CodigoProductoSunat =   row["CodigoProductoSunat"].ToString(),
                    CodigoProducto      =   row["CodigoProducto"].ToString()
                };
                detalleDocumentos.Add(detalleDocumento);
            }

            return detalleDocumentos;
        }
    }
}
