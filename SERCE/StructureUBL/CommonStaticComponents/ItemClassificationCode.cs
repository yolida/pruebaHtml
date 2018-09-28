using System;

namespace StructureUBL.CommonStaticComponents
{
    public class ItemClassificationCode // Código de producto (SUNAT)
    {
        public string ListID { get; set; }
        public string ListAgencyName { get; set; }
        public string ListName { get; set; }

        /// <summary>
        /// Código de producto (SUNAT) n8
        /// Se dejó el formato en string, debido a que SUNAT aun esta evaluando otras alternativas
        /// para este campo
        /// </summary>
        public string Value { get; set; }

        public ItemClassificationCode()
        {
            ListID          = "UNSPSC";
            ListAgencyName  = "GS1 US";
            ListName        = "Item Classification";
        }
    }
}
