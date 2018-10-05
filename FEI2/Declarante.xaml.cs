using System;
using System.Windows;
using DataLayer.CRUD;
using Microsoft.Win32;

namespace FEI
{
    public partial class Declarante : Window
    {
        public int IdEmisor;
        public Int16 Id_DatosFox;
        public Data_Usuario data_Usuario   =   new Data_Usuario();
        public Declarante(int idEmisor, Int16 idDatosFox, Data_Usuario usuario)
        {
            InitializeComponent();
            IdEmisor        =   idEmisor;
            Id_DatosFox     =   idDatosFox;
            data_Usuario    =   usuario;
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.Escape);
            if (compare == 0)
            {
                Close();
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCertificadoDigital.Text.ToString().Trim()) && !string.IsNullOrEmpty(txtCertificadoDigitalClave.Password.ToString().Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioSol.Text.ToString().Trim()) && !string.IsNullOrEmpty(txtClaveSol.Password.ToString().Trim()))
            {
                Data_AccesosSunat data_AccesosSunat = new Data_AccesosSunat(IdEmisor)
                {
                    CertificadoDigital  =   txtCertificadoDigital.Text.ToString().Trim(),
                    ClaveCertificado    =   txtCertificadoDigitalClave.Password.ToString().Trim(),
                    UsuarioSol          =   txtUsuarioSol.Text.ToString().Trim(),
                    ClaveSol            =   txtClaveSol.Password.ToString().Trim()
                };
                if (data_AccesosSunat.Create_AccesosSunat())
                {
                    Data_Usuario registroUsuario   =   new Data_Usuario() { IdUsuario  = data_Usuario.IdUsuario, IdDatosFox = Id_DatosFox };

                    if (registroUsuario.Create_User_Empresa())
                    {
                        MessageBox.Show("Los datos se han registrado con éxito, para ver los cambios es necesario reiniciar FEICONT.", "Registro exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
                        try
                        {
                            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                            Application.Current.Shutdown();
                            //System.Windows.Forms.Application.Restart();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Tenemos problemas para reiniciar, por favor cierre y vuelva a abrir la aplicación.", "Es necesario reiniciar la aplicación", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                        MessageBox.Show("Ha ocurrido un problema en el registro de datos usuario_empresa, contacte con soporte.", "Registro fallido", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Ha ocurrido un problema en el registro de datos, contacte con soporte.", "Registro fallido", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Antes de continuar debe rellenar todos los campos.", "Campos en blanco", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog   =   new OpenFileDialog();
            openFileDialog.Multiselect      =   false;
            openFileDialog.Filter           =   "Certificados|*.pfx|Todos los archivos|*.*";
            openFileDialog.DefaultExt       =   "*.pfx";
            openFileDialog.Title            =   "Selección de certificado digital";

            Nullable<bool> dialogOk   =   openFileDialog.ShowDialog();

            if (dialogOk  == true)
            {
                string  ruta    =   openFileDialog.FileName;
                txtCertificadoDigital.Text = ruta;
            }
        }
    }
}
