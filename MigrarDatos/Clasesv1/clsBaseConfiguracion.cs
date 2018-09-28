using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FEI1
{
    public class clsBaseConfiguracion1
    {
        public string cs_prDbms { get; set; }
        public string cs_prDbmsdriver { get; set; }
        public string cs_prDbmsservidor { get; set; }
        public string cs_prDbmsservidorpuerto { get; set; }
        public string cs_prDbnombre { get; set; }
        public string cs_prDbusuario { get; set; }
        public string cs_prDbclave { get; set; }

        public clsBaseConfiguracion1()
        {                 
        }         
    }
}
