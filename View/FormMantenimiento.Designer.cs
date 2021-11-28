
namespace Hilton.View
{
    partial class FormMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.iTalk_GroupBox2 = new ProjectCinematica.iTalk_GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudCosto = new ProjectCinematica.iTalk_NumericUpDown();
            this.iTalk_GroupBox1 = new ProjectCinematica.iTalk_GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalon = new System.Windows.Forms.Button();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iTalk_Panel1 = new ProjectCinematica.iTalk_Panel();
            this.dgvMantenimientos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new ProjectCinematica.iTalk_TextBox_Small();
            this.iTalk_GroupBox2.SuspendLayout();
            this.iTalk_GroupBox1.SuspendLayout();
            this.iTalk_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR:";
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(940, 23);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(92, 33);
            this.btnEstado.TabIndex = 9;
            this.btnEstado.Text = "ESTADO";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(815, 23);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 33);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(691, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 33);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.btnCancelar);
            this.iTalk_GroupBox2.Controls.Add(this.btnGuardar);
            this.iTalk_GroupBox2.Controls.Add(this.nudCosto);
            this.iTalk_GroupBox2.Controls.Add(this.iTalk_GroupBox1);
            this.iTalk_GroupBox2.Controls.Add(this.btnEmpresa);
            this.iTalk_GroupBox2.Controls.Add(this.txtEmpresa);
            this.iTalk_GroupBox2.Controls.Add(this.label6);
            this.iTalk_GroupBox2.Controls.Add(this.btnEmpleado);
            this.iTalk_GroupBox2.Controls.Add(this.txtEmpleado);
            this.iTalk_GroupBox2.Controls.Add(this.label7);
            this.iTalk_GroupBox2.Controls.Add(this.dtpFecha);
            this.iTalk_GroupBox2.Controls.Add(this.label5);
            this.iTalk_GroupBox2.Controls.Add(this.label3);
            this.iTalk_GroupBox2.Controls.Add(this.btnSalon);
            this.iTalk_GroupBox2.Controls.Add(this.txtSalon);
            this.iTalk_GroupBox2.Controls.Add(this.label2);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(691, 80);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(487, 522);
            this.iTalk_GroupBox2.TabIndex = 19;
            this.iTalk_GroupBox2.Text = "DATOS DEL MANTENIMIENTO:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(277, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 33);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 33);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // nudCosto
            // 
            this.nudCosto.BackColor = System.Drawing.Color.Transparent;
            this.nudCosto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.nudCosto.ForeColor = System.Drawing.Color.DimGray;
            this.nudCosto.Location = new System.Drawing.Point(124, 103);
            this.nudCosto.Maximum = ((long)(100));
            this.nudCosto.Minimum = ((long)(0));
            this.nudCosto.MinimumSize = new System.Drawing.Size(62, 28);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(272, 28);
            this.nudCosto.TabIndex = 29;
            this.nudCosto.Text = "iTalk_NumericUpDown1";
            this.nudCosto.TextAlignment = ProjectCinematica.iTalk_NumericUpDown._TextAlignment.Near;
            this.nudCosto.Value = ((long)(0));
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.txtDescripcion);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(34, 337);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(425, 108);
            this.iTalk_GroupBox1.TabIndex = 18;
            this.iTalk_GroupBox1.Text = "DESCRIPCIÓN DEL MANTENIMIENTO:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(5, 28);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(415, 75);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(408, 280);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(51, 27);
            this.btnEmpresa.TabIndex = 28;
            this.btnEmpresa.Text = "...";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(124, 281);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(274, 27);
            this.txtEmpresa.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "EMPRESA:";
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(408, 225);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(51, 27);
            this.btnEmpleado.TabIndex = 25;
            this.btnEmpleado.Text = "...";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(122, 225);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(274, 27);
            this.txtEmpleado.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "EMPLEADO:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(120, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(331, 27);
            this.dtpFecha.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "COSTO:";
            // 
            // btnSalon
            // 
            this.btnSalon.Location = new System.Drawing.Point(408, 166);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(51, 27);
            this.btnSalon.TabIndex = 19;
            this.btnSalon.Text = "...";
            this.btnSalon.UseVisualStyleBackColor = true;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(121, 166);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(274, 27);
            this.txtSalon.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "SALÓN:";
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.dgvMantenimientos);
            this.iTalk_Panel1.Location = new System.Drawing.Point(41, 80);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(614, 522);
            this.iTalk_Panel1.TabIndex = 5;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // dgvMantenimientos
            // 
            this.dgvMantenimientos.AllowUserToAddRows = false;
            this.dgvMantenimientos.AllowUserToDeleteRows = false;
            this.dgvMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMantenimientos.Location = new System.Drawing.Point(5, 5);
            this.dgvMantenimientos.Name = "dgvMantenimientos";
            this.dgvMantenimientos.ReadOnly = true;
            this.dgvMantenimientos.Size = new System.Drawing.Size(604, 512);
            this.dgvMantenimientos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(120, 25);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.Size = new System.Drawing.Size(530, 28);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 624);
            this.Controls.Add(this.iTalk_GroupBox2);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.iTalk_Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMantenimiento";
            this.Text = "MANTENIMIENTOS";
            this.iTalk_GroupBox2.ResumeLayout(false);
            this.iTalk_GroupBox2.PerformLayout();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            this.iTalk_Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectCinematica.iTalk_TextBox_Small txtBuscar;
        private System.Windows.Forms.Label label1;
        private ProjectCinematica.iTalk_Panel iTalk_Panel1;
        private System.Windows.Forms.DataGridView dgvMantenimientos;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox2;
        private ProjectCinematica.iTalk_NumericUpDown nudCosto;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}