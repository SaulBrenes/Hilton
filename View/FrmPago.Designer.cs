
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.iTalk_GroupBox1 = new ProjectCinematica.iTalk_GroupBox();
            this.iTalk_GroupBox2 = new ProjectCinematica.iTalk_GroupBox();
            this.iTalk_GroupBox3 = new ProjectCinematica.iTalk_GroupBox();
            this.lblSubtotalServicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubtotalSalon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iTalk_GroupBox4 = new ProjectCinematica.iTalk_GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.dgvSalones = new System.Windows.Forms.DataGridView();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.iTalk_GroupBox1.SuspendLayout();
            this.iTalk_GroupBox2.SuspendLayout();
            this.iTalk_GroupBox3.SuspendLayout();
            this.iTalk_GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.dgvEventos);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(22, 12);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(592, 79);
            this.iTalk_GroupBox1.TabIndex = 0;
            this.iTalk_GroupBox1.Text = "Datos del evento";
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.dgvSalones);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(22, 97);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(592, 110);
            this.iTalk_GroupBox2.TabIndex = 0;
            this.iTalk_GroupBox2.Text = "Total por salones reservados";
            // 
            // iTalk_GroupBox3
            // 
            this.iTalk_GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox3.Controls.Add(this.dgvServicios);
            this.iTalk_GroupBox3.Location = new System.Drawing.Point(22, 257);
            this.iTalk_GroupBox3.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox3.Name = "iTalk_GroupBox3";
            this.iTalk_GroupBox3.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox3.Size = new System.Drawing.Size(592, 104);
            this.iTalk_GroupBox3.TabIndex = 1;
            this.iTalk_GroupBox3.Text = "Total por servicios contratados";
            // 
            // lblSubtotalServicio
            // 
            this.lblSubtotalServicio.AutoSize = true;
            this.lblSubtotalServicio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalServicio.Location = new System.Drawing.Point(502, 375);
            this.lblSubtotalServicio.Name = "lblSubtotalServicio";
            this.lblSubtotalServicio.Size = new System.Drawing.Size(99, 18);
            this.lblSubtotalServicio.TabIndex = 2;
            this.lblSubtotalServicio.Text = "#######";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtotal por servicios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subtotal evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "#######";
            // 
            // lblSubtotalSalon
            // 
            this.lblSubtotalSalon.AutoSize = true;
            this.lblSubtotalSalon.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalSalon.Location = new System.Drawing.Point(495, 219);
            this.lblSubtotalSalon.Name = "lblSubtotalSalon";
            this.lblSubtotalSalon.Size = new System.Drawing.Size(99, 18);
            this.lblSubtotalSalon.TabIndex = 7;
            this.lblSubtotalSalon.Text = "#######";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 219);
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
            this.iTalk_GroupBox4.Controls.Add(this.numericUpDown1);
            this.iTalk_GroupBox4.Controls.Add(this.label10);
            this.iTalk_GroupBox4.Controls.Add(this.textBox2);
            this.iTalk_GroupBox4.Controls.Add(this.label9);
            this.iTalk_GroupBox4.Controls.Add(this.cmbFormaPago);
            this.iTalk_GroupBox4.Controls.Add(this.textBox1);
            this.iTalk_GroupBox4.Controls.Add(this.label8);
            this.iTalk_GroupBox4.Controls.Add(this.label7);
            this.iTalk_GroupBox4.Location = new System.Drawing.Point(635, 21);
            this.iTalk_GroupBox4.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox4.Name = "iTalk_GroupBox4";
            this.iTalk_GroupBox4.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox4.Size = new System.Drawing.Size(338, 419);
            this.iTalk_GroupBox4.TabIndex = 8;
            this.iTalk_GroupBox4.Text = "Datos adicionales";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cajero:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Forma de pago:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(43, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(258, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(176, 255);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 26);
            this.numericUpDown1.TabIndex = 15;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(5, 28);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(582, 46);
            this.dgvEventos.TabIndex = 1;
            // 
            // dgvSalones
            // 
            this.dgvSalones.AllowUserToAddRows = false;
            this.dgvSalones.AllowUserToDeleteRows = false;
            this.dgvSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalones.Location = new System.Drawing.Point(5, 28);
            this.dgvSalones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvSalones.MultiSelect = false;
            this.dgvSalones.Name = "dgvSalones";
            this.dgvSalones.ReadOnly = true;
            this.dgvSalones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvSalones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalones.Size = new System.Drawing.Size(582, 77);
            this.dgvSalones.TabIndex = 1;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(5, 28);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(582, 71);
            this.dgvServicios.TabIndex = 1;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 452);
            this.Controls.Add(this.iTalk_GroupBox4);
            this.Controls.Add(this.lblSubtotalSalon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubtotalServicio);
            this.Controls.Add(this.iTalk_GroupBox3);
            this.Controls.Add(this.iTalk_GroupBox2);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPago";
            this.Text = "Facturación de evento";
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox2.ResumeLayout(false);
            this.iTalk_GroupBox3.ResumeLayout(false);
            this.iTalk_GroupBox4.ResumeLayout(false);
            this.iTalk_GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubtotalSalon;
        private System.Windows.Forms.Label label6;
        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridView dgvSalones;
        private System.Windows.Forms.DataGridView dgvServicios;
    }
}