using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Windows;
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
        //Metodo constructor
        public Usuarios(string modo, string id)
        {
            InitializeComponent();
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
                    if (txtUsuario.Text.Trim().Length > 0 && txtClave.Password.Trim().Length > 0)
                    {
                        /** Antiguo */
                        //entidad_usuario.cs_pxActualizar(true);
                        /** Fin-Antiguo */
                        user.cs_pxActualizar(true);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "INS":
                    user = new clsEntityUsers();
                    user.Cs_pr_Users_Id = Guid.NewGuid().ToString();
                    user.Cs_pr_User = txtUsuario.Text;
                    user.Cs_pr_Password = txtClave.Password;
                    user.Cs_pr_Role_Id = "USER";
                    if (txtUsuario.Text.Trim().Length > 0 && txtClave.Password.Trim().Length > 0)
                    {
                        user.cs_pxInsertar(false);
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR13", "");
                    }
                    break;
                case "DLT":
                    if (user.Cs_pr_Role_Id.Trim().ToUpper() == "ADMIN")
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
    }
}
