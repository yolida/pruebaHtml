
using FEI.Extension.Base;
using SERCE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
/// <summary>
///  Jordy Amaro 12-01-17 FEI2-4
///  Cambio de interfaz - clase de inicio de aplicacion
/// </summary>
namespace FEI
{
    /// <summary>
    /// App.xaml 
    /// </summary>
    public partial class App : System.Windows.Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {  
            //Buscar la ruta de almacen de archivos de FEI.
            string ruta = new clsRegistry().Read("RUTA");
            if (ruta == null)
            {//En caso no exista mostrar el formulario de seleccion de ruta.
                frmSelect f = new frmSelect();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Si ingresa la ruta mostrar el inicion de sesion.
                    InicioSesion inicio = new InicioSesion();
                    inicio.Show();
                }
            }
            else
            {
                //Iniciar configuracion actual y mostrar inicio de sesion. 
                clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                //Mostrar formulario de Inicio de Sesion.
                InicioSesion inicio = new InicioSesion();
                inicio.Show();
            }           
           
        }
    }
}
