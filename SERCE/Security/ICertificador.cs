﻿using System.Threading.Tasks;
using Models.Intercambio;

namespace Security
{
    public interface ICertificador
    {
        Task<FirmadoResponse> FirmarXml(FirmadoRequest request);
    }
}
