using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hilton.Controller;


namespace Hilton.View
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = CUsuario.Validar_acceso(this.txtUsuario.Text, this.txtContraseña.Text);

            if (dato != null)
            {

                if (dato.Rows.Count > 0)
                {
                    //DataRow dr;
                    //dr = dato.Rows[0];

                    if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                    {

                        MessageBox.Show("Bienvenido al Sistema", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 fp = new Form1();
                        fp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("No hay conexión al servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
