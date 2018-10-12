﻿using DataLayer.CRUD;
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
        Data_Usuario data_Usuario;
        string IdDocumento  =   string.Empty;
        Data_Log data_Log;

        public ProcesarEnvio(Data_Usuario idUser_Empresa, string idDocumento)
        {
            data_Usuario    =   idUser_Empresa;
            IdDocumento     =   idDocumento;
        }

        public async void Post()
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
                    Data_Log data_Log   =   new Data_Log()
                    {
                        DetalleError    =   response.MensajeError,
                        Comentario      =   $"El XML con serie correlativo: {documento.SerieCorrelativo} no se pudo generar",
                        IdUser_Empresa  =   data_Usuario.IdUser_Empresa
                    };
                    data_Log.Create_Log();
                }

                string rutaArchivo = Path.Combine(data_Documento.Ruta, $"{documento.SerieCorrelativo}.xml");
                
                Firmar firmar   =   new Firmar();

                FirmadoRequest firmadoRequest   =   firmar.Data(data_Documento.IdEmisor, response.TramaXmlSinFirma);
                FirmadoResponse firmadoResponse =   await firmar.Post(firmadoRequest);      //  Ya se obtuvo el documento firmado

                if (firmadoResponse.Exito)  //  Comprobamos que se haya firmado de forma correcta
                {
                    Data_Documentos actualizacionXML = new Data_Documentos(IdDocumento) { XmlFirmado = Encoding.UTF8.GetString(Convert.FromBase64String(firmadoResponse.TramaXmlFirmado)) };
                    if (!actualizacionXML.Update_Documento_OneColumn("[dbo].[Update_Documento_SignedXML]"))
                    {
                        data_Log = new Data_Log()
                        {
                            DetalleError    =   "Error al actualizar el xmlFirmado del documento",
                            Comentario      =   "Error con la base de datos",
                            IdUser_Empresa  =   data_Usuario.IdUser_Empresa
                        };
                        data_Log.Create_Log();
                    }
                }
                else
                {
                    data_Log = new Data_Log() { DetalleError = response.MensajeError, Comentario = "Error al firmar el documento", IdUser_Empresa = data_Usuario.IdUser_Empresa };
                    data_Log.Create_Log();
                }

                EnviarSunat enviarSunat =   new EnviarSunat();

                EnviarDocumentoRequest enviarDocumentoRequest   =   enviarSunat.Data(firmadoResponse.TramaXmlFirmado, data_Documento, 
                                                                    GetURL(data_Documento.TipoDocumento));  // Obtenemos los datos para EnviarDocumentoRequest

                EnviarDocumentoResponse enviarDocumentoResponse =   await enviarSunat.Post_Documento(enviarDocumentoRequest);

                //  enviarDocumentoResponse =   jsonEnvioDocumento  ;   respuestaComunConArchivo    =   respuestaEnvio

                string mensajeRespuesta = enviarDocumentoResponse.MensajeRespuesta;//  Temporal para pruebas

                if (enviarDocumentoResponse.Exito && !string.IsNullOrEmpty(enviarDocumentoResponse.TramaZipCdr))    // Comprobar envío a sunat
                {
                    Data_Documentos actualizacionCDR    =   new Data_Documentos() { IdDocumento = IdDocumento,   CdrSunat    = enviarDocumentoResponse.TramaZipCdr };
                    if (!actualizacionCDR.Update_Documento_OneColumn("[dbo].[Update_Documento_CDR]"))
                    {
                        data_Log = new Data_Log()
                        {
                            DetalleError    =   "Error al actualizar el CDR del documento",
                            Comentario      =   "Error con la base de datos",
                            IdUser_Empresa  =   data_Usuario.IdUser_Empresa
                        };
                        data_Log.Create_Log();
                    }  

                    if (!Directory.Exists($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}"))
                        Directory.CreateDirectory($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}");

                    File.WriteAllBytes($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\{enviarDocumentoResponse.NombreArchivo}.xml",
                        Convert.FromBase64String(firmadoResponse.TramaXmlFirmado));

                    if (!Directory.Exists($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR"))
                        Directory.CreateDirectory($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR");

                    File.WriteAllBytes($"{data_Documento.Ruta}\\{enviarDocumentoResponse.NombreArchivo}\\CDR\\R-{enviarDocumentoResponse.NombreArchivo}.zip",
                        Convert.FromBase64String(enviarDocumentoResponse.TramaZipCdr));
                }
                else
                {
                    data_Log = new Data_Log() { DetalleError = enviarDocumentoResponse.MensajeError, Comentario = "Error al enviar el documento", IdUser_Empresa = data_Usuario.IdUser_Empresa };
                    //  IMPORTANTE
                    // Aquí se debe crear un registro del enviarDocumentoResponse.MensajeError en comentarios del documento igual si tiene éxito
                }
            }
            catch (Exception ex)
            {
                data_Log = new Data_Log() { DetalleError = $"A ocurrido un error: {ex}", Comentario = "Error al procesar el envío del documento", IdUser_Empresa = data_Usuario.IdUser_Empresa };
                data_Log.Create_Log();
            }
        }

        public string GetURL(string tipoDocumento)
        {
            string url  =   string.Empty;
            Data_AccesosSunat data_AccesosSunat =   new Data_AccesosSunat(data_Usuario.IdAccesosSunat);
            data_AccesosSunat.Read_AccesosSunat();

            if (tipoDocumento.Equals("03")) // Aquí se debe identificar si es guía de remisión
            {
                if (data_AccesosSunat.UsuarioSol.Equals("MODDATOS"))
                    url =   "https://e-beta.sunat.gob.pe/ol-ti-itemision-guia-gem-beta/billService?wsdl";
                else
                    url =   "https://e-guiaremision.sunat.gob.pe/ol-ti-itemision-guia-gem/billService?wsdl";
            }
            else
            {
                if (data_AccesosSunat.UsuarioSol.Equals("MODDATOS"))
                    url =   "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService";
                else
                    url =   "https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService?wsdl";
            }
            //https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService
            return url;
        }
    }
}
