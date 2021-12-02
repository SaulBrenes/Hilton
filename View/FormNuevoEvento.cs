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
    public partial class FormNuevoEvento : Form
    {
        public int idEmpleado{get; set;}
        public string nombreEmpleado { get; set; }
        public FormNuevoEvento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNuevoEvento_Load(object sender, EventArgs e)
        {
            dtpFechaEvento.MinDate = DateTime.Today;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = dtpHoraInicio.Value.AddHours(1);
            dtpHoraFin.MinDate = dtpHoraInicio.Value.AddHours(1);
            txtCantHoras.Text = $"{dtpHoraFin.Value.Hour - dtpHoraInicio.Value.Hour + (dtpHoraFin.Value.Minute - dtpHoraInicio.Value.Minute)/60}";
        }
    }
}
