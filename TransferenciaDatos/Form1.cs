using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferenciaDatos
{
    public partial class Form1 : Form
    {
        string idEmpresa;
        public Form1(string idempresa)
        {
            InitializeComponent();
            idEmpresa = idempresa;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar que almenos un check este seleccionado
            int seleccionados = 0;
            if (chkBoletas.Checked)
            {
                seleccionados++;
            }
            if (chkFactura.Checked)
            {
                seleccionados++;
            }
            if (chkNotasBoletas.Checked)
            {
                seleccionados++;
            }
            if (chkNotasFactura.Checked)
            {
                seleccionados++;
            }
            if (seleccionados >= 1)
            {
                this.Hide();
                Form2 form2 = new Form2(idEmpresa, this, chkBoletas.Checked, chkFactura.Checked, chkNotasBoletas.Checked, chkNotasFactura.Checked, rdNoExportados.Checked, rdTodos.Checked);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Seleccione al menos un tipo de comprobante.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
          
        }
    }
}
