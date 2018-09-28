namespace FEI.Usuario
{
    partial class frmComprobantedetalle
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDetalle = new FEI.Base.ucBaseDatagridview();
            this.lblSerienumero = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.lblRazonsocial = new System.Windows.Forms.Label();
            this.lblFechaemision = new System.Windows.Forms.Label();
            this.txtDocumentotipo = new System.Windows.Forms.TextBox();
            this.lblDocumentotipo = new System.Windows.Forms.Label();
            this.txtSerienumero = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtFechaemision = new System.Windows.Forms.TextBox();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.grpInformacionDocumento = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.grpInformacionDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(697, 526);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 124);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalle.Size = new System.Drawing.Size(760, 396);
            this.dgvDetalle.TabIndex = 4;
            // 
            // lblSerienumero
            // 
            this.lblSerienumero.AutoSize = true;
            this.lblSerienumero.Location = new System.Drawing.Point(412, 25);
            this.lblSerienumero.Name = "lblSerienumero";
            this.lblSerienumero.Size = new System.Drawing.Size(79, 13);
            this.lblSerienumero.TabIndex = 5;
            this.lblSerienumero.Text = "Serie/Número: ";
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
            // lblRazonsocial
            // 
            this.lblRazonsocial.AutoSize = true;
            this.lblRazonsocial.Location = new System.Drawing.Point(10, 77);
            this.lblRazonsocial.Name = "lblRazonsocial";
            this.lblRazonsocial.Size = new System.Drawing.Size(74, 13);
            this.lblRazonsocial.TabIndex = 7;
            this.lblRazonsocial.Text = "Razón social: ";
            // 
            // lblFechaemision
            // 
            this.lblFechaemision.AutoSize = true;
            this.lblFechaemision.Location = new System.Drawing.Point(412, 51);
            this.lblFechaemision.Name = "lblFechaemision";
            this.lblFechaemision.Size = new System.Drawing.Size(96, 13);
            this.lblFechaemision.TabIndex = 8;
            this.lblFechaemision.Text = "Fecha de emisión: ";
            // 
            // txtDocumentotipo
            // 
            this.txtDocumentotipo.Location = new System.Drawing.Point(118, 22);
            this.txtDocumentotipo.Name = "txtDocumentotipo";
            this.txtDocumentotipo.ReadOnly = true;
            this.txtDocumentotipo.Size = new System.Drawing.Size(230, 20);
            this.txtDocumentotipo.TabIndex = 9;
            // 
            // lblDocumentotipo
            // 
            this.lblDocumentotipo.AutoSize = true;
            this.lblDocumentotipo.Location = new System.Drawing.Point(10, 25);
            this.lblDocumentotipo.Name = "lblDocumentotipo";
            this.lblDocumentotipo.Size = new System.Drawing.Size(102, 13);
            this.lblDocumentotipo.TabIndex = 10;
            this.lblDocumentotipo.Text = "Tipo de documento:";
            // 
            // txtSerienumero
            // 
            this.txtSerienumero.Location = new System.Drawing.Point(514, 22);
            this.txtSerienumero.Name = "txtSerienumero";
            this.txtSerienumero.ReadOnly = true;
            this.txtSerienumero.Size = new System.Drawing.Size(230, 20);
            this.txtSerienumero.TabIndex = 11;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(118, 48);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(230, 20);
            this.txtRuc.TabIndex = 12;
            // 
            // txtFechaemision
            // 
            this.txtFechaemision.Location = new System.Drawing.Point(514, 48);
            this.txtFechaemision.Name = "txtFechaemision";
            this.txtFechaemision.ReadOnly = true;
            this.txtFechaemision.Size = new System.Drawing.Size(230, 20);
            this.txtFechaemision.TabIndex = 13;
            // 
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(118, 74);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.ReadOnly = true;
            this.txtRazonsocial.Size = new System.Drawing.Size(626, 20);
            this.txtRazonsocial.TabIndex = 14;
            // 
            // grpInformacionDocumento
            // 
            this.grpInformacionDocumento.Controls.Add(this.lblDocumentotipo);
            this.grpInformacionDocumento.Controls.Add(this.txtRazonsocial);
            this.grpInformacionDocumento.Controls.Add(this.lblSerienumero);
            this.grpInformacionDocumento.Controls.Add(this.txtFechaemision);
            this.grpInformacionDocumento.Controls.Add(this.lblRuc);
            this.grpInformacionDocumento.Controls.Add(this.txtRuc);
            this.grpInformacionDocumento.Controls.Add(this.lblRazonsocial);
            this.grpInformacionDocumento.Controls.Add(this.txtSerienumero);
            this.grpInformacionDocumento.Controls.Add(this.lblFechaemision);
            this.grpInformacionDocumento.Controls.Add(this.txtDocumentotipo);
            this.grpInformacionDocumento.Location = new System.Drawing.Point(12, 12);
            this.grpInformacionDocumento.Name = "grpInformacionDocumento";
            this.grpInformacionDocumento.Size = new System.Drawing.Size(760, 106);
            this.grpInformacionDocumento.TabIndex = 15;
            this.grpInformacionDocumento.TabStop = false;
            this.grpInformacionDocumento.Text = "Información del documento:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 520;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmComprobantedetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpInformacionDocumento);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmComprobantedetalle";
            this.Text = "Detalle del comprobante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.grpInformacionDocumento.ResumeLayout(false);
            this.grpInformacionDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private Base.ucBaseDatagridview dgvDetalle;
        private System.Windows.Forms.Label lblSerienumero;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label lblRazonsocial;
        private System.Windows.Forms.Label lblFechaemision;
        private System.Windows.Forms.TextBox txtDocumentotipo;
        private System.Windows.Forms.Label lblDocumentotipo;
        private System.Windows.Forms.TextBox txtSerienumero;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtFechaemision;
        private System.Windows.Forms.TextBox txtRazonsocial;
        private System.Windows.Forms.GroupBox grpInformacionDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}