using System;
using Newtonsoft.Json;

namespace Models.Modelos
{
    public class Anticipo
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string ComprobanteAnticipo { get; set; } // cbc:ID

        [JsonProperty(Required = Required.AllowNull)]
        public string TipoDocumento { get; set; } // @schemeID

        [JsonProperty(Required = Required.AllowNull)]
        public decimal Monto { get; set; } // cbc:PaidAmount

        [JsonProperty(Required = Required.AllowNull)]
        public string Moneda { get; set; } // @currencyID

        [JsonProperty(Required = Required.AllowNull)]
        public string NroDocumentoEmisor { get; set; } // cbc:InstructionID

        [JsonProperty(Required = Required.AllowNull)]
        public string TipoDocumentoIdentidad { get; set; } // @schemeID

        /// <summary>
        /// /Invoice/cac:PrepaidPayment/cbc:PaidDate
        /// Fecha de Pago
        /// </summary>
        public DateTime FechaPago { get; set; }
    }
}
