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
    public partial class FrmReporteIngresoMensual : Form
    {
        int año;
        public FrmReporteIngresoMensual(int año)
        {
            this.año = año;
            InitializeComponent();
        }

        private void FrmReporteIngresoMensual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.ObtenerPagoDeEvento' Puede moverla o quitarla según sea necesario.
            this.VentasMensualesDelAñoTableAdapter.Fill(this.dataSetReportes.VentasMensualesDelAño, año);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.SalonesEvento' Puede moverla o quitarla según sea necesario.
            this.DetalleVentasMensualesTableAdapter.Fill(this.dataSetReportes.DetalleVentasMensuales, año);
            this.reportViewer1.RefreshReport();
        }
    }
}
