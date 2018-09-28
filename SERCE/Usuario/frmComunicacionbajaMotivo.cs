using FEI.Base;
using FEI.Extension.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERCE.Usuario
{
    public partial class frmComunicacionbajaMotivo : frmBaseFormularios
    {
        string Id;
        clsEntityVoidedDocuments_VoidedDocumentsLine documento;

        public frmComunicacionbajaMotivo(string Id)
        {
            this.Id = Id;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            documento.Cs_tag_VoidReasonDescription = this.txtDescripcion.Text;
            documento.cs_pxActualizar(true);
            DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ComunicacionBajaMotivo_Load(object sender, EventArgs e)
        {
            documento = new clsEntityVoidedDocuments_VoidedDocumentsLine().cs_fxObtenerUnoPorId(this.Id);
        }
    }
}
