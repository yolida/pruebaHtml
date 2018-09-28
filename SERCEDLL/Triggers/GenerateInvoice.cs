using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using GenerateXML;
using Models.Intercambio;
using Models.Modelos;
using Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FEI.Extension.Triggers
{
    public class GenerateInvoice
    {
        public string RutaArchivo { get; set; }
        public string IdDocumento { get; set; }
        public async void GenerateXMLInvoice(string idDocument, EntityData entityData)
        {

            //string xml = new clsNegocioCEFactura(entityData.LocalDB).cs_pxGenerarXMLAString(idDocument);

            clsEntityDocument cabecera = new clsEntityDocument(entityData.LocalDB).cs_fxObtenerUnoPorId(idDocument);
            List<clsEntityDocument_Line> detalle = new clsEntityDocument_Line(entityData.LocalDB).
                                                        cs_fxObtenerTodoPorCabeceraId(cabecera.Cs_pr_Document_Id);

            //--------------------------------------------------------------------------------------
            List<List<string>> iars = new clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation(entityData.LocalDB).
                                        cs_pxObtenerTodoPorCabeceraId(cabecera.Cs_pr_Document_Id);

            List<List<string>> guias_remision = new clsEntityDocument_DespatchDocumentReference(entityData.LocalDB).
                                        cs_pxObtenerTodoPorId(cabecera.Cs_pr_Document_Id);

            List<List<string>> otro_documento_relacionado = new clsEntityDocument_AdditionalDocumentReference(entityData.LocalDB).
                                        cs_pxObtenerTodoPorId(cabecera.Cs_pr_Document_Id);
            List<List<string>> impuestos_globales = new clsEntityDocument_TaxTotal(entityData.LocalDB).
                                        cs_pxObtenerTodoPorCabeceraId(cabecera.Cs_pr_Document_Id);

            List<clsEntityDocument_Advance> Adicional_Anticipos = new
                                        clsEntityDocument_Advance(entityData.LocalDB).cs_fxObtenerTodoPorCabeceraId(cabecera.Cs_pr_Document_Id);
            //--------------------------------------------------------------------------------------


            //-------------------------------------------------------------------------------------------
            // AdditionalMonetaryTotal
            List<List<string>> dataAdditionalMonetaryTotal = new
                                            clsEntityDocument_UBLExtension_ExtensionContent_AdditionalInformation_AdditionalMonetaryTotal(entityData.LocalDB).
                                            cs_pxObtenerTodoPorCabeceraId(iars[0][0]);


            //-------------------------------------------------------------------------------------------

            List<DetalleDocumento> detalleDocumentos = new List<DetalleDocumento>();

            DocumentoElectronico documento = new DocumentoElectronico()
            {
                TipoDocumento = cabecera.Cs_tag_InvoiceTypeCode,
               
                //SerieCorrelativo = cabecera.Cs_pr_Document_Id,
                DetalleDocumentos = detalleDocumentos

            };




            var proxy = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiFEICONT"]) };

            string metodoApi;
            switch (documento.TipoDocumento)
            {
                case "07":
                    metodoApi = "api/GenerarNotaCredito";
                    break;
                case "08":
                    metodoApi = "api/GenerarNotaDebito";
                    break;
                default:
                    metodoApi = "api/GenerarFactura";
                    break;
            }

            var response = await proxy.PostAsJsonAsync(metodoApi, documento);
            var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>(); // Aquí se crea el XML encriptado
            string pruebbbitaaaa = Encoding.Default.GetString(Convert.FromBase64String(respuesta.TramaXmlSinFirma));

            if (!respuesta.Exito)
                throw new ApplicationException(respuesta.MensajeError);

            //RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{documento.SerieCorrelativo}.xml");

            File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(respuesta.TramaXmlSinFirma));

            //IdDocumento = documento.SerieCorrelativo;
        }
    }
}
