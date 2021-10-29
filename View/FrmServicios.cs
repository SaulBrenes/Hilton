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
    public partial class FrmServicios : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmServicios()
        {
            InitializeComponent();
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEstado.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = true;
            }

        }
        private void Habilitar(bool valor)
        {
            this.txtNombre.Enabled = valor;
            //this.mtxtCodigo.Enabled = valor;
            //this.nudcapacidadmax.Enabled = valor;
            this.nudPrecioHora.Enabled = valor;
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            //this.mtxtCodigo.Text = string.Empty;
            //nudcapacidadmax.Value = 0;
            nudPrecioHora.Value = 0;
        }
    }
}
