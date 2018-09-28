using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class TaxCategoryId
    {
        public string SchemeID { get; set; }

        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string SchemeAgencyID { get; set; }

        public string Value { get; set; } // Categoría de impuestos

        public TaxCategoryId()
        {
            SchemeID            = "UN/ECE 5305";
            SchemeName          = "Tax Category Identifier";
            SchemeAgencyName    = "United Nations Economic Commission for Europe";
            SchemeAgencyID      = "6";
        }
    }
}
