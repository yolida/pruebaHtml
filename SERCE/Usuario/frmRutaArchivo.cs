using FEI.Extension.Base;
using SERCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FEI.Usuario
{
    public partial class frmRutaArchivo : frmBaseFormularios
    {
        public frmRutaArchivo()
        {
            InitializeComponent();
        }

        private void frmRutaArchivo_Load(object sender, EventArgs e)
        {
            string ruta = new clsRegistry().Read("RUTA");
            label2.Text = ruta;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelect f = new frmSelect();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se cerrará el programa para aplicar los cambios");
                Application.Exit();
            }


            // f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ruta = new clsRegistry().DeleteKey("RUTA");
            if (ruta)
            {
                MessageBox.Show("Se ha eliminado el registro correctamente. La aplicacion de cerrará para aplicar los cambios");
                Application.Exit();
            }
        }
    }
}
