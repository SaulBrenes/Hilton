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
    public partial class FrmSalon : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmSalon()
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
            this.mtxtCodigo.Enabled = valor;
            this.nudcapacidadmax.Enabled = valor;
            this.nudPrecioHora.Enabled = valor;
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.mtxtCodigo.Text = string.Empty;
            nudcapacidadmax.Value = 0;
            nudPrecioHora.Value = 0;
        }

        private void FrmSalon_Load(object sender, EventArgs e)
        {
            dgvSalones.DataSource = CSalon.MostrarSalones();
            Botones();
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvSalones.DataSource = CSalon.BuscarSalon(txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvSalones.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CSalon.EstadoSalon(Convert.ToInt32(this.dgvSalones.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                dgvSalones.DataSource = CSalon.MostrarSalones();
            }

            else
            {
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

              this.dgvSalones.CurrentCell = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            gbCampos.Visible = false;
            this.Botones();
            this.Limpiar();
            this.dgvSalones.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            gbCampos.Visible = true;
            this.Botones();
            this.Limpiar();
            this.mtxtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvSalones.SelectedRows.Count == 1)
            {
                this.mtxtCodigo.Text = Convert.ToString(this.dgvSalones.CurrentRow.Cells[1].Value);
                this.txtNombre.Text = Convert.ToString(this.dgvSalones.CurrentRow.Cells[2].Value);
                this.nudPrecioHora.Value = decimal.Parse(this.dgvSalones.CurrentRow.Cells[4].Value.ToString());
                nudcapacidadmax.Value = decimal.Parse(dgvSalones.CurrentRow.Cells[3].Value.ToString());

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                gbCampos.Visible = true;
                this.mtxtCodigo.Focus();

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
                    rpta = CSalon.AgregarSalon(mtxtCodigo.Text, txtNombre.Text, float.Parse(nudPrecioHora.Value.ToString()), int.Parse(nudcapacidadmax.Value.ToString()));

                }
                else
                {
                    rpta = CSalon.ActualizarSalon(Convert.ToInt32(this.dgvSalones.CurrentRow.Cells[0].Value), mtxtCodigo.Text, txtNombre.Text, float.Parse(nudPrecioHora.Value.ToString()), int.Parse(nudcapacidadmax.Value.ToString()));

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
                gbCampos.Visible = false;
                this.Botones();
                this.Limpiar();
               
                dgvSalones.DataSource = CSalon.MostrarSalones();
                dgvSalones.CurrentCell = null;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        

        private void nudPrecioHora_Enter(object sender, EventArgs e)
        {
            nudPrecioHora.ResetText();
        }

        private void nudcapacidadmax_Enter(object sender, EventArgs e)
        {
            nudcapacidadmax.ResetText();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Form1 frmDialogReporte = new Form1();
            //frmDialogReporte.ShowDialog();
        }
    }
}
