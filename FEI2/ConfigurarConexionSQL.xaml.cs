using DataLayer;
using DataLayer.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
        bool exitoConexion      =   false; // Indicador de que se realizó la conexión con éxito
        bool asegurarGuardado   =   false;

        public ConfigurarConeccionSQL(bool Update)
        {
            InitializeComponent();

            if (Update) // Sí es true se debe actualizar
            {
                InternalAccess internalAccess   =   new InternalAccess();
                internalAccess.Read_InternalAccess();
                txtServidor.Text                =   internalAccess.Servidor;
                txtUsuario.Text                 =   internalAccess.Usuario;
                txtContrasenia.Password         =   internalAccess.Contrasenia;

                InternalConnection internalConnection = new InternalConnection();
                string uriIcon              =   internalConnection.GetPathMDF() + "\\images\\close.png";
                imageGuardar.Source         =   new BitmapImage(new Uri(uriIcon));
                TextBotonGuardar.Content    =   "Salir";  // Entonces la funcionalidad del botón cambia a SALIR debido a que la conexión es incorrecta
            }
            else // Sí es false se debe crear
            {
                InternalConnection internalConnection = new InternalConnection();
                string uriIcon              =   internalConnection.GetPathMDF() + "\\images\\close.png";
                imageGuardar.Source         =   new BitmapImage(new Uri(uriIcon));
                TextBotonGuardar.Content    =   "Salir";  // Entonces la funcionalidad del botón cambia a SALIR debido a que la conexión es incorrecta
            }
        }
        

        void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            string msg  =   string.Empty;
            MessageBoxResult result;
            if (exitoConexion == false)
            {
                msg     =   "Aún no se ha podido realizar la conexión con la base de datos, ¿Esta seguro(a) de salir?";
                result  =   MessageBox.Show(msg, "No se obtuvo la conexión al servidor de base de datos", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                    e.Cancel    =   true;    // Sí el usuario no quiere cerrar la aplicación, cancelará el cierre, sino cerrará toda la aplicación
                else
                    Application.Current.Shutdown();
            }
            else // En caso de que si se haya realizado el testing de conexión pero todavía no se haya guardado los datos de conexión
            {
                if (asegurarGuardado == false)
                {
                    msg     =   "Aún no ha guardado los datos de conexión, ¿Esta seguro(a) de salir?";
                    result  =   MessageBox.Show(msg, "No se obtuvo la conexión al servidor de base de datos", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.No)
                        e.Cancel    =   true;    // Sí el usuario no quiere cerrar la aplicación, cancelará el cierre, sino cerrará toda la aplicación
                    else
                        Application.Current.Shutdown();
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

            string cadena = $"data source={servidor}; initial catalog=master; user id={usuario}; password={contrasenia}; Connection Timeout=7";

            Connection connection = new Connection();

            if (!string.IsNullOrEmpty(servidor) && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasenia))    // Todos los campos completados
            {
                if (connection.CheckConnection(cadena))    // Comprobamos la conexión con la base de datos
                {   
                    // Actualizar la cadena de conexión
                    exitoConexion               =   true;
                    TextBotonGuardar.Content    =   "Guardar";  // Entonces la funcionalidad del botón cambia a GUARDAR debido a que la conexión es correcta
                    InternalConnection internalConnection = new InternalConnection();
                    string uriIcon              =   internalConnection.GetPathMDF() + "\\images\\save-icon.png";
                    imageGuardar.Source         =   new BitmapImage(new Uri(uriIcon));
                    MessageBox.Show("La conexión con el servidor tuvo éxito, procede a guardar para conservar los datos de conexión.",
                        "Prueba de conexión", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Lo sentimos, no se ha podido realizar la conexión con el servidor de base de datos, corriga los datos y vuelva a intentarlo.",
                        "Sin conexión", MessageBoxButton.OK, MessageBoxImage.Information);  // Aún  no se puede conectar con la base de datos
                }
            }
            else
                MessageBox.Show("Antes de continuar debes completar todos los campos.", "Datos incompletos", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (exitoConexion   ==  false)  //  Sí es que es FALSE, entonces el botón funciona como botón de salir
                Close();
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

                if (!string.IsNullOrEmpty(servidor) && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasenia))    // Todos los campos completados
                {
                    if (connection.CheckConnection(cadena))    // Comprobamos la conexión con la base de datos
                    {
                        string ruta                 =   Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        if (!Directory.Exists($"{ruta}\\FEICONT"))
                            Directory.CreateDirectory($"{ruta}\\FEICONT");

                        #region Escritura del archivo txt con los datos del servidor de base de datos
                        try
                        {
                            if (File.Exists($"{ruta}\\FEICONT\\access.txt"))
                                File.Delete($"{ruta}\\FEICONT\\access.txt");
                            else
                            {
                                using (StreamWriter streamWriter = new StreamWriter($"{ruta}\\FEICONT\\access.txt"))
                                {
                                    streamWriter.WriteLine($"{servidor}|{usuario}|{contrasenia}");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            // El archivo esta en uso o no se puede acceder a el
                        }
                        #endregion Escritura del archivo txt con los datos del servidor de base de datos

                        #region Actualizar o crear InternalDB
                        InternalAccess internalAccess   =   new InternalAccess() {  Servidor    =   servidor,   Usuario =   usuario, Contrasenia    =   contrasenia };

                        ReadGeneralData readGeneralData =   new ReadGeneralData();
                        DataTable dataTableInternalData =   readGeneralData.GetInternalDataTable("[dbo].[Read_DataAccess]");

                        if (dataTableInternalData.Rows.Count == 1)  // En caso de que ya haya un registro en la db
                            internalAccess.Alter_InternalAccess("[dbo].[Update_DataAccess]");
                        else // Sí no lo hay, la crea
                            internalAccess.Alter_InternalAccess("[dbo].[Create_DataAccess]");
                        #endregion Actualizar o crear InternalDB

                        // Ejecutar todo el script de creación de base de datos (PENDIENTE)

                        asegurarGuardado    =   true;

                        Application.Current.Shutdown();
                        System.Windows.Forms.Application.Restart(); // Se reinicia la aplicación para que acceda de inmediato al login ya con los accesos correctos de la db
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos, se ha cambiado los datos de acceso, corriga los datos y vuelva a intentarlo.",
                            "Sin conexión", MessageBoxButton.OK, MessageBoxImage.Information);  // Aún  no se puede conectar con la base de datos
                        InternalConnection internalConnection = new InternalConnection();
                        string uriIcon              =   internalConnection.GetPathMDF() + "\\images\\close.png";
                        imageGuardar.Source         =   new BitmapImage(new Uri(uriIcon));
                        TextBotonGuardar.Content    =   "Salir";  // Entonces la funcionalidad del botón cambia a SALIR debido a que la conexión es incorrecta
                    }
                }
                else
                    MessageBox.Show("Antes de continuar debes completar todos los campos.", "Datos incompletos", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
