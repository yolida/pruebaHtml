using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.CRUD
{
    public interface IData_Documentos
    {
        Task<List<Data_Documentos>> GetListFiltered(Int16 IdDatosFox, DateTime Start_FechaRegistro, DateTime End_FechaRegistro, int idTipoDocumento);
    }
}
