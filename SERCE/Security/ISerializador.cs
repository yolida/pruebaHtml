using System.Threading.Tasks;
using Common;
using Models.Intercambio;

namespace Security
{
    public interface ISerializador
    {
        Task<string> GenerarXml<T>(T objectToSerialize) where T : IEstructuraXml;
        Task<string> GenerarZip(string tramaXml, string nombreArchivo);
        Task<EnviarDocumentoResponse> GenerarDocumentoRespuesta(string constanciaRecepcion);
    }
}
