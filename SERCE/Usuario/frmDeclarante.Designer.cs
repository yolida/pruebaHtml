namespace FEI.Usuario
{
    partial class frmDeclarante
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtUsuariosol = new System.Windows.Forms.TextBox();
            this.txtClavesol = new System.Windows.Forms.TextBox();
            this.lblUsuarioSol = new System.Windows.Forms.Label();
            this.lblClavesol = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCertificadodigital = new System.Windows.Forms.Label();
            this.txtCertificadodigital = new System.Windows.Forms.TextBox();
            this.txtCertificadodigitalclave = new System.Windows.Forms.TextBox();
            this.lblCertificadodigitalclave = new System.Windows.Forms.Label();
            this.lblRazonsocial = new System.Windows.Forms.Label();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(145, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(265, 191);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtUsuariosol
            // 
            this.txtUsuariosol.Location = new System.Drawing.Point(145, 61);
            this.txtUsuariosol.Name = "txtUsuariosol";
            this.txtUsuariosol.Size = new System.Drawing.Size(200, 20);
            this.txtUsuariosol.TabIndex = 3;
            // 
            // txtClavesol
            // 
            this.txtClavesol.Location = new System.Drawing.Point(145, 87);
            this.txtClavesol.Name = "txtClavesol";
            this.txtClavesol.Size = new System.Drawing.Size(200, 20);
            this.txtClavesol.TabIndex = 4;
            this.txtClavesol.UseSystemPasswordChar = true;
            // 
            // lblUsuarioSol
            // 
            this.lblUsuarioSol.AutoSize = true;
            this.lblUsuarioSol.Location = new System.Drawing.Point(12, 64);
            this.lblUsuarioSol.Name = "lblUsuarioSol";
            this.lblUsuarioSol.Size = new System.Drawing.Size(70, 13);
            this.lblUsuarioSol.TabIndex = 4;
            this.lblUsuarioSol.Text = "Usuario SOL:";
            // 
            // lblClavesol
            // 
            this.lblClavesol.AutoSize = true;
            this.lblClavesol.Location = new System.Drawing.Point(12, 90);
            this.lblClavesol.Name = "lblClavesol";
            this.lblClavesol.Size = new System.Drawing.Size(61, 13);
            this.lblClavesol.TabIndex = 3;
            this.lblClavesol.Text = "Clave SOL:";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(145, 9);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(200, 20);
            this.txtRUC.TabIndex = 1;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(12, 12);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(33, 13);
            this.lblRuc.TabIndex = 1;
            this.lblRuc.Text = "RUC:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(179, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCertificadodigital
            // 
            this.lblCertificadodigital.AutoSize = true;
            this.lblCertificadodigital.Location = new System.Drawing.Point(12, 116);
            this.lblCertificadodigital.Name = "lblCertificadodigital";
            this.lblCertificadodigital.Size = new System.Drawing.Size(120, 13);
            this.lblCertificadodigital.TabIndex = 5;
            this.lblCertificadodigital.Text = "Certificado digital (*.pfx):";
            // 
            // txtCertificadodigital
            // 
            this.txtCertificadodigital.Location = new System.Drawing.Point(145, 113);
            this.txtCertificadodigital.Name = "txtCertificadodigital";
            this.txtCertificadodigital.Size = new System.Drawing.Size(200, 20);
            this.txtCertificadodigital.TabIndex = 5;
            // 
            // txtCertificadodigitalclave
            // 
            this.txtCertificadodigitalclave.Location = new System.Drawing.Point(145, 139);
            this.txtCertificadodigitalclave.Name = "txtCertificadodigitalclave";
            this.txtCertificadodigitalclave.Size = new System.Drawing.Size(200, 20);
            this.txtCertificadodigitalclave.TabIndex = 6;
            this.txtCertificadodigitalclave.UseSystemPasswordChar = true;
            // 
            // lblCertificadodigitalclave
            // 
            this.lblCertificadodigitalclave.AutoSize = true;
            this.lblCertificadodigitalclave.Location = new System.Drawing.Point(12, 142);
            this.lblCertificadodigitalclave.Name = "lblCertificadodigitalclave";
            this.lblCertificadodigitalclave.Size = new System.Drawing.Size(126, 13);
            this.lblCertificadodigitalclave.TabIndex = 12;
            this.lblCertificadodigitalclave.Text = "Certificado digital - Clave:";
            // 
            // lblRazonsocial
            // 
            this.lblRazonsocial.AutoSize = true;
            this.lblRazonsocial.Location = new System.Drawing.Point(12, 38);
            this.lblRazonsocial.Name = "lblRazonsocial";
            this.lblRazonsocial.Size = new System.Drawing.Size(71, 13);
            this.lblRazonsocial.TabIndex = 13;
            this.lblRazonsocial.Text = "Razón social:";
            // 
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(145, 35);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.Size = new System.Drawing.Size(200, 20);
            this.txtRazonsocial.TabIndex = 2;
            // 
            // frmDeclarante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 226);
            this.Controls.Add(this.txtRazonsocial);
            this.Controls.Add(this.lblRazonsocial);
            this.Controls.Add(this.txtCertificadodigitalclave);
            this.Controls.Add(this.lblCertificadodigitalclave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCertificadodigital);
            this.Controls.Add(this.txtUsuariosol);
            this.Controls.Add(this.txtClavesol);
            this.Controls.Add(this.lblCertificadodigital);
            this.Controls.Add(this.lblUsuarioSol);
            this.Controls.Add(this.lblClavesol);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(373, 247);
            this.Name = "frmDeclarante";
            this.Text = "Configuración - Información del declarante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeclarante_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label lblClavesol;
        private System.Windows.Forms.Label lblUsuarioSol;
        private System.Windows.Forms.TextBox txtClavesol;
        private System.Windows.Forms.TextBox txtUsuariosol;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCertificadodigital;
        private System.Windows.Forms.TextBox txtCertificadodigital;
        private System.Windows.Forms.TextBox txtCertificadodigitalclave;
        private System.Windows.Forms.Label lblCertificadodigitalclave;
        private System.Windows.Forms.Label lblRazonsocial;
        private System.Windows.Forms.TextBox txtRazonsocial;
    }
}