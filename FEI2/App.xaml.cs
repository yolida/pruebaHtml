using FEI.Extension.Base;
using FEI.pages;
using SERCE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FEI
{

    /// <summary>
    /// App.xaml 
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private bool isInitialized = true;
        void App_Startup(object sender, StartupEventArgs e)
        {
            if (!isPermited())
            {
                clsBaseMensaje.cs_pxMsgEr("ERR20", "");
                isInitialized = false;
                System.Windows.Application.Current.Shutdown();

            }
            else
            {
                //Buscar la ruta de almacen de archivos de FEI.
                string ruta = new clsRegistry().Read("RUTA");
                if (ruta == null)
                {//En caso no exista mostrar el formulario de seleccion de ruta.
                    frmSelect f = new frmSelect();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        //Si ingresa la ruta mostrar el inicion de sesion.
                        //InicioSesion inicio = new InicioSesion();
                        //inicio.Show();
                        presentacion Presentacion_FEI = new presentacion();
                        Presentacion_FEI.Show();
                    }
                }
                else
                {
                    //Iniciar configuracion actual y mostrar inicio de sesion. 
                    clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
                    //Mostrar formulario de Inicio de Sesion.
                    //InicioSesion inicio = new InicioSesion();
                    //inicio.Show();
                    presentacion Presentacion_FEI = new presentacion();
                    Presentacion_FEI.Show();
                }
            }
        }

        public static bool isPermited()
        {
            try
            {
                bool retorno = false;
                //comprobar tipo de licencia si no tiene licencia volver false.
                if (new clsBaseLicencia().getIsTerminalServer())
                {
                    // clsBaseLog.cs_pxRegistarAdd("isterminal");
                    bool b = true;
                    Mutex mutex = new Mutex(true, "FEI" + Environment.UserName.ToLowerInvariant(), out b);
                    if (!b)
                    {
                        //hay otra instancia para el usuario bloquear el inicio de otra instancia para el usuario
                        retorno = false;
                        clsBaseLog.cs_pxRegistarAdd("!b false");
                    }
                    else
                    {
                        //Es la primera instancia para el usuario verificar conexiones
                        //obtener conexiones permitidas
                        int usuarios_permitidos = new clsBaseLicencia().getConexionesPermitidas();
                        int usuarios_actuales = new clsBaseLicencia().getUsuariosActivos();
                        clsBaseLog.cs_pxRegistarAdd("up" + usuarios_permitidos.ToString() + " " + usuarios_actuales);
                        if (usuarios_actuales <= usuarios_permitidos)
                        {
                            //retorno = true;
                            int nuevos_actuales = usuarios_actuales + 1;
                            bool resultado = new clsBaseLicencia().saveUsuariosActivos(nuevos_actuales.ToString());
                            if (resultado)
                            {
                                retorno = true;
                            }
                            else
                            {
                                retorno = false;
                            }
                        }
                        else
                        {
                            retorno = false;
                        }
                    }
                }
                else
                {

                    //solo permitir una instancia
                    Process curr = Process.GetCurrentProcess();
                    Process[] procs = Process.GetProcessesByName(curr.ProcessName);
                    foreach (Process p in procs)
                    {
                        if ((p.Id != curr.Id) && (p.MainModule.FileName == curr.MainModule.FileName))
                        {
                            return false;
                        }
                    }

                    return true;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd(ex.ToString());
                return false;
            }

        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            //clsBaseLog.cs_pxRegistarAdd("dismin1");
            if (isInitialized == true)
            {
                //clsBaseLog.cs_pxRegistarAdd("dismin1");
                try
                {
                    //Disminuir los usuarios activos
                    int usuarios_actuales = new clsBaseLicencia().getUsuariosActivos();
                    if (usuarios_actuales > 0)
                    {
                        int nuevos_actuales = usuarios_actuales - 1;
                        bool resultado = new clsBaseLicencia().saveUsuariosActivos(nuevos_actuales.ToString());
                    }
                    else
                    {
                        bool resultado = new clsBaseLicencia().saveUsuariosActivos("0");
                    }
                }
                catch (Exception ex)
                {
                    clsBaseLog.cs_pxRegistarAdd("::" + ex.ToString());
                    bool resultado = new clsBaseLicencia().saveUsuariosActivos("0");
                }

            }
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.Exception.Message, "Excepción no controlada");
            clsBaseLog.cs_pxRegistarAdd(e.Exception.Message + "\n " + e.Exception.StackTrace);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
            e.Handled = true;

            //clsBaseLog.cs_pxRegistarAdd("dismiasan1");
            /*if (new clsBaseLicencia().getIsTerminalServer())
            {
                if (isInitialized == true)
                {
                    try
                    {
                        //Disminuir los usuarios activos
                        int usuarios_actuales = new clsBaseLicencia().getUsuariosActivos();
                        if (usuarios_actuales > 0)
                        {
                            int nuevos_actuales = usuarios_actuales - 1;
                            bool resultado = new clsBaseLicencia().saveUsuariosActivos(nuevos_actuales.ToString());
                        }
                        else
                        {
                            bool resultado = new clsBaseLicencia().saveUsuariosActivos("0");
                        }
                    }
                    catch (Exception ex)
                    {
                        clsBaseLog.cs_pxRegistarAdd("::" + ex.ToString());
                        bool resultado = new clsBaseLicencia().saveUsuariosActivos("0");
                    }

                }

            }*/

        }
    }
}
