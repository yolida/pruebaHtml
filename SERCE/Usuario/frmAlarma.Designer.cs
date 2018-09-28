namespace FEI.Usuario
{
    partial class frmAlarma
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEnviomanual = new System.Windows.Forms.CheckBox();
            this.cboEnviomanual_mostrarglobo_minutosvalor = new System.Windows.Forms.ComboBox();
            this.rbtEnviomanual_nomostrarglobo = new System.Windows.Forms.RadioButton();
            this.rbtEnviomanual_mostrarglobo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnvioautomatico_horavalor = new System.Windows.Forms.DateTimePicker();
            this.chkEnvioautomatico = new System.Windows.Forms.CheckBox();
            this.cboEnvioautomatico_minutosvalor = new System.Windows.Forms.ComboBox();
            this.rbtEnvioautomatico_hora = new System.Windows.Forms.RadioButton();
            this.rbtEnvioautomatico_minutos = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkIniciar_Windows = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEnviomanual);
            this.groupBox2.Controls.Add(this.cboEnviomanual_mostrarglobo_minutosvalor);
            this.groupBox2.Controls.Add(this.rbtEnviomanual_nomostrarglobo);
            this.groupBox2.Controls.Add(this.rbtEnviomanual_mostrarglobo);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 104);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envío manual: ";
            // 
            // chkEnviomanual
            // 
            this.chkEnviomanual.AutoSize = true;
            this.chkEnviomanual.Location = new System.Drawing.Point(12, 22);
            this.chkEnviomanual.Name = "chkEnviomanual";
            this.chkEnviomanual.Size = new System.Drawing.Size(226, 17);
            this.chkEnviomanual.TabIndex = 4;
            this.chkEnviomanual.Text = "Activar el envío manual de comprobantes.";
            this.chkEnviomanual.UseVisualStyleBackColor = true;
            this.chkEnviomanual.CheckedChanged += new System.EventHandler(this.chkEnviomanual_CheckedChanged);
            // 
            // cboEnviomanual_mostrarglobo_minutosvalor
            // 
            this.cboEnviomanual_mostrarglobo_minutosvalor.DisplayMember = "0";
            this.cboEnviomanual_mostrarglobo_minutosvalor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnviomanual_mostrarglobo_minutosvalor.FormattingEnabled = true;
            this.cboEnviomanual_mostrarglobo_minutosvalor.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6",
            "60"});
            this.cboEnviomanual_mostrarglobo_minutosvalor.Location = new System.Drawing.Point(399, 44);
            this.cboEnviomanual_mostrarglobo_minutosvalor.Name = "cboEnviomanual_mostrarglobo_minutosvalor";
            this.cboEnviomanual_mostrarglobo_minutosvalor.Size = new System.Drawing.Size(114, 21);
            this.cboEnviomanual_mostrarglobo_minutosvalor.TabIndex = 3;
            // 
            // rbtEnviomanual_nomostrarglobo
            // 
            this.rbtEnviomanual_nomostrarglobo.AutoSize = true;
            this.rbtEnviomanual_nomostrarglobo.Location = new System.Drawing.Point(33, 72);
            this.rbtEnviomanual_nomostrarglobo.Name = "rbtEnviomanual_nomostrarglobo";
            this.rbtEnviomanual_nomostrarglobo.Size = new System.Drawing.Size(180, 17);
            this.rbtEnviomanual_nomostrarglobo.TabIndex = 6;
            this.rbtEnviomanual_nomostrarglobo.TabStop = true;
            this.rbtEnviomanual_nomostrarglobo.Text = "No mostrar mensaje recordatorio.";
            this.rbtEnviomanual_nomostrarglobo.UseVisualStyleBackColor = true;
            // 
            // rbtEnviomanual_mostrarglobo
            // 
            this.rbtEnviomanual_mostrarglobo.AutoSize = true;
            this.rbtEnviomanual_mostrarglobo.Location = new System.Drawing.Point(33, 45);
            this.rbtEnviomanual_mostrarglobo.Name = "rbtEnviomanual_mostrarglobo";
            this.rbtEnviomanual_mostrarglobo.Size = new System.Drawing.Size(360, 17);
            this.rbtEnviomanual_mostrarglobo.TabIndex = 5;
            this.rbtEnviomanual_mostrarglobo.TabStop = true;
            this.rbtEnviomanual_mostrarglobo.Text = "Mostrar mensaje recordatorio en intervalos de tiempo (Veces por hora): ";
            this.rbtEnviomanual_mostrarglobo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnvioautomatico_horavalor);
            this.groupBox1.Controls.Add(this.chkEnvioautomatico);
            this.groupBox1.Controls.Add(this.cboEnvioautomatico_minutosvalor);
            this.groupBox1.Controls.Add(this.rbtEnvioautomatico_hora);
            this.groupBox1.Controls.Add(this.rbtEnvioautomatico_minutos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envío programado: ";
            // 
            // dtpEnvioautomatico_horavalor
            // 
            this.dtpEnvioautomatico_horavalor.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnvioautomatico_horavalor.Location = new System.Drawing.Point(399, 71);
            this.dtpEnvioautomatico_horavalor.Name = "dtpEnvioautomatico_horavalor";
            this.dtpEnvioautomatico_horavalor.ShowUpDown = true;
            this.dtpEnvioautomatico_horavalor.Size = new System.Drawing.Size(114, 20);
            this.dtpEnvioautomatico_horavalor.TabIndex = 7;
            // 
            // chkEnvioautomatico
            // 
            this.chkEnvioautomatico.AutoSize = true;
            this.chkEnvioautomatico.Location = new System.Drawing.Point(12, 22);
            this.chkEnvioautomatico.Name = "chkEnvioautomatico";
            this.chkEnvioautomatico.Size = new System.Drawing.Size(237, 17);
            this.chkEnvioautomatico.TabIndex = 4;
            this.chkEnvioautomatico.Text = "Activar envío programado de comprobantes.";
            this.chkEnvioautomatico.UseVisualStyleBackColor = true;
            this.chkEnvioautomatico.CheckedChanged += new System.EventHandler(this.chkEnvioautomatico_CheckedChanged);
            // 
            // cboEnvioautomatico_minutosvalor
            // 
            this.cboEnvioautomatico_minutosvalor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnvioautomatico_minutosvalor.FormattingEnabled = true;
            this.cboEnvioautomatico_minutosvalor.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6",
            "24"});
            this.cboEnvioautomatico_minutosvalor.Location = new System.Drawing.Point(399, 44);
            this.cboEnvioautomatico_minutosvalor.Name = "cboEnvioautomatico_minutosvalor";
            this.cboEnvioautomatico_minutosvalor.Size = new System.Drawing.Size(114, 21);
            this.cboEnvioautomatico_minutosvalor.TabIndex = 3;
            // 
            // rbtEnvioautomatico_hora
            // 
            this.rbtEnvioautomatico_hora.AutoSize = true;
            this.rbtEnvioautomatico_hora.Location = new System.Drawing.Point(33, 72);
            this.rbtEnvioautomatico_hora.Name = "rbtEnvioautomatico_hora";
            this.rbtEnvioautomatico_hora.Size = new System.Drawing.Size(290, 17);
            this.rbtEnvioautomatico_hora.TabIndex = 6;
            this.rbtEnvioautomatico_hora.TabStop = true;
            this.rbtEnvioautomatico_hora.Text = "Envío programado para enviar a una hora determinada: ";
            this.rbtEnvioautomatico_hora.UseVisualStyleBackColor = true;
            // 
            // rbtEnvioautomatico_minutos
            // 
            this.rbtEnvioautomatico_minutos.AutoSize = true;
            this.rbtEnvioautomatico_minutos.Location = new System.Drawing.Point(33, 45);
            this.rbtEnvioautomatico_minutos.Name = "rbtEnvioautomatico_minutos";
            this.rbtEnvioautomatico_minutos.Size = new System.Drawing.Size(356, 17);
            this.rbtEnvioautomatico_minutos.TabIndex = 5;
            this.rbtEnvioautomatico_minutos.TabStop = true;
            this.rbtEnvioautomatico_minutos.Text = "Envío programado para enviar en intervalos de tiempo (Veces al día): ";
            this.rbtEnvioautomatico_minutos.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(467, 232);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 232);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkIniciar_Windows
            // 
            this.chkIniciar_Windows.AutoSize = true;
            this.chkIniciar_Windows.Location = new System.Drawing.Point(24, 236);
            this.chkIniciar_Windows.Name = "chkIniciar_Windows";
            this.chkIniciar_Windows.Size = new System.Drawing.Size(216, 17);
            this.chkIniciar_Windows.TabIndex = 10;
            this.chkIniciar_Windows.Text = "Iniciar la aplicación al arrancar windows.";
            this.chkIniciar_Windows.UseVisualStyleBackColor = true;
            this.chkIniciar_Windows.Visible = false;
            // 
            // frmAlarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 272);
            this.Controls.Add(this.chkIniciar_Windows);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.MaximumSize = new System.Drawing.Size(570, 311);
            this.MinimumSize = new System.Drawing.Size(570, 311);
            this.Name = "frmAlarma";
            this.Text = "Configuración - Formas de envío y alertas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlarma_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboEnvioautomatico_minutosvalor;
        private System.Windows.Forms.CheckBox chkEnvioautomatico;
        private System.Windows.Forms.RadioButton rbtEnvioautomatico_minutos;
        private System.Windows.Forms.RadioButton rbtEnvioautomatico_hora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEnviomanual;
        private System.Windows.Forms.ComboBox cboEnviomanual_mostrarglobo_minutosvalor;
        private System.Windows.Forms.RadioButton rbtEnviomanual_nomostrarglobo;
        private System.Windows.Forms.RadioButton rbtEnviomanual_mostrarglobo;
        private System.Windows.Forms.DateTimePicker dtpEnvioautomatico_horavalor;
        private System.Windows.Forms.CheckBox chkIniciar_Windows;
    }
}