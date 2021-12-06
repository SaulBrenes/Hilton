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
    public partial class NuevoCliente : Form
    {

        public bool Creado { get; set; }

        public int idCliente { get; set; }

        public string Nombre { get; set; }

      

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            txtPNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Creado = false;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {

                string rpta = CCliente.AgregarCliente(txtPNombre.Text,
                    txtSNombre.Text, txtPApellido.Text, txtSApellido.Text,
                    mtxtTelefono.Text, mtxtCedula.Text);
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Datos Ingresados", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Creado = true;
                    idCliente = CCliente.IdultimoClienteRegistrado();
                    Nombre = $"{txtPNombre.Text} {txtPApellido.Text}";
                    Close();
                }
                else
                {
                    MessageBox.Show(rpta, "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private bool ValidarCampos()
        {
            if(txtPNombre.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
                txtPNombre.Focus();
                return false;
            }

            if (txtSNombre.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
                txtSNombre.Focus();
                return false;
            }


            if (txtPApellido.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
                txtPApellido.Focus();
                return false;
            }

            if (txtSApellido.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
                txtSApellido.Focus();
                return false;
            }

            if(mtxtTelefono.Text == string.Empty || mtxtTelefono.Text.Length < 8)
            {
                MessageBox.Show("Llene todos los campos");
                mtxtTelefono.Focus();
                return false;
            }

            if (mtxtCedula.Text == string.Empty || mtxtCedula.Text.Length < 16)
            {
                MessageBox.Show("Llene todos los campos");
                mtxtCedula.Focus();
                return false;
            }

            return true;
        }
    }
}
