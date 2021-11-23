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
    public partial class SeleccionEmpleado : Form
    {
        public int idEmpleado { get; set; }

        public string nombreEmpleado { get; set; }

        public bool Elegido { get; set; }

        public SeleccionEmpleado( )
        {
            InitializeComponent();
            
        }

        private void SeleccionEmpleado_Load(object sender, EventArgs e)
        {
            DataTable dt = CEmpleado.MostrarEmpleados();
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado%'";
            dgvEmpleados.DataSource = dt;
            dgvEmpleados.Columns[6].Visible = false;
            dgvEmpleados.Columns[7].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CEmpleado.BuscarEmpleado(txtBuscar.Text);
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado%'";
            dgvEmpleados.Columns[6].Visible = false;
            dgvEmpleados.Columns[7].Visible = false;
            dgvEmpleados.DataSource = dt;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dgvEmpleados.SelectedRows.Count == 1)
            {
                idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());
                nombreEmpleado = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
                nombreEmpleado += " " + dgvEmpleados.SelectedRows[0].Cells[2].Value.ToString();
                nombreEmpleado += " " + dgvEmpleados.SelectedRows[0].Cells[3].Value.ToString();
                nombreEmpleado += " " + dgvEmpleados.SelectedRows[0].Cells[4].Value.ToString();
                MessageBox.Show(idEmpleado + " " + nombreEmpleado);
                Elegido = true;
                Close();
            }
            else {

                MessageBox.Show("Seleccione un empleado");
            }
           
        }
    }
}
