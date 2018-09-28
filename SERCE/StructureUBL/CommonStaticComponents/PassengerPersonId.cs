using System;

namespace StructureUBL.CommonStaticComponents
{
    public class PassengerPersonId
    {
        public string SchemeID { get; set; } //an1 Paquete turístico – Código de tipo de Documento identidad del huésped

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string Value { get; set; } // Número de documento de identidad del pasajero

        public PassengerPersonId()
        {
            SchemeName          = "SUNAT:Identificador de Documento de Identidad";
            SchemeAgencyName    = "PE:SUNAT";
        }
    }
}
