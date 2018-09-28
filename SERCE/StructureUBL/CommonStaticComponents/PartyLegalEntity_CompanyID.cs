using System;

namespace StructureUBL.CommonStaticComponents
{
    public class PartyLegalEntity_CompanyID
    {
        public string SchemeID { get; set; } // Código de tipo de documento de identidad del destinatario

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string SchemeURI { get; set; }

        public int Value { get; set; } // Número de documento de identidad del destinatario

        public PartyLegalEntity_CompanyID()
        {
            SchemeName          = "SUNAT:Identificador de Documento de Identidad";
            SchemeAgencyName    = "PE:SUNAT";
            SchemeURI           = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06";
        }
    }
}
