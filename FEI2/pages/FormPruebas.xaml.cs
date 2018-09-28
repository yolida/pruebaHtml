using System;
using System.Windows;
using Models.Modelos;
using System.Text;
using Models.Intercambio;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GenerateXML;
using Security;
using System.Threading.Tasks;
using ServicesSunat;
using ServicesSunat.SOAP;
using System.Data;
using System.Net.Http;
using System.Configuration;
using BusinessLayer;
using DataLayer.CRUD;

namespace FEI.pages
{
    /// <summary>
    /// Interaction logic for FormPruebas.xaml
    /// </summary>
    public partial class FormPruebas : Window
    {
        public string RutaArchivo { get; set; }
        //public string SerieCorrelativo { get; set; }
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;
        private readonly ICertificador _certificador;
        /*******************************************************************************/
        private static string rutaXML { get; set; }
        private static string rutaCertificado { get; set; }
        private static string passCertificado { get; set; }

        public FormPruebas()
        {
            //DocumentoElectronico documentoElectronico = new DocumentoElectronico();
            //_documentoXml = (IDocumentoXml)documentoElectronico;

            //Serializador serializador = new Serializador();
            //_serializador = (ISerializador)serializador;

            //Certificador certificador = new Certificador();
            //_certificador = (ICertificador)certificador;


            InitializeComponent();
        }

        private async void Ejecutar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            //20186C16-C1DC-4717-8F46-407447D225BC  =   5
            //E6360E58-8BD6-4F80-B65B-8B2098760287  =   6

            var response = new DocumentoResponse();
            //try
            //{
                // Generar xml y serializar
                FacturaXml facturaXml = new FacturaXml();
                Serializador serializador = new Serializador();

                //var invoice = facturaXml.metodoTemp(documento);
                //response.TramaXmlSinFirma = serializador.GenerateSimpleXML(invoice);
                response.Exito = true;

                string xmlTextoPlano = Encoding.UTF8.GetString(Convert.FromBase64String(response.TramaXmlSinFirma)); // Para pruebas 

                // Certificado
                rutaCertificado = @"D:\certificado\Certificado-NuevoProveedor\Wnl2U2wyVk01S2wyMzgzQQ%3d%3d.pfx";
                passCertificado = "53P4xfFC8sSeFRmt";

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = response.TramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(rutaCertificado)),
                    PasswordCertificado = passCertificado,
                    UnSoloNodoExtension = false
                };



                EnviarDocumentoRequest enviarDocumentoRequest = new EnviarDocumentoRequest()
                {
                    Ruc = "1073580496",
                    UsuarioSol = "MODDATOS",
                    ClaveSol = "MODDATOS",
                    EndPointUrl = "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService",
                    IdDocumento = "F001-00000001",
                    TipoDocumento = "01",
                    //TramaXmlFirmado = documentoFirmado.TramaXmlFirmado
                };

                var jsonEnvioDocumento = await PostSimple(enviarDocumentoRequest);


                string waiiiit = string.Empty;
            //}
            //catch (Exception ex)
            //{
            //    response.MensajeError = ex.Message;
            //    response.Pila = ex.StackTrace;
            //    response.Exito = false;
            //}

        }
        
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        //[HttpPost]
        public async Task<EnviarDocumentoResponse> PostSimple(EnviarDocumentoRequest request)
        {

            var response                =   new EnviarDocumentoResponse();
            var nombreArchivo           =   $"{request.Ruc}-{request.TipoDocumento}-{request.IdDocumento}";
            Serializador serializador   =   new Serializador();
            ServicioSunatDocumentos servicioSunatDocumentos     =   new ServicioSunatDocumentos();

            IServicioSunatDocumentos _servicioSunatDocumentos   =   (IServicioSunatDocumentos)servicioSunatDocumentos;

            var tramaZip    =   await serializador.GenerateZip(request.TramaXmlFirmado, nombreArchivo);

            _servicioSunatDocumentos.Inicializar(new ParametrosConexion
            {
                Ruc         =   request.Ruc,
                UserName    =   request.UsuarioSol,
                Password    =   request.ClaveSol,
                EndPointUrl =   request.EndPointUrl
            });

            var resultado   =   _servicioSunatDocumentos.EnviarDocumento(new DocumentoSunat
            {
                TramaXml        =   tramaZip,
                NombreArchivo   =   $"{nombreArchivo}.zip"
            });

            if (!resultado.Exito)
            {
                response.Exito          =   false;
                response.MensajeError   =   resultado.MensajeError;
            }
            else
            {
                response    =   await _serializador.GenerarDocumentoRespuesta(resultado.ConstanciaDeRecepcion);
                // Quitamos la R y la extensión devueltas por el Servicio.
                response.NombreArchivo  =   nombreArchivo;
            }

            return response;
        }

        private void btnEjecutar_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnEjecutar_ConInterfaces_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Data_Documentos data_Documento  =   new Data_Documentos("20186C16-C1DC-4717-8F46-407447D225BC");
                data_Documento.Read_Documento();

                GenerarFactura generarFactura =   new GenerarFactura();

                DocumentoElectronico documento  =   generarFactura.data(data_Documento);
                var response                    =   await generarFactura.Post(documento);

                if (!response.Exito)
                    System.Windows.MessageBox.Show($"A ocurrido un error en la generación de XML: {response.MensajeError}");

                string rutaArchivo = Path.Combine(data_Documento.Ruta, $"{documento.SerieCorrelativo}.xml");
                
                Firmar firmar   =   new Firmar();

                FirmadoRequest firmadoRequest   =   firmar.Data(data_Documento.IdEmisor, response.TramaXmlSinFirma);
                FirmadoResponse firmadoResponse =   await firmar.Post(firmadoRequest);  //  Ya se obtuvo el documento firmado

                if (firmadoResponse.Exito)  //  Comprobamos que se haya firmado de forma correcta
                    File.WriteAllBytes(rutaArchivo, Convert.FromBase64String(firmadoResponse.TramaXmlFirmado));
                else
                    System.Windows.MessageBox.Show($"A ocurrido un error al firmar el XML: {response.MensajeError}");

                EnviarSunat enviarSunat =   new EnviarSunat();

                EnviarDocumentoRequest enviarDocumentoRequest   =   enviarSunat.Data(firmadoResponse.TramaXmlFirmado, data_Documento, 
                                                                    "urlsunat");  // Obtenemos los datos para EnviarDocumentoRequest

                EnviarDocumentoResponse enviarDocumentoResponse =   await enviarSunat.Post_Documento(enviarDocumentoRequest);

                //  enviarDocumentoResponse =   jsonEnvioDocumento  ;   respuestaComunConArchivo    =   respuestaEnvio

                System.Windows.MessageBox.Show(enviarDocumentoResponse.MensajeRespuesta);   //  Temporal para pruebas

                if (enviarDocumentoResponse.Exito && !string.IsNullOrEmpty(enviarDocumentoResponse.TramaZipCdr))    // Comprobar envío a sunat
                {
                    if (!Directory.Exists($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}"))
                        Directory.CreateDirectory($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}");

                    File.WriteAllBytes($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\{enviarDocumentoResponse.NombreArchivo}.xml",
                        Convert.FromBase64String(firmadoResponse.TramaXmlFirmado));

                    if (!Directory.Exists($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR"))
                        Directory.CreateDirectory($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR");

                    File.WriteAllBytes($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR\\R-{enviarDocumentoResponse.NombreArchivo}.zip",
                        Convert.FromBase64String(enviarDocumentoResponse.TramaZipCdr));
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"A ocurrido un error: {ex}");
            }
        }
    }
}