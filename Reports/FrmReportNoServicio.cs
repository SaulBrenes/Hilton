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
    public partial class FrmReportNoServicio : Form
    {
        int año;
        public FrmReportNoServicio(int año)
        {
            this.año = año;
            InitializeComponent();
        }

        private void FrmReportNoServicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.NoEventosRealizadosSalones' Puede moverla o quitarla según sea necesario.
            this.NoServiciosRealizadosAñoTableAdapter.Fill(this.DataSetReportes.NoServiciosRealizadosAño, año);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.DetalleNoEventosRealizadosSalones' Puede moverla o quitarla según sea necesario.
            this.DetalleNoServiciosRealizadosTableAdapter.Fill(this.DataSetReportes.DetalleNoServiciosRealizados, año);
            this.reportViewer1.RefreshReport();
        }
    }
}
