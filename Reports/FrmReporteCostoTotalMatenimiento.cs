using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton.Reports
{
    public partial class FrmReporteCostoTotalMatenimiento : Form
    {
        int año;
        public FrmReporteCostoTotalMatenimiento(int año)
        {
            this.año = año;
            InitializeComponent();
        }

        private void FrmReporteCostoTotalMatenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.CostoTotalDeMantenimientoAño' Puede moverla o quitarla según sea necesario.
            this.CostoTotalDeMantenimientoAñoTableAdapter.Fill(this.DataSetReportes.CostoTotalDeMantenimientoAño, año);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.DetalleCostoMantenimiento' Puede moverla o quitarla según sea necesario.
            this.DetalleCostoMantenimientoTableAdapter.Fill(this.DataSetReportes.DetalleCostoMantenimiento, año);

            this.reportViewer1.RefreshReport();
        }
    }
}
