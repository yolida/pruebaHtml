using Models.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.CRUD
{
    public class Data_SubTotalImpuesto: SubTotalImpuestos
    {
        public Data_SubTotalImpuesto(int idTotalImpuestos)
        {
            IdTotalImpuestos = idTotalImpuestos;
        }

        public int IdTotalImpuestos { get; set; }

        public List<SubTotalImpuestos> Read_SubTotalImpuesto()
        {
            List<SubTotalImpuestos> subTotalImpuestos   =   new List<SubTotalImpuestos>();

            ReadGeneralData readGeneralData;
            readGeneralData     =   new ReadGeneralData();
            DataTable dataTable =   readGeneralData.GetDataTable("[dbo].[Read_SubTotalImpuesto]", "@IdTotalImpuestos", IdTotalImpuestos);

            int cantidadLineas = 0;

            cantidadLineas = dataTable.Rows.Count;

            DataRow row;

            SubTotalImpuestos subTotalImpuesto;

            for (int i = 0; i < cantidadLineas; i++)
            {
                row = dataTable.Rows[i];
                subTotalImpuesto = new SubTotalImpuestos()
                {
                    IdTotalImpuestos    =   Convert.ToInt32(row["IdTotalImpuestos"]),
                    BaseImponible       =   Convert.ToDecimal(row["BaseImponible"]),
                    TipoMonedaBase      =   row["MBMoneda"].ToString(),
                    MontoTotal          =   Convert.ToDecimal(row["MontoTotal"]),
                    TipoMonedaTotal     =   row["MTMoneda"].ToString(),
                    CategoriaImpuestos  =   string.Empty,   // Pendiente de verificación
                    PorcentajeImp       =   Convert.ToDecimal(row["PorcentajeImp"]),
                    TipoAfectacion      =   row["TipoAfectacion"].ToString(),
                    TipoSistemaISC      =   string.Empty,
                    PlanImpuestosID = string.Empty, // Pendiente de verificación
                    PlanImpuestosNombre  = string.Empty, // Pendiente de verificación
                    PlanImpuestosCodigo = string.Empty // Pendiente de verificación
                };
                subTotalImpuestos.Add(subTotalImpuesto);
            }

            return subTotalImpuestos;
        }
    }
}
