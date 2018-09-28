using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class ContractDocumentReference_DocumentTypeCode
    {
        public string ListAgencyName { get; set; }

        public string ListName { get; set; }

        public string ListURI { get; set; }

        public Int16 Value { get; set; } // Tipo de Servicio Público

        public ContractDocumentReference_DocumentTypeCode()
        {
            ListAgencyName  = "PE:SUNAT";
            ListName        = "SUNAT:Identificador de Tipo de Servicio";
            ListURI         = "urn:pe:gob:sunat:cpe:see:gem: catalogos: catalogo56";
        }

    }
}
