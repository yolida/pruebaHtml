using System;
namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class DeliveryId
    {
        public string SchemeID { get; set; }

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string SchemeURI { get; set; }

        public string Value { get; set; }

        public DeliveryId() {
            SchemeName          = "SUNAT:Identificador de Tipo de Medidor";
            SchemeAgencyName    = "PE:SUNAT";
            SchemeURI           = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo58";
        }
    }
}
