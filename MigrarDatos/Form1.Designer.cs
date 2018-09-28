namespace MigrarDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboGestorBasedatos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDbmsdriver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbmsservidorpuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDbnombre = new System.Windows.Forms.TextBox();
            this.txtDbmsservidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDbclave = new System.Windows.Forms.TextBox();
            this.txtDbusuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdriver2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtport2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtsrv2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcontra2 = new System.Windows.Forms.TextBox();
            this.txtUSER2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Migrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboGestorBasedatos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDbmsdriver);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDbmsservidorpuerto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDbnombre);
            this.groupBox1.Controls.Add(this.txtDbmsservidor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDbclave);
            this.groupBox1.Controls.Add(this.txtDbusuario);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion Base de Datos v1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Usuario:";
            // 
            // cboGestorBasedatos
            // 
            this.cboGestorBasedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestorBasedatos.FormattingEnabled = true;
            this.cboGestorBasedatos.Items.AddRange(new object[] {
            "Microsoft SQL Server"});
            this.cboGestorBasedatos.Location = new System.Drawing.Point(178, 40);
            this.cboGestorBasedatos.Name = "cboGestorBasedatos";
            this.cboGestorBasedatos.Size = new System.Drawing.Size(200, 21);
            this.cboGestorBasedatos.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Driver de gestor BD (ODBC):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Gestor BD:";
            // 
            // txtDbmsdriver
            // 
            this.txtDbmsdriver.Enabled = false;
            this.txtDbmsdriver.Location = new System.Drawing.Point(178, 67);
            this.txtDbmsdriver.Name = "txtDbmsdriver";
            this.txtDbmsdriver.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsdriver.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de base de datos:";
            // 
            // txtDbmsservidorpuerto
            // 
            this.txtDbmsservidorpuerto.Location = new System.Drawing.Point(178, 119);
            this.txtDbmsservidorpuerto.Name = "txtDbmsservidorpuerto";
            this.txtDbmsservidorpuerto.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsservidorpuerto.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Puerto del servidor BD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Servidor BD:";
            // 
            // txtDbnombre
            // 
            this.txtDbnombre.Location = new System.Drawing.Point(178, 145);
            this.txtDbnombre.Name = "txtDbnombre";
            this.txtDbnombre.Size = new System.Drawing.Size(200, 20);
            this.txtDbnombre.TabIndex = 24;
            // 
            // txtDbmsservidor
            // 
            this.txtDbmsservidor.Location = new System.Drawing.Point(178, 93);
            this.txtDbmsservidor.Name = "txtDbmsservidor";
            this.txtDbmsservidor.Size = new System.Drawing.Size(200, 20);
            this.txtDbmsservidor.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-40, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Usuario:";
            // 
            // txtDbclave
            // 
            this.txtDbclave.Location = new System.Drawing.Point(178, 197);
            this.txtDbclave.Name = "txtDbclave";
            this.txtDbclave.Size = new System.Drawing.Size(200, 20);
            this.txtDbclave.TabIndex = 28;
            this.txtDbclave.UseSystemPasswordChar = true;
            // 
            // txtDbusuario
            // 
            this.txtDbusuario.Location = new System.Drawing.Point(178, 171);
            this.txtDbusuario.Name = "txtDbusuario";
            this.txtDbusuario.Size = new System.Drawing.Size(200, 20);
            this.txtDbusuario.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtdriver2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtport2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtName2);
            this.groupBox2.Controls.Add(this.txtsrv2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtcontra2);
            this.groupBox2.Controls.Add(this.txtUSER2);
            this.groupBox2.Location = new System.Drawing.Point(488, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion Base de Datos v2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Usuario:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft SQL Server"});
            this.comboBox1.Location = new System.Drawing.Point(179, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Driver de gestor BD (ODBC):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Gestor BD:";
            // 
            // txtdriver2
            // 
            this.txtdriver2.Enabled = false;
            this.txtdriver2.Location = new System.Drawing.Point(179, 67);
            this.txtdriver2.Name = "txtdriver2";
            this.txtdriver2.Size = new System.Drawing.Size(200, 20);
            this.txtdriver2.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Nombre de base de datos:";
            // 
            // txtport2
            // 
            this.txtport2.Location = new System.Drawing.Point(179, 119);
            this.txtport2.Name = "txtport2";
            this.txtport2.Size = new System.Drawing.Size(200, 20);
            this.txtport2.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Puerto del servidor BD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Servidor BD:";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(179, 145);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(200, 20);
            this.txtName2.TabIndex = 38;
            // 
            // txtsrv2
            // 
            this.txtsrv2.Location = new System.Drawing.Point(179, 93);
            this.txtsrv2.Name = "txtsrv2";
            this.txtsrv2.Size = new System.Drawing.Size(200, 20);
            this.txtsrv2.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Contraseña:";
            // 
            // txtcontra2
            // 
            this.txtcontra2.Location = new System.Drawing.Point(179, 197);
            this.txtcontra2.Name = "txtcontra2";
            this.txtcontra2.Size = new System.Drawing.Size(200, 20);
            this.txtcontra2.TabIndex = 41;
            this.txtcontra2.UseSystemPasswordChar = true;
            // 
            // txtUSER2
            // 
            this.txtUSER2.Location = new System.Drawing.Point(179, 171);
            this.txtUSER2.Name = "txtUSER2";
            this.txtUSER2.Size = new System.Drawing.Size(200, 20);
            this.txtUSER2.TabIndex = 39;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 343);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(871, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 378);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migrar Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboGestorBasedatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDbmsdriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDbmsservidorpuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDbnombre;
        private System.Windows.Forms.TextBox txtDbmsservidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDbclave;
        private System.Windows.Forms.TextBox txtDbusuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdriver2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtport2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtsrv2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcontra2;
        private System.Windows.Forms.TextBox txtUSER2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

