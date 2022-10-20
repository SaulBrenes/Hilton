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
    public partial class FrmEmpresaMantenimiento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmEmpresaMantenimiento()
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
            txtDireccion.Enabled = valor;
            mtxtTelefono.Enabled = valor;
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            mtxtTelefono.Text = string.Empty;
        }

        private void FrmEmpresaMantenimiento_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Botones();
            txtBuscar.Focus();

        }

        private void MostrarDatos()
        {
            dgvEmpresas.DataSource = CEmpresaMantenimiento.MostrarEmpresas();
            dgvEmpresas.Columns[0].Visible = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.IsNuevo = false;
            //this.IsEditar = false;
            //this.Botones();
            //this.Limpiar();
            //this.dgvEmpresas.CurrentCell = null;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            dgvEmpresas.DataSource = CEmpresaMantenimiento.BuscarEmpresa(txtBuscar.Text);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvEmpresas.SelectedRows.Count == 1)
            {
                this.txtNombre.Text = Convert.ToString(this.dgvEmpresas.CurrentRow.Cells[1].Value);
                this.mtxtTelefono.Text = (this.dgvEmpresas.CurrentRow.Cells[2].Value.ToString());
                this.txtDireccion.Text = (this.dgvEmpresas.CurrentRow.Cells[3].Value.ToString());
                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtNombre.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Editar", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstado_Click_1(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvEmpresas.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CEmpresaMantenimiento.EstadoEmpresa(Convert.ToInt32(this.dgvEmpresas.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CEmpresaMantenimiento.AgregarEmpresa(txtNombre.Text, txtDireccion.Text, mtxtTelefono.Text);

                }
                else
                {
                    rpta = CEmpresaMantenimiento.ActualizarEmpresa(Convert.ToInt32(this.dgvEmpresas.CurrentRow.Cells[0].Value), txtNombre.Text, txtDireccion.Text, mtxtTelefono.Text);

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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dgvEmpresas.CurrentCell = null;
        }
    }
}
