
using FEI.Extension.Base;
using FEI.Extension.Datos;
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
    public partial class frmUsuarios : frmBaseFormularios
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario Formulario = new frmUsuario("INS", "");
            if (Formulario.ShowDialog(this) == DialogResult.OK)
            {
                cs_pxDgvcambio();
            }
            Formulario.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count>0)
            {
                frmUsuario Formulario = new frmUsuario("UPD", this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (Formulario.ShowDialog() == DialogResult.OK)
                {
                    cs_pxDgvcambio();
                }
                Formulario.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                frmUsuario Formulario = new frmUsuario("DLT", this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (Formulario.ShowDialog() == DialogResult.OK)
                {
                    cs_pxDgvcambio();
                }
                Formulario.Dispose();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCatalogositem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                frmUsuario Formulario = new frmUsuario("UPD", this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (Formulario.ShowDialog() == DialogResult.OK)
                {
                    cs_pxDgvcambio();
                }
                Formulario.Dispose();
            }
        }

        private void cs_pxDgvcambio()
        {
            dgvUsuarios.Rows.Clear();
            List<List<string>> registros = new clsEntityUsers().cs_pxObtenerTodo();
            foreach (var item in registros)
            {
                dgvUsuarios.Rows.Add(
                    item[0].ToString().Trim(),
                    item[1].ToString().Trim(),
                    item[3].ToString().Trim()
                );
            }
            if (dgvUsuarios.Rows.Count <= 0)
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cs_pxDgvcambio();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                frmUsuarioCuentas Formulario = new frmUsuarioCuentas(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (Formulario.ShowDialog() == DialogResult.OK)
                {
                    cs_pxDgvcambio();
                }
                Formulario.Dispose();
            }
        }
    }
}
