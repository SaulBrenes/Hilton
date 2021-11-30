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
    public partial class FormSeleccionarEmpresaM : Form
    {
        public int idEmpresa { get; set; }

        public string nombreEmpresa { get; set; }

        public bool Elegido { get; set; }

        public FormSeleccionarEmpresaM()
        {
            InitializeComponent();
        }

        private void FormSeleccionarEmpresaM_Load(object sender, EventArgs e)
        {
            DataTable dt = CEmpresaMantenimiento.MostrarEmpresas();
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado%'";
            dgvEmpresas.DataSource = dt;
            dgvEmpresas.Columns[0].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1)
            {
                idEmpresa= Convert.ToInt32(dgvEmpresas.SelectedRows[0].Cells[0].Value.ToString());
                nombreEmpresa = dgvEmpresas.SelectedRows[0].Cells[1].Value.ToString();
                Elegido = true;
                Close();
            }
            else
            {

                MessageBox.Show("Seleccione una empresa");
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CEmpresaMantenimiento.BuscarEmpresa(txtBuscar.Text);
            dt.DefaultView.RowFilter = $"Estado Like 'Habilitado%'";
            dgvEmpresas.DataSource = dt;
            dgvEmpresas.Columns[0].Visible = false;
        }
    }
}
