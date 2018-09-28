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
using System.Configuration;
using FEI.Extension.Datos;
using FEI.Extension.Base;
using System.Text.RegularExpressions;

namespace FEI.Usuario
{
    public partial class frmDeclarante : frmBaseFormularios
    {
        private string cs_cmModo = "";
        private clsEntityDeclarant entidad_declarante;
        public frmDeclarante(string modo, string id)
        {
            InitializeComponent();
            this.cs_cmModo = modo;
            switch (cs_cmModo)
            {
                case "UPD":
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtRUC.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuariosol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonsocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClavesol.Text = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadodigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadodigitalclave.Text = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    break;
                case "INS":
                    entidad_declarante = new clsEntityDeclarant();
                    txtRUC.Text = "";
                    txtUsuariosol.Text = "";
                    txtRazonsocial.Text = "";
                    txtClavesol.Text = "";
                    txtCertificadodigital.Text = "";
                    txtCertificadodigitalclave.Text = "";
                    txtEmail.Text = "";
                    break;
                case "DLT":
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtRUC.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuariosol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonsocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClavesol.Text = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadodigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadodigitalclave.Text = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    txtRUC.Enabled = false;
                    txtUsuariosol.Enabled = false;
                    txtRazonsocial.Enabled = false;
                    txtClavesol.Enabled = false;
                    txtCertificadodigital.Enabled = false;
                    txtCertificadodigitalclave.Enabled = false;
                    txtEmail.Enabled = false;
                    this.btnGuardar.Text = "Eliminar";
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (cs_cmModo)
            {
                case "UPD":
                    entidad_declarante.Cs_pr_Ruc = txtRUC.Text;
                    entidad_declarante.Cs_pr_RazonSocial = txtRazonsocial.Text;
                    entidad_declarante.Cs_pr_Usuariosol = txtUsuariosol.Text;
                    entidad_declarante.Cs_pr_Clavesol = txtClavesol.Text;
                    entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadodigital.Text;
                    entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadodigitalclave.Text;
                    entidad_declarante.Cs_pr_Email = txtEmail.Text;
                    if (this.txtRUC.Text.Trim().Length > 0
                        && this.txtRazonsocial.Text.Trim().Length > 0
                        && this.txtUsuariosol.Text.Trim().Length > 0
                        && this.txtClavesol.Text.Trim().Length > 0
                        && this.txtCertificadodigital.Text.Trim().Length > 0
                        && this.txtCertificadodigitalclave.Text.Trim().Length > 0
                        && this.txtEmail.Text.Trim().Length > 0
                        )
                    {
                        entidad_declarante.cs_pxActualizar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "INS":
                    entidad_declarante.Cs_pr_Declarant_Id = Guid.NewGuid().ToString();
                    entidad_declarante.Cs_pr_Ruc = txtRUC.Text;
                    entidad_declarante.Cs_pr_RazonSocial = txtRazonsocial.Text;
                    entidad_declarante.Cs_pr_Usuariosol = txtUsuariosol.Text;
                    entidad_declarante.Cs_pr_Clavesol = txtClavesol.Text;
                    entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadodigital.Text;
                    entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadodigitalclave.Text;
                    entidad_declarante.Cs_pr_Email = txtEmail.Text;
                    if (this.txtRUC.Text.Trim().Length > 0
                        && this.txtRazonsocial.Text.Trim().Length > 0
                        && this.txtUsuariosol.Text.Trim().Length > 0
                        && this.txtClavesol.Text.Trim().Length > 0
                        && this.txtCertificadodigital.Text.Trim().Length > 0
                        && this.txtCertificadodigitalclave.Text.Trim().Length > 0
                        && this.txtEmail.Text.Trim().Length > 0
                        )
                    {
                        entidad_declarante.cs_pxInsertar(false);
                        clsEntityAccount account = new clsEntityAccount();
                        account.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                        account.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        account.Cs_pr_Users_Id = "01";
                        account.cs_pxInsertar(false);

                        clsEntityDatabaseLocal bdlocal = new clsEntityDatabaseLocal();
                        bdlocal.Cs_pr_DatabaseLocal_Id = Guid.NewGuid().ToString();
                        bdlocal.Cs_pr_DBMS = "Microsoft SQL Server";
                        bdlocal.Cs_pr_DBMSDriver = "SQL Server";
                        bdlocal.Cs_pr_DBMSServername = "SERVERNAME_REGISTERS";
                        bdlocal.Cs_pr_DBMSServerport = "1433";
                        bdlocal.Cs_pr_DBName = "cs_bdfei";
                        bdlocal.Cs_pr_DBPassword = "CLAVE";
                        bdlocal.Cs_pr_DBUse = "T";
                        bdlocal.Cs_pr_DBUser = "USUARIO";
                        bdlocal.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        bdlocal.cs_pxInsertar(false);

                        clsEntityDatabaseWeb bdweb = new clsEntityDatabaseWeb();
                        bdweb.Cs_pr_DatabaseWeb_Id = Guid.NewGuid().ToString();
                        bdweb.Cs_pr_DBMS = "Microsoft SQL Server";
                        bdweb.Cs_pr_DBMSDriver = "SQL Server";
                        bdweb.Cs_pr_DBMSServername = "SERVERNAME_WEBPUBLICATION";
                        bdweb.Cs_pr_DBMSServerport = "1433";
                        bdweb.Cs_pr_DBName = "cs_bdfei_web";
                        bdweb.Cs_pr_DBPassword = "CLAVE";
                        bdweb.Cs_pr_DBUse = "T";
                        bdweb.Cs_pr_DBUser = "USUARIO";
                        bdweb.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        bdweb.cs_pxInsertar(false);

                        clsEntityAlarms alarms = new clsEntityAlarms();
                        alarms.Cs_pr_Alarms_Id = Guid.NewGuid().ToString();
                        alarms.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        alarms.Cs_pr_Envioautomatico = "T";
                        alarms.Cs_pr_Envioautomatico_hora = "T";
                        alarms.Cs_pr_Envioautomatico_horavalor = DateTime.Now.ToString();
                        alarms.Cs_pr_Envioautomatico_minutos = "F";
                        alarms.Cs_pr_Envioautomatico_minutosvalor = "6";
                        alarms.Cs_pr_Enviomanual = "F";
                        alarms.Cs_pr_Enviomanual_mostrarglobo = "F";
                        alarms.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = "10";
                        alarms.Cs_pr_Enviomanual_nomostrarglobo = "T";
                        alarms.Cs_pr_Iniciarconwindows = "F";
                        alarms.cs_pxInsertar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                  
                    break;
                case "DLT":
                    if (new clsBaseConfiguracion().Cs_pr_Declarant_Id == entidad_declarante.Cs_pr_Declarant_Id)
                    {
                        if (MessageBox.Show("La empresa seleccionada y su base de datos actual está en uso;\n¿seguro que desea eliminar esta empresa? \n(Debe reiniciar el programa).","¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            entidad_declarante.Cs_pr_Ruc = txtRUC.Text;
                            entidad_declarante.Cs_pr_RazonSocial = txtRazonsocial.Text;
                            entidad_declarante.Cs_pr_Usuariosol = txtUsuariosol.Text;
                            entidad_declarante.Cs_pr_Clavesol = txtClavesol.Text;
                            entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadodigital.Text;
                            entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadodigitalclave.Text;
                            entidad_declarante.Cs_pr_Email = txtEmail.Text;
                            entidad_declarante.cs_pxElimnar(false);
                            new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id,"").cs_pxElimnar(false);
                            new clsEntityAccount().cs_pxEliminarCuentasAsociadasEMPRESA(entidad_declarante.Cs_pr_Declarant_Id);
                            //Eliminar las cuentas asociadas
                        }
                    }
                    else
                    {
                        entidad_declarante.Cs_pr_Ruc = txtRUC.Text;
                        entidad_declarante.Cs_pr_RazonSocial = txtRazonsocial.Text;
                        entidad_declarante.Cs_pr_Usuariosol = txtUsuariosol.Text;
                        entidad_declarante.Cs_pr_Clavesol = txtClavesol.Text;
                        entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadodigital.Text;
                        entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadodigitalclave.Text;
                        entidad_declarante.Cs_pr_Email = txtEmail.Text;
                        entidad_declarante.cs_pxElimnar(false);
                        new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                        new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                        new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id,"").cs_pxElimnar(false);
                        //Eliminar las cuentas asociadas
                    }
                    break;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDeclarante_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back;
           // e.Handled = !char.IsDigit(e.KeyChar);
        }
        public bool ValidateEmail(string emailAddress)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Match matches = Regex.Match(emailAddress, regexPattern);
            return matches.Success;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Ingrese email valido");
            }
           
        }
    }
}
