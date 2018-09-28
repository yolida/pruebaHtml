using System;
using System.Windows.Forms;
using FEI.Usuario;
using FEI.Base;
using System.Diagnostics;
using FEI.Extension.Base;
using ContasisALF;
using Servicios;
using System.Security.Cryptography;
using System.Text;

namespace SERCE
{
    static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
           /* if (PriorProcess() != null)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR20", "");
                return;
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            /* string Code = GetMD5("FEI-Contasis-2016");
             if (args.Length > 0)
             {
                 if (args[0].ToString() == Code)
                 {*/

            try
            {
                /* if (args.Length > 0)
                 {
                     if (args[0].ToString() == "1")
                     {*/
                        // Application.Run(new frmLogin());      
                        string ruta = new clsRegistry().Read("RUTA");
                        if (ruta == null)
                        {
                  
                           frmSelect f = new frmSelect();
                          
                           if (f.ShowDialog() == DialogResult.OK)
                            {                               
                                Application.Run(new frmLogin());
                            }
                        }
                        else
                        {
                            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                            Application.Run(new frmLogin());
                        }
                  /*  }
                    else
                    {
                        MessageBox.Show("Inicie desde FEI.exe");
                    }

                }
                else
                {
                    MessageBox.Show("Inicie desde FEI.exe");
                }*/

            }
            catch (Exception)
            {
                //throw;
            }
            /* }
             else
             {
                 MessageBox.Show("Es necesario iniciar la aplicacion desde el lanzador de FEI");
             }
         }
         else
         {
             MessageBox.Show("Es necesario iniciar la aplicacion desde el lanzador de FEI");
         }*/
         
        }

        public static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
