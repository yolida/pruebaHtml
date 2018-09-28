using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class LocaleCode // Código de Servicios de Telecomunicaciones (De corresponder)
    {
        public string ListAgencyName { get; set; }
        public string ListName { get; set; }
        public string ListURI { get; set; }
        public string Value { get; set; }
        public LocaleCode()
        {
            ListAgencyName = "PE:SUNAT";
            ListName = "SUNAT:Identificador de Servicio de Telecomunicación";
            ListURI = "urn:pe:gob:sunat:cpe:see:gem: catalogos: catalogo57";
        }
    }
}
