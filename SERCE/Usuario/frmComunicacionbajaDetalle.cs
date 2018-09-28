using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using SERCE.Usuario;
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
    public partial class frmComunicacionbajaDetalle : frmBaseFormularios
    {
        private string id_comunicacionbaja;

        public frmComunicacionbajaDetalle(string id_resumendiario)
        {
            this.id_comunicacionbaja = id_resumendiario;
            InitializeComponent();
        }

        private void cs_pxCargarGrid()
        {
            try
            {
                clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(new clsBaseConfiguracion().Cs_pr_Declarant_Id);
                clsEntityVoidedDocuments rd = new clsEntityVoidedDocuments().cs_fxObtenerUnoPorId(id_comunicacionbaja);
                txtDocumento.Text = rd.Cs_tag_ID;
                txtFechaemision.Text = rd.Cs_tag_IssueDate;
                txtRazonsocial.Text = declarante.Cs_pr_RazonSocial;
                txtRuc.Text = declarante.Cs_pr_Ruc;

                dgvComprobanteselectronicos.Rows.Clear();
                List<List<string>> registros = new clsEntityDocument().cs_pxObtenerDocumentosPorComunicacionBaja(id_comunicacionbaja);

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
                        item[33].ToString().Trim(),//Incluido en resumen diario
                        item[37].ToString().Trim(),//Incluido en comunicación de baja
                        new clsEntityVoidedDocuments_VoidedDocumentsLine().cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(item[0], item[37]).Cs_tag_VoidReasonDescription//Motivo de baja de comprobantes
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmResumendiarioOpciones_Load(object sender, EventArgs e)
        {
            cs_pxCargarGrid();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarComentarioDeComunicaciónDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new frmComunicacionbajaMotivo(new clsEntityVoidedDocuments_VoidedDocumentsLine().cs_fxObtenerUnoPorDocumentoPrincipalYDocumentoRelacionado(dgvComprobanteselectronicos.CurrentRow.Cells[0].Value.ToString(), dgvComprobanteselectronicos.CurrentRow.Cells[15].Value.ToString()).Cs_pr_VoidedDocuments_VoidedDocumentsLine_Id).ShowDialog() == DialogResult.OK)
            {
                cs_pxCargarGrid();
            }
        }

        private void descartarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que descartar este documento?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new clsEntityVoidedDocuments_VoidedDocumentsLine().cs_fxDescartarDocumento(dgvComprobanteselectronicos.CurrentRow.Cells[0].Value.ToString(), dgvComprobanteselectronicos.CurrentRow.Cells[15].Value.ToString());
                cs_pxCargarGrid();
            }
        }

        private void frmComunicacionbajaDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Jordy Amaro 09-12-16 FE-906
            //CAmbio para no cargar el grid nuevamente de este formulario y agregar el dialog result para obtener estado desde el form comunicacion de baja.
            //Ini-Modifica 
            if (new clsEntityVoidedDocuments().cs_fxCantidadElementos(id_comunicacionbaja) <= 0)
            {
                new clsNegocioCEComunicacionBaja().cs_pxDescartarDocumento(id_comunicacionbaja);
                //cs_pxCargarGrid();
            }
            DialogResult = DialogResult.OK;
            //Fin-Modifica
        }
    }
}
