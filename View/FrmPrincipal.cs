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

        public FrmPrincipal()
        {
            InitializeComponent(); 
        }

        public FrmPrincipal(string rol)
        {
            InitializeComponent();
            this.Rol = rol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalon frmSalon = new FrmSalon();
            frmSalon.MdiParent = this;
            frmSalon.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicios frmServicios = new FrmServicios();
            MostrarFrame(frmServicios);
        }

        private void MostrarFrame(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            MostrarFrame(frmClientes);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            MostrarFrame(frmEmpleados);
        }

        private void empresasDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresaMantenimiento frmEmpresa = new FrmEmpresaMantenimiento();
            MostrarFrame(frmEmpresa);
        }
    }
}
