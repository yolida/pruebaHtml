using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Configuracion de base de datos local.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Configuracion_bdlocal.xaml
    /// </summary>
    public partial class Configuracion_bdlocal : Page
    {
        private clsEntityDatabaseLocal entidad_basedatos;
        List<ComboBoxPares> GestorBaseDatos = new List<ComboBoxPares>();
        public bool cs_prConexionEstado=false;
        //Metodo constructor.
        public Configuracion_bdlocal(clsEntityDeclarant declarant)
        {
            InitializeComponent();
            //Agregar valores la combobox de gestores de base de datos.
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
            //Obtener la configuracion dela base de datos local para la empresa actual.
            entidad_basedatos = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(declarant.Cs_pr_Declarant_Id);
            cboGestorBD.Text = entidad_basedatos.Cs_pr_DBMS;
            txtDriver.Text = entidad_basedatos.Cs_pr_DBMSDriver;
            txtServidor.Text = entidad_basedatos.Cs_pr_DBMSServername;
            txtPuerto.Text = entidad_basedatos.Cs_pr_DBMSServerport;
            txtNombreBD.Text = entidad_basedatos.Cs_pr_DBName;
            txtUsuario.Text = entidad_basedatos.Cs_pr_DBUser;
            txtContrasenia.Text = entidad_basedatos.Cs_pr_DBPassword;

        }
        ///Evento click para crear la base de datos.
        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            //asignar valores a la entidad base de datos local.
            entidad_basedatos.Cs_pr_DBMS = cboGestorBD.Text;
            entidad_basedatos.Cs_pr_DBMSDriver = txtDriver.Text;
            entidad_basedatos.Cs_pr_DBMSServername = txtServidor.Text;
            entidad_basedatos.Cs_pr_DBMSServerport = txtPuerto.Text;
            entidad_basedatos.Cs_pr_DBName = txtNombreBD.Text;
            entidad_basedatos.Cs_pr_DBUser = txtUsuario.Text;
            entidad_basedatos.Cs_pr_DBPassword = txtContrasenia.Text;
            entidad_basedatos.cs_pxActualizar(false);
            cs_pxActualizarEstado();
            //Actualizar la configuracion para el sistema.
            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            configuracion.cs_prDbms = entidad_basedatos.Cs_pr_DBMS;
            configuracion.cs_prDbmsdriver = entidad_basedatos.Cs_pr_DBMSDriver;
            configuracion.cs_prDbmsservidor = entidad_basedatos.Cs_pr_DBMSServername;
            configuracion.cs_prDbmsservidorpuerto = entidad_basedatos.Cs_pr_DBMSServerport;
            configuracion.cs_prDbnombre = entidad_basedatos.Cs_pr_DBName;
            configuracion.cs_prDbusuario = entidad_basedatos.Cs_pr_DBUser;
            configuracion.cs_prDbclave = entidad_basedatos.Cs_pr_DBPassword;
            configuracion.cs_pxActualizar(false);
            entidad_basedatos.cs_pxCrearBaseDatos();
        }
        //Evento para guardar los cambios.
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Asignar valores para la entidad de base de datos local
            entidad_basedatos.Cs_pr_DBMS = cboGestorBD.Text;
            entidad_basedatos.Cs_pr_DBMSDriver = txtDriver.Text;
            entidad_basedatos.Cs_pr_DBMSServername = txtServidor.Text;
            entidad_basedatos.Cs_pr_DBMSServerport = txtPuerto.Text;
            entidad_basedatos.Cs_pr_DBName = txtNombreBD.Text;
            entidad_basedatos.Cs_pr_DBUser = txtUsuario.Text;
            entidad_basedatos.Cs_pr_DBPassword = txtContrasenia.Text;
            entidad_basedatos.cs_pxActualizar(true);
           
            //Actualizar valores para la configuracion de base de datos.
            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            configuracion.cs_prDbms = entidad_basedatos.Cs_pr_DBMS;
            configuracion.cs_prDbmsdriver = entidad_basedatos.Cs_pr_DBMSDriver;
            configuracion.cs_prDbmsservidor = entidad_basedatos.Cs_pr_DBMSServername;
            configuracion.cs_prDbmsservidorpuerto = entidad_basedatos.Cs_pr_DBMSServerport;
            configuracion.cs_prDbnombre = entidad_basedatos.Cs_pr_DBName;
            configuracion.cs_prDbusuario = entidad_basedatos.Cs_pr_DBUser;
            configuracion.cs_prDbclave = entidad_basedatos.Cs_pr_DBPassword;
            configuracion.cs_pxActualizar(false);
            cs_pxActualizarEstado();
            (this.Tag as MainWindow).EstadoMenu(cs_prConexionEstado);

        }
        // Metodo para actualizar estado  de la conexion a base de  datos
        private void cs_pxActualizarEstado()
        {
            //Obtener el estado de la conexin a bd
           // clsBaseConexion conexion = new clsBaseConexion();
           // cs_prConexionEstado = conexion.cs_fxConexionEstado();
        }
        // Evento de cambio de gestor de base de datos.
        private void cboGestorBD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxPares seleccionado=(ComboBoxPares)cboGestorBD.SelectedItem;
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

            if (seleccionado._Value == "PostgreSQL")
            {
                TextBoton.Content = "Actualizar base de datos existente";
            }
            else
            {
                TextBoton.Content = "Crear base de datos";
            }

            txtDriver.Text = clsBaseUtil.cs_fxDBMS_Driver(cboGestorBD.SelectedIndex + 1);
        }
        //Evento para verificar la estructura de la base de datos.
        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            new Loading().ShowDialog();
        }
    }
}
