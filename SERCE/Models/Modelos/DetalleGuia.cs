﻿using Newtonsoft.Json;

namespace Models.Modelos
{
    public class DetalleGuia
    {
        [JsonProperty(Required = Required.Always)]
        public int Correlativo { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string CodigoItem { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Descripcion { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string UnidadMedida { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal Cantidad { get; set; }

        public int LineaReferencia { get; set; }
    }
}
