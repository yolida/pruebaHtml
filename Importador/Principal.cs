using FEI.Extension.Base;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Importador
{
    public partial class Principal : Form
    {
       // private bool contador = false;
        private BackgroundWorker worker = new BackgroundWorker();
        private System.Timers.Timer timerVerificacion = new System.Timers.Timer();
        public Principal()
        {
            InitializeComponent();
            worker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
       
            timerVerificacion.Elapsed += new ElapsedEventHandler(runWorkerImportador);
            // Set the Interval to 1 second.
            timerVerificacion.Interval = 60000;
            timerVerificacion.Enabled = true;
            timerVerificacion.Start();
           // aTimerFactura.Start();
        }
        private void runWorkerImportador(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            tmrCargaArchivo_Tick(sender, e);
        }

        private void tmrCargaArchivo_Tick(object sender, DoWorkEventArgs e)
        {
            //verifica la carpeta cada cierto periodo de tiempo
            /*if (contador == false)
            {
                Inicio();
                Ocultar();
                contador = true;
            }*/
            try
            {
                CargarTextoPlano.Procesar();
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Principal form = (Principal)sender;
            form.ShowInTaskbar = false;
            form.Opacity = 0;
          //  Inicio();
            Ocultar();
        }

        private void timerVerificacion_Tick(object sender, EventArgs e)
        {
               
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detenerToolStripMenuItem.Text == "Detener")
            {
                timerVerificacion.Stop();
                detenerToolStripMenuItem.Text = "Iniciar";
            }
            else {
                timerVerificacion.Start();
                detenerToolStripMenuItem.Text = "Detener";
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Inicio()
        {
            timerVerificacion.Stop();
            Principal prin = Application.OpenForms.OfType<Principal>().SingleOrDefault();
            while (prin==null)
            {
                prin.Close();
            }
            timerVerificacion.Start();
        }
        private void Ocultar(){
            timerVerificacion.Stop();
            ntfIcon.Visible = true;
            ntfIcon.BalloonTipText = "Programa de importación de archivos activado.";
            ntfIcon.ShowBalloonTip(2000);
            timerVerificacion.Start();
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void iniciarConWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryActual = Environment.CurrentDirectory;
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("FEI_Importador", directoryActual + "\\Importador.exe");
            }
            catch
            {
            }            
        }

        private void quitarDelInicioDeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("FEI_Importador", false);               
            }
            catch{ }           
        }
    }
}
