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
    public partial class FrmReportNoEventosSalon : Form
    {
        int año;
        public FrmReportNoEventosSalon(int año)
        {
            this.año = año;
            InitializeComponent();
        }

        private void FrmReportNoEventosSalon_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.NoEventosRealizadosSalones' Puede moverla o quitarla según sea necesario.
            this.NoEventosRealizadosSalonesTableAdapter.Fill(this.DataSetReportes.NoEventosRealizadosSalones, año);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.DetalleNoEventosRealizadosSalones' Puede moverla o quitarla según sea necesario.
            this.DetalleNoEventosRealizadosSalonesTableAdapter.Fill(this.DataSetReportes.DetalleNoEventosRealizadosSalones, año);

            this.reportViewer1.RefreshReport();
        }
    }
}
