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
    public partial class SeleccionarCliente : Form
    {

        public bool Elegido { get; set; }

        public int idCliente { get; set; }

        public string Nombre { get; set; }

        public SeleccionarCliente()
        {
            InitializeComponent();
            DataTable dt = CCliente.MostrarClientes();
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado'";
            dgvClientes.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CCliente.BuscarClientes(txtBuscar.Text);
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado'";
            dgvClientes.DataSource = dt;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dgvClientes.SelectedRows[0];
                idCliente = Convert.ToInt32(dgvr.Cells[0].Value);
                Nombre = dgvr.Cells[1].Value.ToString() + " ";
                Nombre += dgvr.Cells[3].Value.ToString();
                Elegido = true;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
