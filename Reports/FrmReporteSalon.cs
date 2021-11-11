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
    public partial class FrmReporteSalon : Form
    {
        public FrmReporteSalon()
        {
            InitializeComponent();
        }

        private void FrmReporteSalon_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetSalones.Salones' Puede moverla o quitarla según sea necesario.
            this.SalonesTableAdapter.Fill(this.DataSetSalones.Salones);

            this.reportViewer1.RefreshReport();
        }
    }
}
