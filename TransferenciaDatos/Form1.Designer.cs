namespace TransferenciaDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNotasBoletas = new System.Windows.Forms.CheckBox();
            this.chkNotasFactura = new System.Windows.Forms.CheckBox();
            this.chkBoletas = new System.Windows.Forms.CheckBox();
            this.chkFactura = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdNoExportados = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cual es la información que desea transferir?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNotasBoletas);
            this.groupBox1.Controls.Add(this.chkNotasFactura);
            this.groupBox1.Controls.Add(this.chkBoletas);
            this.groupBox1.Controls.Add(this.chkFactura);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Documento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkNotasBoletas
            // 
            this.chkNotasBoletas.AutoSize = true;
            this.chkNotasBoletas.Location = new System.Drawing.Point(217, 67);
            this.chkNotasBoletas.Name = "chkNotasBoletas";
            this.chkNotasBoletas.Size = new System.Drawing.Size(129, 18);
            this.chkNotasBoletas.TabIndex = 3;
            this.chkNotasBoletas.Text = "NC y ND de Boletas";
            this.chkNotasBoletas.UseVisualStyleBackColor = true;
            // 
            // chkNotasFactura
            // 
            this.chkNotasFactura.AutoSize = true;
            this.chkNotasFactura.Location = new System.Drawing.Point(217, 30);
            this.chkNotasFactura.Name = "chkNotasFactura";
            this.chkNotasFactura.Size = new System.Drawing.Size(133, 18);
            this.chkNotasFactura.TabIndex = 2;
            this.chkNotasFactura.Text = "NC y ND de Facturas";
            this.chkNotasFactura.UseVisualStyleBackColor = true;
            // 
            // chkBoletas
            // 
            this.chkBoletas.AutoSize = true;
            this.chkBoletas.Location = new System.Drawing.Point(21, 67);
            this.chkBoletas.Name = "chkBoletas";
            this.chkBoletas.Size = new System.Drawing.Size(68, 18);
            this.chkBoletas.TabIndex = 1;
            this.chkBoletas.Text = "Boletas";
            this.chkBoletas.UseVisualStyleBackColor = true;
            // 
            // chkFactura
            // 
            this.chkFactura.AutoSize = true;
            this.chkFactura.Location = new System.Drawing.Point(21, 30);
            this.chkFactura.Name = "chkFactura";
            this.chkFactura.Size = new System.Drawing.Size(72, 18);
            this.chkFactura.TabIndex = 0;
            this.chkFactura.Text = "Facturas";
            this.chkFactura.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(22, 54);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(158, 18);
            this.rdTodos.TabIndex = 7;
            this.rdTodos.Text = "Todos los comprobantes";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdNoExportados
            // 
            this.rdNoExportados.AutoSize = true;
            this.rdNoExportados.Checked = true;
            this.rdNoExportados.Location = new System.Drawing.Point(22, 28);
            this.rdNoExportados.Name = "rdNoExportados";
            this.rdNoExportados.Size = new System.Drawing.Size(232, 18);
            this.rdNoExportados.TabIndex = 6;
            this.rdNoExportados.TabStop = true;
            this.rdNoExportados.Text = "Solo los no exportados anteriormente";
            this.rdNoExportados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNoExportados);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(13, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alcance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia de datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNotasBoletas;
        private System.Windows.Forms.CheckBox chkNotasFactura;
        private System.Windows.Forms.CheckBox chkBoletas;
        private System.Windows.Forms.CheckBox chkFactura;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdNoExportados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

