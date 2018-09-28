namespace FEI.Usuario
{
    partial class frmComunicacionBajaMotivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarErroresEnElDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDescartarComunicacionbaja = new System.Windows.Forms.Button();
            this.btnConsultarTiket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEjectuarBusqueda = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnviarComunicacionbaja = new System.Windows.Forms.Button();
            this.dgvComunicacionbaja = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Comunicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_TICKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario_sunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_SCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_SUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esta_comunicacionbaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia_comunicacionbaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComunicacionbaja)).BeginInit();
            this.SuspendLayout();
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
            // btnDescartarComunicacionbaja
            // 
            this.btnDescartarComunicacionbaja.Location = new System.Drawing.Point(120, 416);
            this.btnDescartarComunicacionbaja.Name = "btnDescartarComunicacionbaja";
            this.btnDescartarComunicacionbaja.Size = new System.Drawing.Size(143, 23);
            this.btnDescartarComunicacionbaja.TabIndex = 34;
            this.btnDescartarComunicacionbaja.Text = "Descartar documento";
            this.btnDescartarComunicacionbaja.UseVisualStyleBackColor = true;
            this.btnDescartarComunicacionbaja.Click += new System.EventHandler(this.btnDescartarComunicacionbaja_Click);
            // 
            // btnConsultarTiket
            // 
            this.btnConsultarTiket.Location = new System.Drawing.Point(418, 416);
            this.btnConsultarTiket.Name = "btnConsultarTiket";
            this.btnConsultarTiket.Size = new System.Drawing.Size(143, 23);
            this.btnConsultarTiket.TabIndex = 33;
            this.btnConsultarTiket.Text = "Consultar ticket";
            this.btnConsultarTiket.UseVisualStyleBackColor = true;
            this.btnConsultarTiket.Click += new System.EventHandler(this.btnConsultarTiket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.btnEjectuarBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de documentos: ";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(18, 50);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(72, 13);
            this.lblFechaFin.TabIndex = 30;
            this.lblFechaFin.Text = "Fecha de fin: ";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(18, 24);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(85, 13);
            this.lblFechaInicio.TabIndex = 29;
            this.lblFechaInicio.Text = "Fecha de inicio: ";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(109, 47);
            this.dtpFechaFin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 28;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(109, 21);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // btnEjectuarBusqueda
            // 
            this.btnEjectuarBusqueda.Image = global::SERCE.Properties.Resources.edit_find;
            this.btnEjectuarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjectuarBusqueda.Location = new System.Drawing.Point(435, 14);
            this.btnEjectuarBusqueda.Name = "btnEjectuarBusqueda";
            this.btnEjectuarBusqueda.Size = new System.Drawing.Size(189, 24);
            this.btnEjectuarBusqueda.TabIndex = 22;
            this.btnEjectuarBusqueda.Text = "Realizar búsqueda";
            this.btnEjectuarBusqueda.Click += new System.EventHandler(this.btnEjectuarBusqueda_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(567, 416);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEnviarComunicacionbaja
            // 
            this.btnEnviarComunicacionbaja.Location = new System.Drawing.Point(269, 416);
            this.btnEnviarComunicacionbaja.Name = "btnEnviarComunicacionbaja";
            this.btnEnviarComunicacionbaja.Size = new System.Drawing.Size(143, 23);
            this.btnEnviarComunicacionbaja.TabIndex = 31;
            this.btnEnviarComunicacionbaja.Text = "Entregar C. B. a SUNAT";
            this.btnEnviarComunicacionbaja.UseVisualStyleBackColor = true;
            this.btnEnviarComunicacionbaja.Click += new System.EventHandler(this.btnEnviarComunicacionbaja_Click);
            // 
            // dgvComunicacionbaja
            // 
            this.dgvComunicacionbaja.AllowUserToAddRows = false;
            this.dgvComunicacionbaja.AllowUserToDeleteRows = false;
            this.dgvComunicacionbaja.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvComunicacionbaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComunicacionbaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComunicacionbaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Seleccionar,
            this.Codigo,
            this.Fecha_Comunicacion,
            this.Fecha_referencia,
            this.fecha,
            this.Ticket,
            this.EstadoSCC,
            this.EstadoSUNAT,
            this.ESTADO_TICKET,
            this.comentario_sunat,
            this.Estado_SCC,
            this.Estado_SUNAT,
            this.esta_comunicacionbaja,
            this.Referencia_comunicacionbaja});
            this.dgvComunicacionbaja.ContextMenuStrip = this.cmsGrid;
            this.dgvComunicacionbaja.EnableHeadersVisualStyles = false;
            this.dgvComunicacionbaja.Location = new System.Drawing.Point(12, 95);
            this.dgvComunicacionbaja.Name = "dgvComunicacionbaja";
            this.dgvComunicacionbaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComunicacionbaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComunicacionbaja.Size = new System.Drawing.Size(630, 315);
            this.dgvComunicacionbaja.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 23;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha_Comunicacion
            // 
            this.Fecha_Comunicacion.HeaderText = "Fecha de comunicación";
            this.Fecha_Comunicacion.Name = "Fecha_Comunicacion";
            this.Fecha_Comunicacion.Width = 150;
            // 
            // Fecha_referencia
            // 
            this.Fecha_referencia.HeaderText = "Fecha de referencia";
            this.Fecha_referencia.Name = "Fecha_referencia";
            this.Fecha_referencia.Visible = false;
            this.Fecha_referencia.Width = 150;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de envío";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            // 
            // EstadoSCC
            // 
            this.EstadoSCC.HeaderText = "Estado SCC";
            this.EstadoSCC.Name = "EstadoSCC";
            // 
            // EstadoSUNAT
            // 
            this.EstadoSUNAT.HeaderText = "Estado SUNAT";
            this.EstadoSUNAT.Name = "EstadoSUNAT";
            // 
            // ESTADO_TICKET
            // 
            this.ESTADO_TICKET.HeaderText = "Estado SUNAT (Ticket)";
            this.ESTADO_TICKET.Name = "ESTADO_TICKET";
            this.ESTADO_TICKET.Width = 150;
            // 
            // comentario_sunat
            // 
            this.comentario_sunat.HeaderText = "Comentario desde SUNAT";
            this.comentario_sunat.Name = "comentario_sunat";
            this.comentario_sunat.Width = 300;
            // 
            // Estado_SCC
            // 
            this.Estado_SCC.HeaderText = "Estado_SCC";
            this.Estado_SCC.Name = "Estado_SCC";
            this.Estado_SCC.Visible = false;
            // 
            // Estado_SUNAT
            // 
            this.Estado_SUNAT.HeaderText = "Estado_SUNAT";
            this.Estado_SUNAT.Name = "Estado_SUNAT";
            this.Estado_SUNAT.Visible = false;
            // 
            // esta_comunicacionbaja
            // 
            this.esta_comunicacionbaja.HeaderText = "Estado en c. de baja";
            this.esta_comunicacionbaja.Name = "esta_comunicacionbaja";
            this.esta_comunicacionbaja.Visible = false;
            // 
            // Referencia_comunicacionbaja
            // 
            this.Referencia_comunicacionbaja.HeaderText = "Referencia_comunicacionbaja";
            this.Referencia_comunicacionbaja.Name = "Referencia_comunicacionbaja";
            this.Referencia_comunicacionbaja.Visible = false;
            // 
            // frmComunicacionBajaMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.btnDescartarComunicacionbaja);
            this.Controls.Add(this.btnConsultarTiket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEnviarComunicacionbaja);
            this.Controls.Add(this.dgvComunicacionbaja);
            this.Name = "frmComunicacionBajaMotivo";
            this.Text = "Comunicación de baja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComunicacionBajaMotivo_FormClosing);
            this.Load += new System.EventHandler(this.frmComunicacionBaja_Load);
            this.cmsGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComunicacionbaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnEjectuarBusqueda;
        private System.Windows.Forms.DataGridView dgvComunicacionbaja;
        private System.Windows.Forms.Button btnConsultarTiket;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEnviarComunicacionbaja;
        private System.Windows.Forms.Button btnDescartarComunicacionbaja;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarErroresEnElDocumentoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Comunicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_TICKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario_sunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_SCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_SUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn esta_comunicacionbaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia_comunicacionbaja;
    }
}