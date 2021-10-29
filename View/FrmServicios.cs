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
    public partial class FrmServicios : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmServicios()
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
            this.txtNombre.Enabled = valor;
            richtxtdescripcion.Enabled = valor;
            this.nudTarifa.Enabled = valor;
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            richtxtdescripcion.Text = string.Empty;
            nudTarifa.Value = 0;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Botones();
            txtBuscar.Focus();
        }

        private void MostrarDatos()
        {
            dgvServicios.DataSource = CServicio.MostrarServicios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvServicios.DataSource = CServicio.BuscarServicios(txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvServicios.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CServicio.EstadoServicio(Convert.ToInt32(this.dgvServicios.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.dgvServicios.CurrentCell = null;
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
            this.dgvServicios.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvServicios.SelectedRows.Count == 1)
            {
                this.txtNombre.Text = Convert.ToString(this.dgvServicios.CurrentRow.Cells[1].Value);
                nudTarifa.Value = decimal.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString());
                richtxtdescripcion.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();
                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtNombre.Focus();

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
                    rpta = CServicio.AgregarServicio( txtNombre.Text, float.Parse(nudTarifa.Value.ToString()), richtxtdescripcion.Text);

                }
                else
                {
                    rpta = CServicio.ActualizarServicio(Convert.ToInt32(this.dgvServicios.CurrentRow.Cells[0].Value), txtNombre.Text, float.Parse(nudTarifa.Value.ToString()), richtxtdescripcion.Text);

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
