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

        private void btnRS_Click(object sender, EventArgs e)
        {
            FrmReportIngresoSalon frmReport = new FrmReportIngresoSalon(dtpRS.Value.Year);
            frmReport.ShowDialog();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            FrmReporteCostoTotalMatenimiento frmReporte = new FrmReporteCostoTotalMatenimiento(dtpCM.Value.Year);
            frmReporte.ShowDialog();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            FrmReportCostoMantenimientoSalon frmReport = new FrmReportCostoMantenimientoSalon(dtpMS.Value.Year);
            frmReport.ShowDialog();

            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            FrmReportNoEventosSalon frmReport = new FrmReportNoEventosSalon(dtpCE.Value.Year);
            frmReport.ShowDialog();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            FrmReportNoServicio frmReport = new FrmReportNoServicio(dtpCS.Value.Year);
            frmReport.ShowDialog();
        }

        private void iTalk_Panel1_MouseEnter(object sender, EventArgs e)
        {
       
        }
    }
}
