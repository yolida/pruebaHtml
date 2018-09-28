﻿using System;

namespace StructureUBL.CommonStaticComponents
{
    /// <summary>
    /// Código de motivo de traslado
    /// </summary>
    public class ShipmentId
    {
        public string SchemeName { get; set; }

        public string SchemeAgencyName { get; set; }

        public string SchemeURI { get; set; }

        public string Value { get; set; }

        public ShipmentId()
        {
            SchemeName          = "Motivo de Traslado";
            SchemeAgencyName    = "PE:SUNAT";
            SchemeURI           = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo20";
        }
    }
}
