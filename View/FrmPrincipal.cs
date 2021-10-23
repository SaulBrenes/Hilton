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
    }
}
