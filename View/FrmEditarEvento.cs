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
    public partial class FrmEditarEvento : Form
    {
        int IdEvento;
        int capacidad = 0;
        DataTable dtEvento = new DataTable();
        DataTable dtReservaciones = new DataTable();
        DataTable dtServicios = new DataTable();
        DataTable dtContrataciones = new DataTable();
        List<int> servicios = new List<int>();
        List<int> Nuevoservicios = new List<int>();
        List<int> salones = new List<int>();

        public FrmEditarEvento(int IdEvento)
        {
            this.IdEvento = IdEvento;
            InitializeComponent();
            nudPersonas.Maximum = 1000000;

        }

        private void Ponerdatos()
        {
            dtpFechaEvento.Value = Convert.ToDateTime(dtEvento.Rows[0][0].ToString());
            txtDescripcion.Text = dtEvento.Rows[0][1].ToString();
            dtpHoraInicio.Value = Convert.ToDateTime($"{dtpFechaEvento.Value.ToShortDateString()} {dtEvento.Rows[0][2]}");
            dtpHoraFin.Value = Convert.ToDateTime($"{dtpFechaEvento.Value.ToShortDateString()} {dtEvento.Rows[0][3]}");
            txtCantHoras.Text = dtEvento.Rows[0][4].ToString();
            txtCapacidadActual.Text = dtEvento.Rows[0][5].ToString();
            capacidad += int.Parse(dtEvento.Rows[0][5].ToString());
            txtCliente.Text = dtEvento.Rows[0][6].ToString();
            nudPersonas.Value = Convert.ToDecimal(dtEvento.Rows[0][5].ToString());
           

        }

        private void FrmEditarEvento_Load(object sender, EventArgs e)
        {
            dgvSalonesReservados.DataSource = CPago.ObtenerTotalSalones(IdEvento);
            dgvServicios.DataSource = CEvento.ServiciosEventos(IdEvento);
            dgvContrataciones.DataSource = CEvento.ContratacionesExternaEvento(IdEvento);
            dtEvento = CEvento.ObtenerEventoEditar(IdEvento);
            Ponerdatos();
            dgvSalonesOcupados.DataSource = CEvento.HorarioSalonesOcupados(dtpFechaEvento.Value);
            CargarTablasAgregado();
            ObtenerServicios();
        }

        private void CargarTablasAgregado() {
            dtReservaciones.Columns.Add("Salón", typeof(string));
            dtReservaciones.Columns.Add("Precio/h", typeof(float));
            dtReservaciones.Columns.Add("Capacidad", typeof(int));

            dgvSaloneAgregados.DataSource = dtReservaciones;

            dtServicios.Columns.Add("Nombre");
            dtServicios.Columns.Add("Tarifa");
            dtServicios.Columns.Add("Total servicio", typeof(float));

            dgvServiciosAgregados.DataSource = dtServicios;

            dtContrataciones.Columns.Add("Nombre", typeof(string));
            dtContrataciones.Columns.Add("Descripción", typeof(string));
            dtContrataciones.Columns.Add("Costo", typeof(float));
            dgvContratacionesAgregadas.DataSource = dtContrataciones;

        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            dtContrataciones.Rows.Add();
            int nf = dtContrataciones.Rows.Count - 1;
            dtContrataciones.Rows[nf][0] = txtNombreContratacion.Text;
            dtContrataciones.Rows[nf][1] = txtDescripcionContratacon.Text;
            dtContrataciones.Rows[nf][2] = float.Parse(nudCostoContra.Value.ToString());

            txtNombreContratacion.Text = string.Empty;
            txtDescripcionContratacon.Text = string.Empty;
            nudCostoContra.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuitarContrataciones_Click(object sender, EventArgs e)
        {
            if (dgvContratacionesAgregadas.SelectedRows.Count > 0)
            {
                int index = dgvContratacionesAgregadas.SelectedRows[0].Index;
                dtContrataciones.Rows[index].Delete();
            }
            else
            {
                MessageBox.Show("Seleccione la fila de la contratacion a quitar");
            }
        }

        private void ObtenerServicios()
        {
            DataTable dt = CEvento.IdServiciosEvento(IdEvento);
            foreach (DataRow dr in dt.Rows)
            {
                servicios.Add(int.Parse(dr[0].ToString()));
            }
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            SeleccionarServicios ss = new SeleccionarServicios();
            ss.ShowDialog();
            if (ss.Elegido)
            {
                int i = servicios.IndexOf(ss.idServicio);
                if (i == -1)
                {
                    servicios.Add(ss.idServicio);
                    Nuevoservicios.Add(ss.idServicio);

                    dtServicios.Rows.Add();
                    int nf = dtServicios.Rows.Count - 1;

                    dtServicios.Rows[nf][0] = ss.dt.Rows[ss.index][1];
                    dtServicios.Rows[nf][1] = ss.dt.Rows[ss.index][2];
                    dtServicios.Rows[nf][2] = float.Parse(txtCantHoras.Text) * float.Parse(ss.dt.Rows[ss.index][2].ToString());
                }

            }
        }

        private void btnQuitarS_Click(object sender, EventArgs e)
        {
            if (dgvServiciosAgregados.SelectedRows.Count > 0)
            {
                int index = dgvServiciosAgregados.SelectedRows[0].Index;
                dtServicios.Rows[index].Delete();
                servicios.RemoveAt(index);
                Nuevoservicios.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Seleccione la fila del servicio a quitar");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarSalon ss = new SeleccionarSalon(CEvento.SalonesDisponibles(dtpFechaEvento.Value, dtpHoraInicio.Value, dtpHoraFin.Value));
            ss.EditaEvento = true;
            ss.ShowDialog();
            if (ss.Elegido)
            {
                if (salones.IndexOf(ss.idSalon) == -1)
                {
                    salones.Add(ss.idSalon);
                    dtReservaciones.Rows.Add();
                    int count = dtReservaciones.Rows.Count - 1;

                    dtReservaciones.Rows[count][0] = ss.Nombre;
                    dtReservaciones.Rows[count][1] = ss.precio;
                    dtReservaciones.Rows[count][2] = ss.Capacidad;

                    capacidad += ss.Capacidad;
                    txtCapacidadActual.Text = $"{capacidad}";
                }
            }
        }

        private void btnQuitarSalon_Click(object sender, EventArgs e)
        {
            if (dtReservaciones.Rows.Count > 0)
            {
                if (dgvSaloneAgregados.SelectedRows.Count > 0)
                {
                    int index = dgvSaloneAgregados.SelectedRows[0].Index;
                    capacidad -= Convert.ToInt32(dgvSaloneAgregados.CurrentRow.Cells[2].Value);
                    txtCapacidadActual.Text = $"{capacidad}";
                    dtReservaciones.Rows.RemoveAt(index);
                    salones.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila de salones reservados");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool seGuarda = ValidarGuardadoEvento();
            string respuesta = "";
            if (seGuarda)
            {

                respuesta = CEvento.EditarAsistenciaEvento(IdEvento, int.Parse(nudPersonas.Value.ToString()));
                if (respuesta != "OK")
                {
                    MessageBox.Show("No se pudo editar asistencia del evento, cambios descartados:" + respuesta);
                    return;
                }

                if (dtReservaciones.Rows.Count > 0)
                {
                    for (int i = 0; i < salones.Count; i++)
                    {
                        respuesta = CEvento.AgregarReservacion(IdEvento, salones.ElementAt(i));
                        if (respuesta != "OK")
                        {
                            MessageBox.Show("No se pudieron agregar las reservaciones al evento:" + respuesta);
                            return;
                        }
                    }
                }

                for (int i = 0; i < Nuevoservicios.Count; i++)
                {
                    int idServicio = Nuevoservicios.ElementAt(i);
                    respuesta = CEvento.AgregarServicios(IdEvento, idServicio);
                    if (respuesta != "OK")
                    {
                        MessageBox.Show("No se pudieron agregar todos los servicios:" + respuesta);
                        return;
                    }
                }


                for (int i = 0; i < dtContrataciones.Rows.Count; i++)
                {
                    string nombre = dtContrataciones.Rows[i][0].ToString();
                    string descripcion = dtContrataciones.Rows[i][1].ToString();
                    float precio = float.Parse(dtContrataciones.Rows[i][2].ToString());
                    respuesta = CEvento.AgregarContratacionExterna(IdEvento, nombre, descripcion, precio);
                    if (respuesta != "OK")
                    {
                        MessageBox.Show("No se pudieron agregar todas las contrataciones:" + respuesta);
                        return;
                    }
                }
                MessageBox.Show("Se edito evento correctamente");
                Close();
            }
        }
        private bool ValidarGuardadoEvento()
        {
            
            //Validando que la capacidad total sea >= que la cantidad de personas asitentes
            if (Int32.Parse(nudPersonas.Value.ToString()) > Int32.Parse(txtCapacidadActual.Text))
            {
                MessageBox.Show("Las reservaciones actuales no cubren la cantidad de personas asistentes");
                return false;
            }

            if (nudPersonas.Value == 0)
            {
                MessageBox.Show("Ingrese la cantidad de asistentes al evento");
                nudPersonas.Focus();
                return false;
            }

            return true;
        
        }
    }
}
