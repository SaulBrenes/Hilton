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
using Hilton.Model;

namespace Hilton.View
{
    public partial class FrmUsuarios : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private bool IsContrasena = false;

        public int idEmpleado { get; set; }
        public FrmUsuarios()
        {
            InitializeComponent();
            //Inilizando combobox
            cmbRol.Items.AddRange(Roles.rolesDisponibles);
        }

        //MÉTODOS AUXILIARES DE INTERFAZ
        public void mostrarDatos()
        {
            dgvUsuarios.DataSource = CUsuario.MostrarUsuario();
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[2].Visible = false;
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar || IsContrasena) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEstado.Enabled = false;
                btnNuevaContrasena.Enabled = false;
                btnMostrar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = true;
                btnNuevaContrasena.Enabled = true;
                btnMostrar.Enabled = false;
            }

        }
        private void Habilitar(bool valor)
        {
            txtUsuario.Enabled = valor;
            txtEmpleado.Enabled = valor;
            txtContraseña.Enabled = valor;
            txtRepeticionC.Enabled = valor;
            btnEmpleado.Enabled = valor;
            btnMostrar.Enabled = valor;
            cmbRol.Enabled = valor;
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtEmpleado.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtRepeticionC.Text = string.Empty;
            cmbRol.SelectedItem = null;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            txtBuscar.Focus();
            Botones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = CUsuario.BuscarUsuario(txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dgvUsuarios.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CUsuario.EstadoUsuario(Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            IsContrasena = false;
            this.Botones();
            this.Limpiar();
            this.txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            IsContrasena = false;
            this.Botones();
            this.Limpiar();
            this.dgvUsuarios.CurrentCell = null;
            txtBuscar.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 1)
            {
                this.txtUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[1].Value);
                this.txtEmpleado.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[3].Value);
                cmbRol.SelectedItem = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[4].Value);
               

                idEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[2].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                IsContrasena = false;

                this.Botones();
                txtContraseña.Enabled = false;
                txtRepeticionC.Enabled = false;
                btnMostrar.Enabled = false;
                if (cmbRol.SelectedIndex == 0)
                {
                    cmbRol.Enabled = false;
                }
                this.txtUsuario.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Editar", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rpta ="";
            string usuario = txtUsuario.Text;
            string empleado = txtEmpleado.Text;
            string contraseña1 = txtContraseña.Text;
            string contraseña2 = txtRepeticionC.Text;
            string rol = cmbRol.Text;
            if (IsNuevo)
            {
                if(contraseña1.Equals(string.Empty) || contraseña2.Equals(string.Empty))
                {
                    MessageBox.Show("Ingrese la contraseña del nuevo usuario");
                    txtContraseña.Focus();
                    return;
                }
                
                if(contraseña1 == contraseña2)
                {
                    rpta = CUsuario.InsertarUsuario(usuario, contraseña1, rol, idEmpleado);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }

            }
            else if (IsEditar)
            {

                rpta = CUsuario.ActualizarDatosUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()), usuario, rol, idEmpleado) ;
            }

            else if (IsContrasena)
            {

                if (contraseña1.Length < 8)
                {
                    MessageBox.Show("La contraseña debe ser al menos de 8 dígitos");
                    txtContraseña.Focus();
                    return;
                }


                if (contraseña1.Equals(string.Empty))
                {
                    MessageBox.Show("Rellene el campo de contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña2.Equals(string.Empty))
                {
                    MessageBox.Show("Rellene el campo de repetir");
                    txtRepeticionC.Focus();
                    return;
                }

                if (contraseña1 == contraseña2)
                {
                    rpta = CUsuario.ActualizarContraseñaUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()),
                                                                contraseña1,
                                                                "Administrador");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }

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
            IsContrasena = false;
            this.Botones();
            this.Limpiar();
            mostrarDatos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(btnMostrar.Text == "Mostrar")
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtRepeticionC.UseSystemPasswordChar = false;
                btnMostrar.Text = "Ocultar";
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtRepeticionC.UseSystemPasswordChar = true;
                btnMostrar.Text = "Mostrar";
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            SeleccionEmpleado se = new SeleccionEmpleado();
            se.ShowDialog();
            if (se.Elegido)
            {
                idEmpleado = se.idEmpleado;
                txtEmpleado.Text  = se.nombreEmpleado;
            }
          
            
        }

        private void btnNuevaContrasena_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 1)
            {
                this.txtUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[1].Value);
                this.txtEmpleado.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[3].Value);
                cmbRol.SelectedItem = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[4].Value);
                idEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[2].Value);

                this.IsNuevo = false;
                this.IsEditar = false;
                IsContrasena = true;
                this.Botones();
                txtUsuario.Enabled = false;
                btnEmpleado.Enabled = false;
                cmbRol.Enabled = false;
                this.txtContraseña.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes", "Sistema HILTON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
