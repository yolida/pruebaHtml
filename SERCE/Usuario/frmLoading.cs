using FEI.Extension.Base;
using FEI.Extension.Datos;
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
    public partial class frmLoading : frmBaseFormularios
    {
        public frmLoading()
        {
            InitializeComponent();                 
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmLoading_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = SERCE.Properties.Resources.AnimatedImage;
            this.ControlBox = false;
            labelProgress.Text = "Actualizando";                    
            backgroundWorker.RunWorkerAsync();
           
        }
        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            new clsEntityDatabaseLocal().cs_pxVerificarBaseDatos();
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {       
            labelProgress.Text = "Actualizando";         
        }

        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // hide animation
            pictureBox1.Image = null;
            labelProgress.Text = "";     
            labelConfirm.Text = "Estructura actualizada!";
            pictureBox1.Image = SERCE.Properties.Resources.InformationImage;         
            this.ControlBox = true;
            //Hide();
         
        }      
    }
}
