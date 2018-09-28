using System;

namespace StructureUBL.CommonStaticComponents
{
    [Serializable]
    public class IdentificationCode
    {
        public string ListID { get; set; }

        public string ListAgencyName { get; set; }

        public string ListName { get; set; }

        /// <summary>
        /// Pais del uso, explotación o aprovechamiento del servicio. - Código de país
        /// </summary>
        public string Value { get; set; }

        public IdentificationCode()
        {
            ListID          = "ISO 3166-1";
            ListAgencyName  = "United Nations Economic Commission for Europe";
            ListName        = "Country";
        }
    }
}
