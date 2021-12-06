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
    public partial class SeleccionarSalon : Form
    {
        public bool Elegido;

        public bool EditaEvento;
        public int idSalon { get; set; }
        public string Nombre { get; set; }

        public float precio { get; set; }

        public int Capacidad { get; set; }

        public DataTable dt { get; set; }

        public SeleccionarSalon(DataTable datos)
        {
            InitializeComponent();
            dt = datos;
            dgvSalon.DataSource = dt;
        }

        private void SeleccionarSalon_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (EditaEvento)
            {
                dt.DefaultView.RowFilter = $"Nombre Like '{txtBuscar.Text}%'";
                return;
            }
            dt.DefaultView.RowFilter = $"Nombre Like '{txtBuscar.Text}%' or " +
                $"Código Like '{txtBuscar.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegido = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvSalon.SelectedRows.Count == 1)
            {
                if (EditaEvento)
                {
                    idSalon = Convert.ToInt32(dgvSalon.SelectedRows[0].Cells[0].Value.ToString());
                    Nombre = dgvSalon.SelectedRows[0].Cells[1].Value.ToString();
                    precio = float.Parse(dgvSalon.SelectedRows[0].Cells[2].Value.ToString());
                    Capacidad = int.Parse(dgvSalon.SelectedRows[0].Cells[3].Value.ToString());
                    Elegido = true;
                    Close();
                    return;
                }
                
                
                idSalon = Convert.ToInt32(dgvSalon.SelectedRows[0].Cells[0].Value.ToString());
                Nombre = dgvSalon.SelectedRows[0].Cells[2].Value.ToString();
                    
                Elegido = true;
                Close();
            }
            else
            {

                MessageBox.Show("Seleccione un salón");
            }
        }
    }
}
