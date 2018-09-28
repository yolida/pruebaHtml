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
using FEI.Extension.Base;
using FEI.Extension.Datos;

namespace FEI.Usuario
{
    public partial class frmAlarma : frmBaseFormularios
    {
        private clsEntityAlarms entidad_alarma;
        public frmAlarma(clsEntityAlarms alarm)
        {
            InitializeComponent();
            this.cboEnvioautomatico_minutosvalor.SelectedIndex = 0;
            this.cboEnviomanual_mostrarglobo_minutosvalor.SelectedIndex = 0;

            entidad_alarma = alarm;
            this.chkEnvioautomatico.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico);
            this.rbtEnvioautomatico_minutos.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico_minutos);
            this.cboEnvioautomatico_minutosvalor.Text = entidad_alarma.Cs_pr_Envioautomatico_minutosvalor;
            this.rbtEnvioautomatico_hora.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico_hora);
            this.dtpEnvioautomatico_horavalor.Value = Convert.ToDateTime(entidad_alarma.Cs_pr_Envioautomatico_horavalor);
            this.chkEnviomanual.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual);
            this.rbtEnviomanual_mostrarglobo.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual_mostrarglobo);
            this.cboEnviomanual_mostrarglobo_minutosvalor.Text = entidad_alarma.Cs_pr_Enviomanual_mostrarglobo_minutosvalor;
            this.rbtEnviomanual_nomostrarglobo.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual_nomostrarglobo);
            this.chkIniciar_Windows.Checked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Iniciarconwindows);
            
            if (chkEnvioautomatico.Checked == true)
            {
                chkEnviomanual.Checked = false;
            }
            else
            {
                chkEnviomanual.Checked = true;
            }

            if (chkEnvioautomatico.Checked == true)
            {
                chkEnviomanual.Checked = false;
            }
            else
            {
                chkEnviomanual.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entidad_alarma.Cs_pr_Envioautomatico = clsBaseUtil.cs_fxBooleanToString(this.chkEnvioautomatico.Checked);
            entidad_alarma.Cs_pr_Envioautomatico_minutos = clsBaseUtil.cs_fxBooleanToString(this.rbtEnvioautomatico_minutos.Checked);
            entidad_alarma.Cs_pr_Envioautomatico_minutosvalor = this.cboEnvioautomatico_minutosvalor.Text;
            entidad_alarma.Cs_pr_Envioautomatico_hora = clsBaseUtil.cs_fxBooleanToString(this.rbtEnvioautomatico_hora.Checked);
            entidad_alarma.Cs_pr_Envioautomatico_horavalor = this.dtpEnvioautomatico_horavalor.Text;
            entidad_alarma.Cs_pr_Enviomanual = clsBaseUtil.cs_fxBooleanToString(this.chkEnviomanual.Checked);
            entidad_alarma.Cs_pr_Enviomanual_mostrarglobo = clsBaseUtil.cs_fxBooleanToString(this.rbtEnviomanual_mostrarglobo.Checked);
            entidad_alarma.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = this.cboEnviomanual_mostrarglobo_minutosvalor.Text;
            entidad_alarma.Cs_pr_Enviomanual_nomostrarglobo = clsBaseUtil.cs_fxBooleanToString(this.rbtEnviomanual_nomostrarglobo.Checked);
            entidad_alarma.Cs_pr_Iniciarconwindows = clsBaseUtil.cs_fxBooleanToString(this.chkIniciar_Windows.Checked);
            this.dtpEnvioautomatico_horavalor.Value = Convert.ToDateTime(entidad_alarma.Cs_pr_Envioautomatico_horavalor);
            entidad_alarma.cs_pxActualizar(true);
            //entidad_alarma.cs_pxIniciarWindows(this.chkIniciar_Windows.Checked);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkEnvioautomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnvioautomatico.Checked == true)
            {
                chkEnviomanual.Checked = false;
            }else
	        {
                chkEnviomanual.Checked = true;
	        }
        }

        private void chkEnviomanual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnviomanual.Checked == true)
            {
                chkEnvioautomatico.Checked = false;
            }
            else
            {
                chkEnvioautomatico.Checked = true;
            }
        }

        private void frmAlarma_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
