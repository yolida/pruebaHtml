using FEI.ayuda;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Configuracion de informacion declarantes.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Configuracion_declarante.xaml
    /// </summary>
    public partial class Configuracion_declarante : Page
    {
        List<clsEntityDeclarant> entidades;
        List<ReporteEmpresa> lista_reporte;
        ReporteEmpresa itemRow;
        clsEntityDatabaseLocal localDB;
        //Metodo constructor
        public Configuracion_declarante(clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            localDB = local;
                   
        }
        //Metodo para cargar el grid de declarantes
        private void cargarDataGrid()
        {
            //Limpiar la grilla.
            dgComprobantes.ItemsSource = null;
            dgComprobantes.Items.Clear();
            //Obtener todos los declarantes registrados
            entidades = new clsEntityDeclarant().cs_pxObtenerTodo();
            lista_reporte = new List<ReporteEmpresa>();
            if (entidades.Count > 0)
            {
                //Recorrer los registro de declarantes para rellenra la grilla
                foreach (var item in entidades)
                {
                    itemRow = new ReporteEmpresa();
                    itemRow.Id = item.Cs_pr_Declarant_Id;
                    itemRow.RazonSocial = item.Cs_pr_RazonSocial;
                    itemRow.Ruc = item.Cs_pr_Ruc;
                    itemRow.RutaCertificadoDigital = item.Cs_pr_Rutacertificadodigital;                  
                    lista_reporte.Add(itemRow);
                }
                dgComprobantes.ItemsSource = lista_reporte;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
            }else
            {
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
            }           

        }      
        //Metodo de carga incial de la ventana.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cargarDataGrid();
        }
        //Evento click para eliminar un declarante.
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //Obtner elemento seleccionado
            ReporteEmpresa item = (ReporteEmpresa)dgComprobantes.SelectedItem;
            if (item != null)
            {
                //Cargar formulario de manejo de declarante para eliminar.
                Declarante Formulario = new Declarante("DLT", item.Id, localDB);
                Formulario.ShowDialog();
                if (Formulario.DialogResult.HasValue && Formulario.DialogResult.Value)
                {
                    cargarDataGrid();
                }
            }else
            {
                System.Windows.Forms.MessageBox.Show("Debe seleccionar una empresa a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }      
        }
        //Evento click para modificar la informacion de declarante.
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            //Obtener elemento seleccionado
            ReporteEmpresa item = (ReporteEmpresa)dgComprobantes.SelectedItem;
            if (item != null)
            {
                //Mostrar formulario para manejo de declarante  con opcion de actualizar
                Declarante Formulario = new Declarante("UPD", item.Id, localDB);
                Formulario.ShowDialog();
                if (Formulario.DialogResult.HasValue && Formulario.DialogResult.Value)
                {
                    cargarDataGrid();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Debe seleccionar una empresa a modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        //Evento click para crear nuevo declarante.
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //Mostrar formulario de menajeo de declarante con opcion para crear nuevo.
            Declarante Formulario = new Declarante("INS", "", localDB);
            Formulario.ShowDialog();
            if (Formulario.DialogResult.HasValue && Formulario.DialogResult.Value)
            {
                cargarDataGrid();
            }
        }

        private void Page_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.F12);
            if (compare == 0)
            {
                AyudaPrincipal ayuda = new AyudaPrincipal("23");
                ayuda.ShowDialog();
            }
        }
    }

}
