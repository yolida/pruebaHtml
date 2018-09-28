using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class PersonId
    {
        /// Paquete turístico – Código de tipo de Documento identidad del huésped
        /// an1
        public string SchemeID { get; set; }

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string SchemeURI { get; set; }

        public string Value { get; set; } // Paquete turístico – Documento identidad del huésped

        public PersonId()
        {
            SchemeName          = "SUNAT:Identificador de Documento de Identidad";
            SchemeAgencyName    = "PE:SUNAT";
            SchemeURI           = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06";
        }
    }
}
