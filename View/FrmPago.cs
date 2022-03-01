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
    public partial class FrmPago : Form
    {
        int idEmpleado;
        int idEvento;
        public bool imprimir { get; set; }
        public FrmPago(string nombreEmpleado, int idEmpleado, int idEvento)
        {
            InitializeComponent();
            txtEmpleado.Text = nombreEmpleado;
            this.idEmpleado = idEmpleado;
            this.idEvento = idEvento;
            txtFecha.Text = DateTime.Now.ToShortDateString();
            cmbFormaPago.SelectedIndex = 0;

            dgvEventos.DataSource = CPago.ObtenerEncabezadoPago(idEvento);
            dgvSalones.DataSource = CPago.ObtenerTotalSalones(idEvento);
            dgvServicios.DataSource = CPago.MostrarServiciosEvento(idEvento);
            DataTable dt = CPago.ObtenerTotales(idEvento);
            lblSubtotalSalon.Text = dt.Rows[0][0].ToString();
            lblSubtotalServicio.Text = dt.Rows[0][1].ToString();
            lblTotalEvento.Text = dt.Rows[0][2].ToString();
            lblTotalFinal.Text = dt.Rows[0][2].ToString();

        }

        private void npdDescuento_ValueChanged(object sender, EventArgs e)
        {
            float descuento = float.Parse(npdDescuento.Value.ToString())/100;
            float subtotal = float.Parse(lblTotalEvento.Text);
            lblTotalFinal.Text = $"{(subtotal * (1-descuento))}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = CPago.GuardarPago(idEvento, DateTime.Now,
                float.Parse(npdDescuento.Value.ToString()) / 100,
                idEmpleado,
                cmbFormaPago.Text);

            if(respuesta == "OK")
            {
                DialogResult dialogResult = MessageBox.Show("Se guardo el pago correctamente ¿Quiere Imprimir Factura?","Sistema Hilton",MessageBoxButtons.OKCancel);
                if(dialogResult== DialogResult.OK)
                {
                    imprimir = true;
                    Close();
                }
                Close();
            }
            else
            {
                MessageBox.Show($"No se pudo guardar pago: {respuesta}");
            }
        }
    }
}
