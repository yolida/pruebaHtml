using FEI.ayuda;
using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Configuracion de base de datos web.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Configuracion_bdweb.xaml
    /// </summary>
    public partial class Configuracion_bdweb : Page
    {
        private clsEntityDatabaseWeb entidad_basedatos;
        List<ComboBoxPares> GestorBaseDatos = new List<ComboBoxPares>();
        public bool cs_prConexionEstado = false;
        private clsEntityDatabaseLocal localDB;
        //Metodo constructor.
        public Configuracion_bdweb(clsEntityDeclarant declarant)
        {
            InitializeComponent();
            localDB = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(declarant.Cs_pr_Declarant_Id);
            //Cargar valores para gestores de base de datos web.
            GestorBaseDatos.Add(new ComboBoxPares("1", "Microsoft SQL Server"));
            GestorBaseDatos.Add(new ComboBoxPares("2", "MySQL"));
            GestorBaseDatos.Add(new ComboBoxPares("3", "SQLite"));
            cboGestorBD.DisplayMemberPath = "_Value";
            cboGestorBD.SelectedValuePath = "_key";
            cboGestorBD.ItemsSource = GestorBaseDatos;

            if (cboGestorBD.Text == "")
            {
                cboGestorBD.SelectedIndex = 0;
            }
            //Cargar configuracion de base de datos web
            entidad_basedatos =  new clsEntityDatabaseWeb().cs_fxObtenerUnoPorDeclaranteId(declarant.Cs_pr_Declarant_Id);
            cboGestorBD.Text = entidad_basedatos.Cs_pr_DBMS;
            txtDriver.Text = entidad_basedatos.Cs_pr_DBMSDriver;
            txtServidor.Text = entidad_basedatos.Cs_pr_DBMSServername;
            txtPuerto.Text = entidad_basedatos.Cs_pr_DBMSServerport;
            txtNombreBD.Text = entidad_basedatos.Cs_pr_DBName;
            txtUsuario.Text = entidad_basedatos.Cs_pr_DBUser;
            txtContrasenia.Password = entidad_basedatos.Cs_pr_DBPassword;
        }
        // Evento de cambio de gestor de base de datos.
        private void cboGestorBD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Obtener valor seleccionado.
            ComboBoxPares seleccionado = (ComboBoxPares)cboGestorBD.SelectedItem;
            if (seleccionado._Value == "SQLite")
            {
                txtServidor.IsEnabled = false;
                txtPuerto.IsEnabled = false;
                txtUsuario.IsEnabled = false;
                txtContrasenia.IsEnabled = false;
            }
            else
            {
                txtServidor.IsEnabled = true;
                txtPuerto.IsEnabled = true;
                txtUsuario.IsEnabled = true;
                txtContrasenia.IsEnabled = true;
            }
            //Definir texto segun opcion seleccionado.
            if (cboGestorBD.Text == "PostgreSQL")
            {
                TextBoton.Content = "Actualizar base de datos existente";
            }
            else
            {
                TextBoton.Content = "Crear base de datos";
            }
            txtDriver.Text = clsBaseUtil.cs_fxDBMS_Driver(cboGestorBD.SelectedIndex + 1);
        }
        private int existeCambios(clsEntityDatabaseWeb web)
        {
            int cambios = 0;
            if (web.Cs_pr_DBMS != cboGestorBD.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBMSDriver != txtDriver.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBMSServername != txtServidor.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBMSServerport != txtPuerto.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBName != txtNombreBD.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBUser != txtUsuario.Text.Trim())
            {
                cambios++;
            }
            if (web.Cs_pr_DBPassword != txtContrasenia.Password.Trim())
            {
                cambios++;
            }

            return cambios;
        }
        //Evento  guardar configuracion.
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (existeCambios(entidad_basedatos) > 0)
            {
                //Salvar la configuracion de la base de datos.
                entidad_basedatos.Cs_pr_DBMS = cboGestorBD.Text;
                entidad_basedatos.Cs_pr_DBMSDriver = txtDriver.Text;
                entidad_basedatos.Cs_pr_DBMSServername = txtServidor.Text;
                entidad_basedatos.Cs_pr_DBMSServerport = txtPuerto.Text;
                entidad_basedatos.Cs_pr_DBName = txtNombreBD.Text;
                entidad_basedatos.Cs_pr_DBUser = txtUsuario.Text;
                entidad_basedatos.Cs_pr_DBPassword = txtContrasenia.Password;
                entidad_basedatos.cs_pxActualizar(true);

                cs_pxActualizarEstado();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se han realizado cambios.", "Advertencia - Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Evento actualizar estado de la conexion a base de datos.
        private void cs_pxActualizarEstado()
        {
            //Obtner el estado de la conexion de la base de datos.
            clsBaseConexion conexion = new clsBaseConexion(localDB);
            cs_prConexionEstado = conexion.cs_fxConexionEstado();
        }
        //Evento para crear la base de datos web.
        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            //Asignar la configuracion de base de datos.
            entidad_basedatos.Cs_pr_DBMS = cboGestorBD.Text;
            entidad_basedatos.Cs_pr_DBMSDriver = txtDriver.Text;
            entidad_basedatos.Cs_pr_DBMSServername = txtServidor.Text;
            entidad_basedatos.Cs_pr_DBMSServerport = txtPuerto.Text;
            entidad_basedatos.Cs_pr_DBName = txtNombreBD.Text;
            entidad_basedatos.Cs_pr_DBUser = txtUsuario.Text;
            entidad_basedatos.Cs_pr_DBPassword = txtContrasenia.Password;
            entidad_basedatos.cs_pxActualizar(false);
            cs_pxActualizarEstado();
            entidad_basedatos.cs_pxCrearBaseDatos();
        }

        private void Page_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.F12);
            if (compare == 0)
            {
                AyudaPrincipal ayuda = new AyudaPrincipal("22");
                ayuda.ShowDialog();
            }
        }
    }
}
