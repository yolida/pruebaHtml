using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class HandlingCode
    {
        public string ListName { get; set; }

        public string ListAgencyName { get; set; }

        public string ListURI { get; set; }

        public string Value { get; set; }

        public HandlingCode()
        {
            ListName        = "SUNAT:Indicador de Motivo de Traslado";
            ListAgencyName  = "PE:SUNAT";
            ListURI         = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo20";
        }
    }
}
