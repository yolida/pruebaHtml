using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using FEI.Extension.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEI.Usuario
{
    public partial class frmComunicacionBajaMotivo : frmBaseFormularios
    {
        List<string> Items;
        public frmComunicacionBajaMotivo()
        {
            InitializeComponent();
            this.Items = null;
        }

        public frmComunicacionBajaMotivo(List<string> Items)
        {
            InitializeComponent();
            this.Items = Items;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cs_pxCargarDgvDocumentosBaja(string fechainicio, string fechafin)
        {
            try
            {
                DateTime finicio = Convert.ToDateTime(fechainicio);
                DateTime ffin = Convert.ToDateTime(fechafin);
                dgvComunicacionbaja.Rows.Clear();
                List<List<string>> registros = new clsNegocioCEComunicacionBaja().cs_pxObtenerPorFiltroPrincipal(finicio.ToString("yyyy-MM-dd"), ffin.ToString("yyyy-MM-dd"));
                foreach (var item in registros)
                {
                    string Estado_SCC = "";
                    bool validar_motivos_baja = new clsEntityVoidedDocuments().cs_pxValidarMotivosDeBajaEnItems(item[0].Trim().ToString());
                    string ticket = item[7].ToString().Trim();
                    string comentario_desde_sunat = item[10].ToString().Trim();
                    string condicion_de_ticket = "";
                    string fecha_emision = "";
                   // string fecha_referencia = "";
                   // string fecha_comunicacion = "";

                    if (comentario_desde_sunat.Trim() == "")
                    {
                        condicion_de_ticket = "PENDIENTE DE RECEPCIÓN";
                    }
                    else
                    {
                        condicion_de_ticket = "RECIBIDO";
                    }

                    if (validar_motivos_baja == true && ticket == "")
                    {
                        Estado_SCC = "2";
                    }
                    if (validar_motivos_baja == false && ticket == "")
                    {
                        Estado_SCC = "1";
                    }
                    if (validar_motivos_baja == false && ticket != "")
                    {
                        Estado_SCC = "0";
                    }
                    if (validar_motivos_baja == true && ticket != "")
                    {
                        Estado_SCC = item[8].ToString().Trim();
                    }


                    if (Estado_SCC == "0")
                    {
                        fecha_emision = item[3].ToString();
                    }
                    else
                    {
                        fecha_emision = "";
                    }


                    dgvComunicacionbaja.Rows.Add(
                        item[0].ToString().Trim(),      //ID
                        false,                          //Seleccionar
                        item[1].Trim(),                 //Código
                        item[2].Trim(),             //Fecha de comunicación
                        item[2].Trim(),               //Fecha de referencia (OCULTO HASTA QUE SE APRUEBE)
                        fecha_emision,                  //Fecha de emision
                        item[7].Trim(),                 //Ticket
                        "",                             //Estado SCC - Descripción
                        "",                             //Estado SUNAT - Descripción
                        condicion_de_ticket,            //Estado SUNAT RECEPCIÓN DE TICKET - Decripción
                        item[10].ToString().Trim(),     //Comentario desde SUNAT
                        Estado_SCC,                     //Estado SCC
                        item[9].ToString().Trim()       //Estado SUNAT
                    );
                }

                foreach (DataGridViewRow row in dgvComunicacionbaja.Rows)
                {
                    string idice_ESCC = row.Cells[11].Value.ToString();
                    string idice_ESUNAT = row.Cells[12].Value.ToString();
                    int i_scc_descipcion = 7;
                    int i_sunat_descipcion = 8;

                    switch (idice_ESCC)
                    {
                        case "1":
                            row.Cells[i_scc_descipcion].Style.ForeColor = Color.Red;//Pendiente (errores)
                            Seleccionar.ReadOnly = false;
                            break;
                        case "2":
                            row.Cells[i_scc_descipcion].Style.ForeColor = Color.RoyalBlue;//Pendiente (correcto)
                            break;
                        case "0":
                            row.Cells[i_scc_descipcion].Style.ForeColor = Color.Green;//Enviado
                            break;
                    }
                    row.Cells[i_scc_descipcion].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(idice_ESCC)).ToUpper();
                    switch (idice_ESUNAT)
                    {
                        case "0":
                            row.Cells[i_sunat_descipcion].Style.ForeColor = Color.Green;//Aceptado
                            break;
                        case "1":
                            row.Cells[i_sunat_descipcion].Style.ForeColor = Color.Brown;//Rechazado
                            break;
                        case "2":
                            row.Cells[i_sunat_descipcion].Style.ForeColor = Color.Red;//Sin respuesta
                            break;
                        case "3":
                            row.Cells[i_sunat_descipcion].Style.ForeColor = Color.Salmon;//Anulado
                            break;
                    }
                    row.Cells[i_sunat_descipcion].Value = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(idice_ESUNAT)).ToUpper();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private void frmComunicacionBaja_Load(object sender, EventArgs e)
        {
            try
            {
                if (Items!=null)
                {
                    new clsNegocioCEComunicacionBaja().cs_pxProcesarComunicacionBaja(this.Items);
                }
                cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
            }
        }

        private void btnEnviarComunicacionbaja_Click(object sender, EventArgs e)
        {
            try
            {
                string ya_enviados = String.Empty;
                string no_enviados_motivo = String.Empty;
                
                if (dgvComunicacionbaja.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvComunicacionbaja.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            if (row.Cells[6].Value.ToString().Trim() != "" || row.Cells[10].Value.ToString().Trim() != "")
                            {
                                ya_enviados += " -> " + row.Cells[2].Value.ToString() + " \n";
                            }
                            else
                            {
                                bool validar_motivos_baja = new clsEntityVoidedDocuments().cs_pxValidarMotivosDeBajaEnItems(row.Cells[0].Value.ToString());
                                if (validar_motivos_baja == true)
                                {
                                    if (new clsBaseSunat().cs_pxEnviarRA(row.Cells[0].Value.ToString()))
                                    {
                                        row.Cells[7].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(0).ToUpper();
                                        row.Cells[7].Style.ForeColor = Color.Green;
                                    }
                                }
                                else
                                {

                                    no_enviados_motivo += " -> " + row.Cells[2].Value.ToString() + " \n";
                                }
                            }
                        }

                    }
                    if (ya_enviados != "")
                    {
                        clsBaseMensaje.cs_pxMsg("Elementos ya enviados", "Los siguientes documentos ya fueron enviados anteriormente. \n" + ya_enviados);
                    }
                    if (no_enviados_motivo != "")
                    {
                        clsBaseMensaje.cs_pxMsg("Elementos no enviados", "Los siguientes documentos no fueron enviados. Verifique los motivos de baja en los items \n" + no_enviados_motivo);
                    }
                }
                cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
            }

        }

        private void btnDescartarComunicacionbaja_Click(object sender, EventArgs e)
        {
            //new clsNegocioCEComunicacionBaja().cs_pxDescartarDocumento(dgvComunicacionbaja.CurrentRow.Cells[0].Value.ToString());
            //Jordy Amaro 01-12-16 FE-881
            //Cambio de logica para descarte de documentos.
            //Ini-Cambio 01
            try
            {
                if (dgvComunicacionbaja.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvComunicacionbaja.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            new clsNegocioCEComunicacionBaja().cs_pxDescartarDocumento(row.Cells[0].Value.ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("DescartarComunicacionBaja" + ex.ToString());
            }
            //Fin-Cambio 01
            cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
        }

        private void btnEjectuarBusqueda_Click(object sender, EventArgs e)
        {
            cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
        }

        private void btnConsultarTiket_Click(object sender, EventArgs e)
        {
            try
            {
                string no_enviados = String.Empty;
                if (dgvComunicacionbaja.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvComunicacionbaja.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            if(row.Cells[12].Value.ToString() == "0" && row.Cells[6].Value.ToString() != "")
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                new clsBaseSunat().cs_pxConsultarTicket(row.Cells[6].Value.ToString());
                                Cursor.Current = Cursors.Default;
                                // new clsBaseSunat().cs_pxConsultarTicket(dgvComunicacionbaja.CurrentRow.Cells[6].Value.ToString());
                            }
                            else
                            {
                                no_enviados += " -> " + row.Cells[2].Value.ToString() + " \n";
                            }
                           
                        }
                    }
                    if (no_enviados != "")
                    {
                        clsBaseMensaje.cs_pxMsg("Elementos no consultados", "Los siguientes documentos no fueron consultados. Verifique la existencia del ticket de consulta \n" + no_enviados);
                    }
                }

            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
            }
            cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvComunicacionbaja.Rows.Count > 0)
            {
                if (new frmComunicacionbajaDetalle(dgvComunicacionbaja.CurrentRow.Cells[0].Value.ToString()).ShowDialog() == DialogResult.OK)
                {
                    cs_pxCargarDgvDocumentosBaja(dtpFechaInicio.Text.ToString(), dtpFechaFin.Text.ToString());
                }
            }

        }

        private void mostrarErroresEnElDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvComunicacionbaja.Rows.Count > 0)
            {
                new frmComunicacionbajaVisorSUNAT(dgvComunicacionbaja.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
            }
        }
        //Jordy Amaro  09-12-16 FE-906
        //Agregado para obtner estado y refrescar grilla principal.
        private void frmComunicacionBajaMotivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
