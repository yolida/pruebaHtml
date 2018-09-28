using System;

namespace StructureUBL.CommonAggregateComponents
{
    /// <summary>
    /// cbc:CustomizationID | [0..1]
    /// </summary>
    public class CustomizationID
    {
        public string schemeAgencyName { get; set; }

        public string Value { get; set; }

        public CustomizationID() {
            schemeAgencyName = "PE:SUNAT";
        }
    }
}
