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
        public static string Nombre { get ; set; }

        public static string Rol;

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
                        FrmPrincipal fp = new FrmPrincipal();
                        fp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Centro de convenciones HILTON", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = string.Empty;
                        txtContraseña.Text = string.Empty;
                        txtUsuario.Focus();
                    }
                }
            }
            else
                MessageBox.Show("No hay conexión al servidor", "Sistema de Centro de convenciones HILTON", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}