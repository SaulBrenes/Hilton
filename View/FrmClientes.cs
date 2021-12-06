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
    public partial class FrmClientes: Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEstado.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = true;
            }

        }
        private void Habilitar(bool valor)
        {
            txtPNombre.Enabled = valor;
            txtSNombre.Enabled = valor;
            txtPApellido.Enabled = valor;
            txtSApellido.Enabled = valor;
            mtxtTelefono.Enabled = valor;
            mtxtCedula.Enabled = valor;
        }
        private void Limpiar()
        {
            txtPNombre.Text = string.Empty;
            txtSNombre.Text = string.Empty;
            txtPApellido.Text = string.Empty;
            txtSApellido.Text = string.Empty;
            mtxtTelefono.Text = string.Empty;
            mtxtCedula.Text = string.Empty;
            txtBuscar.Text = string.Empty;
        }

        private void MostrarDatos()
        {
            dgvClientes.DataSource = CCliente.MostrarClientes();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            txtBuscar.Focus();
            Botones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = CCliente.BuscarClientes(txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvClientes.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CCliente.EstadoCliente(Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dgvClientes.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtPNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.SelectedRows.Count == 1)
            {
                this.txtPNombre.Text = Convert.ToString(this.dgvClientes.CurrentRow.Cells[1].Value);
                this.txtSNombre.Text = Convert.ToString(this.dgvClientes.CurrentRow.Cells[2].Value);
                this.txtPApellido.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                this.txtSApellido.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                this.mtxtTelefono.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                this.mtxtCedula.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();



                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtPNombre.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Eitar", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CCliente.AgregarCliente(txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, mtxtTelefono.Text, mtxtCedula.Text);

                }
                else
                {
                    rpta = CCliente.ActualizarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString()), txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, mtxtTelefono.Text, mtxtCedula.Text);

                }

                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {

                        MessageBox.Show("Datos Ingresados", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema Hilon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                MostrarDatos();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


    }
}
