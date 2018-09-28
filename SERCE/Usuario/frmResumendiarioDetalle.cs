using FEI.Base;
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
    public partial class frmResumendiarioDetalle : frmBaseFormularios
    {
        private string id_resumendiario;

        public frmResumendiarioDetalle(string id_resumendiario)
        {
            this.id_resumendiario = id_resumendiario;
            InitializeComponent();
        }

        private void frmResumendiarioOpciones_Load(object sender, EventArgs e)
        {
            try
            {
                clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(new clsBaseConfiguracion().Cs_pr_Declarant_Id);
                clsEntitySummaryDocuments rd = new clsEntitySummaryDocuments().cs_fxObtenerUnoPorId(id_resumendiario);
                txtDocumento.Text = rd.Cs_tag_ID;
                txtFechaemision.Text = rd.Cs_tag_IssueDate;
                txtRazonsocial.Text = declarante.Cs_pr_RazonSocial;
                txtRuc.Text = declarante.Cs_pr_Ruc;

                dgvComprobanteselectronicos.Rows.Clear();
                List<List<string>> registros = new clsEntityDocument().cs_pxObtenerPorResumenDiario(id_resumendiario);

                int numero_orden = 0;
                foreach (var item in registros)
                {
                    numero_orden++;
                    dgvComprobanteselectronicos.Rows.Add(
                        item[0].ToString().Trim(),//ID
                        false,
                        numero_orden.ToString(),//ID
                        clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(item[3].Trim()),//Comprobantes
                        item[28].Trim(),//Estado SCC
                        item[27].Trim(),//Estado SUNAT
                        item[1].ToString().Trim(),//Serie - número
                        item[2].ToString().Trim(),//Fecha de emisión
                        item[21].ToString().Trim(),//Ruc
                        item[23].ToString().Trim(),//Razón social
                        item[28].ToString().Trim(),//Razón social
                        item[27].ToString().Trim(),//Razón social
                        item[35].ToString().Trim(),//Fecha de envío
                        item[32].ToString().Trim(),//Comentario de sunat
                        item[33].ToString().Trim()//Incluido en resumen diario
                    );
                }

                foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                {
                    switch (row.Cells[10].Value.ToString())
                    {
                        case "1":
                            row.Cells[4].Style.ForeColor = Color.Red;//Pendiente (errores)
                            Seleccionar.ReadOnly = false;
                            break;
                        case "2":
                            row.Cells[4].Style.ForeColor = Color.RoyalBlue;//Pendiente (correcto)
                            break;
                        case "0":
                            row.Cells[4].Style.ForeColor = Color.Green;//Enviado
                            break;
                    }
                    row.Cells[4].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(row.Cells[10].Value)).ToUpper();
                    switch (row.Cells[11].Value.ToString())
                    {
                        case "0":
                            row.Cells[5].Style.ForeColor = Color.Green;//Aceptado
                            break;
                        case "1":
                            row.Cells[5].Style.ForeColor = Color.Brown;//Rechazado
                            break;
                        case "2":
                            row.Cells[5].Style.ForeColor = Color.Red;//Sin respuesta
                            break;
                        case "3":
                            row.Cells[5].Style.ForeColor = Color.Salmon;//Anulado
                            break;
                    }
                    row.Cells[5].Value = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(row.Cells[11].Value)).ToUpper();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar items.Revise archivo de errores");
                clsBaseLog.cs_pxRegistarAdd("frmResumendiarioOpciones_Load " + ex.ToString());
            }
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
