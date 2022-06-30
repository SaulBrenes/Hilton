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
    public partial class FormMantenimiento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        int idSalon { get; set; }
        int idEmpresa { get; set; }
        int idEmpleado { get; set; }

        public FormMantenimiento()
        {
            InitializeComponent();
            nudCosto.Maximum = decimal.MaxValue;
            txtBuscar.Focus();
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
            dtpFecha.Enabled = valor;
            nudCosto.Enabled = valor;
            btnSalon.Enabled = valor;
            btnEmpleado.Enabled = valor;
            btnEmpresa.Enabled = valor;
            txtDescripcion.Enabled = valor;
        }
        private void Limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            nudCosto.Value = 0;
            txtSalon.Text = string.Empty;
            txtEmpleado.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void MostrarDatos()
        {
            dgvMantenimientos.DataSource = CMantenimiento.MostrarMatenimientos();
            dgvMantenimientos.Columns[0].Visible = false;
            dgvMantenimientos.Columns[1].Visible = false;
            dgvMantenimientos.Columns[4].Visible = false;
            dgvMantenimientos.Columns[6].Visible = false;
            dgvMantenimientos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Botones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvMantenimientos.DataSource = CMantenimiento.BuscarMantenimiento(txtBuscar.Text);
            dgvMantenimientos.Columns[0].Visible = false;
            dgvMantenimientos.Columns[1].Visible = false;
            dgvMantenimientos.Columns[4].Visible = false;
            dgvMantenimientos.Columns[6].Visible = false;
            dgvMantenimientos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtpFecha.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMantenimientos.SelectedRows.Count == 1)
            {

                idSalon = Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[1].Value);
                idEmpresa = Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[4].Value);
                idEmpleado = Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[6].Value);


                this.txtSalon.Text = Convert.ToString(this.dgvMantenimientos.CurrentRow.Cells[2].Value);
                this.dtpFecha.Text = Convert.ToString(this.dgvMantenimientos.CurrentRow.Cells[3].Value);
                this.txtEmpresa.Text = dgvMantenimientos.CurrentRow.Cells[5].Value.ToString();
                this.txtEmpleado.Text = dgvMantenimientos.CurrentRow.Cells[7].Value.ToString();
                this.nudCosto.Text = dgvMantenimientos.CurrentRow.Cells[8].Value.ToString();
                this.txtDescripcion.Text = dgvMantenimientos.CurrentRow.Cells[10].Value.ToString();


                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.dtpFecha.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvMantenimientos.SelectedRows.Count == 1)
            {
                try
                {
                    rpta = CMantenimiento.EstadoMantenimiento(Convert.ToInt32(this.dgvMantenimientos.CurrentRow.Cells[0].Value));
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
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO del registro", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo && ValidarCampos())
                {
                    rpta = CMantenimiento.CrearMantenimiento(idSalon,idEmpleado,idEmpresa,
                        float.Parse(nudCosto.Value.ToString()), txtDescripcion.Text, dtpFecha.Value);

                }
                else
                {
                    rpta = CMantenimiento.EditarMantenimiento(Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[0].Value),
                                                            idSalon, idEmpleado, idEmpresa,
                                                            float.Parse(nudCosto.Value.ToString()), 
                                                            txtDescripcion.Text, dtpFecha.Value);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dgvMantenimientos.CurrentCell = null;
            txtBuscar.Focus();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            SeleccionarSalon seleccionarSalon = 
                new SeleccionarSalon(CSalon.MostrarSalones());
            seleccionarSalon.ShowDialog();
            if (seleccionarSalon.Elegido)
            {
                idSalon = seleccionarSalon.idSalon;
                txtSalon.Text = seleccionarSalon.Nombre;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            SeleccionEmpleado se = new SeleccionEmpleado();
            se.ShowDialog();
            if (se.Elegido)
            {
                idEmpleado = se.idEmpleado;
                txtEmpleado.Text = se.nombreEmpleado;
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormSeleccionarEmpresaM sm = new FormSeleccionarEmpresaM();
            sm.ShowDialog();
            if (sm.Elegido)
            {
                idEmpresa = sm.idEmpresa;
                txtEmpresa.Text = sm.nombreEmpresa;
            }
        }

        private bool ValidarCampos()
        {
            if(txtDescripcion.Text== string.Empty)
            {
                MessageBox.Show("El campo de descripción esta vacío", "Falta de campos");
                return false;
            }

            if(txtEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Eliga el empleado que superviso el mantenimiento", "Falta de campos");
                return false;
            }

            if(txtEmpresa.Text == string.Empty)
            {
                MessageBox.Show("Eliga la empresa que realizo el mantenimiento", "Falta de campos");
                return false;
            }

            if (txtSalon.Text == string.Empty)
            {
                MessageBox.Show("Eliga el salón donde se hizó mantenimiento", "Falta de campos");
                return false;
            }

            return true;
        }
    }
}
