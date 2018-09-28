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
    public partial class Form2 : Form
    {
        Form1 form1;
        bool chkBoletas;
        bool chkFactura;
        bool chkBoletasNotas;
        bool chkFacturasNotas;
        bool rdNoExportados;
        bool rdTodos;
        string idEmpresa;

        public Form2(string idempresa,Form1 form,bool chkBoletas1,bool chkFactura1,bool chkBoletasNotas1, bool chkFacturasNotas1,bool rdNoExportados1,bool rdTodos1)
        {
            InitializeComponent();
            form1 = form;
            idEmpresa = idempresa;
            chkBoletas= chkBoletas1;
            chkFactura=chkFactura1;
            chkBoletasNotas=chkBoletasNotas1;
            chkFacturasNotas=chkFacturasNotas1;
            rdNoExportados=rdNoExportados1;
            rdTodos=rdTodos1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fechaInicio = "";
            string fechaFin = "";

           /* if (chkFechas.Checked == true)
            {*/
                fechaInicio = dtpInicio.Text;
                fechaFin = dtpFin.Text;
           /* }*/
            this.Hide();
            Form3 form3 = new Form3(idEmpresa, this,chkBoletas,chkFactura,chkBoletasNotas,chkFacturasNotas,rdNoExportados,rdTodos,true,fechaInicio,fechaFin);
            form3.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtpInicio.Format = DateTimePickerFormat.Custom; dtpInicio.CustomFormat = "yyyy-MM-dd"; dtpInicio.Text = DateTime.Now.Date.ToString();
            dtpFin.Format = DateTimePickerFormat.Custom; dtpFin.CustomFormat = "yyyy-MM-dd"; dtpFin.Text = DateTime.Now.Date.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
