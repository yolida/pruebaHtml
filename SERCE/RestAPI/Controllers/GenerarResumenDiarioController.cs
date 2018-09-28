using System;
using System.Threading.Tasks;
using System.Web.Http;
using Models.Intercambio;
using Models.Modelos;
using Security;
using GenerateXML;
using Microsoft.Practices.Unity;
using RestAPI.App_Start;

namespace RestAPI.Controllers
{
    [RoutePrefix("api/GenerarResumenDiario")]
    public class GenerarResumenDiarioController : ApiController
    {
        private IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;

        public GenerarResumenDiarioController(ISerializador serializador)
        {
            _serializador = serializador;
            _documentoXml = UnityConfig.GetConfiguredContainer()
                .Resolve<IDocumentoXml>(GetType().Name);
        }


        [Route("v1")]
        [HttpPost]
        public async Task<DocumentoResponse> Post([FromBody] ResumenDiario resumen)
        {
            var response = new DocumentoResponse();
            try
            {
                var summary = _documentoXml.Generar(resumen);
                response.TramaXmlSinFirma = await _serializador.GenerarXml(summary);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
            }

            return response;
        }

        [Route("v2")]
        [HttpPost]
        public async Task<DocumentoResponse> ResumenNuevo([FromBody] ResumenDiarioNuevo resumen)
        {
            var response = new DocumentoResponse();
            try
            {
                // Solucion temporal --> Issue #58
                _documentoXml = UnityConfig.GetConfiguredContainer().Resolve<IDocumentoXml>();
                var summary = _documentoXml.Generar(resumen);
                response.TramaXmlSinFirma = await _serializador.GenerarXml(summary);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
            }

            return response;
        }
    }
}
