using System;

namespace StructureUBL.CommonStaticComponents
{
    /// <summary>
    /// Catálogo No. 18: Códigos – Modalidad de traslado
    /// Tabla db: ModalidadTransporte
    /// </summary>
    [Serializable]
    public class TransportModeCode
    {
        public string ListName { get; set; }

        public string ListAgencyName { get; set; }

        public string ListURI { get; set; }

        /// <summary>
        /// Modalidad de Transporte. Dato exclusivo para la Factura Guía Remitente (FG Remitente)
        /// </summary>
        public string Value { get; set; }
        public TransportModeCode()
        {
            ListName = /*"SUNAT:indicador de Modalidad de Transporte"*/ "Modalidad de Transporte";
            ListAgencyName = "PE:SUNAT";
            ListURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo18";
        }
    }
}
