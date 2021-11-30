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
    public partial class SeleccionarSalon : Form
    {
        public bool Elegido;
        public int idSalon { get; set; }
        public string Nombre { get; set; }

        public DataTable dt { get; set; }

        public SeleccionarSalon(DataTable datos)
        {
            InitializeComponent();
            dt = datos;
            dgvSalon.DataSource = dt;
        }

        private void SeleccionarSalon_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = $"Nombre Like '{txtBuscar.Text}%' or " +
                $"Código Like '{txtBuscar.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvSalon.SelectedRows.Count == 1)
            {
                idSalon = Convert.ToInt32(dgvSalon.SelectedRows[0].Cells[0].Value.ToString());
                Nombre = dgvSalon.SelectedRows[0].Cells[2].Value.ToString();
                Elegido = true;
                Close();
            }
            else
            {

                MessageBox.Show("Seleccione un salón");
            }
        }
    }
}
