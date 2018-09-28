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

namespace FEI.Usuario
{
    public partial class frmComprobantedetalle : frmBaseFormularios
    {
        public frmComprobantedetalle(string id)
        {
            InitializeComponent();
            dgvDetalle.Rows.Clear();

            clsEntityDocument cabecera = new clsEntityDocument();
            cabecera.cs_fxObtenerUnoPorId(id);

            txtDocumentotipo.Text = clsBaseUtil.cs_fxComprobantesElectronicos_descripcion(cabecera.Cs_tag_InvoiceTypeCode);
            txtRuc.Text = cabecera.Cs_tag_AccountingSupplierParty_CustomerAssignedAccountID;
            txtFechaemision.Text = cabecera.Cs_tag_IssueDate;
            txtRazonsocial.Text = cabecera.Cs_tag_AccountingCustomerParty_Party_PartyLegalEntity_RegistrationName;
            txtSerienumero.Text = cabecera.Cs_tag_ID;
            
            List<List<string>> registros = new clsEntityDocument_Line().cs_pxObtenerTodoPorId(id);

            if (registros.Count>0)
            {
                foreach (var item in registros)
                {
                    decimal vardecimal = 0;
                    List<List<string>> descipcion_item = new clsEntityDocument_Line_Description().cs_pxObtenerTodoPorId(item[0]);
                    if (item[6].ToString().Trim() == "")
                    {
                        vardecimal = 0;
                    }
                    else
                    {
                        vardecimal = decimal.Parse(item[6].ToString().Trim());
                    }

                    if (descipcion_item.Count>0 && descipcion_item!=null)
                    {
                        dgvDetalle.Rows.Add(
                            item[0].ToString().Trim(),
                            descipcion_item[0][2],
                            item[4].ToString().Trim(),
                            Convert.ToString(vardecimal)
                        );
                    }
                    else
                    {
                        clsBaseMensaje.cs_pxMsgEr("ERR19", "No existe una descripción del documento.");
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
