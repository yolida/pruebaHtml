using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class DocumentStatusCode
    {
        public string ListAgencyName { get; set; }

        public string ListName { get; set; }

        public string ListURI { get; set; }

        public string Value { get; set; }

        public DocumentStatusCode()
        {
            ListAgencyName = "PE:SUNAT";
            // ListName = "SUNAT:Identificador de Tipo de Tarifa";
            ListURI = "urn:pe:gob:sunat:cpe:see:gem: catalogos: catalogo24";
        }
    }
}
