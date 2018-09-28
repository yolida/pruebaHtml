using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FEI1
{
    public class clsBaseLog1
    {
        /// <summary>
        /// Metodo para registrar un error en archivo de log
        /// </summary>
        /// <param name="mensaje"></param>
        public static void cs_pxRegistarAdd1(string mensaje)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\receptor_log.txt";
            if (!File.Exists(directory))
            {
                File.Create(directory).Close();
            }
            TextWriter tw = new StreamWriter(directory, true);
            tw.WriteLine("<>" + DateTime.Now.ToString() + ":: " + mensaje);
            tw.Close();

        }
    }
}
