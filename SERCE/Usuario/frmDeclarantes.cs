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
    public partial class frmDeclarantes : frmBaseFormularios
    {
        public frmDeclarantes()
        {
            InitializeComponent();
        }
        
        private void frmDeclarantes_Load(object sender, EventArgs e)
        {
            dgvDeclarantes.Rows.Clear();
            List<clsEntityDeclarant> entidades = new clsEntityDeclarant().cs_pxObtenerTodo();
            foreach (var item in entidades)
            {
                dgvDeclarantes.Rows.Add(
                    item.Cs_pr_Declarant_Id,
                    item.Cs_pr_Ruc,
                    item.Cs_pr_RazonSocial
                );
            }
            if (dgvDeclarantes.Rows.Count <= 0)
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            else
            {
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDeclarante Formulario = new frmDeclarante("INS", "");
            if (Formulario.ShowDialog(this) == DialogResult.OK)
            {
                cs_pxDgvcambio();
            }
            Formulario.Dispose();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmDeclarante Formulario = new frmDeclarante("UPD", this.dgvDeclarantes.CurrentRow.Cells[0].Value.ToString());
            if (Formulario.ShowDialog() == DialogResult.OK)
            {
                cs_pxDgvcambio();
            }
            Formulario.Dispose();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmDeclarante Formulario = new frmDeclarante("DLT", this.dgvDeclarantes.CurrentRow.Cells[0].Value.ToString());
            if (Formulario.ShowDialog() == DialogResult.OK)
            {
                cs_pxDgvcambio();
            }
            Formulario.Dispose();
        }

        private void cs_pxDgvcambio()
        {
            dgvDeclarantes.Rows.Clear();
            List<clsEntityDeclarant> entidades = new clsEntityDeclarant().cs_pxObtenerTodo();
            foreach (var item in entidades)
            {
                dgvDeclarantes.Rows.Add(
                    item.Cs_pr_Declarant_Id,
                    item.Cs_pr_Ruc,
                    item.Cs_pr_RazonSocial
                );
            }
            if (dgvDeclarantes.Rows.Count <= 0)
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            else
            {
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        DialogResult resultado = DialogResult.Abort;

        private void dgvDeclarantes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDeclarantes.Rows.Count>0)
            {
                frmDeclarante Formulario = new frmDeclarante("UPD", this.dgvDeclarantes.CurrentRow.Cells[0].Value.ToString());
                if (Formulario.ShowDialog() == DialogResult.OK)
                {
                    cs_pxDgvcambio();
                    resultado = DialogResult.OK;
                }
                Formulario.Dispose();
            }
        }

        private void frmDeclarantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void verInformaciónDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
