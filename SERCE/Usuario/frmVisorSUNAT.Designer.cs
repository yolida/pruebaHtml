namespace FEI.Usuario
{
    partial class frmVisorSUNAT
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
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wbrTextoPlano = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trvXML = new System.Windows.Forms.TreeView();
            this.rbtRecepción = new System.Windows.Forms.RadioButton();
            this.rbtEnvío = new System.Windows.Forms.RadioButton();
            this.grpInformacionDocumento = new System.Windows.Forms.GroupBox();
            this.lblDocumentotipo = new System.Windows.Forms.Label();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.lblSerienumero = new System.Windows.Forms.Label();
            this.txtFechaemision = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lblRazonsocial = new System.Windows.Forms.Label();
            this.txtSerienumero = new System.Windows.Forms.TextBox();
            this.lblFechaemision = new System.Windows.Forms.Label();
            this.txtDocumentotipo = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ofdDescargar = new System.Windows.Forms.OpenFileDialog();
            this.btnDescargarXML = new System.Windows.Forms.Button();
            this.sfdDescargar = new System.Windows.Forms.SaveFileDialog();
            this.btnDescargarXML_Recepción = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpInformacionDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Controls.Add(this.tabPage3);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 124);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(760, 396);
            this.tbcPrincipal.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wbrTextoPlano);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Validación de documentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wbrTextoPlano
            // 
            this.wbrTextoPlano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrTextoPlano.Location = new System.Drawing.Point(3, 3);
            this.wbrTextoPlano.Name = "wbrTextoPlano";
            this.wbrTextoPlano.Size = new System.Drawing.Size(746, 364);
            this.wbrTextoPlano.TabIndex = 2;
            this.wbrTextoPlano.WebBrowserShortcutsEnabled = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trvXML);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estructura XML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trvXML
            // 
            this.trvXML.BackColor = System.Drawing.Color.Gainsboro;
            this.trvXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvXML.Location = new System.Drawing.Point(3, 3);
            this.trvXML.Name = "trvXML";
            this.trvXML.Size = new System.Drawing.Size(746, 364);
            this.trvXML.TabIndex = 0;
            // 
            // rbtRecepción
            // 
            this.rbtRecepción.AutoSize = true;
            this.rbtRecepción.Location = new System.Drawing.Point(162, 522);
            this.rbtRecepción.Name = "rbtRecepción";
            this.rbtRecepción.Size = new System.Drawing.Size(145, 17);
            this.rbtRecepción.TabIndex = 16;
            this.rbtRecepción.TabStop = true;
            this.rbtRecepción.Text = "Documento de recepción";
            this.rbtRecepción.UseVisualStyleBackColor = true;
            // 
            // rbtEnvío
            // 
            this.rbtEnvío.AutoSize = true;
            this.rbtEnvío.Location = new System.Drawing.Point(12, 522);
            this.rbtEnvío.Name = "rbtEnvío";
            this.rbtEnvío.Size = new System.Drawing.Size(126, 17);
            this.rbtEnvío.TabIndex = 15;
            this.rbtEnvío.TabStop = true;
            this.rbtEnvío.Text = "Documento de envío";
            this.rbtEnvío.UseVisualStyleBackColor = true;
            this.rbtEnvío.CheckedChanged += new System.EventHandler(this.rbtEnvío_CheckedChanged);
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
            this.grpInformacionDocumento.TabIndex = 18;
            this.grpInformacionDocumento.TabStop = false;
            this.grpInformacionDocumento.Text = "Información del documento:";
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
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(118, 74);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.ReadOnly = true;
            this.txtRazonsocial.Size = new System.Drawing.Size(626, 20);
            this.txtRazonsocial.TabIndex = 14;
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
            // lblRazonsocial
            // 
            this.lblRazonsocial.AutoSize = true;
            this.lblRazonsocial.Location = new System.Drawing.Point(10, 77);
            this.lblRazonsocial.Name = "lblRazonsocial";
            this.lblRazonsocial.Size = new System.Drawing.Size(74, 13);
            this.lblRazonsocial.TabIndex = 7;
            this.lblRazonsocial.Text = "Razón social: ";
            // 
            // txtSerienumero
            // 
            this.txtSerienumero.Location = new System.Drawing.Point(514, 22);
            this.txtSerienumero.Name = "txtSerienumero";
            this.txtSerienumero.ReadOnly = true;
            this.txtSerienumero.Size = new System.Drawing.Size(230, 20);
            this.txtSerienumero.TabIndex = 11;
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
            // btnDescargarXML
            // 
            this.btnDescargarXML.Location = new System.Drawing.Point(345, 526);
            this.btnDescargarXML.Name = "btnDescargarXML";
            this.btnDescargarXML.Size = new System.Drawing.Size(170, 23);
            this.btnDescargarXML.TabIndex = 22;
            this.btnDescargarXML.Text = "Descargar XML de Envío";
            this.btnDescargarXML.UseVisualStyleBackColor = true;
            this.btnDescargarXML.Click += new System.EventHandler(this.btnDescargarXML_Click);
            // 
            // btnDescargarXML_Recepción
            // 
            this.btnDescargarXML_Recepción.Location = new System.Drawing.Point(521, 526);
            this.btnDescargarXML_Recepción.Name = "btnDescargarXML_Recepción";
            this.btnDescargarXML_Recepción.Size = new System.Drawing.Size(170, 23);
            this.btnDescargarXML_Recepción.TabIndex = 23;
            this.btnDescargarXML_Recepción.Text = "Descargar XML de Recepción";
            this.btnDescargarXML_Recepción.UseVisualStyleBackColor = true;
            this.btnDescargarXML_Recepción.Click += new System.EventHandler(this.btnDescargarXML_Recepción_Click);
            // 
            // frmVisorSUNAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDescargarXML_Recepción);
            this.Controls.Add(this.btnDescargarXML);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.rbtRecepción);
            this.Controls.Add(this.rbtEnvío);
            this.Controls.Add(this.grpInformacionDocumento);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmVisorSUNAT";
            this.Text = "Visor de documentos";
            this.Load += new System.EventHandler(this.frmVisorSUNAT_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grpInformacionDocumento.ResumeLayout(false);
            this.grpInformacionDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RadioButton rbtEnvío;
        private System.Windows.Forms.RadioButton rbtRecepción;
        private System.Windows.Forms.GroupBox grpInformacionDocumento;
        private System.Windows.Forms.Label lblDocumentotipo;
        private System.Windows.Forms.TextBox txtRazonsocial;
        private System.Windows.Forms.Label lblSerienumero;
        private System.Windows.Forms.TextBox txtFechaemision;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lblRazonsocial;
        private System.Windows.Forms.TextBox txtSerienumero;
        private System.Windows.Forms.Label lblFechaemision;
        private System.Windows.Forms.TextBox txtDocumentotipo;
        private System.Windows.Forms.WebBrowser wbrTextoPlano;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView trvXML;
        private System.Windows.Forms.OpenFileDialog ofdDescargar;
        private System.Windows.Forms.Button btnDescargarXML;
        private System.Windows.Forms.SaveFileDialog sfdDescargar;
        private System.Windows.Forms.Button btnDescargarXML_Recepción;
    }
}