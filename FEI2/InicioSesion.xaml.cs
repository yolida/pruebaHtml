using FEI.Extension.Base;
using FEI.Extension.Datos;
using Security;
using SERCE;
using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
///  Cambio de interfaz - Ventana inicio de sesion
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        clsEntityAccount Profile;
        bool regla_login = false;
        bool regla_account = false;
        string userid = String.Empty;
        string Profile_Id = String.Empty;
        string seleccion_empresa = String.Empty;
        public bool DoTest = true; // Poner en true para ejecutar el formulario de pruebas
        /// <summary>
        /// Cosntructor
        /// </summary>
        public InicioSesion()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
        /// <summary>
        /// Evento Cerrar de la ventana inicio de sesion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        /// <summary>
        /// Evento Ingresar al sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Todos los comprobantes se agregaron a su respectiva comunicacion de baja","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            try
            {
                //txtUsuario.IsKeyboardFocused
                //btnIngresar.IsEnabled = false;          
                regla_login = false; 
                regla_account = false;
                //Obtener si usuario esta registrado.
                userid = new clsEntityUsers().cs_pxLogin(txtUsuario.Text.Trim(), txtPassword.Password.Trim());
                if (userid.Length > 0)
                    regla_login = true;

                //Obtener valor empresa seleccionado.
               
                if (cboEmpresa.IsEnabled == false)
                    seleccion_empresa = "";
                else
                {
                    //En caso no exista una empresa seleccionado
                    if (cboEmpresa.SelectedValue != null)
                    {
                        seleccion_empresa = cboEmpresa.SelectedValue.ToString();
                        //Obtener la configuracion de base de datos para la empresa seleccionada.
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
                    // seleccion_empresa = cboEmpresa.SelectedValue.ToString();
                }
                //Iniciar instancia del perfil
                Profile = new clsEntityAccount();
                Profile_Id = Profile.dgvVerificarCuenta(userid, seleccion_empresa);
                if (Profile_Id != "")
                    regla_account = true;

                if (regla_login == true && regla_account == true)
                {
                    //Si el login es correcto y pertenece al perfil  
                    clsEntityDatabaseLocal local = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(seleccion_empresa);
                    clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(seleccion_empresa);

                    clsBaseConexion con = new clsBaseConexion(local);

                    bool estado = con.cs_fxConexionEstadoServidor();
                    //Si la conexion al servidor de base de datos es correcta
                    Hide();
                    if (estado == true)
                    { // verifica el estado de la base de datos
                        bool actualizar = new clsEntityDatabaseLocal(declarante).cs_pxSeDebeActualizarBD();
                        //Determinar si se debe actualizar, versión antigua
                        if (actualizar)
                        {
                            //Mostrar mensaje para pedir confirmacion de actualizacion de base de datos.
                            if (System.Windows.Forms.MessageBox.Show("Es necesario actualizar la estructura de la base de datos.Si escoge continuar se realizara ahora, caso contrario puede hacerlo despues utilizando la opcion verificar estructura.\n ¿Desea continuar?", "Verificar estructura - Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                            {
                                new Loading(declarante).ShowDialog();
                            }
                        }
                        //Nuevo cambio para actualizar la estructura de la base de datos

                    }
                    // Verificar sí se esta haciendo pruebas

                    if(DoTest == true)
                        new pages.FormPruebas().Show();
                    else //Cargar la ventana principal
                        new MainWindow(new clsEntityAccount().cs_fxObtenerUnoPorId(Profile_Id)).Show();
                }
                else
                {
                    //Mensaje de error en inicio de sesion.                 
                    clsBaseMensaje.cs_pxMsgEr("ERR12", "Error de inicio de sesión.");
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("btnIngresar " + ex.ToString());
            }
        }
        /// <summary>
        /// Evento de carga al iniciar la ventana de inicio de sesion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //Obtener las empresas registradas
                if (new clsEntityDeclarant().cs_pxObtenerTodo().Count > 0)
                {
                    cboEmpresa.ItemsSource = new clsEntityDeclarant().cs_pxObtenerTodo();
                    cboEmpresa.DisplayMemberPath = "Cs_pr_RazonSocial";
                    cboEmpresa.SelectedValuePath = "Cs_pr_Declarant_Id";
                    cboEmpresa.SelectedIndex = 0;
                }
                else
                {
                    cboEmpresa.IsEnabled = false;
                    //frmSelect f = new frmSelect();
                    //f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                //Registrar error en el log.
                clsBaseLog.cs_pxRegistarAdd("Windows Loaded " + ex.ToString());
            }
        }
        //Mover la pantalla
        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void txtPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.Enter);
            if (compare == 0)
            {
                btnIngresar_Click(this, new RoutedEventArgs());
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) => CargarTxt.Procesar();
    }
}
