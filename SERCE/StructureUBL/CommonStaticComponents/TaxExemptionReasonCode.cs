using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class TaxExemptionReasonCode
    {
        public string ListName { get; set; }

        public string ListAgencyName { get; set; }

        public string ListURI { get; set; }

        public string Value { get; set; } // Código de tipo de afectación del IGV an2

        public TaxExemptionReasonCode()
        {
            ListName        = /*"SUNAT:Codigo de Tipo de Afectación del IGV"*/ "Afectacion del IGV";    //CAMBIAR!!!!!!!!!!! CATALOGO 5 Y 7
            ListAgencyName  = "PE:SUNAT";
            ListURI         = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07";
        }
    }
}