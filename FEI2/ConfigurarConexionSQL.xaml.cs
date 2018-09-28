using DataLayer;
using DataLayer.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FEI
{
    /// <summary>
    /// Interaction logic for ConfigurarConeccionSQL.xaml
    /// </summary>
    public partial class ConfigurarConeccionSQL : Window
    {
        bool exitoConexion = false; // Indicador de que se realizó la conexión con éxito

        public ConfigurarConeccionSQL()
        {
            InitializeComponent();
        }
        

        void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            // If data is dirty, notify user and ask for a response
            if (exitoConexion)
            {
                string msg = "Data is dirty. Close without saving?";
                MessageBoxResult result =
                  MessageBox.Show(
                    msg,
                    "Data App",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    // If user doesn't want to close, cancel closure
                    e.Cancel = true;
                }
            }
        }

        private void btnTestDB_Click(object sender, RoutedEventArgs e)
        {
            string servidor     =   string.Empty;
            string usuario      =   string.Empty;
            string contrasenia  =   string.Empty;

            servidor            =   txtServidor.Text.ToString().Trim();
            usuario             =   txtUsuario.Text.ToString().Trim();
            contrasenia         =   txtContrasenia.Password.ToString().Trim();

            string cadena = $"data source={servidor}; initial catalog=master; user id={usuario}; password={contrasenia}; Connection Timeout=3";

            Connection connection = new Connection();

            if (!string.IsNullOrEmpty(servidor) || !string.IsNullOrEmpty(usuario) || !string.IsNullOrEmpty(contrasenia))
            {
                if (!connection.CheckConnection(cadena))
                {   // Actualizar la cadena de conexión
                    MessageBox.Show("Lo sentimos, no se podido realizar la conexión con el servidor de base de datos, corriga los datos y vuelva a intentarlo.",
                        "Sin conexión", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    exitoConexion       =   true;
                    btnGuardar.Content  =   "Guardar";
                }
            }

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (exitoConexion)  //  Sí es que es FALSE, entonces el botón funciona como botón de salir
            {
                Application.Current.Shutdown();
            }
            else // En caso de que este en TRUE es porque ya se probó con éxito la conexión con la DB, se vuelve a comprobar los accesos para asegurar la conexión siga disponible
            { 
                string servidor     =   string.Empty;
                string usuario      =   string.Empty;
                string contrasenia  =   string.Empty;

                servidor            =   txtServidor.Text.ToString().Trim();
                usuario             =   txtUsuario.Text.ToString().Trim();
                contrasenia         =   txtContrasenia.Password.ToString().Trim();

                string cadena = $"data source={servidor}; initial catalog=master; user id={usuario}; password={contrasenia}; Connection Timeout=3";

                Connection connection = new Connection();

                if (!string.IsNullOrEmpty(servidor) || !string.IsNullOrEmpty(usuario) || !string.IsNullOrEmpty(contrasenia))
                {
                    if (!connection.CheckConnection(cadena))
                    {   // Actualizar la cadena de conexión
                        MessageBox.Show("Lo sentimos, se ha cambiado los datos de acceso, corriga los datos y vuelva a intentarlo.",
                            "Sin conexión", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        // Escribir txt con los accesos (pendiente)

                        Application.Current.Shutdown();
                        System.Windows.Forms.Application.Restart(); // Se reinicia la aplicación para que acceda de inmediato al login ya con los accesos correctos de la db
                    }
                }
                else
                    MessageBox.Show("Lo sentimos, no se podido realizar la conexión con el servidor de base de datos, corriga los datos y vuelva a intentarlo.",
                            "Sin conexión", MessageBoxButton.OK, MessageBoxImage.Information);
                }
        }
    }
}
