using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class InstructionID
    {
        public string SchemeID { get; set; } // Código de tipo de documento del comprobante de anticipo

        public string Value { get; set; } // n11 Número de RUC del emisor del comprobante de anticipo
    }
}
