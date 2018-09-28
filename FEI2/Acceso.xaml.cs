using System.Data;
using System.Windows;
using DataLayer;
using DataLayer.CRUD;
using System.ComponentModel;
using System;
using System.IO;

namespace FEI
{
    /// <summary>
    /// Interaction logic for Acceso.xaml
    /// </summary>
    public partial class Acceso : Window
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // testing
                ReadGeneralData readGeneralData =   new ReadGeneralData();
                DataTable dataTableInternalData =   readGeneralData.GetInternalDataTable("[dbo].[Read_DataAccess]");

                int cantidadFilas   = dataTableInternalData.Rows.Count;

                InternalConnection  internalConnection  =   new InternalConnection();
                string[] valores    =   internalConnection.GetDataFile();
                
                if (cantidadFilas != 1) //  Comprobar que haya registro en db interna, primera vez que se ejecute el sistema
                {   // Se comprueba que los valores sean correctos
                    if (valores.Length == 2 || !string.IsNullOrEmpty(valores[0]) || !string.IsNullOrEmpty(valores[1]) || !string.IsNullOrEmpty(valores[2]))
                    {
                        Connection connection = new Connection();
                        string cadena = $"data source={valores[0]}; initial catalog=master; user id={valores[1]}; password={valores[2]};";
                        if (!connection.CheckConnection(cadena))    //  Verificamos que la cadena de conexión sea correcta
                        {
                            if (internalConnection.Create_DataAccess(valores))  // Sólo si la cadena de conexión es correcta procedemos a registrar
                            {
                                Application.Current.Shutdown();
                                System.Windows.Forms.Application.Restart();
                            }
                        }
                    }
                    else // Sí no es correcto se pide configurar de forma manual (Formulario)
                    {
                        MessageBox.Show("Se debe configurar de forma manual la conexión a la base de datos.");
                        ConfigurarConeccionSQL configurarConeccionSQL   =   new ConfigurarConeccionSQL();
                        configurarConeccionSQL.Show();
                    }
                }
                else     // En caso de que haya registro en db interna  
                {   // Comprobar la conexión con el servidor de SqlServer

                    InternalAccess internalAccess   =   new InternalAccess();
                    internalAccess.Read_InternalAccess();
                    string cadena   =   $"data source={@internalAccess.Servidor}; initial catalog=master; user id={@internalAccess.Usuario}; password={@internalAccess.Contrasenia}; Connection Timeout=3";

                    Connection  connection  =   new Connection();

                    if (!connection.CheckConnection(cadena))    
                    {   // Actualizar la cadena de conexión
                        MessageBox.Show("Se debe configurar de forma manual la conexión a la base de datos.");
                        ConfigurarConeccionSQL configurarConeccionSQL = new ConfigurarConeccionSQL();
                        configurarConeccionSQL.Show();
                    }
                    else // Aquí ya no se tiene problemas con la base de datos
                    {
                        DataTable dataTable =   readGeneralData.GetDataTable("[sysfox].[List_DatosFox]");

                        int cantidadLineas  =   dataTable.Rows.Count;

                        if (cantidadLineas <= 0)
                        {
                            MessageBox.Show("Aún no tienes registrada ninguna empresa, puedes realizar este registro desde tu sistema Contasis.",   
                                "Error de conexión con los módulos Contasis", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            Application.Current.Shutdown();
                        }
                        else
                        {
                            // Comprobar accesos
                            var items           =   (dataTable  as  IListSource).GetList();

                            lstEmpresas.ItemsSource         =   items;
                            lstEmpresas.DisplayMemberPath   =   "NombreLegal";
                            lstEmpresas.SelectedValuePath   =   "IdDatosFox";
                            lstEmpresas.SelectedIndex       =   0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al iniciar la aplicación, detalle del error: {ex}" , "Error de sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ComprobarDatosDeAutenticacion()
        {
            Data_AccesosSunat data_AccesosSunat = new Data_AccesosSunat((int)lstEmpresas.SelectedValue);

            if (!string.IsNullOrEmpty(data_AccesosSunat.Usuario))
            {
                txtUsuario.IsEnabled    =   false;
                txtPassword.IsEnabled   =   false;
                btnIngresar.IsEnabled   =   false;
                btnIngresar.Content     =   "Registro de datos";
            }
        }
    }
}
