using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERCE.Usuario
{
    public partial class frmUsuarioCuentas : frmBaseFormularios
    {
        string Id = "";
        public frmUsuarioCuentas(string Id)
        {
            this.Id = Id;
            InitializeComponent();
        }

        private void frmUsuarioCuentas_Load(object sender, EventArgs e)
        {
            cs_pxCargarEmpresasLista();
            cs_pxCargarEmpresasGrid(Id);
            foreach (DataGridViewRow row in dgvEmpresas.Rows)
            {
                row.Cells[1].Value = false;
            }
        }

        private void cs_pxCargarEmpresasLista()
        {
            List<clsEntityDeclarant> empresas = new clsEntityDeclarant().cs_pxObtenerTodo();
            if (empresas.Count>0 || empresas == null)
            {
                cboEmpresas.DataSource = new clsEntityDeclarant().cs_pxObtenerTodo();
                cboEmpresas.ValueMember = "Cs_pr_Declarant_Id";
                cboEmpresas.DisplayMember = "Cs_pr_RazonSocial";
            }
        }

        private void cs_pxCargarEmpresasGrid(string Id)
        {
            List<clsEntityAccount> cuentas = new clsEntityAccount().dgvEmpresasUsuario(Id);
            if (cuentas.Count > 0 || cuentas == null)
            {
                foreach (var item in cuentas)
                {
                    if (item.Cs_pr_Declarant_Id!="")
                    {
                        try
                        {
                            clsEntityDeclarant clsEntityDeclarant = new clsEntityDeclarant().cs_pxObtenerUnoPorId(item.Cs_pr_Declarant_Id);
                            dgvEmpresas.Rows.Add(item.Cs_pr_Account_Id, false, clsEntityDeclarant.Cs_pr_RazonSocial);
                        }
                        catch (Exception)
                        {

                        }
                                             
                    }
                }
            }

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEmpresas.Items.Count > 0)
            {
                string declarant = cboEmpresas.SelectedValue.ToString();
                if (new clsEntityAccount().dgvCuentaDuplicada(Id, declarant) == false)
                {
                    clsEntityAccount cuenta = new clsEntityAccount();
                    cuenta.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                    cuenta.Cs_pr_Declarant_Id = declarant;
                    cuenta.Cs_pr_Users_Id = Id;
                    cuenta.cs_pxInsertar(false);
                    dgvEmpresas.Rows.Clear();
                    cs_pxCargarEmpresasLista();
                    cs_pxCargarEmpresasGrid(Id);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if ( new clsEntityUsers().cs_pxObtenerUnoPorId(Id).Cs_pr_Role_Id.ToUpper() != "ADMIN")
            {
                if (dgvEmpresas.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvEmpresas.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            clsEntityAccount cuenta = new clsEntityAccount().cs_fxObtenerUnoPorId(row.Cells[0].Value.ToString());
                            cuenta.cs_pxElimnar(false);
                        }
                    }
                    dgvEmpresas.Rows.Clear();
                    cs_pxCargarEmpresasLista();
                    cs_pxCargarEmpresasGrid(Id);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
