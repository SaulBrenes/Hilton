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
    public partial class Factura : Form
    {
        public int idEvento { get; set; }
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.ObtenerPagoDeEvento' Puede moverla o quitarla según sea necesario.
            this.ObtenerPagoDeEventoTableAdapter.Fill(this.DataSetFactura.ObtenerPagoDeEvento, idEvento);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.SalonesEvento' Puede moverla o quitarla según sea necesario.
            this.SalonesEventoTableAdapter.Fill(this.DataSetFactura.SalonesEvento, idEvento);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.ServiciosEvento' Puede moverla o quitarla según sea necesario.
            this.ServiciosEventoTableAdapter.Fill(this.DataSetFactura.ServiciosEvento, idEvento);

            this.reportViewer1.RefreshReport();
        }
    }
}
