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
    public partial class FrmMiCuenta : Form
    {
        private int idusuario;
        public FrmMiCuenta(string rol, string usuario, int idusuario)
        {
            InitializeComponent();
            lblRolCuenta.Text = rol;
            txtUsuario.Text = usuario;
            this.idusuario = idusuario;

        }

        private void FrmMiCuenta_Load(object sender, EventArgs e)
        {
            this.Size = new Size( 360,308);
            this.Controls.Remove(this.groupBox1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            this.Controls.Add(this.groupBox1);
            this.Size = new Size(360, 530);
            btnContrasena.Enabled = false;
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            if (btnMostrar1.Text.Equals("o"))
            {
                btnMostrar1.Text = "*";
                btnMostrar2.Text = "*";
                txtContrasena.UseSystemPasswordChar = false;
                txtRepeticionC.UseSystemPasswordChar = false;

            }
            else if (btnMostrar1.Text.Equals("*"))
            {
                btnMostrar1.Text = "o";
                btnMostrar2.Text = "o";
                txtContrasena.UseSystemPasswordChar = true;
                txtRepeticionC.UseSystemPasswordChar = true;
            }
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            btnMostrar1_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Controls.Remove(this.groupBox1);
            groupBox1.Visible = false;
            this.Size = new Size(360, 308);
            btnContrasena.Enabled = true;
            txtContrasena.Text = string.Empty;
            txtRepeticionC.Text = string.Empty;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(string.Empty))
            {
                MessageBox.Show("Llene el campo de contraseña");
                txtContrasena.Focus();
                return;
            }

            if (txtRepeticionC.Text.Equals(string.Empty))
            {
                MessageBox.Show("Escriba nuevamente la contraseña");
                txtRepeticionC.Focus();
                return;
            }

            if(txtContrasena.Text == txtRepeticionC.Text)
            {
                string repuesta = CUsuario.ActualizarContraseñaUsuario(idusuario,txtContrasena.Text, lblRolCuenta.Text);
                if (repuesta.Equals("OK"))
                {
                    repuesta = "Contraseña cambiada correctamente";
                }
                
                MessageBox.Show(repuesta);
                btnCancelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden");
                txtRepeticionC.Focus();
            }

        }
    }
}
