﻿using System;
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
        //Atributos proximos a usar para validar el tipo de usuario que entro

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
                    if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                    {

                        MessageBox.Show("Bienvenido al Sistema", "Sistema Centro de convenciones HILTON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string Nombre = dato.Rows[0][1].ToString();
                        string rol = dato.Rows[0][2].ToString();
                                                                         //Estado del usuario   
                        FrmPrincipal fp = new FrmPrincipal(Nombre, rol, dato.Rows[0][4].ToString());
                        fp.usuario = txtUsuario.Text;
                        fp.Idusuario = Convert.ToInt32(dato.Rows[0][3].ToString());
                        fp.IdEmpleado = Convert.ToInt32(dato.Rows[0][5].ToString());

                        fp.FormClosed += FrmPrincipal_FormClosed;
                        fp.Show();
                        this.Hide();
                        txtUsuario.Text = String.Empty;
                        txtContraseña.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Centro de convenciones HILTON", "Sistema Hilton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = string.Empty;
                        txtContraseña.Text = string.Empty;
                        txtUsuario.Focus();
                    }
                }
            }
            else
                MessageBox.Show("No hay conexión al servidor", "Sistema de Centro de convenciones HILTON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
            txtUsuario.Focus();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar_Click(sender, e);
            }
        }

        private void btnMirar_Click(object sender, EventArgs e)
        {
            if(btnMirar.Text.Equals("O"))
            {
                btnMirar.Text = "*";
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                btnMirar.Text = "O";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
