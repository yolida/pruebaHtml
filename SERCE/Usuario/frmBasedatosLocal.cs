using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FEI.Base;
using FEI.Extension.Datos;
using FEI.Extension.Base;

namespace FEI.Configuracion
{
    public partial class frmBasedatosLocal : frmBaseFormularios
    {
        private clsEntityDatabaseLocal entidad_basedatos;
        
        public frmBasedatosLocal(clsEntityDeclarant declarant)
        {
            InitializeComponent();
            if (cboGestorBasedatos.Text == "")
            {
                cboGestorBasedatos.SelectedIndex = 0;
            }
            entidad_basedatos = new clsEntityDatabaseLocal().cs_fxObtenerUnoPorDeclaranteId(declarant.Cs_pr_Declarant_Id);
            cboGestorBasedatos.Text = entidad_basedatos.Cs_pr_DBMS;
            txtDbmsdriver.Text = entidad_basedatos.Cs_pr_DBMSDriver;
            txtDbmsservidor.Text = entidad_basedatos.Cs_pr_DBMSServername;
            txtDbmsservidorpuerto.Text = entidad_basedatos.Cs_pr_DBMSServerport;
            txtDbnombre.Text = entidad_basedatos.Cs_pr_DBName;
            txtDbusuario.Text = entidad_basedatos.Cs_pr_DBUser;
            txtDbclave.Text = entidad_basedatos.Cs_pr_DBPassword;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entidad_basedatos.Cs_pr_DBMS = cboGestorBasedatos.Text;
            entidad_basedatos.Cs_pr_DBMSDriver = txtDbmsdriver.Text;
            entidad_basedatos.Cs_pr_DBMSServername = txtDbmsservidor.Text;
            entidad_basedatos.Cs_pr_DBMSServerport = txtDbmsservidorpuerto.Text;
            entidad_basedatos.Cs_pr_DBName = txtDbnombre.Text;
            entidad_basedatos.Cs_pr_DBUser = txtDbusuario.Text;
            entidad_basedatos.Cs_pr_DBPassword = txtDbclave.Text;
            entidad_basedatos.cs_pxActualizar(true);
            cs_pxActualizarEstado();

            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            configuracion.cs_prDbms = entidad_basedatos.Cs_pr_DBMS;
            configuracion.cs_prDbmsdriver = entidad_basedatos.Cs_pr_DBMSDriver;
            configuracion.cs_prDbmsservidor = entidad_basedatos.Cs_pr_DBMSServername;
            configuracion.cs_prDbmsservidorpuerto = entidad_basedatos.Cs_pr_DBMSServerport;
            configuracion.cs_prDbnombre = entidad_basedatos.Cs_pr_DBName;
            configuracion.cs_prDbusuario = entidad_basedatos.Cs_pr_DBUser;
            configuracion.cs_prDbclave = entidad_basedatos.Cs_pr_DBPassword;
            configuracion.cs_pxActualizar(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            entidad_basedatos.Cs_pr_DBMS = cboGestorBasedatos.Text;
            entidad_basedatos.Cs_pr_DBMSDriver = txtDbmsdriver.Text;
            entidad_basedatos.Cs_pr_DBMSServername = txtDbmsservidor.Text;
            entidad_basedatos.Cs_pr_DBMSServerport = txtDbmsservidorpuerto.Text;
            entidad_basedatos.Cs_pr_DBName = txtDbnombre.Text;
            entidad_basedatos.Cs_pr_DBUser = txtDbusuario.Text;
            entidad_basedatos.Cs_pr_DBPassword = txtDbclave.Text;
            entidad_basedatos.cs_pxActualizar(false);
            cs_pxActualizarEstado();
            clsBaseConfiguracion configuracion = new clsBaseConfiguracion();
            configuracion.cs_prDbms = entidad_basedatos.Cs_pr_DBMS;
            configuracion.cs_prDbmsdriver = entidad_basedatos.Cs_pr_DBMSDriver;
            configuracion.cs_prDbmsservidor = entidad_basedatos.Cs_pr_DBMSServername;
            configuracion.cs_prDbmsservidorpuerto = entidad_basedatos.Cs_pr_DBMSServerport;
            configuracion.cs_prDbnombre = entidad_basedatos.Cs_pr_DBName;
            configuracion.cs_prDbusuario = entidad_basedatos.Cs_pr_DBUser;
            configuracion.cs_prDbclave = entidad_basedatos.Cs_pr_DBPassword;
            configuracion.cs_pxActualizar(false);
            entidad_basedatos.cs_pxCrearBaseDatos();
        }

        public bool cs_prConexionEstado;     

        private void cs_pxActualizarEstado()
        {
            clsBaseConexion conexion = new clsBaseConexion();
            cs_prConexionEstado = conexion.cs_fxConexionEstado();
        }

        private void cboGestorBasedatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGestorBasedatos.Text == "SQLite")
            {
                txtDbmsservidor.Enabled = false;
                txtDbmsservidorpuerto.Enabled = false;
                txtDbusuario.Enabled = false;
                txtDbclave.Enabled = false;
            }
            else
            {
                txtDbmsservidor.Enabled = true;
                txtDbmsservidorpuerto.Enabled = true;
                txtDbusuario.Enabled = true;
                txtDbclave.Enabled = true;
            }
            
            if (cboGestorBasedatos.Text == "PostgreSQL")
            {
                btnCrear.Text = "Actualizar base de datos existente";
            }
            else
            {
                btnCrear.Text = "Crear la base de datos";
            }

            txtDbmsdriver.Text = clsBaseUtil.cs_fxDBMS_Driver(cboGestorBasedatos.SelectedIndex + 1);
        }

        private void frmBasedatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
