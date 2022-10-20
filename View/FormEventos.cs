using Hilton.Controller;
using Hilton.Reports;
using Hilton.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton
{
    public partial class FormEventos : Form
    {
        
        int IdEvento;

        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        bool Pagado;
        bool Cancelado;
        bool Reservado;
        DataTable dtSalones;
        DataTable dtServicios;
        DataTable dtContrataciones;

        public FormEventos()
        {
            InitializeComponent();
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtBuscar.Text == string.Empty)
            {
                dt = CEvento.MostrarEventos();
            }
            else
            {
                dt = CEvento.BuscarEventos(txtBuscar.Text);
            }
            FiltrarTablaEventos(dt);

        }

        private void FiltrarTablaEventos(DataTable dt)
        {
            switch (cmbFiltro.Text)
            {
                case "RESERVADO":
                    dt.DefaultView.RowFilter = $"Estado LIKE 'Reservado%'";
                    break;

                case "PAGADO":
                    dt.DefaultView.RowFilter = $"Estado LIKE 'Pagado%'";
                    break;

                case "CANCELADO":
                    dt.DefaultView.RowFilter = $"Estado LIKE 'Cancelado%'";
                    break;
            }
            dgvEventos.DataSource = dt;
            //añadida el 6/12/2021
            dgvEventos.Columns[0].Visible = false;
            dgvEventos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEventos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if(dgvEventos.Rows.Count > 0)
            {
                dgvEventos.Rows[0].Selected = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cmbFiltro_SelectedIndexChanged(sender, e);
        }

        private void dgvEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count == 1)
            {
                IdEvento = Convert.ToInt32(dgvEventos.SelectedRows[0].Cells[0].Value);
                dtSalones = CEvento.ReservacionesEvento(IdEvento);
                dgvReservacionesEventos.DataSource = dtSalones;
                dtServicios = CEvento.ServiciosEventos(IdEvento);
                dgvServicios.DataSource = dtServicios;
                dtContrataciones = CEvento.ContratacionesExternaEvento(IdEvento);
                dgvContrataciones.DataSource = dtContrataciones;
                EstadoEvento(dgvEventos.CurrentRow.Cells[8].Value.ToString());
                CambiarCampos();

            }
            else if (dgvEventos.SelectedRows.Count == 0 && dgvEventos.Rows.Count > 0 && dgvServicios.Rows.Count > 0)
            {
                IdEvento = -1;
                DataTable dt = (DataTable)dgvReservacionesEventos.DataSource;
                dtSalones.Rows.Clear();
                dtContrataciones.Clear();
                dtServicios.Rows.Clear();
                EstadoEvento("");
            }
        }

        private void Botones()
        {
            if (Pagado)
            {
                btnEditar.Enabled = false;
                btnFactura.Enabled = false;
                btnMostrarF.Enabled = true;
                btnEstado.Enabled = false;
                return;
            }

            if (Cancelado)
            {
                btnEditar.Enabled = false;
                btnFactura.Enabled = false;
                btnMostrarF.Enabled = false;
                btnEstado.Enabled = true;
                btnEstado.Text = "Reservar";
                EventoCancelado();
                return;
            }

            if (Reservado)
            {
                btnEditar.Enabled = true;
                btnFactura.Enabled = true;
                btnMostrarF.Enabled = false;
                btnEstado.Enabled = true;
                btnEstado.Text = "Cancelar";
                return;
            }

            btnEditar.Enabled = true;
            btnFactura.Enabled = true;
            btnMostrarF.Enabled = true;
            btnEstado.Enabled = true;

        }

        private void EstadoEvento(string Estado)
        {
            switch (Estado)
            {
                case "Reservado":
                    Reservado = true;
                    Pagado = false;
                    Cancelado = false;
                    break;
                case "Pagado":
                    Reservado = false;
                    Pagado = true;
                    Cancelado = false;
                    break;

                case "Cancelado":
                    Reservado = false;
                    Pagado = false;
                    Cancelado = true;
                    break;

                default:
                    Reservado = false;
                    Pagado = false;
                    Cancelado = false;
                    break;
            }
            Botones();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvEventos.SelectedRows.Count == 1)
            {
                try
                {
                    rpta = CEvento.CambiarEstadoEvento(IdEvento);

                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                cmbFiltro_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO del registro", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormNuevoEvento formNuevoEvento = new FormNuevoEvento();
            formNuevoEvento.idEmpleado = idEmpleado;
            formNuevoEvento.nombreEmpleado = nombreEmpleado;
            formNuevoEvento.ShowDialog();
            txtBuscar.Text = string.Empty;
            cmbFiltro.SelectedIndex = 0;
            cmbFiltro_SelectedIndexChanged(sender, e);
            if (dgvEventos.Rows.Count > 0)
            {
                dgvEventos.Rows[0].Selected = true;
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if(dgvEventos.SelectedRows.Count > 0)
            {
                IdEvento = int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString());
                FrmPago frm = new FrmPago(nombreEmpleado, idEmpleado, IdEvento);
                frm.ShowDialog();
                if (frm.imprimir)
                {
                    Factura f = new Factura();
                    f.idEvento = IdEvento;
                    f.ShowDialog();
                }
                cmbFiltro_SelectedIndexChanged(sender, e);

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void btnMostrarF_Click(object sender, EventArgs e)
        {
            if(dgvEventos.SelectedRows.Count > 0)
            {
                IdEvento = int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString());
                Factura f = new Factura();
                f.idEvento = IdEvento;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void CambiarCampos()
        {
            txtEvento.Text = dgvEventos.CurrentRow.Cells[1].Value.ToString();
            txtFecha.Text = dgvEventos.CurrentRow.Cells[2].Value.ToString();
            txtCliente.Text = dgvEventos.CurrentRow.Cells[3].Value.ToString();
  
        }

        private void EventoCancelado()
        {
            // TODO: ROWS DGV
            DateTime date = Convert.ToDateTime(dgvEventos.CurrentRow.Cells[2].Value.ToString());
            if (DateTime.Compare(DateTime.Now, date)>= 0)
            {
                btnEstado.Enabled = false;
            }
            else
            {
                btnEstado.Enabled = true;
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count > 0)
            {
                IdEvento = int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString());

                FrmEditarEvento frm = new FrmEditarEvento(IdEvento);
                frm.ShowDialog();
                txtBuscar.Text = string.Empty;
                cmbFiltro.SelectedIndex = 0;
                cmbFiltro_SelectedIndexChanged(sender, e);
                if (dgvEventos.Rows.Count > 0)
                {
                    dgvEventos.Rows[0].Selected = true;
                }
            }
        }
    }
}
