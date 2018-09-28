using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.pages;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using ContasisALF;
using System.Diagnostics;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
/// Cambio de interfaz - Ventana principal.
/// </summary>
namespace FEI
{
    /// <summary>
    /// MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private clsEntityAlarms alarm;
        private clsEntityAlarms alarmRD;
        private clsBaseConexion conexion;
        private clsEntityDeclarant Empresa;
        private clsEntityDatabaseLocal localDB;
        private clsEntityUsers Usuario;
        private clsEntityAccount Perfil;
        private int fracciones;
        private int horas;
        private DateTime hora_base;
        private string hora_procesada;
        private string hora_ahora;
        private int minutos;
        private List<string> Pendientes_envío;
        private List<List<string>> Pendientes_envío_ResumenDiario;
        private List<string> Pendientes_envío_enviar;
        private List<List<string>> Pendientes_envío_ResumenDiario_enviar;
        private System.Windows.Forms.NotifyIcon ntiEnvio = new System.Windows.Forms.NotifyIcon();
        private bool CerrarAplicacion = true;
        private bool __isLeftHide = false;
        private string currentDirectory = Directory.GetCurrentDirectory();
        private string fileExecutable;

        /// <summary>
        /// Metodo constructor 
        /// </summary>
        /// <param name="Profile"></param>
        public MainWindow(clsEntityAccount Profile)
        {
            InitializeComponent();
            Perfil = Profile;
            fileExecutable = currentDirectory + "\\Srlc.exe";
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = fileExecutable;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.Close();
            string fecha = new clsBaseLicencia().getFechaVencimiento();
            lblAlerta.Content = fecha;
        }
        /// <summary>
        /// Metodo para determinar cambio de estado en los menus del lado izquierda.
        /// </summary>
        /// <param name="data"></param>
        public void EstadoMenu(bool estado)
        {
            //Si estado es false ->bloquear el menu lateral.
            if (estado == false)
            {
                Dispatcher.BeginInvoke((Action)(() => LeftTabControl.SelectedIndex = 4));
                var tab_reporte = LeftTabControl.Items[0] as TabItem;
                tab_reporte.IsEnabled = false;
                var tab_factura = LeftTabControl.Items[1] as TabItem;
                tab_factura.IsEnabled = false;
                var tab_resumen = LeftTabControl.Items[2] as TabItem;
                tab_resumen.IsEnabled = false;
                var tab_comunicacion = LeftTabControl.Items[3] as TabItem;
                tab_comunicacion.IsEnabled = false;
            }
            else
            {
                var tab_reporte = LeftTabControl.Items[0] as TabItem;
                tab_reporte.IsEnabled = true;
                var tab_factura = LeftTabControl.Items[1] as TabItem;
                tab_factura.IsEnabled = true;
                var tab_resumen = LeftTabControl.Items[2] as TabItem;
                tab_resumen.IsEnabled = true;
                var tab_comunicacion = LeftTabControl.Items[3] as TabItem;
                tab_comunicacion.IsEnabled = true;
            }
        }
        /// Evento para mostrar el menu.
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (Exception)
            {

            }
           
        }     
        // Evento click menu reporte resumen
        private void clkReporteResumen(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Reporte_Resumen.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu reporte factura
        private void clkReporteFactura(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Reporte_Factura.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu reporte boleta
        private void clkReporteBoleta(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Reporte_Boleta.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu reporte comunicacion de baja
        private void clkReporteBaja(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Reporte_ComunicacionBaja.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu reporte general.
        private void clkReporteGeneral(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Reporte_General.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu Factura envio sunat
        private void clkFacturaSunat(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Factura_Sunat.xaml", UriKind.RelativeOrAbsolute);
        }
        // Evento click menu Factura alertas.
        private void clkFacturaAlerta(object sender, MouseButtonEventArgs e)
        {
            Factura_Alerta facAlerta= new Factura_Alerta(alarm);
            this.pageContainer.Navigate(facAlerta);
        }
        // Evento click menu generacion de resumen diario.
        private void clkResumenDiarioGenerar(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/ResumenDiario_Generar.xaml", UriKind.RelativeOrAbsolute);
        }
        //Evento click envio a sunat de resumen diario.
        private void clkResumenDiarioSunat(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/ResumenDiario_Sunat.xaml", UriKind.RelativeOrAbsolute);
        }
        //Evento click generar comunicacion de baja
        private void clkComunicacionGenerar(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/ComunicacionBaja_Generar.xaml", UriKind.RelativeOrAbsolute);
        }
        //Evento click enviar comunicacion de baja.
        private void clkComunicacionSunat(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/ComunicacionBaja_Sunat.xaml", UriKind.RelativeOrAbsolute);
        } 
        //Evento click alertas de resumen diario    
        private void clkResumenDiarioAlerta(object sender, MouseButtonEventArgs e)
        {
            ResumenDiario_Alerta rdalerta = new ResumenDiario_Alerta(alarmRD,Empresa.Cs_pr_Declarant_Id);
            this.pageContainer.Navigate(rdalerta);
        }
        //Evento click configuracion de base de datos local.
        private void clkConfiguracionBDLocal(object sender, MouseButtonEventArgs e)
        {
            Configuracion_bdlocal confBDlocal = new Configuracion_bdlocal(Empresa);
            this.pageContainer.Navigate(confBDlocal);
        }
        //Evento click configuracion de base de datos web.
        private void clkConfiguracionBDWeb(object sender, MouseButtonEventArgs e)
        {
            Configuracion_bdweb confBDweb = new Configuracion_bdweb(Empresa);
            this.pageContainer.Navigate(confBDweb);
        }
        //Evento click configuracion de empresas
        private void clkConfiguracionEmpresa(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Configuracion_declarante.xaml", UriKind.RelativeOrAbsolute);
        }
        //Evento click configuracion de usuarios
        private void clkConfiguracionUsuario(object sender, MouseButtonEventArgs e)
        {
            this.pageContainer.Source = new Uri("pages/Configuracion_usuarios.xaml", UriKind.RelativeOrAbsolute);
        }
        private void clkConfiguracionLicencia(object sender, MouseButtonEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();      
            StreamReader sr = new StreamReader(currentDirectory+"\\lcl.txt", System.Text.Encoding.Default);
            string texto;
            texto = sr.ReadToEnd();
            sr.Close();
            bool activo =new clsBaseLicencia().licenceActive(DateTime.Now.ToString("yyyy-MM-dd"),"2.00.00");  
            //string text2 = LoadLic.Load();
          //  bool flag3 = text2.Equals(string.Empty);
            if (activo)
            {
                //Ya se tiene cadena encriptada.Desencriptar y obtener tipo de licencia y fecha.

                string fecha = new clsBaseLicencia().getFechaVencimiento();
                string tipoLicencia = "T";
                string codigoPeticion = texto;

                Licencia lic = new Licencia(fecha, tipoLicencia, codigoPeticion);
                lic.ShowDialog();
                //  MessageBox.Show(Encrypt.Base64_Decode(text2));
                //   MessageBox.Show(text2);
              
            }
            else
            {
                Activacion frmActivacion = new Activacion(texto);
                frmActivacion.ShowDialog();

                if (frmActivacion.DialogResult.HasValue && frmActivacion.DialogResult.Value)
                {
                    MessageBox.Show("Activado");
                }

                // Application.Run(new frmActivacion(text));

            }

        }
        
        
        //Evento para esconder o mostrar el menu lateral       
        private void spliter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Left Bar hide and show
            __isLeftHide =! __isLeftHide;
            if (__isLeftHide)
            {
                this.gridForm.ColumnDefinitions[0].Width = new GridLength(1d);
            }
            else
            {
                this.gridForm.ColumnDefinitions[0].Width = new GridLength(240d);
            }
          
        }
        //Evento de cierre para la ventana principal.
        private void mainForm_Closed(object sender, EventArgs e)
        {
            //Si cerrar aplicacion completamente es true -> caso contrario dejar por defecto que solo cierra la ventana.;
            if (CerrarAplicacion)
            {
                System.Windows.Application.Current.Shutdown();
            }        
        }
        //Evento de carga en la pagina principal
        private void mainForm_Loaded(object sender, RoutedEventArgs e)
        {
            //Si el perfil inicado sesion existe.
            if (Perfil.Cs_pr_Users_Id != "")
            {   
                Usuario = new clsEntityUsers().cs_pxObtenerUnoPorId(Perfil.Cs_pr_Users_Id);
                //Si tiene rol de admin
                if (Usuario.Cs_pr_Role_Id == "ADMIN")
                {                 
                   
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        //Bloquear el menu
                        EstadoMenu(false);
                        AlmacenLocal.IsEnabled = false;
                        AlmacenWeb.IsEnabled = false;                 
                    }
                    //Habilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                else
                {
                
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        //Bloquear el menu
                        EstadoMenu(false);
                        AlmacenLocal.IsEnabled = false;
                        AlmacenWeb.IsEnabled = false;
                       
                    }
                    //Deshabilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                lblUsuario.Content = "Usuario: " + Usuario.Cs_pr_User;
            }
            
            if (Perfil.Cs_pr_Declarant_Id != "")
            {
                //Si el usuario existe cargar las alarmas y reiniciar los paramteros de conexion
                Empresa = new clsEntityDeclarant().cs_pxObtenerUnoPorId(Perfil.Cs_pr_Declarant_Id);
                localDB = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(Perfil.Cs_pr_Declarant_Id);
                lblEmpresa.Content = "Empresa: " + Empresa.Cs_pr_RazonSocial;              
                alarm = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(Empresa.Cs_pr_Declarant_Id, "");//Obtener configuracion alarma facturas.
                alarmRD = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(Empresa.Cs_pr_Declarant_Id, "1");//Obtener configuracion alarma de resumen diario.
                cs_pxReiniciarConexión();
                cs_pxReiniciar();
            }
            else
            {
                if (Usuario.Cs_pr_Role_Id == "ADMIN")
                {
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        EstadoMenu(false);
                        AlmacenLocal.IsEnabled = false;
                        AlmacenWeb.IsEnabled = false;
                     
                    }
                    //Habilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                else
                {
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        EstadoMenu(false);
                        AlmacenLocal.IsEnabled = false;
                        AlmacenWeb.IsEnabled = false;                     
                    }
                    //Deshabilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
            }

            //Timer facturas y notas asociadas
            DispatcherTimer dispatch = new DispatcherTimer();
            dispatch.Interval = new TimeSpan(0,1,0);
            dispatch.Tick += new System.EventHandler(this.tmrAlarmaFactura_Tick);
            dispatch.Start();

            //Timer resumen diario
            DispatcherTimer dispatchRD = new DispatcherTimer();
            dispatchRD.Interval = new TimeSpan(0, 1, 0);
            dispatchRD.Tick += new System.EventHandler(this.tmrAlarmaRD_Tick);
            dispatchRD.Start();

            //Timer envio de comprobantes a web
            DispatcherTimer dispatchWEB = new DispatcherTimer();
            dispatchWEB.Interval = new TimeSpan(0, 5, 0);
            dispatchWEB.Tick += new System.EventHandler(this.tmrInsertarAWeb_Tick);
            dispatchWEB.Start();

        }
        //Metodo que invoca el timer de insertar documentos en web.
        private void tmrInsertarAWeb_Tick(object sender, EventArgs e)
        {
            new clsEntityDatabaseWeb().cs_pxEnviarAWeb(Empresa);
        }
        //Metodo que invoca el timer de verificar las alarmas de facturas.
        private void tmrAlarmaFactura_Tick(object sender, EventArgs e)
        {
            try
            {
                if (alarm != null)
                {//Si la alarma esta definida
                    Pendientes_envío = new clsEntityDocument(localDB).cs_pxObtenerPendientesEnvio();
                    //Enviar un número de veces al día automatico
                    if (alarm.Cs_pr_Envioautomatico == "T" && alarm.Cs_pr_Envioautomatico_minutos == "T" && Pendientes_envío.Count > 0)
                    {
                        fracciones = Convert.ToInt32(alarm.Cs_pr_Envioautomatico_minutosvalor);
                        horas = 24 / Convert.ToInt32(alarm.Cs_pr_Envioautomatico_minutosvalor);
                        //Recorrer las fracciones de tiempo para evaluar la alarma
                        for (int i = 0; i < fracciones; i++)
                        {
                            hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                            hora_base = hora_base.AddHours(horas * i);
                            hora_procesada = hora_base.ToString("yyyy-MM-dd HH:00:00").Trim();
                            hora_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00").Trim();
                            //Si la hora a revisar es igual a la hora actual mostrar notificacion
                            if (hora_ahora == hora_procesada)
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los comprobantes electrónicos pendientes.";
                                ntiEnvio.BalloonTipTitle = "Envío automático de comprobantes 1.";
                                ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                                ntiEnvio.ShowBalloonTip(1000);
                                cs_pxEntregarComprobantesAutomático();
                                break;
                            }
                        }
                    }
                    //Enviar automatico hora definida
                    if (alarm.Cs_pr_Envioautomatico == "T" && alarm.Cs_pr_Envioautomatico_hora == "T" && Pendientes_envío.Count > 0)
                    {
                        hora_ahora = DateTime.Now.ToShortTimeString();
                        //si ambas horas son iguales realizar el envio
                        if (hora_ahora == alarm.Cs_pr_Envioautomatico_horavalor.Trim())
                        {
                            ntiEnvio.Visible = true;
                            ntiEnvio.Icon = SystemIcons.Information;
                            ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los comprobantes electrónicos pendientes.";
                            ntiEnvio.BalloonTipTitle = "Envío automático de comprobantes 2.";
                            ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                            ntiEnvio.ShowBalloonTip(1000);
                            cs_pxEntregarComprobantesAutomático();
                        }
                    }

                    if (alarm.Cs_pr_Enviomanual == "T" && alarm.Cs_pr_Enviomanual_mostrarglobo == "T" && Pendientes_envío.Count > 0)
                    {   //Si es envio manual  y mostrar recordatorio cada cierto tiempo.
                        //Dividir los periodos de envio por hora.
                        hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
                        fracciones = Convert.ToInt32(alarmRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        minutos = 60 / Convert.ToInt32(alarmRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        //Por cada periodo de hora detectado se revisa si coincida la hora actual con el programado.
                        for (int i = 0; i < fracciones; i++)
                        {
                            hora_procesada = hora_base.AddMinutes(minutos * i).ToString("yyyy-MM-dd HH:mm:00").Trim();
                            hora_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
                            //si las horas coinciden mostrar notificacion recordatoria.
                            if (hora_ahora == hora_procesada)
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Existen " + Pendientes_envío.Count.ToString() + " comprobantes electrónicos pendientes de envío a SUNAT.";
                                ntiEnvio.BalloonTipTitle = "Envío manual de comprobantes.";
                                ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                                ntiEnvio.ShowBalloonTip(1000);
                                break;
                            }
                        }
                    }

                    if (alarm.Cs_pr_Enviomanual == "T" && alarm.Cs_pr_Enviomanual_nomostrarglobo == "T")
                    {
                        //NO MOSTRAR GLOBO
                    }
                }
            }
            catch (Exception){}
        }
        //Metodo que invoca el timer de verificar las alarmas de resumenes diarios.
        private void tmrAlarmaRD_Tick(object sender, EventArgs e)
        {
            try
            {
                //Si alarma para resumen diario esta definida realizar proceso.
                if (alarmRD != null)
                {

                    Pendientes_envío_ResumenDiario = new clsEntitySummaryDocuments(localDB).cs_pxObtenerPendientesEnvioRD();
                    //Caso de envio automatico con numero de veces por dia y que haya pendientes de envio.
                    if (alarmRD.Cs_pr_Envioautomatico == "T" && alarmRD.Cs_pr_Envioautomatico_minutos == "T" && Pendientes_envío_ResumenDiario.Count > 0)
                    {
                        //Se divide las horas del dia en fracciones de tiempo dadas.                
                        fracciones = Convert.ToInt32(alarmRD.Cs_pr_Envioautomatico_minutosvalor);
                        horas = 24 / Convert.ToInt32(alarmRD.Cs_pr_Envioautomatico_minutosvalor);
                        //Por cada fraccion se verifica si es igual al periodo actual.
                        for (int i = 0; i < fracciones; i++)
                        {
                            hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                            hora_base = hora_base.AddHours(horas * i);
                            hora_procesada = hora_base.ToString("yyyy-MM-dd HH:00:00").Trim();
                            hora_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00").Trim();
                            //Si la hora a revisar es igual a la hora actual mostrar notificacion
                            if (hora_ahora == hora_procesada)
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los resumenes diarios pendientes.";
                                ntiEnvio.BalloonTipTitle = "Envío automático de resumen diario.";
                                ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                                ntiEnvio.ShowBalloonTip(1000);
                                cs_pxEntregarComprobantesAutomáticoRD();
                                break;
                            }
                        }
                    }
                    //Caso de envio automatico programado por hora y que haya pendientes de envio.
                    if (alarmRD.Cs_pr_Envioautomatico == "T" && alarmRD.Cs_pr_Envioautomatico_hora == "T" && Pendientes_envío_ResumenDiario.Count > 0)
                    {
                        hora_ahora = DateTime.Now.ToShortTimeString();
                        //Si la hora actual es igual a la hora programada enviar los resumenes.
                        if (hora_ahora == alarmRD.Cs_pr_Envioautomatico_horavalor.Trim())
                        {
                            ntiEnvio.Visible = true;
                            ntiEnvio.Icon = SystemIcons.Information;
                            ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los resumenes diarios pendientes.";
                            ntiEnvio.BalloonTipTitle = "Envío automático de resumen diario.";
                            ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                            ntiEnvio.ShowBalloonTip(1000);
                            cs_pxEntregarComprobantesAutomáticoRD();
                        }
                    }
                    //Caso de envio manual con notificaciones y pendientes de envio.
                    if (alarmRD.Cs_pr_Enviomanual == "T" && alarmRD.Cs_pr_Enviomanual_mostrarglobo == "T" && Pendientes_envío_ResumenDiario.Count > 0)
                    {
                        //MOSTRAR GLOBO RECORDATORIO CADA CIERTO TIEMPO
                        //Dividir los periodos de envio por hora.
                        hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
                        fracciones = Convert.ToInt32(alarmRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        minutos = 60 / Convert.ToInt32(alarmRD.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        //Por cada periodo de hora detectado se revisa si coincida la hora actual con el programado.
                        for (int i = 0; i < fracciones; i++)
                        {
                            hora_procesada = hora_base.AddMinutes(minutos * i).ToString("yyyy-MM-dd HH:mm:00").Trim();
                            hora_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
                            //si las horas coinciden mostrar notificacion recordatoria.
                            if (hora_ahora == hora_procesada)
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Existen " + Pendientes_envío_ResumenDiario.Count.ToString() + " resumenes diarios pendientes de envío a SUNAT.";
                                ntiEnvio.BalloonTipTitle = "Envío manual de comprobantes.";
                                ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                                ntiEnvio.ShowBalloonTip(1000);
                                break;
                            }
                        }
                    }
                    //CAso envio manual sin mostrar notificaciones.
                    if (alarmRD.Cs_pr_Enviomanual == "T" && alarmRD.Cs_pr_Enviomanual_nomostrarglobo == "T")
                    {
                        //NO MOSTRAR GLOBO
                    }
                }
            }
            catch (Exception){ }
        }
        //Metodo para enviar comprobantes de facturas de manera automatica.
        private void cs_pxEntregarComprobantesAutomático()
        {
            try
            {
                Pendientes_envío_enviar = new clsEntityDocument(localDB).cs_pxObtenerPendientesEnvio();
                foreach (var item in Pendientes_envío_enviar)
                {
                   /* if (item[3].ToString() != "03" && item[9] != "03")
                    {*/
                        clsBaseSunat sunat = new clsBaseSunat(localDB);
                        sunat.cs_pxEnviarCE(item,true);
                  //  }

                }              
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Envio automatico facturas y notas" + ex.Message);
            }
        }
        //Metodo para enviar comprobantes resumenes diarios de manera automatica.
        private void cs_pxEntregarComprobantesAutomáticoRD()
        {
            try
            {
                //Obtener los comprobante a enviar en resumen diario.
                Pendientes_envío_ResumenDiario_enviar = new clsEntitySummaryDocuments(localDB).cs_pxObtenerPendientesEnvioRD();
                foreach (var item in Pendientes_envío_ResumenDiario_enviar)
                {
                    clsBaseSunat sunat = new clsBaseSunat(localDB);
                    sunat.cs_pxEnviarRC(item[0], false);
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("Envio de resumenes diarios automatico" + ex.Message);
            }
        }
        //Metodo para reiniciar parametros de conexion.
        private void cs_pxReiniciarConexión()
        {
            conexion = new clsBaseConexion(localDB);
        }
        //Metodo para reiniciar permisos en la aplicacion
        private void cs_pxReiniciar()
        {
            //Verificar la base de datos de esta empresa.
            //Leer la configuración de la base de datos de esta empresa
            //Solo se puede crear una base de datos si existe la empresa.
            //Solsoe asdmasdjamvimasdiañsdo

            bool aux_conexionestado = conexion.cs_fxConexionEstado();
            //Si la conexion no esta establecida
            if (aux_conexionestado.Equals(false))
            {
                Dispatcher.BeginInvoke((Action)(() => LeftTabControl.SelectedIndex = 4));
                var tab_reporte = LeftTabControl.Items[0] as TabItem;
                tab_reporte.IsEnabled = false;
                var tab_factura = LeftTabControl.Items[1] as TabItem;
                tab_factura.IsEnabled = false;
                var tab_resumen = LeftTabControl.Items[2] as TabItem;
                tab_resumen.IsEnabled = false;
                var tab_comunicacion = LeftTabControl.Items[3] as TabItem;
                tab_comunicacion.IsEnabled = false;
            }
            //Si la conexion esta establecida.
            if (aux_conexionestado.Equals(true))
            {
                
                clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(new clsBaseConfiguracion().Cs_pr_Declarant_Id);
                bool aux_existerutacertificadodigital = File.Exists(declarante.Cs_pr_Rutacertificadodigital);
                //Si el certificado digital existe.
                if (aux_existerutacertificadodigital == true)
                {
                    try
                    {
                        X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(declarante.Cs_pr_Rutacertificadodigital), declarante.Cs_pr_Parafrasiscertificadodigital);
                        bool servidorBeta = new clsBaseSunat(localDB).isServidorBeta(declarante);
                        if (servidorBeta == true)
                        {
                            Title = "Facturación Electrónica Integrada V1.0 Servidor Beta Sunat";
                        }
                        else
                        {
                            Title = "Facturación Electrónica Integrada V1.0";
                        }
                    }
                    catch (Exception)
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR17", "La ubicación o la contraseña del certificado digital (*.pfx) no es válido.");
                        Dispatcher.BeginInvoke((Action)(() => LeftTabControl.SelectedIndex = 4));
                        var tab_reporte = LeftTabControl.Items[0] as TabItem;
                        tab_reporte.IsEnabled = false;
                        var tab_factura = LeftTabControl.Items[1] as TabItem;
                        tab_factura.IsEnabled = false;
                        var tab_resumen = LeftTabControl.Items[2] as TabItem;
                        tab_resumen.IsEnabled = false;
                        var tab_comunicacion = LeftTabControl.Items[3] as TabItem;
                        tab_comunicacion.IsEnabled = false;
                    }
                }
                else
                {
                    Dispatcher.BeginInvoke((Action)(() => LeftTabControl.SelectedIndex = 4));
                    var tab_reporte = LeftTabControl.Items[0] as TabItem;
                    tab_reporte.IsEnabled = false;
                    var tab_factura = LeftTabControl.Items[1] as TabItem;
                    tab_factura.IsEnabled = false;
                    var tab_resumen = LeftTabControl.Items[2] as TabItem;
                    tab_resumen.IsEnabled = false;
                    var tab_comunicacion = LeftTabControl.Items[3] as TabItem;
                    tab_comunicacion.IsEnabled = false;
                    clsBaseMensaje.cs_pxMsgEr("ERR17", "La ubicación o la contraseña del certificado digital (*.pfx) no es válido.");
                }
            }
        }
        //Evento de cerrar sesion de usuario.
        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            CerrarAplicacion = false;
            Close();
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
        }
        //Evento de carga en la pagina incrustada dentro la ventana principal.
        private void pageContainer_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {                 
            try
            {
                (e.Content as Configuracion_bdlocal).Tag = this;
            }
            catch
            {}
            
        }
    }
}
