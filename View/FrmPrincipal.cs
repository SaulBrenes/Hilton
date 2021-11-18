﻿using Hilton.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton
{
   
    public partial class FrmPrincipal : Form
    {
        FrmClientes frmCliente;
        FrmEmpleados frmEmpleado;
        FrmEmpresaMantenimiento frmEmpresaMantenimiento;
        FrmSalon frmSalon;
        FrmServicios frmServicios;
        FrmUsuarios frmUsuarios;

        public FrmPrincipal(string nombre, string rol)
        {
            InitializeComponent();
            MinimumSize = Size;
            uSUARIOToolStripMenuItem1.Text = nombre;
            txtRol.Text = rol;
            validarRol(rol);

        }

        private void validarRol(string rol)
        {
            if(rol.CompareTo("Administrador") == 0)
            {
                catálogosToolStripMenuItem.Visible= false;
                operacionesToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                return;
            }

            if(rol.CompareTo("Gerente") == 0)
            {
                operacionesToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;
                return;
            }

            if (rol.CompareTo("Cajero") == 0)
            {
                catálogosToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                return;
            }


        }


        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmSalon))
            {
                return;
            }
            frmSalon = new FrmSalon();
            //frmSalon.FormClosed += CerrarForm;
            agregarForm(frmSalon);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmServicios))
            {
                return;
            }
            frmServicios = new FrmServicios();
            //frmServicios.FormClosed += CerrarForm;
            agregarForm(frmServicios);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmCliente))
            {
                return;
            }
            frmCliente = new FrmClientes();
            //frmCliente.FormClosed += CerrarForm;
            agregarForm(frmCliente);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmEmpleado))
            {
                return;
            }
            frmEmpleado = new FrmEmpleados();
            //frmEmpleado.FormClosed += CerrarForm;
            agregarForm(frmEmpleado);
        }

        private void empresasDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmEmpresaMantenimiento))
            {
                return;
            }
            frmEmpresaMantenimiento = new FrmEmpresaMantenimiento();
            //frmEmpresaMantenimiento.FormClosed += CerrarForm;
            agregarForm(frmEmpresaMantenimiento);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbierto(frmUsuarios))
            {
                return;
            }
            frmUsuarios = new FrmUsuarios();
            agregarForm(frmUsuarios);
        }

        private bool formAbierto(Form f)
        {
            if(f == null)
            {
                return false;
            }

            if (panel1.Controls[0].ToString() == f.ToString())
            {
                return true;
            }

            return false;
        }


        private void agregarForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.FormClosed += CerrarForm;
            pnlVentanas.Controls.Clear();
            pnlVentanas.Controls.Add(f);
            Tag = f;
            lblForm.Text = f.Text;
            f.Show();
        }

       public void CerrarForm(object sender, EventArgs e)
        {
            pnlVentanas.Controls.Add(pictureBox1);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlVentanas.Controls.Clear();
            pnlVentanas.Controls.Add(pictureBox1);
            lblForm.Text = "INICIO";
        }
    }
}
