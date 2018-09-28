﻿using Newtonsoft.Json;

namespace Models.Modelos
{
    public class ItemPercepcion : ItemSunatBase
    {
        [JsonProperty(Order = 8, Required = Required.Always)]
        public decimal ImporteSinPercepcion { get; set; }

        [JsonProperty(Order = 10, Required = Required.Always)]
        public decimal ImportePercibido { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        public string FechaPercepcion { get; set; }
    }
}
