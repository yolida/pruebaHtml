using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class PriceTypeCode
    {
        public string ListName { get; set; }

        public string ListAgencyName { get; set; }

        public string ListURI { get; set; }

        public string Value { get; set; } // Código de tipo de precio

        public PriceTypeCode()
        {
            ListName        = /*"SUNAT:Indicador de Tipo de Precio"*/"Tipo de Precio";
            ListAgencyName  = "PE:SUNAT";
            ListURI         = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16";
        }
    }
}
