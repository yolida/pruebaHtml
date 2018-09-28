using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
/// Cambio de interfaz - acciones para usuario.
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Window
    {
        private clsEntityUsers user;
        private clsBaseConfiguracion entidad_usuario;
        private string cs_cmModo = "";
        private List<List<string>> empresas = new List<List<string>>();
        List<ComboBoxPares> tipos_perfil = new List<ComboBoxPares>();
        //Metodo constructor
        public Usuarios(string modo, string id)
        {
            InitializeComponent();
           /* tipos_perfil.Add(new ComboBoxPares("USER", "Usuario"));
            tipos_perfil.Add(new ComboBoxPares("ADMIN", "Administrador"));
            cboPerfil.DisplayMemberPath = "_Value";
            cboPerfil.SelectedValuePath = "_key";
            cboPerfil.SelectedIndex = 0;
            cboPerfil.ItemsSource = tipos_perfil;*/
            /** Antiguo */
            entidad_usuario = new clsBaseConfiguracion();
            txtUsuario.Text = entidad_usuario.cs_prLoginUsuario;
            txtClave.Password = entidad_usuario.cs_prLoginPassword;
            /** Fin-Antiguo */
            //Elegir acciones segun modo seleccionado.
            this.cs_cmModo = modo;
            switch (cs_cmModo)
            {
                case "UPD":
                    user = new clsEntityUsers().cs_pxObtenerUnoPorId(id);
                    txtUsuario.Text = user.Cs_pr_User;
                    txtClave.Password = user.Cs_pr_Password;
                    if (user.Cs_pr_User == "admin")
                    {
                        txtUsuario.IsEnabled = false;
                    }
                   /* if (user.Cs_pr_Role_Id == "ADMIN")
                    {
                        cboPerfil.SelectedIndex = 1;
                    }
                    else
                    {
                        cboPerfil.SelectedIndex = 0;
                    }*/
                    break;
                case "INS":
                    user = new clsEntityUsers();
                    txtUsuario.Text = "";
                    txtClave.Password = "";
                   
                    break;
                case "DLT":
                    user = new clsEntityUsers().cs_pxObtenerUnoPorId(id);
                    txtUsuario.Text = user.Cs_pr_User;
                    txtUsuario.IsEnabled = false;
                    txtClave.Password = user.Cs_pr_Password;
                    txtClave.IsEnabled = false;
                   /* if (user.Cs_pr_Role_Id == "ADMIN")
                    {
                        cboPerfil.SelectedIndex = 1;
                    }
                    else
                    {
                        cboPerfil.SelectedIndex = 0;
                    }*/
                    //cboPerfil.IsEnabled = false;
                    btnGuardar.Content = "Eliminar";
                    break;
                default:
                    break;
            }
        }
        //Evento guardar los cambios realizados 
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Elegir acciones segun modo seleccionado
            switch (cs_cmModo)
            {
                case "UPD":
                    /** Antiguo */
                    entidad_usuario.cs_prLoginUsuario = txtUsuario.Text;
                    entidad_usuario.cs_prLoginPassword = txtClave.Password;
                    /** Fin-Antiguo */
                    user.Cs_pr_User = txtUsuario.Text;
                    user.Cs_pr_Password = txtClave.Password;
                    /*int indexSeleccionado = cboPerfil.SelectedIndex;
                    if (indexSeleccionado == 0)
                    {*/
                     //   user.Cs_pr_Role_Id = "USER";
                  /*  }
                    else
                    {
                        user.Cs_pr_Role_Id = "ADMIN";
                    }*/
                    if (txtUsuario.Text.Trim().Length > 0 )
                    {
                        /** Antiguo */
                        //entidad_usuario.cs_pxActualizar(true);
                        /** Fin-Antiguo */
                        user.cs_pxActualizar(true);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No deben existir campos vacíos.", "Advertencia - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "INS":
                    user = new clsEntityUsers();
                    user.Cs_pr_Users_Id = Guid.NewGuid().ToString();
                    user.Cs_pr_User = txtUsuario.Text;
                    user.Cs_pr_Password = txtClave.Password;
                    user.Cs_pr_Role_Id = "USER";
                    if (txtUsuario.Text.Trim().Length > 0)
                    {
                        user.cs_pxInsertar(false);                       
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No deben existir campos vacíos.", "Advertencia - Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "DLT":
                    if (user.Cs_pr_Role_Id.Trim().ToUpper() == "ADMIN" && user.Cs_pr_User=="admin")
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR22", "No se puede eliminar el administrador.");
                    }
                    else
                    {
                        user.cs_pxElimnar(false);
                        //Además eliminar las cuentas relacionadas a este usuario.
                        new clsEntityAccount().cs_pxEliminarCuentasAsociadasUSUARIO(user.Cs_pr_Users_Id);
                    }
                    break;
                default:
                    break;
            }
            DialogResult = true;
            Close();
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
