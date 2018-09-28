namespace FEI.Usuario
{
    partial class frmDeclarantes
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verInformaciónDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosParaPublicaciónWEBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDeEnvíoYAlertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDeclarantes = new FEI.Base.ucBaseDatagridview();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(284, 279);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(370, 279);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 23);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(198, 279);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "&Editar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(112, 279);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verInformaciónDeBaseDeDatosToolStripMenuItem,
            this.baseDeDatosParaPublicaciónWEBToolStripMenuItem,
            this.formasDeEnvíoYAlertasToolStripMenuItem});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(238, 70);
            // 
            // verInformaciónDeBaseDeDatosToolStripMenuItem
            // 
            this.verInformaciónDeBaseDeDatosToolStripMenuItem.Name = "verInformaciónDeBaseDeDatosToolStripMenuItem";
            this.verInformaciónDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.verInformaciónDeBaseDeDatosToolStripMenuItem.Text = "Base de datos de Registro";
            this.verInformaciónDeBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.verInformaciónDeBaseDeDatosToolStripMenuItem_Click);
            // 
            // baseDeDatosParaPublicaciónWEBToolStripMenuItem
            // 
            this.baseDeDatosParaPublicaciónWEBToolStripMenuItem.Name = "baseDeDatosParaPublicaciónWEBToolStripMenuItem";
            this.baseDeDatosParaPublicaciónWEBToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.baseDeDatosParaPublicaciónWEBToolStripMenuItem.Text = "Base de datos de Publicación WEB";
            // 
            // formasDeEnvíoYAlertasToolStripMenuItem
            // 
            this.formasDeEnvíoYAlertasToolStripMenuItem.Name = "formasDeEnvíoYAlertasToolStripMenuItem";
            this.formasDeEnvíoYAlertasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.formasDeEnvíoYAlertasToolStripMenuItem.Text = "Formas de envío y alertas";
            // 
            // dgvDeclarantes
            // 
            this.dgvDeclarantes.AllowUserToAddRows = false;
            this.dgvDeclarantes.AllowUserToDeleteRows = false;
            this.dgvDeclarantes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDeclarantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDeclarantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeclarantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.descripcion});
            this.dgvDeclarantes.EnableHeadersVisualStyles = false;
            this.dgvDeclarantes.Location = new System.Drawing.Point(12, 12);
            this.dgvDeclarantes.Name = "dgvDeclarantes";
            this.dgvDeclarantes.ReadOnly = true;
            this.dgvDeclarantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDeclarantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeclarantes.Size = new System.Drawing.Size(438, 261);
            this.dgvDeclarantes.TabIndex = 18;
            this.dgvDeclarantes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeclarantes_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "RUC";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Razón Social";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 1000;
            // 
            // frmDeclarantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 313);
            this.Controls.Add(this.dgvDeclarantes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDeclarantes";
            this.Text = "Declarantes (Empresas)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeclarantes_FormClosing);
            this.Load += new System.EventHandler(this.frmDeclarantes_Load);
            this.cmsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FEI.Base.ucBaseDatagridview dgvDeclarantes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem verInformaciónDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosParaPublicaciónWEBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDeEnvíoYAlertasToolStripMenuItem;
    }
}