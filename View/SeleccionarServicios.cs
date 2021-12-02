using Hilton.Controller;
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
    public partial class SeleccionarServicios : Form
    {
        public bool Elegido;

        public int index;

        public int idServicio { get; set; }
        public DataTable dt { get; set; }

        public SeleccionarServicios()
        {
            InitializeComponent();
        }

        private void SeleccionarServicios_Load(object sender, EventArgs e)
        {
            dt = CServicio.MostrarServicios();
            dt.DefaultView.RowFilter = $"Estado LIKE 'Habilitado'";
            dgvServicios.DataSource = dt;
            dgvServicios.Columns[4].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvServicios.SelectedRows.Count > 0)
            {
                index = dgvServicios.SelectedRows[0].Index;
                idServicio =Convert.ToInt32(dgvServicios.SelectedRows[0].Cells[0].Value);
                Elegido = true;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un servicio");
            }
        }
    }
}
