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
    public partial class FrmEmpleados : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmEmpleados()
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
            txtDirección.Enabled = valor;
        }
        private void Limpiar()
        {
            txtPNombre.Text = string.Empty;
            txtSNombre.Text = string.Empty;
            txtPApellido.Text = string.Empty;
            txtSApellido.Text = string.Empty;
            mtxtTelefono.Text = string.Empty;
            mtxtCedula.Text = string.Empty;
            txtDirección.Text = string.Empty;

        }

        private void MostrarDatos()
        {
            dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados();
            dgvEmpleados.Columns[0].Visible = false;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            txtBuscar.Focus();
            Botones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.IsNuevo = false;
            //this.IsEditar = false;
            //this.Botones();
            //this.Limpiar();
            //this.dgvEmpleados.CurrentCell = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click_1(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvEmpleados.SelectedRows.Count == 1)
            {
                try
                {
                    rpta = CEmpleado.EstadoEmpleado(Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells[0].Value));
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

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = CEmpleado.BuscarEmpleado(txtBuscar.Text);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvEmpleados.SelectedRows.Count == 1)
            {
                this.txtPNombre.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells[1].Value);
                this.txtSNombre.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells[2].Value);
                this.txtPApellido.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                this.txtSApellido.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                this.mtxtTelefono.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                this.mtxtCedula.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                this.txtDirección.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();


                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                gboxCampos.Visible = true;
                this.txtPNombre.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtPNombre.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CEmpleado.AgregarEmpleado(txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, mtxtTelefono.Text, mtxtCedula.Text, txtDirección.Text);

                }
                else
                {
                    rpta = CEmpleado.ActualizarEmpleado(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString()),
                                                        txtPNombre.Text, txtSNombre.Text,
                                                        txtPApellido.Text, txtSApellido.Text,
                                                        mtxtTelefono.Text, mtxtCedula.Text, txtDirección.Text);

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
