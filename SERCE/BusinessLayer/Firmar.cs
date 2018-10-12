using DataLayer.CRUD;
using Models.Intercambio;
using Security;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Firmar
    {
        private readonly ICertificador _certificador;

        public Firmar()
        {
            Certificador certificador   =   new Certificador();
            _certificador               =   (ICertificador)certificador;
        }

        public FirmadoRequest Data(int IdEmisor, string tramaXmlSinFirma)
        {
            Data_AccesosSunat data_AccesosSunat =   new Data_AccesosSunat(IdEmisor);
            data_AccesosSunat.Read_AccesosSunat();

            string certificado  = Convert.ToBase64String(File.ReadAllBytes(data_AccesosSunat.CertificadoDigital));

            var firmadoRequest = new FirmadoRequest()
            {
                TramaXmlSinFirma    =   tramaXmlSinFirma,
                CertificadoDigital  =   certificado,
                PasswordCertificado =   data_AccesosSunat.ClaveCertificado,
                UnSoloNodoExtension =   true
            };

            return firmadoRequest;
        }

        public async Task<FirmadoResponse> Post(FirmadoRequest request)
        {
            var response = new FirmadoResponse();

            try
            {
                response        =   await _certificador.FirmarXml(request);
                response.Exito  =   true;
            }
            catch (Exception ex)
            {
                response.MensajeError   =   ex.Message;
                response.Pila           =   ex.StackTrace;
                response.Exito          =   false;
            }

            return response;
        }
    }
}
