using System;

namespace StructureUBL.CommonStaticComponents
{
    public class Quantity // Consumo del periodo (Servicios públicos)
    {
        public string UnitCode { get; set; } // Consumo del periodo (Servicios públicos)

        public string UnitCodeListID { get; set; }

        public string UnitCodeListAgencyName { get; set; }

        public int Value { get; set; }

        public Quantity() {
            UnitCodeListID = "UN/ECE rec 20";
            UnitCodeListAgencyName = "United Nations Economic Commission for Europe";
        }
    }
}
