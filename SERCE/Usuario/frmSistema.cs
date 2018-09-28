using FEI.Configuracion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FEI.Base;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System.Xml;

namespace FEI.Usuario
{
    public partial class frmSistema : frmBaseFormularios
    {
        private clsEntityAlarms alarm;
        private clsBaseConexion conexion;
        private Color color_fila_seleccionada = Color.LightGoldenrodYellow;
        
        private clsEntityDeclarant Empresa;
        private clsEntityUsers Usuario;
        private clsEntityAccount Perfil;
        
        public frmSistema(clsEntityAccount Profile)
        {
            Perfil = Profile;
            InitializeComponent();
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
         
            if (Perfil.Cs_pr_Users_Id != "")
            {
                Usuario = new clsEntityUsers().cs_pxObtenerUnoPorId(Perfil.Cs_pr_Users_Id);
                if (Usuario.Cs_pr_Role_Id == "ADMIN")
                {
                    informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = true;
                    informaciónDelUsuarioToolStripMenuItem.Enabled = true;
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        conexiónABaseDeDatosToolStripMenuItem.Enabled = false;
                        alarmasDelSistemaToolStripMenuItem.Enabled = false;
                        grpFiltro.Enabled = false;
                        dgvComprobanteselectronicos.Enabled = false;
                        btnActualizarregistros.Enabled = false;
                        btnResumendiario.Enabled = false;
                        btnComunicacionbaja.Enabled = false;
                        btnEntregarcomprobantes.Enabled = false;
                        cboReporteFormato.Enabled = false;
                        btnReporte.Enabled = false;
                    }
                    //Habilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                else
                {
                    informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = false;
                    informaciónDelUsuarioToolStripMenuItem.Enabled = false;
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        conexiónABaseDeDatosToolStripMenuItem.Enabled = false;
                        alarmasDelSistemaToolStripMenuItem.Enabled = false;
                        grpFiltro.Enabled = false;
                        dgvComprobanteselectronicos.Enabled = false;
                        btnActualizarregistros.Enabled = false;
                        btnResumendiario.Enabled = false;
                        btnComunicacionbaja.Enabled = false;
                        btnEntregarcomprobantes.Enabled = false;
                        cboReporteFormato.Enabled = false;
                        btnReporte.Enabled = false;
                    }
                    //Deshabilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                tssUsuario.Text = "Usuario: " + Usuario.Cs_pr_User;
            }

            if (Perfil.Cs_pr_Declarant_Id != "")
            {
                Empresa = new clsEntityDeclarant().cs_pxObtenerUnoPorId(Perfil.Cs_pr_Declarant_Id);
                tssEmpresa.Text = "Empresa: " + Empresa.Cs_pr_RazonSocial;

                cs_pxCargarInterfazFiltro();
                this.alarm = new clsEntityAlarms().cs_fxObtenerUnoPorDeclaranteId(Empresa.Cs_pr_Declarant_Id,"");
                cs_pxReiniciarConexión();
                cs_pxReiniciar();
            }
            else
            {
                if (Usuario.Cs_pr_Role_Id == "ADMIN")
                {
                    informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = true;
                    informaciónDelUsuarioToolStripMenuItem.Enabled = true;
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        conexiónABaseDeDatosToolStripMenuItem.Enabled = false;
                        alarmasDelSistemaToolStripMenuItem.Enabled = false;
                        grpFiltro.Enabled = false;
                        dgvComprobanteselectronicos.Enabled = false;
                        btnActualizarregistros.Enabled = false;
                        btnResumendiario.Enabled = false;
                        btnComunicacionbaja.Enabled = false;
                        btnEntregarcomprobantes.Enabled = false;
                        cboReporteFormato.Enabled = false;
                        btnReporte.Enabled = false;
                    }
                    //Habilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
                else
                {
                    informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = false;
                    informaciónDelUsuarioToolStripMenuItem.Enabled = false;
                    if (Perfil.Cs_pr_Declarant_Id == "")
                    {
                        conexiónABaseDeDatosToolStripMenuItem.Enabled = false;
                        alarmasDelSistemaToolStripMenuItem.Enabled = false;
                        grpFiltro.Enabled = false;
                        dgvComprobanteselectronicos.Enabled = false;
                        btnActualizarregistros.Enabled = false;
                        btnResumendiario.Enabled = false;
                        btnComunicacionbaja.Enabled = false;
                        btnEntregarcomprobantes.Enabled = false;
                        cboReporteFormato.Enabled = false;
                        btnReporte.Enabled = false;
                    }
                    //Deshabilitar las opciones para crear y administrar empresas.
                    //Si existe una conexión con la base de datos, Habilitar la ventana principal.
                    //Si no existe una conexión con la base de datos, Deshabilitar la ventana principal.
                }
            }
        }

        private void cs_pxReiniciarConexión()
        {
            conexion = new clsBaseConexion();
        }

        private void actualizarArchivo()
        {
            clsEntityDatabaseLocal bd = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(Empresa.Cs_pr_Declarant_Id);
            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            configuracion.cs_prDbms = bd.Cs_pr_DBMS;
            configuracion.cs_prDbmsdriver = bd.Cs_pr_DBMSDriver;
            configuracion.cs_prDbmsservidor = bd.Cs_pr_DBMSServername;
            configuracion.cs_prDbmsservidorpuerto = bd.Cs_pr_DBMSServerport;
            configuracion.cs_prDbnombre = bd.Cs_pr_DBName;
            configuracion.cs_prDbusuario = bd.Cs_pr_DBUser;
            configuracion.cs_prDbclave = bd.Cs_pr_DBPassword;
            configuracion.Cs_pr_Declarant_Id = Empresa.Cs_pr_Declarant_Id;
            configuracion.cs_pxActualizar(false);
        }
        private void cs_pxReiniciar()
        {
            //Verificar la base de datos de esta empresa.
            //Leer la configuración de la base de datos de esta empresa
            //Solo se puede crear una base de datos si existe la empresa.
            //Solsoe asdmasdjamvimasdiañsdo

            bool aux_conexionestado = conexion.cs_fxConexionEstado();
            if (aux_conexionestado.Equals(false))
            {
                //informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = false;
                //informaciónDelUsuarioToolStripMenuItem.Enabled = false;
                //alarmasDelSistemaToolStripMenuItem.Enabled = false;
                grpFiltro.Enabled = false;
                dgvComprobanteselectronicos.Enabled = false;
                dgvComprobanteselectronicos.Rows.Clear();
                cboReporteFormato.Enabled = false;
                btnActualizarregistros.Enabled = false;
                //btnGenerarcomprobantes.Enabled = false;
                btnComunicacionbaja.Enabled = false;
                btnResumendiario.Enabled = false;
                btnEntregarcomprobantes.Enabled = false;
                btnReporte.Enabled = false;
                tmrAlarma.Enabled = false;
                //alarm = null;
                tssPendientes.Text = "Pendientes de envío: 0";
                almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Enabled = false;
                verificarEstructuraBaseDeDatosToolStripMenuItem.Enabled = false;
            }
            if (aux_conexionestado.Equals(true))
            {
                //informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Enabled = true;
                clsEntityDeclarant declarante = new clsEntityDeclarant().cs_pxObtenerUnoPorId(new clsBaseConfiguracion().Cs_pr_Declarant_Id);
                bool aux_existerutacertificadodigital = File.Exists(declarante.Cs_pr_Rutacertificadodigital);
                //informaciónDelUsuarioToolStripMenuItem.Enabled = aux_existerutacertificadodigital;
                //alarmasDelSistemaToolStripMenuItem.Enabled = aux_existerutacertificadodigital;
                grpFiltro.Enabled = aux_existerutacertificadodigital;
                dgvComprobanteselectronicos.Enabled = aux_existerutacertificadodigital;
                btnActualizarregistros.Enabled = aux_existerutacertificadodigital;
                //btnGenerarcomprobantes.Enabled = aux_existerutacertificadodigital;
                btnReporte.Enabled = aux_existerutacertificadodigital;
                tmrAlarma.Enabled = aux_existerutacertificadodigital;
                cboReporteFormato.Enabled = aux_existerutacertificadodigital;
                almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Enabled = true;
                verificarEstructuraBaseDeDatosToolStripMenuItem.Enabled = true;
                btnComunicacionbaja.Enabled = true;
                btnResumendiario.Enabled = true;
                if (aux_existerutacertificadodigital == true)
                {
                    string pendientesenvio = new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
                    if (pendientesenvio != null && pendientesenvio.Length > 0)
                    {
                        tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
                    }
                    else
                    {
                        tssPendientes.Text = "Pendientes de envío: 0";
                    }

                    try
                    {
                        X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(declarante.Cs_pr_Rutacertificadodigital), declarante.Cs_pr_Parafrasiscertificadodigital);
                        cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
                        btnEntregarcomprobantes.Enabled = clsBaseUtil.cs_fxStringToBoolean(alarm.Cs_pr_Enviomanual);
                        bool servidorBeta = new clsBaseSunat().isServidorBeta(declarante);
                        if (servidorBeta == true)
                        {
                            this.Text = "Facturación Electrónica Integrada  01.00.00 Servidor Beta Sunat";
                        }
                        else
                        {
                            this.Text = "Facturación Electrónica Integrada  01.00.00";
                        }
                    }
                    catch (Exception ex)
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR17", "La ubicación o la contraseña del certificado digital (*.pfx) no es válido.");
                        string exssd = ex.ToString();
                        dgvComprobanteselectronicos.Rows.Clear();
                        //alarm = null;
                        btnEntregarcomprobantes.Enabled = false;
                        tssPendientes.Text = string.Empty;
                    }
                }
                else
                {
                    clsBaseMensaje.cs_pxMsgEr("ERR17", "La ubicación o la contraseña del certificado digital (*.pfx) no es válido.");
                    //alarm = null;
                    tssPendientes.Text = "Pendientes de envío: 0";
                    dgvComprobanteselectronicos.Rows.Clear();
                }
            }
        }

        private void cs_pxCargarInterfazFiltro()
        {
            chkFiltroFechaemision.Checked = true;
            dtpFechaInicio.Format = DateTimePickerFormat.Custom; dtpFechaInicio.CustomFormat = "yyyy-MM-dd"; dtpFechaInicio.Text = DateTime.Now.Date.ToString();
            dtpFechaFin.Format = DateTimePickerFormat.Custom; dtpFechaFin.CustomFormat = "yyyy-MM-dd"; dtpFechaFin.Text = DateTime.Now.Date.ToString();

            cboComprobanteTipo.Items.Clear();
            cboComprobanteTipo.Items.AddRange(clsBaseUtil.cs_fxComprobantesElectronicos());
            cboComprobanteTipo.SelectedIndex = 0;

            cboComprobanteEstadoSUNAT.Items.Clear();
            cboComprobanteEstadoSUNAT.Items.AddRange(clsBaseUtil.cs_fxComprobantesEstadosSUNATInterfaz());
            cboComprobanteEstadoSUNAT.SelectedIndex = 0;

            cboComprobanteEstadoSCC.Items.Clear();
            cboComprobanteEstadoSCC.Items.AddRange(clsBaseUtil.cs_fxComprobantesEstadosSCC());
            cboComprobanteEstadoSCC.SelectedIndex = 0;

            cboReporteFormato.Items.Clear();
            cboReporteFormato.Items.AddRange(clsBaseUtil.cs_fxReportesFormatos());
            cboReporteFormato.SelectedIndex = 0;
        }
        
        private void cs_pxCargarDgvComprobanteselectronicos(bool F1, bool F2, int tipo, string estadocomprobantescc, string estadocomprobantesunat, string serienumero, string ruc, string razonsocial, string fechainicio, string fechafin)
        {
            dgvComprobanteselectronicos.Rows.Clear();
            List<List<string>> registros = new clsEntityDocument().cs_pxObtenerPorFiltroPrincipal(F1, F2, tipo, estadocomprobantesunat, estadocomprobantescc, serienumero, ruc, razonsocial, fechainicio, fechafin);
            foreach (var item in registros)
            {
                dgvComprobanteselectronicos.Rows.Add(
                    item[0].ToString().Trim(),//ID 0
                    false,//1
                    clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(item[3].Trim()),//Comprobantes 2
                    item[28].Trim(),//Estado SCC 3 
                    item[27].Trim(),//Estado SUNAT 4
                    item[1].ToString().Trim(),//Serie - número 5
                    item[2].ToString().Trim(),//Fecha de emisión 6
                    item[21].ToString().Trim(),//Ruc 7
                    item[23].ToString().Trim(),//Razón social 8
                    item[28].ToString().Trim(),//estado scc 9
                    item[27].ToString().Trim(),//estado sunat 10
                    item[35].ToString().Trim(),//Fecha de envío 11
                    item[32].ToString().Trim(),//Comentario de sunat 12
                    item[33].ToString().Trim(),//Incluido en resumen diario 13
                    item[37].ToString().Trim(),//Referencia de Baja de comprobante 14
                    item[37].ToString().Trim(),//Referencia de Baja de comprobante 15
                    item[3].ToString().Trim(),//tipo doc 16
                    item[9].ToString().Trim()//tipo doc referencia 17
                );
            }

            foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
            {
                switch (row.Cells[9].Value.ToString())
                {
                    case "1":
                        row.Cells[3].Style.ForeColor = Color.Red;//Pendiente (errores)
                        Seleccionar.ReadOnly = false;
                        break;
                    case "2":
                        row.Cells[3].Style.ForeColor = Color.RoyalBlue;//Pendiente (correcto)
                        break;
                    case "0":
                        row.Cells[3].Style.ForeColor = Color.Green;//Enviado
                        break;
                }
                row.Cells[3].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(row.Cells[9].Value)).ToUpper();
                switch (row.Cells[10].Value.ToString())
                {
                    case "0":
                        row.Cells[4].Style.ForeColor = Color.Green;//Aceptado
                        break;
                    case "1":
                        row.Cells[4].Style.ForeColor = Color.Brown;//Rechazado
                        break;
                    case "2":
                        row.Cells[4].Style.ForeColor = Color.Red;//Sin respuesta
                        break;
                    case "3":
                        row.Cells[4].Style.ForeColor = Color.Salmon;//Anulado
                        break;
                }
                row.Cells[4].Value = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(row.Cells[10].Value)).ToUpper();
            }
            chkSeleccionartodo.Checked = false;
        }

        private void tmrAlarma_Tick(object sender, EventArgs e)
        {
            try
            {
                if (alarm != null)
                {
                    List<List<string>> Pendientes_envío = new clsEntityDocument().cs_pxObtenerPendientesEnvio();

                    if (alarm.Cs_pr_Envioautomatico == "T" && alarm.Cs_pr_Envioautomatico_minutos == "T" && Pendientes_envío.Count > 0)//Enviar un número de veces al día.
                    {
                        DateTime hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        int fracciones = Convert.ToInt32(alarm.Cs_pr_Envioautomatico_minutosvalor);
                        int horas = 24 / Convert.ToInt32(alarm.Cs_pr_Envioautomatico_minutosvalor);
                        for (int i = 0; i < fracciones; i++)
                        {
                            if (DateTime.Now.ToString().Trim() == hora_base.AddHours(horas * i).ToString().Trim())
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los comprobantes electrónicos pendientes.";
                                ntiEnvio.BalloonTipTitle = "Envío automático de comprobantes 1.";
                                ntiEnvio.BalloonTipIcon = ToolTipIcon.Info;
                                ntiEnvio.ShowBalloonTip(1000);
                                cs_pxEntregarComprobantesAutomático();
                                break;
                            }
                        }
                    }

                    if (alarm.Cs_pr_Envioautomatico == "T" && alarm.Cs_pr_Envioautomatico_hora == "T" && Pendientes_envío.Count > 0)
                    {
                        string hora = DateTime.Now.ToString();
                        if (hora.Substring(10).Trim() == alarm.Cs_pr_Envioautomatico_horavalor.Trim())
                        {
                            ntiEnvio.Visible = true;
                            ntiEnvio.Icon = SystemIcons.Information;
                            ntiEnvio.BalloonTipText = "Se están enviando a SUNAT los comprobantes electrónicos pendientes.";
                            ntiEnvio.BalloonTipTitle = "Envío automático de comprobantes 2.";
                            ntiEnvio.BalloonTipIcon = ToolTipIcon.Info;
                            ntiEnvio.ShowBalloonTip(1000);
                            cs_pxEntregarComprobantesAutomático();
                        }
                    }

                    if (alarm.Cs_pr_Enviomanual == "T" && alarm.Cs_pr_Enviomanual_mostrarglobo == "T" && Pendientes_envío.Count > 0)
                    {
                        //MOSTRAR GLOBO RECORDATORIO CADA CIERTO TIEMPO
                        DateTime hora_base = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
                        int fracciones = Convert.ToInt32(alarm.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        int minutos = 60 / Convert.ToInt32(alarm.Cs_pr_Enviomanual_mostrarglobo_minutosvalor);
                        for (int i = 0; i < fracciones; i++)
                        {
                            if (DateTime.Now.ToString().Trim() == hora_base.AddMinutes(minutos * i).ToString().Trim())
                            {
                                ntiEnvio.Visible = true;
                                ntiEnvio.Icon = SystemIcons.Information;
                                ntiEnvio.BalloonTipText = "Existen " + Pendientes_envío.Count.ToString() + " comprobantes electrónicos pendientes de envío a SUNAT.";
                                ntiEnvio.BalloonTipTitle = "Envío manual de comprobantes.";
                                ntiEnvio.BalloonTipIcon = ToolTipIcon.Info;
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
            catch (Exception)
            {

                throw;
            }
            
        }

        private void informaciónDelDeclaranteFirmaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeclarantes form = new frmDeclarantes();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cs_pxReiniciar();
            }
        }

        private void informaciónDelUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios form  = new frmUsuarios();
            form.ShowDialog();
        }

        private void catalogoSunatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void acercaDeFEIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca form = new frmAcerca();
            form.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alarmasDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlarma form = new frmAlarma(this.alarm);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cs_pxReiniciar();
            }
        }

        private void btnEjectuarBusqueda_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
            tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
        }

        private void btnActualizarregistros_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
            tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
        }

        /*
        private void btnGenerarcomprobantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvComprobanteselectronicos.Rows.Count > 0)
                {
                    int contar_check = 0;
                    foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            contar_check++;
                            clsBaseSunat sunat = new clsBaseSunat();
                            sunat.cs_pxDocumentoGenerar(row.Cells[0].Value.ToString());
                        }
                    }
                    if (contar_check>0)
                    {
                        clsBaseMensaje.cs_pxMsgOk("OKE8");
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR8", ex.ToString());
            }
        }*/

        private void btnEntregarcomprobantes_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            string no_admitido = "";
            try
            {
                if (dgvComprobanteselectronicos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                    {
                        //solo pasar los marcados
                        if ((bool)row.Cells[1].Value == true)
                        {
                            if(row.Cells[10].Value.ToString() != "0" && row.Cells[16].Value.ToString() != "03" && row.Cells[17].Value.ToString() != "03" ) //para produccion
                            //if (row.Cells[10].Value.ToString() != "0")
                            {
                                //marcados correctos no enviados a sunat y no boletas y no notas realcionadas a boleta
                                Cursor.Current = Cursors.WaitCursor;
                                if (new clsBaseSunat().cs_pxEnviarCE(row.Cells[0].Value.ToString()))
                                {
                                    row.Cells[3].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(0).ToUpper();
                                    row.Cells[3].Style.ForeColor = Color.Green;
                                }
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {//marcados incorrectos agregar a mensaje:
                                no_admitido += " -> "+ row.Cells[5].Value.ToString()+" \n";
                            }
                        }
                            /*if ((bool)row.Cells[1].Value == true)
                            {
                                if (new clsBaseSunat().cs_pxEnviarCE(row.Cells[0].Value.ToString()))
                                {
                                    row.Cells[3].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(0).ToUpper();
                                    row.Cells[3].Style.ForeColor = Color.Green;
                                }
                            }*/
                    }
                }

                if (no_admitido != "")
                {
                    //agregar  comentario de envio a resumen diario.
                    clsBaseMensaje.cs_pxMsg("Elementos no enviados","Los siguientes documentos no fueron enviados. Ya fueron enviados o deberian agregarse a resumen diario\n"+no_admitido);
                }
                cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
                tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15",ex.Message);
            }
        }

        private void dgvComprobanteselectronicos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComprobanteselectronicos.Rows.Count > 0)
            {
                if (e.ColumnIndex == 1)
                {
                    dgvComprobanteselectronicos.EndEdit();
                    switch (this.dgvComprobanteselectronicos.CurrentRow.Cells[4].Value.ToString())
                    {
                        case "ACEPTADO":
                            dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                            this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                            break;
                        case "RECHAZADO":
                            dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                            this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                            break;
                        case "SIN ESTADO":
                            dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                            this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                            break;
                        case "ANULADO":
                            dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                            this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                            break;
                    }
                }
                frmComprobantedetalle entidad_comprobantedetalle = new frmComprobantedetalle(dgvComprobanteselectronicos.CurrentRow.Cells[0].Value.ToString());
                entidad_comprobantedetalle.ShowDialog();
            }
        }

        private void chkSeleccionartodo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
            {
                switch (row.Cells[4].Value.ToString())
                {
                    case "ACEPTADO":
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.Cells[1].Value = false;
                        break;
                    case "RECHAZADO":
                        row.Cells[1].Value = true;
                        row.DefaultCellStyle.BackColor = color_fila_seleccionada;
                        break;
                    case "SIN ESTADO":
                        row.Cells[1].Value = true;
                        row.DefaultCellStyle.BackColor = color_fila_seleccionada;
                        break;
                    case "ANULADO":
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.Cells[1].Value = false;
                        break;
                }
            }
            if (chkSeleccionartodo.Checked == false)
            {
                foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                {
                    row.Cells[1].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            switch (cboReporteFormato.SelectedIndex)
            {
                case 0:
                    clsBaseReporte.cs_pxReporteCSV(dgvComprobanteselectronicos, configuracion.cs_prRutareportesCSV + "\\" + DateTime.Today.Date.ToShortDateString().Replace('/', '-') + ".csv");
                    break;
                case 1:
                    clsBaseReporte.cs_pxReportePDF(dgvComprobanteselectronicos, configuracion.cs_prRutareportesPDF + "\\" + DateTime.Today.Date.ToShortDateString().Replace('/', '-') + ".pdf");
                    break;
            }
        }

        private void frmSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\FEI.chm");
        }

        private void txtSerieNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool continuar = false;
            Regex expresion_contenido1 = new Regex(@"^[a-zA-Z0-9]*$");
            Regex expresion_contenido2 = new Regex(@"^[a-zA-Z0-9]+[-]{1}[0-9]*$");
            if (expresion_contenido1.IsMatch(txtSerieNumero.Text) || expresion_contenido2.IsMatch(txtSerieNumero.Text))
            {
                continuar = true;
            }
            if (continuar == true)
            {
                Regex expresion_numerica = new Regex(@"^[a-zA-Z0-9]$");
                Regex expresion_simbolica = new Regex(@"^[-]$");

                Regex expresion = new Regex(@"^[a-zA-Z0-9]$");
                if (expresion_numerica.IsMatch(e.KeyChar.ToString()) || expresion_simbolica.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar != Convert.ToChar(Keys.Back))
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool continuar = false;
            Regex expresion_contenido = new Regex(@"^[0-9]*$");
            if (expresion_contenido.IsMatch(txtSerieNumero.Text) && txtRuc.Text.Length <= 10)
            {
                continuar = true;
            }
            if (continuar == true)
            {
                Regex expresion_numerica = new Regex(@"^[0-9]$");
                if (expresion_numerica.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar != Convert.ToChar(Keys.Back))
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
        
        private void frmSistema_Resize(object sender, EventArgs e)
        {
            /*
            if (WindowState == FormWindowState.Minimized)
            {
                ntiEnvio.BalloonTipIcon = ToolTipIcon.Info;
                ntiEnvio.BalloonTipText = "FEI Se está ejecutando en segudo Plano";
                ntiEnvio.BalloonTipTitle = "Facturación Electrónica Integral";
                ntiEnvio.Icon = global::FEI.Properties.Resources.FEI;
                ntiEnvio.Text = "Facturación Electrónica Integral";
                ntiEnvio.Visible = true;
                ntiEnvio.ShowBalloonTip(3000);
                ShowInTaskbar = false;
            }*/
        }
        
        private void ntiEnvio_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            ntiEnvio.Visible = false;
        }

        private void cs_pxEntregarComprobantesAutomático()
        {
            try
            {
                List<List<string>> Pendientes_envío = new clsEntityDocument().cs_pxObtenerPendientesEnvio();
                foreach (var item in Pendientes_envío)
                {
                    if(item[3].ToString()!="03" && item[9]!="03")
                    {
                        clsBaseSunat sunat = new clsBaseSunat();
                        sunat.cs_pxEnviarCE(item[0]);
                    }
                    
                }
                cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
                tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
            }
        }

        private void dgvComprobanteselectronicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.ColumnIndex == 1)
            {
                dgvComprobanteselectronicos.EndEdit();
                if ((bool)dgvComprobanteselectronicos.Rows[e.RowIndex].Cells[1].Value == true)
                {
                    this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                    this.dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                }
                if ((bool)dgvComprobanteselectronicos.Rows[e.RowIndex].Cells[1].Value == false)
                {
                    this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                    this.dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    chkSeleccionartodo.Checked = false;
                }

                //SUNAT
                switch (this.dgvComprobanteselectronicos.CurrentRow.Cells[4].Value.ToString())
                {
                    case "ACEPTADO":
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        break;
                    case "RECHAZADO":
                        break;
                    case "SIN ESTADO":
                        break;
                    case "ANULADO":
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }*/
        }

        private void mostrarErroresEnElDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvComprobanteselectronicos.Rows.Count > 0)
            {
                dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                frmVisorSUNAT msg = new frmVisorSUNAT(dgvComprobanteselectronicos.CurrentRow.Cells[0].Value.ToString());
                msg.ShowDialog();
            }
        }

        private void dgvComprobanteselectronicos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvComprobanteselectronicos.Rows.Count > 0)
            {
                dgvComprobanteselectronicos.EndEdit();
                switch (this.dgvComprobanteselectronicos.CurrentRow.Cells[4].Value.ToString())
                {
                    case "ACEPTADO":
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                        break;
                    case "RECHAZADO":
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                        break;
                    case "SIN ESTADO":
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = color_fila_seleccionada;
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = true;
                        break;
                    case "ANULADO":
                        dgvComprobanteselectronicos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        this.dgvComprobanteselectronicos.CurrentRow.Cells[1].Value = false;
                        break;
                }
                
                frmComprobantedetalle entidad_comprobantedetalle = new frmComprobantedetalle(dgvComprobanteselectronicos.CurrentRow.Cells[0].Value.ToString());
                entidad_comprobantedetalle.ShowDialog();
            }
        }

        private void dgvComprobanteselectronicos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvComprobanteselectronicos.Rows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {

                }
            }
            else
            {
                cmsGrid.Visible = false;
                cmsGrid.Enabled = false;
            }
        }

        private void btnResumendiario_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            //new frmResumendiario().ShowDialog();            
            try
            {
                List<string> id_id_documentos = new List<string>();
                foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                {
                     if ((bool)row.Cells[1].Value == true && row.Cells[10].Value.ToString() != "3" && row.Cells[13].Value.ToString() == "")//para produccion
                     //if ((bool)row.Cells[1].Value == true) //para homologacion
                     {
                        id_id_documentos.Add(row.Cells[0].Value.ToString());
                     }
                }
                if (id_id_documentos.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea enviar a resumen diario los documentos seleccionados?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        frmResumendiario form= new frmResumendiario(id_id_documentos);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            cs_pxReiniciar();
                        }
                    }
                    else
                    {
                        frmResumendiario form = new frmResumendiario();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            cs_pxReiniciar();
                        }
                    }
                }
                else
                {
                    frmResumendiario form = new frmResumendiario();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        cs_pxReiniciar();
                    }
               }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistar(ex.ToString());
            }
        }
        /// <summary>
        /// Jordy Amaro 09-12-16 Cambios FE-906
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComunicacionbaja_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            //Jordy Amaro 25/10/16 FE-797
            //Cambios en forma de agregar los documentos para comunicacion de baja.
            try
            {
                List<string> id_id_documentos = new List<string>();
                foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                {
                    if ((bool)row.Cells[1].Value == true  && row.Cells[15].Value.ToString() == "")
                    {
                        if (row.Cells[16].Value.ToString() == "03" || row.Cells[17].Value.ToString() == "03")
                        {
                            if (row.Cells[10].Value.ToString() == "0" || row.Cells[10].Value.ToString() == "2") { 
                                //si es boleta o nota asociada solo agregar si ha sido aceptada o no enviada aun
                                id_id_documentos.Add(row.Cells[0].Value.ToString());
                            }

                        }
                        else
                        {
                            if (row.Cells[10].Value.ToString() == "0")
                            {
                                id_id_documentos.Add(row.Cells[0].Value.ToString());
                            }
                        }
                        
                    }
                }
                if (id_id_documentos.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea enviar a comunicación de baja los documentos seleccionados?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        frmComunicacionBajaMotivo form = new frmComunicacionBajaMotivo(id_id_documentos);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            cs_pxReiniciar();
                        }
                    }
                    else
                    {
                        frmComunicacionBajaMotivo form = new frmComunicacionBajaMotivo();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            cs_pxReiniciar();
                        }
                    }
                }
                else
                {
                    frmComunicacionBajaMotivo form = new frmComunicacionBajaMotivo();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        cs_pxReiniciar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistar(ex.ToString());
            }
        }

        private void almacenDeRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasedatosLocal form = new frmBasedatosLocal(Empresa);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cs_pxReiniciarConexión();
                cs_pxReiniciar();
            }
        }

        private void almacenDeRegistrosParaPublicaciónWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasedatosWeb form = new frmBasedatosWeb(Empresa);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cs_pxReiniciarConexión();
                cs_pxReiniciar();
            }
        }

        private void tmrInsertarAWeb_Tick(object sender, EventArgs e)
        {
            new clsEntityDatabaseWeb().cs_pxEnviarAWeb(Empresa);
        }

        private void declarantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeclarantes form = new frmDeclarantes();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cs_pxReiniciarConexión();
                cs_pxReiniciar();
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            actualizarArchivo();
            //De los elementos seleccionados se debe eliminar todo el contenido.
            //ademas eliminar todos los registros asociados en las otras tablas
            try
            {
                //Verificar si hay elementos seleccionados
                int count = 0;
                foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                {
                    if ((bool)row.Cells[1].Value == true)
                    {
                        count++;
                    }
                }

                if (count>0)
                {
                    if (MessageBox.Show("¿Está seguro que desea descartar los documentos seleccionados?\nEstos documentos serán eliminados completamente de la base de datos.", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvComprobanteselectronicos.Rows)
                        {
                            if ((bool)row.Cells[1].Value == true)
                            {
                                new clsEntityDocument().cs_pxEliminarDocumento(row.Cells[0].Value.ToString());
                                cs_pxCargarDgvComprobanteselectronicos(chkFiltroDescripcion.Checked, chkFiltroFechaemision.Checked, cboComprobanteTipo.SelectedIndex, cboComprobanteEstadoSCC.SelectedIndex.ToString(), cboComprobanteEstadoSUNAT.SelectedIndex.ToString(), txtSerieNumero.Text, txtRuc.Text, txtRazonSocial.Text, dtpFechaInicio.Text, dtpFechaFin.Text);
                                tssPendientes.Text = "Pendientes de envío: " + new clsEntityDocument().cs_pxObtenerCantidadPendientesEnvio();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
            }
        }

        private void chkFiltroFechaemision_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroFechaemision.Checked == true)
            {
                chkFiltroDescripcion.Checked = false;
            }            
        }

        private void chkFiltroDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroDescripcion.Checked == true)
            {
                chkFiltroFechaemision.Checked = false;
            }
        }

        private void verificarEstructuraBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLoading().ShowDialog();
        }

        private void rutaDeArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRutaArchivo f = new frmRutaArchivo();
            f.ShowDialog();
        }
    }
}
