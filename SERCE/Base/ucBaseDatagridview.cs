using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEI.Base
{
    public partial class ucBaseDatagridview : DataGridView
    {
        public ucBaseDatagridview()
        {
            InitializeComponent();
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            BackgroundColor = System.Drawing.Color.Silver;
            ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            EnableHeadersVisualStyles = false;
            RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
    }
}
