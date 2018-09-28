using System;

namespace StructureUBL.CommonStaticComponents
{
    /// <summary>
    /// cbc:ID | [0..1] 
    /// Catálogo No. 13: Ubicación geográfica (UBIGEO)
    /// Utilizar el catálogo de ubigeos del INEI: http://webinei.inei.gob.pe:8080/sisconcode/proyecto/index.htm?proyectoTitulo=UBIGEO&proyectoId=3
    /// </summary>
    public class IdUbigeo
    {
        public string SchemeAgencyName { get; set; }

        public string SchemeName { get; set; }

        public string Value { get; set; }

        public IdUbigeo() {
            SchemeAgencyName    = "PE:INEI";
            SchemeName          = "Ubigeos";
        }
    }
}
