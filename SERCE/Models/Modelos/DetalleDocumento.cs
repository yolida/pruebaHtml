using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.Modelos
{
    public class DetalleDocumento
    {
        public int IdDocumentoDetalle { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int NumeroOrden { get; set; }

        /// <summary>
        /// Valor de venta por ítem | n(12,2)
        /// Si existe en la línea un cac:TaxSubTotal con 'Código de tributo por línea' igual a '9996' cuyo 'Monto base' es mayor a cero  (cbc:TaxableAmount > 0), 
        /// el importe es diferente al resultado de multiplicar el 'Valor referencial unitario por ítem en operaciones no onerosas' por 'Cantidad de unidades por
        /// ítem', menos los descuentos que afecten la base imponible del ítem ('Código de motivo de descuento' igual a '00') más los cargos que afecten la  base 
        /// imponible del ítem ('Código de motivo de cargo' igual a '47'),  con una tolerancia + - 1.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public decimal ValorVenta { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Moneda { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal Cantidad { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string UnidadMedida { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string CodigoItem { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoPrecio { get; set; }

        public decimal Descuento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal TotalVenta { get; set; }

        /// <summary>
        /// InvoiceLine > Item > SellersItemIdentification > cbc:ID
        /// Código de producto del ítem
        /// </summary>
        [JsonProperty(Required = Required.AllowNull)]
        public string CodigoProducto { get; set; }

        /// <summary>
        /// InvoiceLine > Item > CommodityClassification > ItemClassificationCode
        /// Código de producto (SUNAT)
        /// </summary>
        [JsonProperty(Required = Required.AllowNull)]
        public string CodigoProductoSunat { get; set; }

        [JsonProperty(Required = Required.Always)]
        public List<Descripcion> Descripciones { get; set; }
        
        [JsonProperty(Required = Required.AllowNull)]
        public List<PrecioAlternativo> PreciosAlternativos { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<Descuento> Descuentos { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<TotalImpuesto> TotalImpuestos { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<PropiedadAdicional> PropiedadesAdicionales { get; set; }

        public List<Entrega> Entregas { get; set; }

        public DetalleDocumento()
        {
            Descripciones           = new List<Descripcion>();
            PreciosAlternativos     = new List<PrecioAlternativo>();
            Descuentos              = new List<Descuento>();
            TotalImpuestos          = new List<TotalImpuesto>();
            PropiedadesAdicionales  = new List<PropiedadAdicional>();
            Entregas                = new List<Entrega>();
        }
    }
}
