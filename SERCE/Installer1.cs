using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContasisALF;
using Servicios;
using System.IO;
using System.Diagnostics;

namespace SERCE
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);

        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
           /* try {
                Process myProcess = new Process();
                string RutaInstalacion = Directory.GetCurrentDirectory();
                string ArchivoEjecutable = RutaInstalacion + "\\conf.exe";

                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "logg_add.log";
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
                TextWriter tw = new StreamWriter(ruta, true);
                tw.WriteLine("<>" + DateTime.Now.ToString() + ":: " + ArchivoEjecutable);
                tw.Close();

                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = ArchivoEjecutable;
                myProcess.StartInfo.Arguments = "delete";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
               // SaveLic.Remove();
            } catch(Exception e) {

                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "logg_add.log";
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
                TextWriter tw = new StreamWriter(ruta, true);
                tw.WriteLine("<>" + DateTime.Now.ToString() + ":: " + e.ToString());
                tw.Close();
            }*/
            
        }
    }
}
