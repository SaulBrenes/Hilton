using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hilton.Model;

namespace Hilton.View
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            //Inilizando combobox
            cmbRol.Items.AddRange(Roles.rolesDisponibles);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
