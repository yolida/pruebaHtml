namespace FEI.Configuracion
{
    partial class frmBasedatosWeb
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDbmsdriver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbmsservidorpuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbnombre = new System.Windows.Forms.TextBox();
            this.txtDbmsservidor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDbclave = new System.Windows.Forms.TextBox();
            this.txtDbusuario = new System.Windows.Forms.TextBox();
            this.cboGestorBasedatos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(280, 196);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 196);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(173, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear base de datos";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Driver de gestor BD (ODBC):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gestor BD:";
            // 
            // txtDbmsdriver
            // 
            this.txtDbmsdriver.Location = new System.Drawing.Point(160, 35);
            this.txtDbmsdriver.Name = "txtDbmsdriver";
            this.txtDbmsdriver.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsdriver.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre de base de datos:";
            // 
            // txtDbmsservidorpuerto
            // 
            this.txtDbmsservidorpuerto.Location = new System.Drawing.Point(160, 87);
            this.txtDbmsservidorpuerto.Name = "txtDbmsservidorpuerto";
            this.txtDbmsservidorpuerto.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsservidorpuerto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puerto del servidor BD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Servidor BD:";
            // 
            // txtDbnombre
            // 
            this.txtDbnombre.Location = new System.Drawing.Point(160, 113);
            this.txtDbnombre.Name = "txtDbnombre";
            this.txtDbnombre.Size = new System.Drawing.Size(200, 20);
            this.txtDbnombre.TabIndex = 5;
            // 
            // txtDbmsservidor
            // 
            this.txtDbmsservidor.Location = new System.Drawing.Point(160, 61);
            this.txtDbmsservidor.Name = "txtDbmsservidor";
            this.txtDbmsservidor.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsservidor.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(194, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario:";
            // 
            // txtDbclave
            // 
            this.txtDbclave.Location = new System.Drawing.Point(160, 165);
            this.txtDbclave.Name = "txtDbclave";
            this.txtDbclave.Size = new System.Drawing.Size(200, 20);
            this.txtDbclave.TabIndex = 7;
            this.txtDbclave.UseSystemPasswordChar = true;
            // 
            // txtDbusuario
            // 
            this.txtDbusuario.Location = new System.Drawing.Point(160, 139);
            this.txtDbusuario.Name = "txtDbusuario";
            this.txtDbusuario.Size = new System.Drawing.Size(200, 20);
            this.txtDbusuario.TabIndex = 6;
            // 
            // cboGestorBasedatos
            // 
            this.cboGestorBasedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestorBasedatos.FormattingEnabled = true;
            this.cboGestorBasedatos.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "MySQL",
            "SQLite"});
            this.cboGestorBasedatos.Location = new System.Drawing.Point(160, 8);
            this.cboGestorBasedatos.Name = "cboGestorBasedatos";
            this.cboGestorBasedatos.Size = new System.Drawing.Size(200, 21);
            this.cboGestorBasedatos.TabIndex = 1;
            this.cboGestorBasedatos.SelectedIndexChanged += new System.EventHandler(this.cboGestorBasedatos_SelectedIndexChanged);
            // 
            // frmBasedatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 232);
            this.Controls.Add(this.cboGestorBasedatos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDbmsdriver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDbmsservidorpuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDbnombre);
            this.Controls.Add(this.txtDbmsservidor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDbclave);
            this.Controls.Add(this.txtDbusuario);
            this.MaximumSize = new System.Drawing.Size(391, 271);
            this.MinimumSize = new System.Drawing.Size(391, 271);
            this.Name = "frmBasedatos";
            this.Text = "Configuración - Base de datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBasedatos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDbusuario;
        private System.Windows.Forms.TextBox txtDbclave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDbmsservidor;
        private System.Windows.Forms.TextBox txtDbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDbmsservidorpuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbmsdriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboGestorBasedatos;
    }
}