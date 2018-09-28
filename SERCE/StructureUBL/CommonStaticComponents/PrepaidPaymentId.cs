using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class PrepaidPaymentId
    { // Serie y número de comprobante del anticipo (para el caso de reorganización de empresas, incluye el RUC)
        public string SchemeID { get; set; } // Código de tipo de documento n2

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string Value { get; set; }

        public PrepaidPaymentId()
        {
            SchemeName          = /*"SUNAT:Identificador de Documentos Relacionados"*/ "Anticipo";
            SchemeAgencyName    = "PE:SUNAT";
        }
    }
}
