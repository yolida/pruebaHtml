using FEI.Extension.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERCE
{
    public partial class frmSelect : Form
    {   
        public frmSelect()
        {
            InitializeComponent();
            string existe = new clsRegistry().Read("RUTA");

            if (existe != null)
            {
                textBox1.Text = existe.ToString();
            }
            else
            {
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // BOTON DE NUEVO FOLDER ACTIVADO
            folderBrowserDlg.ShowNewFolderButton = true;
            // MOSTRAR CUADRO DE DIALOGO
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                // MOSTRAR CARPETA ELEGIDA EN CUADRO DE TEXTO;
                textBox1.Text = folderBrowserDlg.SelectedPath;              
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = textBox1.Text;         
            if (ruta.Trim() != "" && Directory.Exists(ruta))
            {

                string existe = new clsRegistry().Read("RUTA");
                bool registrado = false;
                if (existe == null)
                {
                    //noexiste
                    registrado = new clsRegistry().Write("RUTA", ruta);

                }
                else
                {
                    new clsRegistry().DeleteKey("RUTA");
                    registrado = new clsRegistry().Write("RUTA", ruta);

                }
                if (!registrado)
                {
             
                    MessageBox.Show("Ocurrio un error al guardar la ruta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Ocurrio un error al guardar la ruta.");
                }
                else
                {
                    MessageBox.Show("La ruta fue almacenada con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una ruta valida.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
