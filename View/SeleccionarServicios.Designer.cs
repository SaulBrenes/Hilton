
namespace Hilton.View
{
    partial class SeleccionarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarServicios));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.iTalk_GroupBox1 = new ProjectCinematica.iTalk_GroupBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(109, 342);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(122, 32);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.dgvServicios);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(22, 23);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(531, 302);
            this.iTalk_GroupBox1.TabIndex = 0;
            this.iTalk_GroupBox1.Text = "SERVICIOS DISPONIBLES";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(5, 28);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(521, 269);
            this.dgvServicios.TabIndex = 0;
            // 
            // SeleccionarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 386);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SeleccionarServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar servicios";
            this.Load += new System.EventHandler(this.SeleccionarServicios_Load);
            this.iTalk_GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectCinematica.iTalk_GroupBox iTalk_GroupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView dgvServicios;
    }
}