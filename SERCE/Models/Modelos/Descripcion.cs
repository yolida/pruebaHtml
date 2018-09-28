using System;
using Newtonsoft.Json;

namespace Models.Modelos
{
    public class Descripcion
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Detalle { get; set; }
    }
}
