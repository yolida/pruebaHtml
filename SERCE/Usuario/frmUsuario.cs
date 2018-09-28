using FEI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FEI.Extension.Base;
using FEI.Extension.Datos;

namespace FEI.Usuario
{
    public partial class frmUsuario : frmBaseFormularios
    {
        private clsEntityUsers user;
        private clsBaseConfiguracion entidad_usuario;
        private string cs_cmModo = "";
        private List<List<string>> empresas = new List<List<string>>();

        public frmUsuario(string modo, string id)
        {
            InitializeComponent();
            /** Antiguo */
            entidad_usuario = new clsBaseConfiguracion();
            txtUsuario.Text = entidad_usuario.cs_prLoginUsuario;
            txtClave.Text = entidad_usuario.cs_prLoginPassword;
            /** Fin-Antiguo */

            this.cs_cmModo = modo;
            switch (cs_cmModo)
            {
                case "UPD":
                    user = new clsEntityUsers().cs_pxObtenerUnoPorId(id);
                    txtUsuario.Text = user.Cs_pr_User;
                    txtClave.Text = user.Cs_pr_Password;
                    break;
                case "INS":
                    user = new clsEntityUsers();
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    break;
                case "DLT":
                    user = new clsEntityUsers().cs_pxObtenerUnoPorId(id);
                    txtUsuario.Text = user.Cs_pr_User;
                    txtUsuario.Enabled = false;
                    txtClave.Text = user.Cs_pr_Password;
                    txtClave.Enabled = false;
                    this.btnGuardar.Text = "Eliminar";
                    break;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (cs_cmModo)
            {
                case "UPD":
                    /** Antiguo */
                    entidad_usuario.cs_prLoginUsuario = txtUsuario.Text;
                    entidad_usuario.cs_prLoginPassword = txtClave.Text;
                    /** Fin-Antiguo */
                    user.Cs_pr_User = txtUsuario.Text;
                    user.Cs_pr_Password = txtClave.Text;
                    if (txtUsuario.Text.Trim().Length > 0 && txtClave.Text.Trim().Length > 0)
                    {
                        /** Antiguo */
                        //entidad_usuario.cs_pxActualizar(true);
                        /** Fin-Antiguo */
                        user.cs_pxActualizar(true);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "INS":
                    user = new clsEntityUsers();
                    user.Cs_pr_Users_Id = Guid.NewGuid().ToString();
                    user.Cs_pr_User = txtUsuario.Text;
                    user.Cs_pr_Password = txtClave.Text;
                    user.Cs_pr_Role_Id = "USER";
                    if (txtUsuario.Text.Trim().Length > 0 && txtClave.Text.Trim().Length > 0)
                    {
                        user.cs_pxInsertar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "DLT":
                    if (user.Cs_pr_Role_Id.Trim().ToUpper() == "ADMIN")
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR22", "No se puede eliminar el administrador.");
                    }
                    else
                    {
                        user.cs_pxElimnar(false);
                        //Además eliminar las cuentas relacionadas a este usuario.
                        new clsEntityAccount().cs_pxEliminarCuentasAsociadasUSUARIO(user.Cs_pr_Users_Id);
                    }
                    break;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pxCargarCboEmpresas(){
            /*
            cboEmpresa.Items.Clear();
            List<clsEntityDeclarant> empresas = new clsEntityDeclarant().cs_pxObtenerTodo();
            cboEmpresa.DataSource = null;
            cboEmpresa.DataSource = empresas;
            cboEmpresa.DisplayMember = "Cs_pr_RazonSocial";
            cboEmpresa.ValueMember = "Cs_pr_Declarant_Id";*/
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            pxCargarCboEmpresas();
        }
    }
}
