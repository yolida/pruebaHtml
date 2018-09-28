using SERCE.Properties;
using System.Resources;

namespace FEI.Usuario
{
    partial class frmSistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.tmrAlarma = new System.Windows.Forms.Timer(this.components);
            this.ntiEnvio = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarErroresEnElDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSeleccionartodo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.cboReporteFormato = new System.Windows.Forms.ComboBox();
            this.btnEntregarcomprobantes = new System.Windows.Forms.Button();
            this.btnActualizarregistros = new System.Windows.Forms.Button();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboComprobanteEstadoSCC = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboComprobanteEstadoSUNAT = new System.Windows.Forms.ComboBox();
            this.cboComprobanteTipo = new System.Windows.Forms.ComboBox();
            this.btnEjectuarBusqueda = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerieNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFiltroFechaemision = new System.Windows.Forms.CheckBox();
            this.chkFiltroDescripcion = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sstPrincipal = new System.Windows.Forms.StatusStrip();
            this.tssPendientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.conexiónABaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenDeRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarEstructuraBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.alarmasDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeFEIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaDeArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrAsíncrono = new System.Windows.Forms.Timer(this.components);
            this.btnResumendiario = new System.Windows.Forms.Button();
            this.btnComunicacionbaja = new System.Windows.Forms.Button();
            this.tmrInsertarAWeb = new System.Windows.Forms.Timer(this.components);
            this.btnDescartar = new System.Windows.Forms.Button();
            this.dgvComprobanteselectronicos = new FEI.Base.ucBaseDatagridview();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoscc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serienumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaemision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSCC_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSUNAT_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_envío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario_SUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incluido_en_resumen_diario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia_comunicacionbaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsGrid.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            this.sstPrincipal.SuspendLayout();
            this.mstPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteselectronicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAlarma
            // 
            this.tmrAlarma.Interval = 1000;
            this.tmrAlarma.Tick += new System.EventHandler(this.tmrAlarma_Tick);
            // 
            // ntiEnvio
            // 
            this.ntiEnvio.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntiEnvio.BalloonTipText = "FEI Se está ejecutando en segudo Plano";
            this.ntiEnvio.BalloonTipTitle = "Facturación Electrónica Integral";
            this.ntiEnvio.Icon = global::SERCE.Properties.Resources.serce;
            this.ntiEnvio.Text = "Facturación Electrónica Integral";
            this.ntiEnvio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntiEnvio_MouseClick);
            // 
            // cmsGrid
            // 
            this.cmsGrid.AllowMerge = false;
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalleToolStripMenuItem,
            this.mostrarErroresEnElDocumentoToolStripMenuItem});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(260, 48);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.verDetalleToolStripMenuItem.Text = "Mostrar Items de este documento";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // mostrarErroresEnElDocumentoToolStripMenuItem
            // 
            this.mostrarErroresEnElDocumentoToolStripMenuItem.Name = "mostrarErroresEnElDocumentoToolStripMenuItem";
            this.mostrarErroresEnElDocumentoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.mostrarErroresEnElDocumentoToolStripMenuItem.Text = "Mostrar Estructura de este documento";
            this.mostrarErroresEnElDocumentoToolStripMenuItem.Click += new System.EventHandler(this.mostrarErroresEnElDocumentoToolStripMenuItem_Click);
            // 
            // chkSeleccionartodo
            // 
            this.chkSeleccionartodo.AutoSize = true;
            this.chkSeleccionartodo.Location = new System.Drawing.Point(58, 173);
            this.chkSeleccionartodo.Name = "chkSeleccionartodo";
            this.chkSeleccionartodo.Size = new System.Drawing.Size(15, 14);
            this.chkSeleccionartodo.TabIndex = 26;
            this.chkSeleccionartodo.UseVisualStyleBackColor = true;
            this.chkSeleccionartodo.CheckedChanged += new System.EventHandler(this.chkSeleccionartodo_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Exportar a:";
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::SERCE.Properties.Resources.document_print1;
            this.btnReporte.Location = new System.Drawing.Point(147, 609);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(33, 24);
            this.btnReporte.TabIndex = 24;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // cboReporteFormato
            // 
            this.cboReporteFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReporteFormato.FormattingEnabled = true;
            this.cboReporteFormato.Location = new System.Drawing.Point(73, 611);
            this.cboReporteFormato.Name = "cboReporteFormato";
            this.cboReporteFormato.Size = new System.Drawing.Size(68, 21);
            this.cboReporteFormato.TabIndex = 23;
            // 
            // btnEntregarcomprobantes
            // 
            this.btnEntregarcomprobantes.Image = global::SERCE.Properties.Resources.mail_reply_all;
            this.btnEntregarcomprobantes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEntregarcomprobantes.Location = new System.Drawing.Point(843, 608);
            this.btnEntregarcomprobantes.Name = "btnEntregarcomprobantes";
            this.btnEntregarcomprobantes.Size = new System.Drawing.Size(149, 24);
            this.btnEntregarcomprobantes.TabIndex = 21;
            this.btnEntregarcomprobantes.Text = "Entregar C. E. a SUNAT";
            this.btnEntregarcomprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregarcomprobantes.UseVisualStyleBackColor = true;
            this.btnEntregarcomprobantes.Click += new System.EventHandler(this.btnEntregarcomprobantes_Click);
            // 
            // btnActualizarregistros
            // 
            this.btnActualizarregistros.Image = global::SERCE.Properties.Resources.view_refresh;
            this.btnActualizarregistros.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnActualizarregistros.Location = new System.Drawing.Point(446, 608);
            this.btnActualizarregistros.Name = "btnActualizarregistros";
            this.btnActualizarregistros.Size = new System.Drawing.Size(103, 24);
            this.btnActualizarregistros.TabIndex = 20;
            this.btnActualizarregistros.Text = "Refrescar grilla";
            this.btnActualizarregistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarregistros.UseVisualStyleBackColor = true;
            this.btnActualizarregistros.Click += new System.EventHandler(this.btnActualizarregistros_Click);
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtRuc);
            this.grpFiltro.Controls.Add(this.label8);
            this.grpFiltro.Controls.Add(this.cboComprobanteEstadoSCC);
            this.grpFiltro.Controls.Add(this.dtpFechaFin);
            this.grpFiltro.Controls.Add(this.dtpFechaInicio);
            this.grpFiltro.Controls.Add(this.cboComprobanteEstadoSUNAT);
            this.grpFiltro.Controls.Add(this.cboComprobanteTipo);
            this.grpFiltro.Controls.Add(this.btnEjectuarBusqueda);
            this.grpFiltro.Controls.Add(this.txtRazonSocial);
            this.grpFiltro.Controls.Add(this.label7);
            this.grpFiltro.Controls.Add(this.label5);
            this.grpFiltro.Controls.Add(this.txtSerieNumero);
            this.grpFiltro.Controls.Add(this.label6);
            this.grpFiltro.Controls.Add(this.chkFiltroFechaemision);
            this.grpFiltro.Controls.Add(this.chkFiltroDescripcion);
            this.grpFiltro.Controls.Add(this.label4);
            this.grpFiltro.Controls.Add(this.label2);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.label3);
            this.grpFiltro.Location = new System.Drawing.Point(12, 33);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(980, 128);
            this.grpFiltro.TabIndex = 17;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtrar comprobantes electrónicos:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(475, 68);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(130, 20);
            this.txtRuc.TabIndex = 29;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Estado del comprobante SCC: ";
            // 
            // cboComprobanteEstadoSCC
            // 
            this.cboComprobanteEstadoSCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobanteEstadoSCC.FormattingEnabled = true;
            this.cboComprobanteEstadoSCC.Location = new System.Drawing.Point(203, 95);
            this.cboComprobanteEstadoSCC.Name = "cboComprobanteEstadoSCC";
            this.cboComprobanteEstadoSCC.Size = new System.Drawing.Size(179, 21);
            this.cboComprobanteEstadoSCC.TabIndex = 26;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(746, 70);
            this.dtpFechaFin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 25;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(746, 44);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 24;
            // 
            // cboComprobanteEstadoSUNAT
            // 
            this.cboComprobanteEstadoSUNAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobanteEstadoSUNAT.FormattingEnabled = true;
            this.cboComprobanteEstadoSUNAT.Location = new System.Drawing.Point(203, 68);
            this.cboComprobanteEstadoSUNAT.Name = "cboComprobanteEstadoSUNAT";
            this.cboComprobanteEstadoSUNAT.Size = new System.Drawing.Size(179, 21);
            this.cboComprobanteEstadoSUNAT.TabIndex = 23;
            // 
            // cboComprobanteTipo
            // 
            this.cboComprobanteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobanteTipo.FormattingEnabled = true;
            this.cboComprobanteTipo.Location = new System.Drawing.Point(203, 41);
            this.cboComprobanteTipo.Name = "cboComprobanteTipo";
            this.cboComprobanteTipo.Size = new System.Drawing.Size(179, 21);
            this.cboComprobanteTipo.TabIndex = 22;
            // 
            // btnEjectuarBusqueda
            // 
            this.btnEjectuarBusqueda.Image = global::SERCE.Properties.Resources.edit_find;
            this.btnEjectuarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjectuarBusqueda.Location = new System.Drawing.Point(658, 95);
            this.btnEjectuarBusqueda.Name = "btnEjectuarBusqueda";
            this.btnEjectuarBusqueda.Size = new System.Drawing.Size(189, 24);
            this.btnEjectuarBusqueda.TabIndex = 21;
            this.btnEjectuarBusqueda.Text = "Realizar búsqueda";
            this.btnEjectuarBusqueda.Click += new System.EventHandler(this.btnEjectuarBusqueda_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(475, 95);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(130, 20);
            this.txtRazonSocial.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Razón social: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serie - número: ";
            // 
            // txtSerieNumero
            // 
            this.txtSerieNumero.Location = new System.Drawing.Point(475, 42);
            this.txtSerieNumero.Name = "txtSerieNumero";
            this.txtSerieNumero.Size = new System.Drawing.Size(130, 20);
            this.txtSerieNumero.TabIndex = 16;
            this.txtSerieNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerieNumero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "RUC:";
            // 
            // chkFiltroFechaemision
            // 
            this.chkFiltroFechaemision.AutoSize = true;
            this.chkFiltroFechaemision.Location = new System.Drawing.Point(639, 19);
            this.chkFiltroFechaemision.Name = "chkFiltroFechaemision";
            this.chkFiltroFechaemision.Size = new System.Drawing.Size(185, 17);
            this.chkFiltroFechaemision.TabIndex = 0;
            this.chkFiltroFechaemision.Text = "Filtrar rango por fecha de emisión:";
            this.chkFiltroFechaemision.UseVisualStyleBackColor = true;
            this.chkFiltroFechaemision.CheckedChanged += new System.EventHandler(this.chkFiltroFechaemision_CheckedChanged);
            // 
            // chkFiltroDescripcion
            // 
            this.chkFiltroDescripcion.AutoSize = true;
            this.chkFiltroDescripcion.Location = new System.Drawing.Point(12, 19);
            this.chkFiltroDescripcion.Name = "chkFiltroDescripcion";
            this.chkFiltroDescripcion.Size = new System.Drawing.Size(211, 17);
            this.chkFiltroDescripcion.TabIndex = 14;
            this.chkFiltroDescripcion.Text = "Filtrar por descripción del comprobante:";
            this.chkFiltroDescripcion.UseVisualStyleBackColor = true;
            this.chkFiltroDescripcion.CheckedChanged += new System.EventHandler(this.chkFiltroDescripcion_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de comprobante: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de fin: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de inicio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estado del comprobante SUNAT: ";
            // 
            // sstPrincipal
            // 
            this.sstPrincipal.AutoSize = false;
            this.sstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssPendientes,
            this.toolStripStatusLabel2,
            this.tssEmpresa,
            this.toolStripStatusLabel1,
            this.tssUsuario});
            this.sstPrincipal.Location = new System.Drawing.Point(0, 655);
            this.sstPrincipal.Name = "sstPrincipal";
            this.sstPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sstPrincipal.Size = new System.Drawing.Size(1004, 26);
            this.sstPrincipal.TabIndex = 2;
            this.sstPrincipal.Text = "sstPrincipal";
            // 
            // tssPendientes
            // 
            this.tssPendientes.Image = global::SERCE.Properties.Resources.mail_forward;
            this.tssPendientes.Name = "tssPendientes";
            this.tssPendientes.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.tssPendientes.Size = new System.Drawing.Size(173, 21);
            this.tssPendientes.Text = "Pendientes de envío: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 21);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tssEmpresa
            // 
            this.tssEmpresa.Name = "tssEmpresa";
            this.tssEmpresa.Size = new System.Drawing.Size(102, 21);
            this.tssEmpresa.Text = "Empresa: (Ninguno)";
            this.tssEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 21);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(97, 21);
            this.tssUsuario.Text = "Usuario: (Ninguno)";
            this.tssUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mstPrincipal.Size = new System.Drawing.Size(1004, 24);
            this.mstPrincipal.TabIndex = 0;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem,
            this.informaciónDelUsuarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.conexiónABaseDeDatosToolStripMenuItem,
            this.toolStripSeparator3,
            this.alarmasDelSistemaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::SERCE.Properties.Resources.preferences_system;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.archivoToolStripMenuItem.Text = "Configuración";
            // 
            // informaciónDelDeclaranteFirmaDigitalToolStripMenuItem
            // 
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Image = global::SERCE.Properties.Resources.system_lock_screen1;
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Name = "informaciónDelDeclaranteFirmaDigitalToolStripMenuItem";
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Text = "Empresas";
            this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem.Click += new System.EventHandler(this.informaciónDelDeclaranteFirmaDigitalToolStripMenuItem_Click);
            // 
            // informaciónDelUsuarioToolStripMenuItem
            // 
            this.informaciónDelUsuarioToolStripMenuItem.Name = "informaciónDelUsuarioToolStripMenuItem";
            this.informaciónDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informaciónDelUsuarioToolStripMenuItem.Text = "Usuarios y permisos";
            this.informaciónDelUsuarioToolStripMenuItem.Click += new System.EventHandler(this.informaciónDelUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // conexiónABaseDeDatosToolStripMenuItem
            // 
            this.conexiónABaseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenDeRegistrosToolStripMenuItem,
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem,
            this.verificarEstructuraBaseDeDatosToolStripMenuItem});
            this.conexiónABaseDeDatosToolStripMenuItem.Image = global::SERCE.Properties.Resources.network_server;
            this.conexiónABaseDeDatosToolStripMenuItem.Name = "conexiónABaseDeDatosToolStripMenuItem";
            this.conexiónABaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.conexiónABaseDeDatosToolStripMenuItem.Text = "Conexión a base de datos";
            // 
            // almacenDeRegistrosToolStripMenuItem
            // 
            this.almacenDeRegistrosToolStripMenuItem.Name = "almacenDeRegistrosToolStripMenuItem";
            this.almacenDeRegistrosToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.almacenDeRegistrosToolStripMenuItem.Text = "Almacen de registros";
            this.almacenDeRegistrosToolStripMenuItem.Click += new System.EventHandler(this.almacenDeRegistrosToolStripMenuItem_Click);
            // 
            // almacenDeRegistrosParaPublicaciónWebToolStripMenuItem
            // 
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Name = "almacenDeRegistrosParaPublicaciónWebToolStripMenuItem";
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Text = "Almacen de registros - Publicación web";
            this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem.Click += new System.EventHandler(this.almacenDeRegistrosParaPublicaciónWebToolStripMenuItem_Click);
            // 
            // verificarEstructuraBaseDeDatosToolStripMenuItem
            // 
            this.verificarEstructuraBaseDeDatosToolStripMenuItem.Name = "verificarEstructuraBaseDeDatosToolStripMenuItem";
            this.verificarEstructuraBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.verificarEstructuraBaseDeDatosToolStripMenuItem.Text = "Verificar Estructura Base de Datos";
            this.verificarEstructuraBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.verificarEstructuraBaseDeDatosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // alarmasDelSistemaToolStripMenuItem
            // 
            this.alarmasDelSistemaToolStripMenuItem.Name = "alarmasDelSistemaToolStripMenuItem";
            this.alarmasDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.alarmasDelSistemaToolStripMenuItem.Text = "Formas de envío y alertas";
            this.alarmasDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.alarmasDelSistemaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::SERCE.Properties.Resources.application_exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.toolStripSeparator2,
            this.acercaDeFEIToolStripMenuItem,
            this.rutaDeArchivosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = global::SERCE.Properties.Resources.help_contents;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Image = global::SERCE.Properties.Resources.help_browser2;
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // acercaDeFEIToolStripMenuItem
            // 
            this.acercaDeFEIToolStripMenuItem.Image = global::SERCE.Properties.Resources.system_lock_screen;
            this.acercaDeFEIToolStripMenuItem.Name = "acercaDeFEIToolStripMenuItem";
            this.acercaDeFEIToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.acercaDeFEIToolStripMenuItem.Text = "Acerca de FEI";
            this.acercaDeFEIToolStripMenuItem.Click += new System.EventHandler(this.acercaDeFEIToolStripMenuItem_Click);
            // 
            // rutaDeArchivosToolStripMenuItem
            // 
            this.rutaDeArchivosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rutaDeArchivosToolStripMenuItem.Image")));
            this.rutaDeArchivosToolStripMenuItem.Name = "rutaDeArchivosToolStripMenuItem";
            this.rutaDeArchivosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rutaDeArchivosToolStripMenuItem.Text = "Ruta de archivos";
            this.rutaDeArchivosToolStripMenuItem.Click += new System.EventHandler(this.rutaDeArchivosToolStripMenuItem_Click);
            // 
            // btnResumendiario
            // 
            this.btnResumendiario.Image = global::SERCE.Properties.Resources.edit_paste;
            this.btnResumendiario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnResumendiario.Location = new System.Drawing.Point(565, 608);
            this.btnResumendiario.Name = "btnResumendiario";
            this.btnResumendiario.Size = new System.Drawing.Size(109, 24);
            this.btnResumendiario.TabIndex = 28;
            this.btnResumendiario.Text = "Resumen diario";
            this.btnResumendiario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumendiario.UseVisualStyleBackColor = true;
            this.btnResumendiario.Click += new System.EventHandler(this.btnResumendiario_Click);
            // 
            // btnComunicacionbaja
            // 
            this.btnComunicacionbaja.Image = global::SERCE.Properties.Resources.mail_mark_not_junk;
            this.btnComunicacionbaja.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnComunicacionbaja.Location = new System.Drawing.Point(690, 608);
            this.btnComunicacionbaja.Name = "btnComunicacionbaja";
            this.btnComunicacionbaja.Size = new System.Drawing.Size(140, 24);
            this.btnComunicacionbaja.TabIndex = 29;
            this.btnComunicacionbaja.Text = "Comunicación de baja";
            this.btnComunicacionbaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComunicacionbaja.UseVisualStyleBackColor = true;
            this.btnComunicacionbaja.Click += new System.EventHandler(this.btnComunicacionbaja_Click);
            // 
            // tmrInsertarAWeb
            // 
            this.tmrInsertarAWeb.Enabled = true;
            this.tmrInsertarAWeb.Interval = 500000;
            this.tmrInsertarAWeb.Tick += new System.EventHandler(this.tmrInsertarAWeb_Tick);
            // 
            // btnDescartar
            // 
            this.btnDescartar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDescartar.Location = new System.Drawing.Point(299, 609);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(130, 24);
            this.btnDescartar.TabIndex = 30;
            this.btnDescartar.Text = "Descartar documentos";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // dgvComprobanteselectronicos
            // 
            this.dgvComprobanteselectronicos.AllowUserToAddRows = false;
            this.dgvComprobanteselectronicos.AllowUserToDeleteRows = false;
            this.dgvComprobanteselectronicos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvComprobanteselectronicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComprobanteselectronicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprobanteselectronicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Seleccionar,
            this.comprobante,
            this.estadoscc,
            this.estadosunat,
            this.serienumero,
            this.fechaemision,
            this.ruc,
            this.razonsocial,
            this.EstadoSCC_codigo,
            this.EstadoSUNAT_codigo,
            this.Fecha_envío,
            this.Comentario_SUNAT,
            this.Incluido_en_resumen_diario,
            this.cb_estado,
            this.referencia_comunicacionbaja,
            this.tipoDoc,
            this.TipoDocRef});
            this.dgvComprobanteselectronicos.ContextMenuStrip = this.cmsGrid;
            this.dgvComprobanteselectronicos.EnableHeadersVisualStyles = false;
            this.dgvComprobanteselectronicos.Location = new System.Drawing.Point(11, 167);
            this.dgvComprobanteselectronicos.Name = "dgvComprobanteselectronicos";
            this.dgvComprobanteselectronicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComprobanteselectronicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComprobanteselectronicos.Size = new System.Drawing.Size(980, 435);
            this.dgvComprobanteselectronicos.TabIndex = 22;
            this.dgvComprobanteselectronicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobanteselectronicos_CellContentClick);
            this.dgvComprobanteselectronicos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobanteselectronicos_CellContentDoubleClick);
            this.dgvComprobanteselectronicos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComprobanteselectronicos_CellMouseClick);
            this.dgvComprobanteselectronicos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComprobanteselectronicos_CellMouseDown);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.Frozen = true;
            this.id.HeaderText = "ID.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Frozen = true;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 24;
            // 
            // comprobante
            // 
            this.comprobante.Frozen = true;
            this.comprobante.HeaderText = "Comprobante";
            this.comprobante.Name = "comprobante";
            this.comprobante.ReadOnly = true;
            this.comprobante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.comprobante.Width = 160;
            // 
            // estadoscc
            // 
            this.estadoscc.HeaderText = "Estado SCC";
            this.estadoscc.Name = "estadoscc";
            this.estadoscc.ReadOnly = true;
            this.estadoscc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // estadosunat
            // 
            this.estadosunat.HeaderText = "Estado SUNAT";
            this.estadosunat.Name = "estadosunat";
            this.estadosunat.ReadOnly = true;
            this.estadosunat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // serienumero
            // 
            this.serienumero.HeaderText = "Serie - número";
            this.serienumero.Name = "serienumero";
            this.serienumero.ReadOnly = true;
            this.serienumero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechaemision
            // 
            this.fechaemision.HeaderText = "Fecha de emisión";
            this.fechaemision.Name = "fechaemision";
            this.fechaemision.ReadOnly = true;
            this.fechaemision.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ruc
            // 
            this.ruc.HeaderText = "RUC";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // razonsocial
            // 
            this.razonsocial.HeaderText = "Razón social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.razonsocial.Width = 300;
            // 
            // EstadoSCC_codigo
            // 
            this.EstadoSCC_codigo.HeaderText = "EstadoSCC_codigo";
            this.EstadoSCC_codigo.Name = "EstadoSCC_codigo";
            this.EstadoSCC_codigo.Visible = false;
            // 
            // EstadoSUNAT_codigo
            // 
            this.EstadoSUNAT_codigo.HeaderText = "EstadoSUNAT_codigo";
            this.EstadoSUNAT_codigo.Name = "EstadoSUNAT_codigo";
            this.EstadoSUNAT_codigo.Visible = false;
            // 
            // Fecha_envío
            // 
            this.Fecha_envío.HeaderText = "Fecha de envío";
            this.Fecha_envío.Name = "Fecha_envío";
            this.Fecha_envío.ReadOnly = true;
            this.Fecha_envío.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha_envío.Width = 150;
            // 
            // Comentario_SUNAT
            // 
            this.Comentario_SUNAT.HeaderText = "Comentario desde SUNAT";
            this.Comentario_SUNAT.Name = "Comentario_SUNAT";
            this.Comentario_SUNAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comentario_SUNAT.Width = 400;
            // 
            // Incluido_en_resumen_diario
            // 
            this.Incluido_en_resumen_diario.HeaderText = "R. D.";
            this.Incluido_en_resumen_diario.Name = "Incluido_en_resumen_diario";
            this.Incluido_en_resumen_diario.Visible = false;
            this.Incluido_en_resumen_diario.Width = 40;
            // 
            // cb_estado
            // 
            this.cb_estado.HeaderText = "Estado de Com. de baja";
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Visible = false;
            // 
            // referencia_comunicacionbaja
            // 
            this.referencia_comunicacionbaja.HeaderText = "referencia_comunicacionbaja";
            this.referencia_comunicacionbaja.Name = "referencia_comunicacionbaja";
            this.referencia_comunicacionbaja.Visible = false;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "tipoDoc";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipoDoc.Visible = false;
            // 
            // TipoDocRef
            // 
            this.TipoDocRef.HeaderText = "TipoDocRef";
            this.TipoDocRef.Name = "TipoDocRef";
            this.TipoDocRef.Visible = false;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 681);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnComunicacionbaja);
            this.Controls.Add(this.btnResumendiario);
            this.Controls.Add(this.chkSeleccionartodo);
            this.Controls.Add(this.dgvComprobanteselectronicos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cboReporteFormato);
            this.Controls.Add(this.btnEntregarcomprobantes);
            this.Controls.Add(this.btnActualizarregistros);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.sstPrincipal);
            this.Controls.Add(this.mstPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstPrincipal;
            this.MinimizeBox = true;
            this.Name = "frmSistema";
            this.ShowInTaskbar = true;
            this.Text = "Facturación Electrónica Integrada  01.00.00";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSistema_FormClosing);
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.Resize += new System.EventHandler(this.frmSistema_Resize);
            this.cmsGrid.ResumeLayout(false);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.sstPrincipal.ResumeLayout(false);
            this.sstPrincipal.PerformLayout();
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteselectronicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónABaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDelUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeFEIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem alarmasDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel tssPendientes;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboComprobanteEstadoSCC;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cboComprobanteEstadoSUNAT;
        private System.Windows.Forms.ComboBox cboComprobanteTipo;
        private System.Windows.Forms.Button btnEjectuarBusqueda;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerieNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFiltroFechaemision;
        private System.Windows.Forms.CheckBox chkFiltroDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Base.ucBaseDatagridview dgvComprobanteselectronicos;
        private System.Windows.Forms.Button btnEntregarcomprobantes;
        private System.Windows.Forms.Button btnActualizarregistros;
        private System.Windows.Forms.ComboBox cboReporteFormato;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip sstPrincipal;
        private System.Windows.Forms.Timer tmrAlarma;
        private System.Windows.Forms.NotifyIcon ntiEnvio;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.CheckBox chkSeleccionartodo;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarErroresEnElDocumentoToolStripMenuItem;
        private System.Windows.Forms.Timer tmrAsíncrono;
        private System.Windows.Forms.Button btnResumendiario;
        private System.Windows.Forms.Button btnComunicacionbaja;
        private System.Windows.Forms.ToolStripMenuItem almacenDeRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenDeRegistrosParaPublicaciónWebToolStripMenuItem;
        private System.Windows.Forms.Timer tmrInsertarAWeb;
        private System.Windows.Forms.ToolStripMenuItem informaciónDelDeclaranteFirmaDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel tssEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.ToolStripMenuItem verificarEstructuraBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaDeArchivosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoscc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn serienumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSCC_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSUNAT_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_envío;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario_SUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incluido_en_resumen_diario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cb_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia_comunicacionbaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocRef;
    }
}

