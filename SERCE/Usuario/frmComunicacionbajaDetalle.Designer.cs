namespace FEI.Usuario
{
    partial class frmComunicacionbajaDetalle
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
            this.grpInformacionDocumento = new System.Windows.Forms.GroupBox();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtFechaemision = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmsDetalle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descartarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvComprobanteselectronicos = new FEI.Base.ucBaseDatagridview();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ComunicacionBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInformacionDocumento.SuspendLayout();
            this.cmsDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteselectronicos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacionDocumento
            // 
            this.grpInformacionDocumento.Controls.Add(this.txtRazonsocial);
            this.grpInformacionDocumento.Controls.Add(this.lblDocumento);
            this.grpInformacionDocumento.Controls.Add(this.txtFechaemision);
            this.grpInformacionDocumento.Controls.Add(this.lblRuc);
            this.grpInformacionDocumento.Controls.Add(this.txtRuc);
            this.grpInformacionDocumento.Controls.Add(this.label3);
            this.grpInformacionDocumento.Controls.Add(this.txtDocumento);
            this.grpInformacionDocumento.Controls.Add(this.label4);
            this.grpInformacionDocumento.Location = new System.Drawing.Point(12, 12);
            this.grpInformacionDocumento.Name = "grpInformacionDocumento";
            this.grpInformacionDocumento.Size = new System.Drawing.Size(760, 106);
            this.grpInformacionDocumento.TabIndex = 32;
            this.grpInformacionDocumento.TabStop = false;
            this.grpInformacionDocumento.Text = "Información del documento:";
            // 
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(118, 74);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.ReadOnly = true;
            this.txtRazonsocial.Size = new System.Drawing.Size(626, 20);
            this.txtRazonsocial.TabIndex = 14;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(10, 25);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtFechaemision
            // 
            this.txtFechaemision.Location = new System.Drawing.Point(514, 48);
            this.txtFechaemision.Name = "txtFechaemision";
            this.txtFechaemision.ReadOnly = true;
            this.txtFechaemision.Size = new System.Drawing.Size(230, 20);
            this.txtFechaemision.TabIndex = 13;
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(10, 51);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(33, 13);
            this.lblRuc.TabIndex = 6;
            this.lblRuc.Text = "RUC:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(118, 48);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(230, 20);
            this.txtRuc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Razón social: ";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(118, 22);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(230, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de emisión: ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(860, 453);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(697, 526);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Cerrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmsDetalle
            // 
            this.cmsDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descartarDocumentoToolStripMenuItem,
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem});
            this.cmsDetalle.Name = "cmsDetalle";
            this.cmsDetalle.Size = new System.Drawing.Size(317, 48);
            // 
            // descartarDocumentoToolStripMenuItem
            // 
            this.descartarDocumentoToolStripMenuItem.Name = "descartarDocumentoToolStripMenuItem";
            this.descartarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.descartarDocumentoToolStripMenuItem.Text = "Descartar documento";
            this.descartarDocumentoToolStripMenuItem.Click += new System.EventHandler(this.descartarDocumentoToolStripMenuItem_Click);
            // 
            // agregarComentarioDeComunicaciónDeBajaToolStripMenuItem
            // 
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem.Name = "agregarComentarioDeComunicaciónDeBajaToolStripMenuItem";
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem.Text = "Agregar comentario de comunicación de baja";
            this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem.Click += new System.EventHandler(this.agregarComentarioDeComunicaciónDeBajaToolStripMenuItem_Click);
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
            this.Orden,
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
            this.ComunicacionBaja,
            this.Motivo});
            this.dgvComprobanteselectronicos.ContextMenuStrip = this.cmsDetalle;
            this.dgvComprobanteselectronicos.EnableHeadersVisualStyles = false;
            this.dgvComprobanteselectronicos.Location = new System.Drawing.Point(12, 124);
            this.dgvComprobanteselectronicos.Name = "dgvComprobanteselectronicos";
            this.dgvComprobanteselectronicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComprobanteselectronicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComprobanteselectronicos.Size = new System.Drawing.Size(760, 396);
            this.dgvComprobanteselectronicos.TabIndex = 23;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "ID.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Visible = false;
            this.Seleccionar.Width = 24;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Nro. orden";
            this.Orden.Name = "Orden";
            // 
            // comprobante
            // 
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
            this.estadoscc.Width = 160;
            // 
            // estadosunat
            // 
            this.estadosunat.HeaderText = "Estado SUNAT";
            this.estadosunat.Name = "estadosunat";
            this.estadosunat.ReadOnly = true;
            this.estadosunat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estadosunat.Width = 160;
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
            this.ruc.Visible = false;
            // 
            // razonsocial
            // 
            this.razonsocial.HeaderText = "Razón social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            this.razonsocial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.razonsocial.Visible = false;
            this.razonsocial.Width = 400;
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
            // 
            // Comentario_SUNAT
            // 
            this.Comentario_SUNAT.HeaderText = "Comentario desde SUNAT";
            this.Comentario_SUNAT.Name = "Comentario_SUNAT";
            this.Comentario_SUNAT.Width = 300;
            // 
            // Incluido_en_resumen_diario
            // 
            this.Incluido_en_resumen_diario.HeaderText = "R. D.";
            this.Incluido_en_resumen_diario.Name = "Incluido_en_resumen_diario";
            this.Incluido_en_resumen_diario.Visible = false;
            this.Incluido_en_resumen_diario.Width = 40;
            // 
            // ComunicacionBaja
            // 
            this.ComunicacionBaja.HeaderText = "Comunicación de baja";
            this.ComunicacionBaja.Name = "ComunicacionBaja";
            this.ComunicacionBaja.Visible = false;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo de baja";
            this.Motivo.Name = "Motivo";
            this.Motivo.Width = 300;
            // 
            // frmComunicacionbajaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpInformacionDocumento);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvComprobanteselectronicos);
            this.Name = "frmComunicacionbajaDetalle";
            this.Text = "Comunicación de baja - Detalle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComunicacionbajaDetalle_FormClosing);
            this.Load += new System.EventHandler(this.frmResumendiarioOpciones_Load);
            this.grpInformacionDocumento.ResumeLayout(false);
            this.grpInformacionDocumento.PerformLayout();
            this.cmsDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteselectronicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Base.ucBaseDatagridview dgvComprobanteselectronicos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox grpInformacionDocumento;
        private System.Windows.Forms.TextBox txtRazonsocial;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtFechaemision;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ContextMenuStrip cmsDetalle;
        private System.Windows.Forms.ToolStripMenuItem descartarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarComentarioDeComunicaciónDeBajaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ComunicacionBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
    }
}