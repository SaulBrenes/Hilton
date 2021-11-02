using Hilton.View;
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
        //Proximo atributo a utiizar agregar estado y rol  a las base de datos
        public string Rol { get; set; }
        FrmClientes frmCliente;
        FrmEmpleados frmEmpleado;
        FrmEmpresaMantenimiento frmEmpresaMantenimiento;
        FrmSalon frmSalon;
        FrmServicios frmServicios;

        public FrmPrincipal()
        {
            InitializeComponent(); 
        }

        public FrmPrincipal(string rol)
        {
            InitializeComponent();
            this.Rol = rol;
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            f.FormClosed += CerrarForm; 
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            Tag = f;
            f.Show();
        }

       public void CerrarForm(object sender, EventArgs e)
        {
            panel1.Controls.Add(pictureBox1);
        }
    }
}
