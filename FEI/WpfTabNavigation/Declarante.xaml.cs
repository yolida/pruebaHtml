using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
/// <summary>
///  Jordy Amaro 12-01-17 FEI2-4
///  Cambio de interfaz - Ventana de configuracion del declarante. Sera llamado desde otra interfaz.
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Declarante.xaml
    /// </summary>
    public partial class Declarante : Window
    {
        private string cs_cmModo = "";
        private clsEntityDeclarant entidad_declarante;
        //Constructor clase
        public Declarante(string modo, string id)
        {
            InitializeComponent();
            this.cs_cmModo = modo;
            //Elegir entre las diferentes acciones a realizar en el fomrulario.
            switch (cs_cmModo)
            {
                case "UPD":
                    //actualizar
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtRuc.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuarioSol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonSocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClaveSol.Text = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadoDigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadoDigitalClave.Text = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    break;
                case "INS":
                    //insertar
                    entidad_declarante = new clsEntityDeclarant();
                    txtRuc.Text = "";
                    txtUsuarioSol.Text = "";
                    txtRazonSocial.Text = "";
                    txtClaveSol.Text = "";
                    txtCertificadoDigital.Text = "";
                    txtCertificadoDigitalClave.Text = "";
                    txtEmail.Text = "";
                    break;
                case "DLT":
                    //eliminar
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtRuc.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuarioSol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonSocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClaveSol.Text = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadoDigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadoDigitalClave.Text = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    txtRuc.IsEnabled = false;
                    txtUsuarioSol.IsEnabled = false;
                    txtRazonSocial.IsEnabled = false;
                    txtClaveSol.IsEnabled = false;
                    txtCertificadoDigital.IsEnabled = false;
                    txtCertificadoDigitalClave.IsEnabled = false;
                    txtEmail.IsEnabled = false;
                    this.btnGuardar.Content = "Eliminar";
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Guardar los cambios realizados segun opcion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Seleccionar acciones segun el modo elegido.
            switch (cs_cmModo)
            {
                case "UPD":
                    //Modo :: Actualizar
                    entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                    entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                    entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                    entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Text;
                    entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                    entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Text;
                    entidad_declarante.Cs_pr_Email = txtEmail.Text;
                    if (this.txtRuc.Text.Trim().Length > 0
                        && this.txtRazonSocial.Text.Trim().Length > 0
                        && this.txtUsuarioSol.Text.Trim().Length > 0
                        && this.txtClaveSol.Text.Trim().Length > 0
                        && this.txtCertificadoDigital.Text.Trim().Length > 0
                        && this.txtCertificadoDigitalClave.Text.Trim().Length > 0
                        && this.txtEmail.Text.Trim().Length > 0
                        )
                    {
                        //Si los campos no estan vacios.
                        entidad_declarante.cs_pxActualizar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "INS":
                    //Modo :: Insertar
                    entidad_declarante.Cs_pr_Declarant_Id = Guid.NewGuid().ToString();
                    entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                    entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                    entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                    entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Text;
                    entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                    entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Text;
                    entidad_declarante.Cs_pr_Email = txtEmail.Text;
                    if (this.txtRuc.Text.Trim().Length > 0
                        && this.txtRazonSocial.Text.Trim().Length > 0
                        && this.txtUsuarioSol.Text.Trim().Length > 0
                        && this.txtClaveSol.Text.Trim().Length > 0
                        && this.txtCertificadoDigital.Text.Trim().Length > 0
                        && this.txtCertificadoDigitalClave.Text.Trim().Length > 0
                        && this.txtEmail.Text.Trim().Length > 0
                        )
                    {
                        //Si los campos no estan vacios insertar informacion del declarante.
                        entidad_declarante.cs_pxInsertar(false);
                        //crear la cuenta
                        clsEntityAccount account = new clsEntityAccount();
                        account.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                        account.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        account.Cs_pr_Users_Id = "01";
                        account.cs_pxInsertar(false);
                        //crear la configuracion local
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
                        //crear la configuracion web.
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
                        //Crear la configuracion de alertas para facturas y notas.
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
                        //Crear la configuracion de alertas para resumen diario.
                        DateTime hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
                        clsEntityAlarms alarmsRD = new clsEntityAlarms();
                        alarmsRD.Cs_pr_Alarms_Id = Guid.NewGuid().ToString();
                        alarmsRD.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                        alarmsRD.Cs_pr_Envioautomatico = "T";
                        alarmsRD.Cs_pr_Envioautomatico_hora = "T";
                        alarmsRD.Cs_pr_Envioautomatico_horavalor = hora_base.ToLongTimeString();
                        alarmsRD.Cs_pr_Envioautomatico_minutos = "F";
                        alarmsRD.Cs_pr_Envioautomatico_minutosvalor = "1";
                        alarmsRD.Cs_pr_Enviomanual = "F";
                        alarmsRD.Cs_pr_Enviomanual_mostrarglobo = "F";
                        alarmsRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = "10";
                        alarmsRD.Cs_pr_Enviomanual_nomostrarglobo = "F";
                        alarmsRD.Cs_pr_Iniciarconwindows = "F";
                        alarmsRD.Cs_pr_Tipo = "1";
                        alarmsRD.cs_pxInsertar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }

                    break;
                case "DLT":
                    //Modo :: Eliminar
                    if (new clsBaseConfiguracion().Cs_pr_Declarant_Id == entidad_declarante.Cs_pr_Declarant_Id)
                    {
                        if (System.Windows.Forms.MessageBox.Show("La empresa seleccionada y su base de datos actual está en uso;\n¿seguro que desea eliminar esta empresa? \n(Debe reiniciar el programa).", "¿Está seguro?",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                            entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                            entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                            entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Text;
                            entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                            entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Text;
                            entidad_declarante.Cs_pr_Email = txtEmail.Text;
                            entidad_declarante.cs_pxElimnar(false);
                            new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "").cs_pxElimnar(false);
                            new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "1").cs_pxElimnar(false);
                            new clsEntityAccount().cs_pxEliminarCuentasAsociadasEMPRESA(entidad_declarante.Cs_pr_Declarant_Id);
                            //Eliminar las cuentas asociadas
                        }
                    }
                    else
                    {
                        entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                        entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                        entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                        entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Text;
                        entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                        entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Text;
                        entidad_declarante.Cs_pr_Email = txtEmail.Text;
                        entidad_declarante.cs_pxElimnar(false);
                        new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                        new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                        new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "").cs_pxElimnar(false);
                        new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "1").cs_pxElimnar(false);
                        //Eliminar las cuentas asociadas
                    }
                    break;
            }
            DialogResult = true;
            Close();
        }
        //Evento de cierre de la ventana de configuracion del declarante.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }
    }
}
