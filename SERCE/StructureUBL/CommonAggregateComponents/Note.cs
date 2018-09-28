using System;

namespace StructureUBL.CommonAggregateComponents
{
    [Serializable]
    public class Note
    {
        public string LanguageLocaleID { get; set; } //Código de leyenda

        public string Leyenda { get; set; } // Leyenda an..100
    }
}
