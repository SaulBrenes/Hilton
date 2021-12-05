using Hilton.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton.View
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            FrmReporteIngresoMensual fRVentasMensual = new FrmReporteIngresoMensual(dtpRM.Value.Year);
            fRVentasMensual.ShowDialog();
        }
    }
}
