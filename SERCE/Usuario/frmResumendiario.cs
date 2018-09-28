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
    public partial class frmResumendiario : frmBaseFormularios
    {
        List<string> Items;
        public frmResumendiario()
        {
            InitializeComponent();
            this.Items = null;
        }
        public frmResumendiario(List<string> Items)
        {
            InitializeComponent();
            this.Items = Items;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResumendiario_Load(object sender, EventArgs e)
        {
            //Recorrer los últimos 7 días:
            //Buscar Resumenes de boletas que ahun no hayan sido enviados (ULTIMOS 7 DÍAS - Del más antiguo a hoy) - Agregar número correlativo.
            //(De los que no hayan sido enviados actualizar los ID con la fecha de hoy)
            //Cuando el usuario desea visualizar el detalle XML, generar y guardarlo en la base de datos (XML de envío).
            //Cuando el usuario envía el documento, obtener el ticket.
            //Debe existir una opción consultar ticket.
            try
            {
                if (Items != null)
                {
                    new clsNegocioCEResumenDiario().cs_pxProcesarResumenDiario(this.Items);
                }
                cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("ResumenDiarioLoad " + ex.Message.ToString());
            }

        }

        private void btnEjectuarBusqueda_Click(object sender, EventArgs e)
        {
            cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));
        }

        private void cs_pxCargarDgvResumenesFecha(string fechainicio, string fechafin)
        {
            dgvResumendiario.Rows.Clear();
            try
            {
                List<List<string>> registros = new clsEntitySummaryDocuments().cs_fxObtenerResumenesPorRangoFecha(fechainicio, fechafin);
                foreach (var item in registros)
                {
                    string fecha_de_envío = string.Empty;
                    /*if (item[9].Trim() == "2")//verifica estado sunat si es sin estado
                    {
                        fecha_de_envío = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                    else
                    {*/
                    fecha_de_envío = item[3].Trim();//reference date dia de lso docuemtnos dentro del resumen.
                                                    //}

                    dgvResumendiario.Rows.Add(
                    item[0].ToString().Trim(),//id
                    false,//checkbox
                    item[1].Trim(),//tag id 
                    item[2].Trim(),//tag reference date
                    fecha_de_envío,
                    item[7],//ticket
                    "",
                    "",
                    item[10].ToString().Trim(),//comentario sunat cell 8
                    item[13].ToString().Trim(),//excepcion sunat cell- 9
                    item[8].ToString().Trim(),//estado scc  cell - 10
                    item[9].ToString().Trim()//estado sunat  cell - 11
                );
                }

                foreach (DataGridViewRow row in dgvResumendiario.Rows)
                {
                    //para estado SCC
                    switch (row.Cells[10].Value.ToString())
                    {
                        case "1":
                            row.Cells[6].Style.ForeColor = Color.Red;//Pendiente (errores)
                            Seleccionar.ReadOnly = false;
                            break;
                        case "2":
                            row.Cells[6].Style.ForeColor = Color.RoyalBlue;//Pendiente (correcto)
                            break;
                        case "0":
                            row.Cells[6].Style.ForeColor = Color.Green;//Enviado
                            break;
                    }

                    row.Cells[6].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(Convert.ToInt16(row.Cells[10].Value)).ToUpper();
                    switch (row.Cells[11].Value.ToString())
                    {
                        case "0":
                            row.Cells[7].Style.ForeColor = Color.Green;//Aceptado
                            break;
                        case "1":
                            row.Cells[7].Style.ForeColor = Color.Brown;//Rechazado
                            break;
                        case "2":
                            row.Cells[7].Style.ForeColor = Color.Red;//Sin respuesta
                            break;
                        case "3":
                            row.Cells[7].Style.ForeColor = Color.Salmon;//Anulado
                            break;
                        case "4":
                            row.Cells[7].Style.ForeColor = Color.Blue;//En proceso //desde sunat
                            break;
                        case "5":
                            row.Cells[7].Style.ForeColor = Color.Green;//Ticket a consultar
                            break;
                    }
                    row.Cells[7].Value = clsBaseUtil.cs_fxComprobantesEstadosSUNAT_descripcion(Convert.ToInt16(row.Cells[11].Value)).ToUpper();
                }
            }
            catch (Exception ex)
            {
                clsBaseLog.cs_pxRegistarAdd("cs_pxCargarDgvResumenesFecha" + ex.Message.ToString());
            }

        }

        private void dgvResumendiario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmResumendiarioDetalle(dgvResumendiario.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
        }

        private void btnEnviarResumendiario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResumendiario.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvResumendiario.Rows)
                    {
                        if ((bool)row.Cells[1].Value == true)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            if (new clsBaseSunat().cs_pxEnviarRC(row.Cells[0].Value.ToString()))
                            {
                                cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));
                                row.Cells[5].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(0).ToUpper();
                                row.Cells[5].Style.ForeColor = Color.Green;
                            }
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR15", ex.Message);
                clsBaseLog.cs_pxRegistarAdd("btnEnviarResumendiario_Click " + ex.Message.ToString());
            }
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvResumendiario.Rows.Count > 0)
            {
                new frmResumendiarioDetalle(dgvResumendiario.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
            }
        }

        private void mostrarErroresEnElDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvResumendiario.Rows.Count > 0)
            {
                new frmResumendiarioVisorSUNAT(dgvResumendiario.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
            }
        }

        private void btnConsultarTiket_Click(object sender, EventArgs e)
        {

            string no_admitidos = String.Empty;
            if (dgvResumendiario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvResumendiario.Rows)
                {
                    if ((bool)row.Cells[1].Value == true)
                    {
                        clsBaseSunat sunat = new clsBaseSunat();
                        if (row.Cells[5].Value.ToString() != "")
                        {
                            try
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                sunat.cs_pxConsultarTicketRC(row.Cells[5].Value.ToString());
                                cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));
                                row.Cells[5].Value = clsBaseUtil.cs_fxComprobantesEstadosSCC_descripcion(0).ToUpper();
                                row.Cells[5].Style.ForeColor = Color.Green;
                                Cursor.Current = Cursors.Default;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                clsBaseLog.cs_pxRegistarAdd("btnConsultarTiket_Click" + ex.ToString());
                                throw;
                            }
                        }
                        else
                        {
                            no_admitidos += row.Cells[2].Value + "\n";
                        }


                    }
                }

                if (no_admitidos != "")
                {
                    clsBaseMensaje.cs_pxMsg("Error al consultar", "Los siguientes resumenes no fueron consultados. Verifique el ticket de consulta\n" + no_admitidos);
                }
            }


        }
        private void frmResumendiario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (dgvResumendiario.Rows.Count > 0)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvResumendiario.Rows)
                {
                    if ((bool)row.Cells[1].Value == true)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea descartar los resumenes seleccionados?\nEstos documentos serán eliminados completamente de la base de datos.", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvResumendiario.Rows)
                        {
                            if ((bool)row.Cells[1].Value == true)
                            {
                                new clsEntitySummaryDocuments().cs_pxEliminarDocumento(row.Cells[0].Value.ToString());
                                cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));

                            }
                        }
                    }
                }

            }
        }

        private void btnSustituir_Click(object sender, EventArgs e)
        {
            string no_procesados = String.Empty;
            string resumenes_exito = String.Empty;
            if (dgvResumendiario.Rows.Count > 0)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvResumendiario.Rows)
                {
                    if ((bool)row.Cells[1].Value == true)
                    {
                        /* if(row.Cells[11].ToString() == "0")
                         {*/
                        count++;
                        /*  }*/
                        /*else
                        {
                            no_procesados += row.Cells[2].ToString();
                        }*/

                    }
                }
                if (no_procesados != "")
                {
                    MessageBox.Show("Los siguientes resumenes no pueden ser sustituidos o rectificados ya que no fueron enviados a SUNAT");
                }

                if (count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea sustituir/rectificar los resumenes seleccionados?\n Los documentos asociados seran liberados y podra volverlos a agregar a resumen diario.", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvResumendiario.Rows)
                        {
                            if ((bool)row.Cells[1].Value == true)
                            {
                                bool exito = new clsEntitySummaryDocuments().cs_pxLiberarSustitutorioDocumento(row.Cells[0].Value.ToString());
                                if (exito)
                                {
                                    resumenes_exito += row.Cells[2].Value.ToString() + "\n";
                                }

                            }
                        }
                        if (resumenes_exito != "")
                        {
                            MessageBox.Show("Los siguientes resumenes fueron liberados con exito:\n" + resumenes_exito);
                        }
                        cs_pxCargarDgvResumenesFecha(dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));
                    }
                }

            }
        }
    }
}
