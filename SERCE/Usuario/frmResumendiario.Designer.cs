namespace FEI.Usuario
{
    partial class frmResumendiario
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
            this.btnConsultarTiket = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEjectuarBusqueda = new System.Windows.Forms.Button();
            this.btnEnviarResumendiario = new System.Windows.Forms.Button();
            this.dgvResumendiario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExceptionSUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario_sunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_SUNAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_SCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnSustituir = new System.Windows.Forms.Button();
            this.cmsGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumendiario)).BeginInit();
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
            // btnConsultarTiket
            // 
            this.btnConsultarTiket.Location = new System.Drawing.Point(418, 418);
            this.btnConsultarTiket.Name = "btnConsultarTiket";
            this.btnConsultarTiket.Size = new System.Drawing.Size(143, 23);
            this.btnConsultarTiket.TabIndex = 10;
            this.btnConsultarTiket.Text = "Consultar ticket";
            this.btnConsultarTiket.UseVisualStyleBackColor = true;
            this.btnConsultarTiket.Click += new System.EventHandler(this.btnConsultarTiket_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(567, 418);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.btnEjectuarBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de resumenes: ";
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
            // btnEnviarResumendiario
            // 
            this.btnEnviarResumendiario.Location = new System.Drawing.Point(269, 418);
            this.btnEnviarResumendiario.Name = "btnEnviarResumendiario";
            this.btnEnviarResumendiario.Size = new System.Drawing.Size(143, 23);
            this.btnEnviarResumendiario.TabIndex = 2;
            this.btnEnviarResumendiario.Text = "Entregar R. D. a SUNAT";
            this.btnEnviarResumendiario.UseVisualStyleBackColor = true;
            this.btnEnviarResumendiario.Click += new System.EventHandler(this.btnEnviarResumendiario_Click);
            // 
            // dgvResumendiario
            // 
            this.dgvResumendiario.AllowUserToAddRows = false;
            this.dgvResumendiario.AllowUserToDeleteRows = false;
            this.dgvResumendiario.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvResumendiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResumendiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResumendiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Seleccionar,
            this.Codigo,
            this.FechaReferencia,
            this.fecha,
            this.Ticket,
            this.EstadoSCC,
            this.EstadoSUNAT,
            this.ExceptionSUNAT,
            this.comentario_sunat,
            this.E_SUNAT,
            this.E_SCC});
            this.dgvResumendiario.ContextMenuStrip = this.cmsGrid;
            this.dgvResumendiario.EnableHeadersVisualStyles = false;
            this.dgvResumendiario.Location = new System.Drawing.Point(12, 96);
            this.dgvResumendiario.Name = "dgvResumendiario";
            this.dgvResumendiario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResumendiario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResumendiario.Size = new System.Drawing.Size(630, 316);
            this.dgvResumendiario.TabIndex = 1;
            this.dgvResumendiario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumendiario_CellDoubleClick);
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
            // FechaReferencia
            // 
            this.FechaReferencia.HeaderText = "F. de referencia";
            this.FechaReferencia.Name = "FechaReferencia";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "F. de envío";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
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
            this.EstadoSUNAT.HeaderText = "Estado SUNAT ";
            this.EstadoSUNAT.Name = "EstadoSUNAT";
            this.EstadoSUNAT.Width = 130;
            // 
            // ExceptionSUNAT
            // 
            this.ExceptionSUNAT.HeaderText = "Comentario desde SUNAT";
            this.ExceptionSUNAT.Name = "ExceptionSUNAT";
            this.ExceptionSUNAT.Width = 200;
            // 
            // comentario_sunat
            // 
            this.comentario_sunat.HeaderText = "Excepcion SUNAT";
            this.comentario_sunat.Name = "comentario_sunat";
            this.comentario_sunat.Width = 150;
            // 
            // E_SUNAT
            // 
            this.E_SUNAT.HeaderText = "E_SUNAT";
            this.E_SUNAT.Name = "E_SUNAT";
            this.E_SUNAT.Visible = false;
            // 
            // E_SCC
            // 
            this.E_SCC.HeaderText = "E_SCC";
            this.E_SCC.Name = "E_SCC";
            this.E_SCC.Visible = false;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(176, 418);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(85, 23);
            this.btnDescartar.TabIndex = 11;
            this.btnDescartar.Text = "Descartar RC";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnSustituir
            // 
            this.btnSustituir.Location = new System.Drawing.Point(13, 418);
            this.btnSustituir.Name = "btnSustituir";
            this.btnSustituir.Size = new System.Drawing.Size(102, 23);
            this.btnSustituir.TabIndex = 12;
            this.btnSustituir.Text = "Liberar resumen";
            this.btnSustituir.UseVisualStyleBackColor = true;
            this.btnSustituir.Click += new System.EventHandler(this.btnSustituir_Click);
            // 
            // frmResumendiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.btnSustituir);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnConsultarTiket);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviarResumendiario);
            this.Controls.Add(this.dgvResumendiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmResumendiario";
            this.Text = "Resumen diario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResumendiario_FormClosing);
            this.Load += new System.EventHandler(this.frmResumendiario_Load);
            this.cmsGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumendiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResumendiario;
        private System.Windows.Forms.Button btnEnviarResumendiario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjectuarBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarErroresEnElDocumentoToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnConsultarTiket;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExceptionSUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario_sunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_SUNAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_SCC;
        private System.Windows.Forms.Button btnSustituir;
    }
}