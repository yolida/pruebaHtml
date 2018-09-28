using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FEI2
{

    public class clsBaseConfiguracion2
    {     
        public string cs_prDbms { get; set; }
        public string cs_prDbmsdriver { get; set; }
        public string cs_prDbmsservidor { get; set; }
        public string cs_prDbmsservidorpuerto { get; set; }
        public string cs_prDbnombre { get; set; }
        public string cs_prDbusuario { get; set; }
        public string cs_prDbclave { get; set; }
     

        public clsBaseConfiguracion2()
        {           
        }
        private static void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
       
      
        /// <summary>
        /// Metodo para actualizar el archivo de configuracion. Opcional mensaje de confirmacion.
        /// </summary>
        /// <param name="obtener_mensaje_respuesta"></param>
     
    }
}
