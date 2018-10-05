using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.CRUD
{
    public interface IData_Documentos
    {
        Task<List<Data_Documentos>> GetListFiltered(DateTime Start_FechaRegistro, DateTime End_FechaRegistro);
    }
}
