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
    public partial class FormNuevoEvento : Form
    {
        public int idEmpleado{get; set;}

        List<int> servicios = new List<int>();

        public int idCliente { get; set; }

        public string nombreEmpleado { get; set; }

        int capacidad = 0;


        DataTable dtSalonesDisponibles;

        DataTable dtReservaciones;

        DataTable dtServicios;

        DataTable dtContratacion;

        DateTime MinInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
        DateTime MaxInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 0, 0);
        DateTime MinFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
        DateTime MaxFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);

        public FormNuevoEvento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNuevoEvento_Load(object sender, EventArgs e)
        {
            //Configuración de datatimepicker
            dtpFechaEvento.MinDate = DateTime.Today;

            dtpHoraInicio.Value = MinInicio;
            dtpHoraInicio.MinDate = MinInicio;
            dtpHoraInicio.MaxDate = MaxInicio;

            dtpHoraFin.Value = MinFin;
            dtpHoraFin.MinDate = MinFin;
            dtpHoraFin.MaxDate = MaxFin;

            nudPersonas.Maximum = 900;

            //Configurando datagridview
            dtReservaciones = new DataTable();
            dtReservaciones.Columns.Add("Id", typeof(Int32));
            dtReservaciones.Columns.Add("Nombre", typeof(string));
            dtReservaciones.Columns.Add("Precio $/h", typeof(float));
            dtReservaciones.Columns.Add("Cap. Máxima", typeof(Int32));
            dgvReservacion.DataSource = dtReservaciones;
            ActulizarVistaSalones();
        }

        public void ActulizarVistaSalones()
        {
            dgvSalonesOcupados.DataSource = CEvento.HorarioSalonesOcupados(dtpFechaEvento.Value);

            dtSalonesDisponibles = CEvento.SalonesDisponibles(dtpFechaEvento.Value,
                dtpHoraInicio.Value, dtpHoraFin.Value);

            if (dtReservaciones != null && dtReservaciones.Rows.Count > 0)
            {
                dtReservaciones.Rows.Clear();
            }


            if (dtSalonesDisponibles.Rows.Count == 0)
            {
                lblAviso.Visible = true;
                btnSeleccionar.Enabled = false;
            }
            else
            {
                lblAviso.Visible = false;
                btnSeleccionar.Enabled = true;
                dgvSalonesDisponibles.DataSource = dtSalonesDisponibles;
            }
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpHoraFin.Value = dtpHoraInicio.Value.AddHours(1);
            txtCantHoras.Text = $"{dtpHoraFin.Value.Hour - dtpHoraInicio.Value.Hour}";
            ActulizarVistaSalones();

        }

        private void dtpHoraFin_ValueChanged(object sender, EventArgs e)
        {
            txtCantHoras.Text = $"{dtpHoraFin.Value.Hour - dtpHoraInicio.Value.Hour}";
            ActulizarVistaSalones();
        }

        private void dtpFechaEvento_ValueChanged(object sender, EventArgs e)
        {
            ActulizarVistaSalones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtSalonesDisponibles.DefaultView.RowFilter =$"Nombre Like '{txtBuscar.Text}%'";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSalonesDisponibles.SelectedRows.Count > 0) {
                int indice = Convert.ToInt32(dgvSalonesDisponibles.CurrentRow.Cells[0].Value);
            
                    if (dtReservaciones.Rows.Count > 0)
                    { 
                        foreach (DataRow dr in dtReservaciones.Rows)
                        {
                           if( Convert.ToInt32(dr.ItemArray[0]) == indice)
                            {
                                MessageBox.Show("Ya se escogió el salón");
                                return;
                            }
                        }

                    }
                dtReservaciones.Rows.Add();
                int count = dtReservaciones.Rows.Count - 1;
                dtReservaciones.Rows[count][0] = indice;

                dtReservaciones.Rows[count][1] =
                        dgvSalonesDisponibles.CurrentRow.Cells[1].Value.ToString();

                dtReservaciones.Rows[count][2] =
                        float.Parse(dgvSalonesDisponibles.CurrentRow.Cells[2].Value.ToString());

                dtReservaciones.Rows[count][3] =
                        Convert.ToInt32(dgvSalonesDisponibles.CurrentRow.Cells[3].Value);

                capacidad += Convert.ToInt32(dgvSalonesDisponibles.CurrentRow.Cells[3].Value);
                txtCapacidadActual.Text = $"{capacidad} personas";
            }
            else
            {
                MessageBox.Show("Seleccione una fila de salones disponibles");
            }
        }

        private void btnQuitarSalon_Click(object sender, EventArgs e)
        {
            if(dtReservaciones.Rows.Count > 0)
            {
                if(dgvReservacion.SelectedRows.Count > 0)
                {
                    int index = dgvReservacion.SelectedRows[0].Index;
                    capacidad -= Convert.ToInt32(dgvReservacion.CurrentRow.Cells[3].Value);
                    txtCapacidadActual.Text = $"{capacidad} personas";
                    dtReservaciones.Rows.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila de salones reservados");
                }
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SeleccionarCliente sc = new SeleccionarCliente();
            sc.ShowDialog();
            if (sc.Elegido)
            {
                idCliente = sc.idCliente;
                txtCliente.Text = sc.Nombre;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente();
            nc.ShowDialog();
            if (nc.Creado)
            {
                idCliente = nc.idCliente;
                txtCliente.Text = nc.Nombre;
            }
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            SeleccionarServicios ss = new SeleccionarServicios();
            ss.ShowDialog();
            if (ss.Elegido)
            {
                int i = servicios.IndexOf(ss.idServicio);
                if(i == -1)
                {
                    servicios.Add(ss.idServicio);
                    if (dtServicios == null)
                    {
                        dtServicios = new DataTable();
                        dtServicios.Columns.Add("ID", typeof(Int32));
                        dtServicios.Columns.Add("Nombre", typeof(string));
                        dtServicios.Columns.Add("Tarifa", typeof(float));
                        dtServicios.Columns.Add("Descripcion", typeof(string));
                        dgvServicios.DataSource = dtServicios;
                    }
                    dtServicios.Rows.Add();
                    int nf = dtServicios.Rows.Count - 1;
                    
                    dtServicios.Rows[nf][0] = ss.dt.Rows[ss.index][0];
                    dtServicios.Rows[nf][1] = ss.dt.Rows[ss.index][1];
                    dtServicios.Rows[nf][2] = ss.dt.Rows[ss.index][2];
                    dtServicios.Rows[nf][3] = ss.dt.Rows[ss.index][3];
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarS_Click(object sender, EventArgs e)
        {
            if(dgvServicios.SelectedRows.Count > 0)
            {
                int index = dgvServicios.SelectedRows[0].Index;
                dtServicios.Rows[index].Delete();
                servicios.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Seleccione la fila del servicio a quitar");
            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            if(dtContratacion == null)
            {
                dtContratacion = new DataTable();
                dtContratacion.Columns.Add("Nombre", typeof(string));
                dtContratacion.Columns.Add("Descripcion", typeof(string));
                dtContratacion.Columns.Add("Precio", typeof(float));
                dgvContrataciones.DataSource = dtContratacion;
            }
            dtContratacion.Rows.Add();
            int nf = dtContratacion.Rows.Count - 1;
            dtContratacion.Rows[nf][0] = txtNombreContratacion.Text;
            dtContratacion.Rows[nf][1] = txtDescripcionContratacon.Text;
            dtContratacion.Rows[nf][2] = float.Parse(nudCostoContra.Value.ToString());

            txtNombreContratacion.Text = string.Empty;
            txtDescripcionContratacon.Text = string.Empty;
            nudCostoContra.Value = 0;
        }

        private void btnQuitarContrataciones_Click(object sender, EventArgs e)
        {
            if(dgvContrataciones.SelectedRows.Count > 0)
            {
                int index = dgvContrataciones.SelectedRows[0].Index;
                dtContratacion.Rows[index].Delete();
            }
            else
            {
                MessageBox.Show("Seleccione la fila de la contratacion a quitar");
            }
        }
    }

}
