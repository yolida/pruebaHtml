using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;

namespace FEI.Usuario
{
    public partial class frmLogin : frmBaseFormularios
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool regla_login = false, regla_account = false;

            string userid = new clsEntityUsers().cs_pxLogin(this.txtUsuario.Text, this.txtContrasenia.Text);
            if (userid.Length > 0)
            {
                regla_login = true;
            }
            
            string seleccion_empresa;
            if (cboEmpresa.Enabled == false)
            {
                seleccion_empresa = "";
            }
            else
            {
                seleccion_empresa = cboEmpresa.SelectedValue.ToString();
                clsEntityDatabaseLocal bd = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(seleccion_empresa);
                clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                configuracion.cs_prDbms = bd.Cs_pr_DBMS;
                configuracion.cs_prDbmsdriver = bd.Cs_pr_DBMSDriver;
                configuracion.cs_prDbmsservidor = bd.Cs_pr_DBMSServername;
                configuracion.cs_prDbmsservidorpuerto = bd.Cs_pr_DBMSServerport;
                configuracion.cs_prDbnombre = bd.Cs_pr_DBName;
                configuracion.cs_prDbusuario = bd.Cs_pr_DBUser;
                configuracion.cs_prDbclave = bd.Cs_pr_DBPassword;
                configuracion.Cs_pr_Declarant_Id = seleccion_empresa;
                configuracion.cs_pxActualizar(false);
            }

            clsEntityAccount Profile = new clsEntityAccount();
            string Profile_Id = Profile.dgvVerificarCuenta(userid, seleccion_empresa);
            if (Profile_Id != "")
            {
                regla_account = true;
            }

            if (regla_login == true && regla_account == true)
            {
               // this.Close();
                Hide();
                clsBaseConexion con = new clsBaseConexion();
                bool estado = con.cs_fxConexionEstadoServidor();
                if (estado == true)
                {                   
                    bool actualizar = new clsEntityDatabaseLocal().cs_pxSeDebeActualizarBD();
                    if (actualizar)
                    {
                        if (MessageBox.Show("Es necesario actualizar la estructura de la base de datos.Si escoge continuar se realizara ahora, caso contrario puede hacerlo despues utilizando la opcion verificar estructura.\n ¿Desea continuar?", "Verificar estructura - Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            new frmLoading().ShowDialog();
                        }
                    }
                }
                new frmSistema(new clsEntityAccount().cs_fxObtenerUnoPorId(Profile_Id)).Show();
            }
            else
            {
                clsBaseMensaje.cs_pxMsgEr("ERR12", "Error de inicio de sesión.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (new clsEntityDeclarant().cs_pxObtenerTodo().Count>0)
                {
                    cboEmpresa.DataSource = new clsEntityDeclarant().cs_pxObtenerTodo();
                    cboEmpresa.ValueMember = "Cs_pr_Declarant_Id";
                    cboEmpresa.DisplayMember = "Cs_pr_RazonSocial";
                }
                else
                {
                    cboEmpresa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("frmLogin_Load "+ ex.ToString());
            }
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar_Click(this, new EventArgs());
            }
        }
    }
}
