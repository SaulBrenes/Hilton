
namespace Hilton.View
{
    partial class FrmSalon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCampos = new System.Windows.Forms.GroupBox();
            this.nudcapacidadmax = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioHora = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSalones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcapacidadmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCampos
            // 
            this.gbCampos.Controls.Add(this.btnGuardar);
            this.gbCampos.Controls.Add(this.btnCancelar);
            this.gbCampos.Controls.Add(this.nudcapacidadmax);
            this.gbCampos.Controls.Add(this.nudPrecioHora);
            this.gbCampos.Controls.Add(this.txtNombre);
            this.gbCampos.Controls.Add(this.mtxtCodigo);
            this.gbCampos.Controls.Add(this.label4);
            this.gbCampos.Controls.Add(this.label3);
            this.gbCampos.Controls.Add(this.label2);
            this.gbCampos.Controls.Add(this.label1);
            this.gbCampos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCampos.Location = new System.Drawing.Point(73, 327);
            this.gbCampos.Name = "gbCampos";
            this.gbCampos.Size = new System.Drawing.Size(1040, 206);
            this.gbCampos.TabIndex = 2;
            this.gbCampos.TabStop = false;
            this.gbCampos.Text = "Campos";
            this.gbCampos.Enter += new System.EventHandler(this.gbCampos_Enter);
            // 
            // nudcapacidadmax
            // 
            this.nudcapacidadmax.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcapacidadmax.Location = new System.Drawing.Point(483, 109);
            this.nudcapacidadmax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudcapacidadmax.Name = "nudcapacidadmax";
            this.nudcapacidadmax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudcapacidadmax.Size = new System.Drawing.Size(270, 27);
            this.nudcapacidadmax.TabIndex = 7;
            this.nudcapacidadmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudcapacidadmax.ThousandsSeparator = true;
            this.nudcapacidadmax.Enter += new System.EventHandler(this.nudcapacidadmax_Enter);
            // 
            // nudPrecioHora
            // 
            this.nudPrecioHora.DecimalPlaces = 2;
            this.nudPrecioHora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecioHora.Location = new System.Drawing.Point(149, 115);
            this.nudPrecioHora.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrecioHora.Name = "nudPrecioHora";
            this.nudPrecioHora.Size = new System.Drawing.Size(127, 27);
            this.nudPrecioHora.TabIndex = 6;
            this.nudPrecioHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrecioHora.ThousandsSeparator = true;
            this.nudPrecioHora.Enter += new System.EventHandler(this.nudPrecioHora_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(483, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCodigo.Location = new System.Drawing.Point(149, 48);
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(127, 27);
            this.mtxtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad máxima:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio/hora:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(113, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(560, 27);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar:";
            // 
            // dgvSalones
            // 
            this.dgvSalones.AllowUserToAddRows = false;
            this.dgvSalones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            this.dgvSalones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSalones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSalones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSalones.ColumnHeadersHeight = 25;
            this.dgvSalones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalones.Location = new System.Drawing.Point(3, 23);
            this.dgvSalones.MultiSelect = false;
            this.dgvSalones.Name = "dgvSalones";
            this.dgvSalones.ReadOnly = true;
            this.dgvSalones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalones.RowHeadersVisible = false;
            this.dgvSalones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSalones.RowTemplate.Height = 30;
            this.dgvSalones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalones.Size = new System.Drawing.Size(1037, 189);
            this.dgvSalones.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(336, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(505, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Location = new System.Drawing.Point(972, 23);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(115, 33);
            this.btnEstado.TabIndex = 13;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(834, 23);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 33);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(696, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 33);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSalones);
            this.groupBox3.Location = new System.Drawing.Point(70, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1043, 215);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // FrmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbCampos);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSalon";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALONES REGISTRADOS";
            this.Load += new System.EventHandler(this.FrmSalon_Load);
            this.gbCampos.ResumeLayout(false);
            this.gbCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcapacidadmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCampos;
        private System.Windows.Forms.NumericUpDown nudcapacidadmax;
        private System.Windows.Forms.NumericUpDown nudPrecioHora;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSalones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}