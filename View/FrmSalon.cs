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
    public partial class FrmSalon : Form
    {
        public FrmSalon()
        {
            InitializeComponent();
        }

        private void FrmSalon_Load(object sender, EventArgs e)
        {
            dgvSalones.DataSource = CSalon.MostrarSalones();
        }
    }
}
