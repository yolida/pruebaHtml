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
        private clsEntityDatabaseLocal localDB;
        //Constructor clase
        public Declarante(string modo, string id, clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
            this.cs_cmModo = modo;
            //Elegir entre las diferentes acciones a realizar en el fomrulario.
            switch (cs_cmModo)
            {
                case "UPD":
                    //actualizar
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtCodigo.Text = entidad_declarante.Cs_pr_Declarant_Id;
                    txtRuc.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuarioSol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonSocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClaveSol.Password = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadoDigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadoDigitalClave.Password = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    txtCodigo.IsEnabled = false;
                    break;
                case "INS":
                    //insertar
                    entidad_declarante = new clsEntityDeclarant();
                    txtCodigo.Text = "";
                    txtRuc.Text = "";
                    txtUsuarioSol.Text = "";
                    txtRazonSocial.Text = "";
                    txtClaveSol.Password = "";
                    txtCertificadoDigital.Text = "";
                    txtCertificadoDigitalClave.Password = "";
                    txtEmail.Text = "";
                    break;
                case "DLT":
                    //eliminar
                    entidad_declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(id);
                    txtCodigo.Text = entidad_declarante.Cs_pr_Declarant_Id;
                    txtRuc.Text = entidad_declarante.Cs_pr_Ruc;
                    txtUsuarioSol.Text = entidad_declarante.Cs_pr_Usuariosol;
                    txtRazonSocial.Text = entidad_declarante.Cs_pr_RazonSocial;
                    txtClaveSol.Password = entidad_declarante.Cs_pr_Clavesol;
                    txtCertificadoDigital.Text = entidad_declarante.Cs_pr_Rutacertificadodigital;
                    txtCertificadoDigitalClave.Password = entidad_declarante.Cs_pr_Parafrasiscertificadodigital;
                    txtEmail.Text = entidad_declarante.Cs_pr_Email;
                    txtCodigo.IsEnabled = false;
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

        private int existeCambios(clsEntityDeclarant declarante)
        {
            int cambios = 0;
            if(declarante.Cs_pr_Ruc != txtRuc.Text.Trim())
            {
                cambios++;
            }          
            if (declarante.Cs_pr_RazonSocial != txtRazonSocial.Text.Trim())
            {
                cambios++;
            }                    
            if (declarante.Cs_pr_Usuariosol != txtUsuarioSol.Text.Trim())
            {
                cambios++;
            }          
            if (declarante.Cs_pr_Clavesol != txtClaveSol.Password.Trim())
            {
                cambios++;
            }
           
            if (declarante.Cs_pr_Rutacertificadodigital != txtCertificadoDigital.Text.Trim())
            {
                cambios++;
            }
           
            if (declarante.Cs_pr_Parafrasiscertificadodigital != txtCertificadoDigitalClave.Password.Trim())
            {
                cambios++;
            }
           
            if (declarante.Cs_pr_Email != txtEmail.Text.Trim())
            {
                cambios++;
            }          
            return cambios;
        }
        /// <summary>
        /// Guardar los cambios realizados segun opcion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            bool cerrarVentana = false;
            //Seleccionar acciones segun el modo elegido.
            switch (cs_cmModo)
            {
                case "UPD":
                    //Modo :: Actualizar
                    
                    if (existeCambios(entidad_declarante)>0)
                    {
                        entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                        entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                        entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                        entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Password;
                        entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                        entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Password;
                        entidad_declarante.Cs_pr_Email = txtEmail.Text;
                        if (this.txtRuc.Text.Trim().Length > 0
                            && this.txtRazonSocial.Text.Trim().Length > 0
                            && this.txtUsuarioSol.Text.Trim().Length > 0
                            && this.txtClaveSol.Password.Trim().Length > 0
                            && this.txtCertificadoDigital.Text.Trim().Length > 0
                            && this.txtCertificadoDigitalClave.Password.Trim().Length > 0
                            && this.txtEmail.Text.Trim().Length > 0
                           )
                        {
                            //Si los campos no estan vacios.
                            entidad_declarante.cs_pxActualizar(false);
                            //buscar si esta sociado al master
                            string account = new clsEntityAccount().dgvVerificarCuenta("02", entidad_declarante.Cs_pr_Declarant_Id);
                            if (account == "")
                            {
                                //noexiste la cuenta agregar
                                //crear la cuenta
                                clsEntityAccount accountMaster = new clsEntityAccount();
                                accountMaster.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                                accountMaster.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                                accountMaster.Cs_pr_Users_Id = "02";
                                accountMaster.cs_pxInsertar(false);
                                /*******************************************/
                            }
                            cerrarVentana = true;
                            System.Windows.Forms.MessageBox.Show("Los cambios se han guardado correctamente.", "Correcto - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("No deben existir campos vacíos.", "Advertencia - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           // clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No se han realizado cambios.", "Advertencia - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
                case "INS":
                    //Modo :: Insertar
                    entidad_declarante.Cs_pr_Declarant_Id = txtCodigo.Text;
                    entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                    entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                    entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                    entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Password;
                    entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                    entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Password;
                    entidad_declarante.Cs_pr_Email = txtEmail.Text;

                    //buscar el codigo ingresado
                    clsEntityDeclarant existe = new clsEntityDeclarant().cs_pxObtenerUnoPorId(txtCodigo.Text.Trim());
                    if (existe == null)
                    {

                        //no existe el codigo ingresado
                        if (this.txtCodigo.Text.Trim().Length > 0
                        && this.txtRuc.Text.Trim().Length > 0
                        && this.txtRazonSocial.Text.Trim().Length > 0
                        && this.txtUsuarioSol.Text.Trim().Length > 0
                        && this.txtClaveSol.Password.Trim().Length > 0
                        && this.txtCertificadoDigital.Text.Trim().Length > 0
                        && this.txtCertificadoDigitalClave.Password.Trim().Length > 0
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
                            //crear los permisos full a admin
                            /*List<clsEntityModulo> modulos = new clsEntityModulo().cs_pxObtenerTodo();
                            if (modulos != null)
                            {
                                foreach (clsEntityModulo item in modulos)
                                {
                                    clsEntityPermisos permiso = new clsEntityPermisos();
                                    permiso.Cs_pr_Permisos_Id = Guid.NewGuid().ToString();
                                    permiso.Cs_pr_Modulo = item.Cs_pr_Modulo_Id;
                                    permiso.Cs_pr_Cuenta = "01";
                                    permiso.Cs_pr_Permitido = "1";
                                    permiso.cs_pxInsertar(false);
                                }
                            }*/
                            /*****************Master********************/
                            //crear la cuenta
                            clsEntityAccount accountMaster = new clsEntityAccount();
                            accountMaster.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                            accountMaster.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                            accountMaster.Cs_pr_Users_Id = "02";
                            accountMaster.cs_pxInsertar(false);
                            //crear los permisos full a admin
                           /* List<clsEntityModulo> modulos_master = new clsEntityModulo().cs_pxObtenerTodo();
                            if (modulos_master != null)
                            {
                                foreach (clsEntityModulo item in modulos_master)
                                {
                                    clsEntityPermisos permiso = new clsEntityPermisos();
                                    permiso.Cs_pr_Permisos_Id = Guid.NewGuid().ToString();
                                    permiso.Cs_pr_Modulo = item.Cs_pr_Modulo_Id;
                                    permiso.Cs_pr_Cuenta = accountMaster.Cs_pr_Account_Id;
                                    permiso.Cs_pr_Permitido = "1";
                                    permiso.cs_pxInsertar(false);
                                }
                            }*/

                            /*******************************************/
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
                            DateTime hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
                            //Crear la configuracion de alertas para facturas y notas.
                            clsEntityAlarms alarms = new clsEntityAlarms();
                            alarms.Cs_pr_Alarms_Id = Guid.NewGuid().ToString();
                            alarms.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                            alarms.Cs_pr_Envioautomatico = "T";
                            alarms.Cs_pr_Envioautomatico_hora = "T";
                            alarms.Cs_pr_Envioautomatico_horavalor = hora_base.ToShortTimeString();
                            alarms.Cs_pr_Envioautomatico_minutos = "F";
                            alarms.Cs_pr_Envioautomatico_minutosvalor = "6";
                            alarms.Cs_pr_Enviomanual = "F";
                            alarms.Cs_pr_Enviomanual_mostrarglobo = hora_base.ToShortTimeString(); ;
                            alarms.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = "10";
                            alarms.Cs_pr_Enviomanual_nomostrarglobo = "T";
                            alarms.Cs_pr_Iniciarconwindows = "F";
                            alarms.cs_pxInsertar(false);
                            //Crear la configuracion de alertas para resumen diario.
                           
                            clsEntityAlarms alarmsRD = new clsEntityAlarms();
                            alarmsRD.Cs_pr_Alarms_Id = Guid.NewGuid().ToString();
                            alarmsRD.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                            alarmsRD.Cs_pr_Envioautomatico = "F";
                            alarmsRD.Cs_pr_Envioautomatico_hora = "T";
                            alarmsRD.Cs_pr_Envioautomatico_horavalor = hora_base.ToShortTimeString();
                            alarmsRD.Cs_pr_Envioautomatico_minutos = "F";
                            alarmsRD.Cs_pr_Envioautomatico_minutosvalor = "1";
                            alarmsRD.Cs_pr_Enviomanual = "F";
                            alarmsRD.Cs_pr_Enviomanual_mostrarglobo = hora_base.ToShortTimeString(); ;
                            alarmsRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = "10";
                            alarmsRD.Cs_pr_Enviomanual_nomostrarglobo = "F";
                            alarmsRD.Cs_pr_Iniciarconwindows = "F";
                            alarmsRD.Cs_pr_Tipo = "1";
                            alarmsRD.cs_pxInsertar(false);

                            //Crear la configuracion de alertas para resumen diario.

                            clsEntityAlarms alarmsRE = new clsEntityAlarms();
                            alarmsRE.Cs_pr_Alarms_Id = Guid.NewGuid().ToString();
                            alarmsRE.Cs_pr_Declarant_Id = entidad_declarante.Cs_pr_Declarant_Id;
                            alarmsRE.Cs_pr_Envioautomatico = "F";
                            alarmsRE.Cs_pr_Envioautomatico_hora = "T";
                            alarmsRE.Cs_pr_Envioautomatico_horavalor = hora_base.ToShortTimeString();
                            alarmsRE.Cs_pr_Envioautomatico_minutos = "F";
                            alarmsRE.Cs_pr_Envioautomatico_minutosvalor = "1";
                            alarmsRE.Cs_pr_Enviomanual = "F";
                            alarmsRE.Cs_pr_Enviomanual_mostrarglobo = hora_base.ToShortTimeString(); ;
                            alarmsRE.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = "10";
                            alarmsRE.Cs_pr_Enviomanual_nomostrarglobo = "F";
                            alarmsRE.Cs_pr_Iniciarconwindows = "F";
                            alarmsRE.Cs_pr_Tipo = "2";
                            alarmsRE.cs_pxInsertar(false);
                            System.Windows.Forms.MessageBox.Show("Los datos se han guardado correctamente.", "Correcto - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cerrarVentana = true;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("No deben existir campos vacíos.", "Advertencia - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                        }
                    }
                    else
                    {
                       System.Windows.Forms.MessageBox.Show("El codigo ingresado ya esta registrado. No puede existir mas de una empresa con el mismo código.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    

                    break;
                case "DLT":
                    //Modo :: Eliminar
                   
                    if (localDB.Cs_pr_Declarant_Id == entidad_declarante.Cs_pr_Declarant_Id)
                    {
                        if (System.Windows.Forms.MessageBox.Show("La empresa seleccionada y su base de datos actual está en uso;\n¿seguro que desea eliminar esta empresa? \n(Debe reiniciar el programa).", "¿Está seguro?",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            cerrarVentana = true;
                            entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                            entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                            entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                            entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Password;
                            entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                            entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Password;
                            entidad_declarante.Cs_pr_Email = txtEmail.Text;
                            entidad_declarante.cs_pxElimnar(false);
                            new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            try
                            {
                                new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "").cs_pxElimnar(false);
                            }
                            catch
                            { }
                            try
                            {
                                new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "1").cs_pxElimnar(false);
                            }
                            catch
                            { }
                            try
                            {
                                new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "2").cs_pxElimnar(false);

                            }
                            catch
                            { }

                            new clsEntityAccount().cs_pxEliminarCuentasAsociadasEMPRESA(entidad_declarante.Cs_pr_Declarant_Id);
                            //Eliminar las cuentas asociadas

                            System.Windows.Application.Current.Shutdown();
                        }
                    }
                    else
                    {
                        if (System.Windows.Forms.MessageBox.Show("¿Esta seguro que desea eliminar esta empresa?.", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            cerrarVentana = true;
                            entidad_declarante.Cs_pr_Ruc = txtRuc.Text;
                            entidad_declarante.Cs_pr_RazonSocial = txtRazonSocial.Text;
                            entidad_declarante.Cs_pr_Usuariosol = txtUsuarioSol.Text;
                            entidad_declarante.Cs_pr_Clavesol = txtClaveSol.Password;
                            entidad_declarante.Cs_pr_Rutacertificadodigital = txtCertificadoDigital.Text;
                            entidad_declarante.Cs_pr_Parafrasiscertificadodigital = txtCertificadoDigitalClave.Password;
                            entidad_declarante.Cs_pr_Email = txtEmail.Text;
                            entidad_declarante.cs_pxElimnar(false);
                            new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id).cs_pxElimnar(false);
                            try
                            {
                                clsEntityAlarms alarm1 = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "");
                                if (alarm1 != null)
                                {
                                    alarm1.cs_pxElimnar(false);
                                }
                            }
                            catch {

                            }
                            try
                            {
                                clsEntityAlarms alarm2 = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "1");
                                if (alarm2 != null)
                                {
                                    alarm2.cs_pxElimnar(false);
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                clsEntityAlarms alarm3 = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(entidad_declarante.Cs_pr_Declarant_Id, "2");
                                if (alarm3 != null)
                                {
                                    alarm3.cs_pxElimnar(false);
                                }
                            }
                            catch
                            {

                            }
                           
                            //Eliminar las cuentas asociadas
                            System.Windows.Forms.MessageBox.Show("Se ha eliminado correctamente la empresa.", "Correcto - Eliminar empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
            }
           
            if (cerrarVentana)
            {
                DialogResult = true;
                Close();
            }
           
        }
        //Evento de cierre de la ventana de configuracion del declarante.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.Escape);
            if (compare == 0)
            {
                Close();
            }
        }
    }
}
