using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEI.Lanzador
{
    public partial class Principal : Form
    {
      
        bool actualizo = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Principal()
        {
            InitializeComponent();
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            string codigoFEI = GetMD5("FEI-Contasis-2016");
            string RutaInstalacion = Directory.GetCurrentDirectory();
            string versionInstalada = GetVersionInstalada();
            if (versionInstalada != "")
            {
                string ArchivoEjecutable = RutaInstalacion + "\\FEI_" + versionInstalada + ".exe";
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = ArchivoEjecutable;
                myProcess.StartInfo.Arguments = "" + codigoFEI + "";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                Application.Exit();

            }
            else
            {
                MessageBox.Show("No existe el ejecutable en la ruta de instalacion.");
                Application.Exit();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                string version_ultima_pc = GetVersionInstalada();
                string ruta = "http://www.contasis.net/ayuda/fei/version.txt";
                WebClient client = new WebClient();
                byte[] allbytes = client.DownloadData(new Uri(ruta));
                string version_descargada = Encoding.UTF8.GetString(allbytes);

                int version_instalada = Convert.ToInt32(version_ultima_pc.Replace(".", ""));
                int version_disponible = Convert.ToInt32(version_descargada.Trim().Replace(".", ""));

                if (version_disponible > version_instalada)
                {
                    // label1.Text = "Es necesario actualizar";
                    MessageBox.Show("Es necesario actualizar");
                    btnActualizar.Visible = true;
                    btnActualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Actualizado");
                }
            }
            catch (Exception ex)
            {
                string exc = ex.Message;
                MessageBox.Show("No se ha podido comprobar la version. Revise su conexion a internet o intente mas tarde");
            }
            /*var versionInfo = FileVersionInfo.GetVersionInfo(pathToExe);
            string version = versionInfo.ProductVersion;*/
            //await DownloadAndSaveAsync("http://contasis.net/ayuda/FEI/version.txt", ruta_guarda);

            //URLDownloadToFile 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            prgBar.Visible = true;
            label1.Visible = true;
            btnActualizar.Enabled = false;
            string RutaInstalacion = Directory.GetCurrentDirectory();
            string ruta = "http://www.contasis.net/ayuda/fei/version.txt";
            WebClient client_version = new WebClient();
            byte[] allbytes = client_version.DownloadData(new Uri(ruta));
            string carpeta_ruta = Encoding.UTF8.GetString(allbytes);

            string ruta_http_fei = "http://www.contasis.net/ayuda/fei/" + carpeta_ruta.Trim() + "/FEI_" + carpeta_ruta.Trim() + ".exe";
            string ruta_local_fei = RutaInstalacion + "\\FEI_" + carpeta_ruta.Trim() + ".exe";
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(ruta_http_fei), ruta_local_fei);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (actualizo)
            {
                label1.Text = "1/2";
                prgBar.Refresh();
                // btnActualizar.Text = "Actualizado";
                downloadSecondPart();
            }
            else
            {
                MessageBox.Show("Ejecute el programa como administrador, para que las actualizaciones puedan ser descargadas");
            }

        }

        private void downloadSecondPart()
        {
            string RutaInstalacion = Directory.GetCurrentDirectory();
            string ruta = "http://www.contasis.net/ayuda/fei/version.txt";
            WebClient client_version = new WebClient();
            byte[] allbytes = client_version.DownloadData(new Uri(ruta));
            string carpeta_ruta = Encoding.UTF8.GetString(allbytes);

            string ruta_http_dll = "http://www.contasis.net/ayuda/fei/" + carpeta_ruta.Trim() + "/FEI.Extension.dll";
            string ruta_local_dll = RutaInstalacion + "\\FEI.Extension.dll";
            WebClient client_t = new WebClient();

            client_t.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_t_DownloadProgressChanged);
            client_t.DownloadFileCompleted += new AsyncCompletedEventHandler(client_t_DownloadFileCompleted);
            client_t.DownloadFileAsync(new Uri(ruta_http_dll), ruta_local_dll);

        }

        private void client_t_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label1.Text = "2/2";
            btnActualizar.Enabled = false;
            btnActualizar.Text = "Actualizado";
        }

        private void client_t_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            actualizo = true;
            prgBar.Maximum = (int)e.TotalBytesToReceive / 100;
            prgBar.Value = (int)e.BytesReceived / 100;
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            actualizo = true;
            prgBar.Maximum = (int)e.TotalBytesToReceive / 100;
            prgBar.Value = (int)e.BytesReceived / 100;
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
        public string GetVersionInstalada()
        {
            string name = String.Empty;
            bool version_fei = false;
            //obtener los ejecutables fei
            string RutaInstalacion = Directory.GetCurrentDirectory();
            List<int> lista_versiones = new List<int>();
            string[] dirs = Directory.GetFiles(RutaInstalacion, "*.exe");
            if (dirs.Length > 0)
            {
                foreach (string dir in dirs)
                {
                    if (dir.Contains("FEI_"))
                    {

                        string directorio = Path.GetFileNameWithoutExtension(dir.ToString());
                        string[] version_o = directorio.Split('_');
                        int version_number = Convert.ToInt32(version_o[1].Replace(".", ""));
                        lista_versiones.Add(version_number);
                        version_fei = true;
                    }
                }

                if (version_fei)
                {
                    int maximo = lista_versiones.Max();
                    string parte_3 = maximo.ToString().Substring(maximo.ToString().Length - 2, 2);
                    string parte_2 = maximo.ToString().Substring(maximo.ToString().Length - 4, 2);
                    string parte_1 = String.Empty;
                    if (maximo.ToString().Length == 6)
                    {
                        parte_1 = maximo.ToString().Substring(0, 2);
                    }
                    else
                    {
                        parte_1 = maximo.ToString().Substring(0, 1);
                        parte_1 = "0" + parte_1;
                    }

                    name = parte_1 + "." + parte_2 + "." + parte_3;
                }
            }
            return name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
