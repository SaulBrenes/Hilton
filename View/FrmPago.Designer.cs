
namespace Hilton.View
{
    partial class FrmPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.lblSubtotalServicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalEvento = new System.Windows.Forms.Label();
            this.lblSubtotalSalon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iTalk_GroupBox4 = new ProjectCinematica.iTalk_GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.npdDescuento = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iTalk_GroupBox3 = new ProjectCinematica.iTalk_GroupBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.iTalk_GroupBox2 = new ProjectCinematica.iTalk_GroupBox();
            this.dgvSalones = new System.Windows.Forms.DataGridView();
            this.iTalk_GroupBox1 = new ProjectCinematica.iTalk_GroupBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.iTalk_GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdDescuento)).BeginInit();
            this.iTalk_GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.iTalk_GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).BeginInit();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtotalServicio
            // 
            this.lblSubtotalServicio.AutoSize = true;
            this.lblSubtotalServicio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalServicio.ForeColor = System.Drawing.Color.White;
            this.lblSubtotalServicio.Location = new System.Drawing.Point(466, 503);
            this.lblSubtotalServicio.Name = "lblSubtotalServicio";
            this.lblSubtotalServicio.Size = new System.Drawing.Size(99, 18);
            this.lblSubtotalServicio.TabIndex = 2;
            this.lblSubtotalServicio.Text = "#######";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtotal por servicios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subtotal evento:";
            // 
            // lblTotalEvento
            // 
            this.lblTotalEvento.AutoSize = true;
            this.lblTotalEvento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEvento.ForeColor = System.Drawing.Color.White;
            this.lblTotalEvento.Location = new System.Drawing.Point(472, 541);
            this.lblTotalEvento.Name = "lblTotalEvento";
            this.lblTotalEvento.Size = new System.Drawing.Size(99, 18);
            this.lblTotalEvento.TabIndex = 5;
            this.lblTotalEvento.Text = "#######";
            // 
            // lblSubtotalSalon
            // 
            this.lblSubtotalSalon.AutoSize = true;
            this.lblSubtotalSalon.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalSalon.ForeColor = System.Drawing.Color.White;
            this.lblSubtotalSalon.Location = new System.Drawing.Point(472, 298);
            this.lblSubtotalSalon.Name = "lblSubtotalSalon";
            this.lblSubtotalSalon.Size = new System.Drawing.Size(99, 18);
            this.lblSubtotalSalon.TabIndex = 7;
            this.lblSubtotalSalon.Text = "#######";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(251, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Subtotal por reservación:";
            // 
            // iTalk_GroupBox4
            // 
            this.iTalk_GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox4.Controls.Add(this.btnCancelar);
            this.iTalk_GroupBox4.Controls.Add(this.btnGuardar);
            this.iTalk_GroupBox4.Controls.Add(this.lblTotalFinal);
            this.iTalk_GroupBox4.Controls.Add(this.label12);
            this.iTalk_GroupBox4.Controls.Add(this.npdDescuento);
            this.iTalk_GroupBox4.Controls.Add(this.label10);
            this.iTalk_GroupBox4.Controls.Add(this.txtFecha);
            this.iTalk_GroupBox4.Controls.Add(this.label9);
            this.iTalk_GroupBox4.Controls.Add(this.cmbFormaPago);
            this.iTalk_GroupBox4.Controls.Add(this.txtEmpleado);
            this.iTalk_GroupBox4.Controls.Add(this.label8);
            this.iTalk_GroupBox4.Controls.Add(this.label7);
            this.iTalk_GroupBox4.Location = new System.Drawing.Point(603, 78);
            this.iTalk_GroupBox4.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox4.Name = "iTalk_GroupBox4";
            this.iTalk_GroupBox4.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox4.Size = new System.Drawing.Size(338, 419);
            this.iTalk_GroupBox4.TabIndex = 8;
            this.iTalk_GroupBox4.Text = "Datos adicionales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.Location = new System.Drawing.Point(176, 304);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(99, 18);
            this.lblTotalFinal.TabIndex = 17;
            this.lblTotalFinal.Text = "#######";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "TOTAL:";
            // 
            // npdDescuento
            // 
            this.npdDescuento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdDescuento.Location = new System.Drawing.Point(176, 255);
            this.npdDescuento.Name = "npdDescuento";
            this.npdDescuento.Size = new System.Drawing.Size(99, 26);
            this.npdDescuento.TabIndex = 15;
            this.npdDescuento.ValueChanged += new System.EventHandler(this.npdDescuento_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Descuento % :";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(43, 61);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(258, 26);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Forma de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta",
            "Cheque"});
            this.cmbFormaPago.Location = new System.Drawing.Point(43, 212);
            this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(258, 26);
            this.cmbFormaPago.TabIndex = 11;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(43, 140);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(258, 26);
            this.txtEmpleado.TabIndex = 3;
            this.txtEmpleado.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cajero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha de pago:";
            // 
            // iTalk_GroupBox3
            // 
            this.iTalk_GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox3.Controls.Add(this.dgvServicios);
            this.iTalk_GroupBox3.Location = new System.Drawing.Point(32, 330);
            this.iTalk_GroupBox3.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox3.Name = "iTalk_GroupBox3";
            this.iTalk_GroupBox3.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox3.Size = new System.Drawing.Size(555, 149);
            this.iTalk_GroupBox3.TabIndex = 1;
            this.iTalk_GroupBox3.Text = "Total por servicios contratados";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(5, 28);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(545, 116);
            this.dgvServicios.TabIndex = 1;
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.dgvSalones);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(27, 129);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(555, 154);
            this.iTalk_GroupBox2.TabIndex = 0;
            this.iTalk_GroupBox2.Text = "Total por salones reservados";
            // 
            // dgvSalones
            // 
            this.dgvSalones.AllowUserToAddRows = false;
            this.dgvSalones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            this.dgvSalones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalones.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalones.Location = new System.Drawing.Point(5, 28);
            this.dgvSalones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvSalones.MultiSelect = false;
            this.dgvSalones.Name = "dgvSalones";
            this.dgvSalones.ReadOnly = true;
            this.dgvSalones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalones.RowHeadersVisible = false;
            this.dgvSalones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvSalones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalones.Size = new System.Drawing.Size(545, 121);
            this.dgvSalones.TabIndex = 1;
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.dgvEventos);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(22, 12);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(555, 107);
            this.iTalk_GroupBox1.TabIndex = 0;
            this.iTalk_GroupBox1.Text = "Datos del evento";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(5, 28);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(545, 74);
            this.dgvEventos.TabIndex = 1;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(985, 574);
            this.Controls.Add(this.iTalk_GroupBox4);
            this.Controls.Add(this.lblSubtotalSalon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalEvento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubtotalServicio);
            this.Controls.Add(this.iTalk_GroupBox3);
            this.Controls.Add(this.iTalk_GroupBox2);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturación de evento";
            this.iTalk_GroupBox4.ResumeLayout(false);
            this.iTalk_GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdDescuento)).EndInit();
            this.iTalk_GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.iTalk_GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).EndInit();
            this.iTalk_GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox1;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox2;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox3;
        private System.Windows.Forms.Label lblSubtotalServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalEvento;
        private System.Windows.Forms.Label lblSubtotalSalon;
        private System.Windows.Forms.Label label6;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox4;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown npdDescuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridView dgvSalones;
        private System.Windows.Forms.DataGridView dgvServicios;
    }
}