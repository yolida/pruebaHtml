using DataLayer.CRUD;
using Models.Intercambio;
using Models.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProcesarEnvio
    {
        int Id_User_Empresa;
        string IdDocumento  =   string.Empty;
        Data_Log data_Log;
        public ProcesarEnvio(int idUser_Empresa, string idDocumento)
        {
            Id_User_Empresa =   idUser_Empresa;
            IdDocumento     =   idDocumento;
        }

        public async void prueba()
        {
            try
            {
                // var taskfactory etc etc pero para despues "20186C16-C1DC-4717-8F46-407447D225BC"
                Data_Documentos data_Documento  =   new Data_Documentos(IdDocumento);   //  IdDocumento variable global
                data_Documento.Read_Documento();

                GenerarFactura generarFactura   =   new GenerarFactura();

                DocumentoElectronico documento  =   generarFactura.data(data_Documento);    //  CAMBIAR A ASINCRONO AL FINALIZAR EL DESARROLLO
                var response                    =   await generarFactura.Post(documento);

                if (!response.Exito)
                {
                    Data_Log data_Log   =   new Data_Log() { DetalleError   =   response.MensajeError, Comentario   =   "El XML no se pudo generar" };
                    data_Log.Create_Log();
                }

                string rutaArchivo = Path.Combine(data_Documento.Ruta, $"{documento.SerieCorrelativo}.xml");
                
                Firmar firmar   =   new Firmar();

                FirmadoRequest firmadoRequest   =   firmar.Data(data_Documento.IdEmisor, response.TramaXmlSinFirma);
                FirmadoResponse firmadoResponse =   await firmar.Post(firmadoRequest);      //  Ya se obtuvo el documento firmado

                if (firmadoResponse.Exito)  //  Comprobamos que se haya firmado de forma correcta
                {
                    Data_Documentos actualizacionXML = new Data_Documentos(IdDocumento);
                    if (!actualizacionXML.Update_Documento_XML(Encoding.UTF8.GetString(Convert.FromBase64String(firmadoResponse.TramaXmlFirmado))))
                    {
                        data_Log = new Data_Log() { DetalleError = "Error al actualizar el xmlFirmado del documento", Comentario = "Error con la base de datos" };
                        data_Log.Create_Log();
                    }
                }
                else
                {
                    data_Log    =   new Data_Log() { DetalleError   =   response.MensajeError, Comentario   =   "Error al firmar el documento"     };
                    data_Log.Create_Log();
                }

                EnviarSunat enviarSunat =   new EnviarSunat();

                EnviarDocumentoRequest enviarDocumentoRequest   =   enviarSunat.Data(firmadoResponse.TramaXmlFirmado, data_Documento, 
                                                                    GetURL());  // Obtenemos los datos para EnviarDocumentoRequest

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

        public string GetURL()
        {
            
        }
    }
}
