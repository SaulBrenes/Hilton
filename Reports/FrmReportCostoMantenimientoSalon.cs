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
    public partial class FrmReportCostoMantenimientoSalon : Form
    {
        int año;
        public FrmReportCostoMantenimientoSalon(int año)
        {
            InitializeComponent();
            this.año = año;
        }

        private void FrmReportCostoMantenimientoSalon_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.ObtenerPagoDeEvento' Puede moverla o quitarla según sea necesario.
            this.CostoMantenimientoSalonAñoTableAdapter.Fill(this.dataSetReportes.CostoMantenimientoSalonAño, año);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.SalonesEvento' Puede moverla o quitarla según sea necesario.
            this.DetalleCostoMantenimientoSalonTableAdapter.Fill(this.dataSetReportes.DetalleCostoMantenimientoSalon, año);
            this.reportViewer1.RefreshReport();
        }
    }
}
