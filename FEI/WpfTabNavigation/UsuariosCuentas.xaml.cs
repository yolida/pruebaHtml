using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Windows;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
/// Cambio de interfaz - cuentas asociadas al usuario
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para UsuariosCuentas.xaml
    /// </summary>
    public partial class UsuariosCuentas : Window
    {
        string Id = "";
        ReporteEmpresa itemRow;
        List<ReporteEmpresa> lista_reporte;
        clsEntityDeclarant clsEntityDeclarant;
        //Metodo constructor
        public UsuariosCuentas(string Id)
        {
            InitializeComponent();
            this.Id = Id;
            cs_pxCargarEmpresasLista();
            cs_pxCargarEmpresasGrid(Id);
        }
        //Metodo de carga de listado de empresas en el combobox
        private void cs_pxCargarEmpresasLista()
        {
            //Obtener la lista de empresas registradas.
            List<clsEntityDeclarant> empresas = new clsEntityDeclarant().cs_pxObtenerTodo();
            if (empresas.Count > 0 || empresas != null)
            {
                cboEmpresas.ItemsSource = new clsEntityDeclarant().cs_pxObtenerTodo();
                cboEmpresas.DisplayMemberPath = "Cs_pr_RazonSocial";
                cboEmpresas.SelectedValuePath = "Cs_pr_Declarant_Id";
                cboEmpresas.SelectedIndex = 0;
            }
        }
        //Metodo de carga de empresas en la grilla
        private void cs_pxCargarEmpresasGrid(string Id)
        {
            dgEmpresas.ItemsSource = null;
            //Obtener la lista de empresas asociadas al usuario actual.
            List<clsEntityAccount> cuentas = new clsEntityAccount().dgvEmpresasUsuario(Id);
            lista_reporte = new List<ReporteEmpresa>();
            if (cuentas.Count > 0 || cuentas != null)
            {
                //Recorrer las cuentas asociadas al usuario.
                foreach (var item in cuentas)
                {
                    if (item.Cs_pr_Declarant_Id != "")
                    {
                        clsEntityDeclarant = new clsEntityDeclarant().cs_pxObtenerUnoPorId(item.Cs_pr_Declarant_Id);

                        itemRow = new ReporteEmpresa();
                        itemRow.Id = item.Cs_pr_Account_Id;
                        itemRow.RazonSocial = clsEntityDeclarant.Cs_pr_RazonSocial;
                        lista_reporte.Add(itemRow);
                    }
                }
                dgEmpresas.ItemsSource = lista_reporte;
            }

        }
        //Metodo guardar la asociacion de las empresas y usuarios
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            ReporteEmpresa item = (ReporteEmpresa)dgEmpresas.SelectedItem;
            if (item != null)
            {
                string declarant = cboEmpresas.SelectedValue.ToString();
                if (new clsEntityAccount().dgvCuentaDuplicada(Id, declarant) == false)
                {
                    clsEntityAccount cuenta = new clsEntityAccount();
                    cuenta.Cs_pr_Account_Id = Guid.NewGuid().ToString();
                    cuenta.Cs_pr_Declarant_Id = declarant;
                    cuenta.Cs_pr_Users_Id = Id;
                    cuenta.cs_pxInsertar(false);
                    dgEmpresas.ItemsSource = null;
                    cs_pxCargarEmpresasLista();
                    cs_pxCargarEmpresasGrid(Id);
                }
            }
        }
        //Metodo remover asociacion empresas de usuario.
        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            ReporteEmpresa item = (ReporteEmpresa)dgEmpresas.SelectedItem;
            if (item != null)
            {
                if (new clsEntityUsers().cs_pxObtenerUnoPorId(Id).Cs_pr_Role_Id.ToUpper() != "ADMIN")
                {
                    clsEntityAccount cuenta = new clsEntityAccount().cs_fxObtenerUnoPorId(item.Id);
                    cuenta.cs_pxElimnar(false);
                    dgEmpresas.ItemsSource = null;
                    cs_pxCargarEmpresasLista();
                    cs_pxCargarEmpresasGrid(Id);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar las empresas asociadas al usuario administrador");
                }
            }
        }
    }
}
