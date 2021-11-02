
namespace Hilton
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manetenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(146, 450);
            this.menuStrip1.TabIndex = 0;
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.AutoSize = false;
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.toolStripSeparator2,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.empresasDeMantenimientoToolStripMenuItem,
            this.toolStripSeparator3});
            this.catálogosToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catálogosToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_hotel_64;
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(142, 60);
            this.catálogosToolStripMenuItem.Text = "Catálogos ";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonesToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_edificio_del_hotel_64;
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviciosToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_camarero_30;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_customers_64__2_;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_customers_64__1_;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // empresasDeMantenimientoToolStripMenuItem
            // 
            this.empresasDeMantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresasDeMantenimientoToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_proveedor_30;
            this.empresasDeMantenimientoToolStripMenuItem.Name = "empresasDeMantenimientoToolStripMenuItem";
            this.empresasDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.empresasDeMantenimientoToolStripMenuItem.Text = "Empresas de mantenimiento";
            this.empresasDeMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.empresasDeMantenimientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(325, 6);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.AutoSize = false;
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.toolStripSeparator1,
            this.PagosToolStripMenuItem,
            this.cancelacionesToolStripMenuItem,
            this.manetenimientoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_gestión_de_eventos_48;
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(142, 60);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_calendario_de_rasgar_las_hojas_96;
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.eventosToolStripMenuItem.Text = "Gestión de Eventos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // PagosToolStripMenuItem
            // 
            this.PagosToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_compartir_acciones_96;
            this.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem";
            this.PagosToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.PagosToolStripMenuItem.Text = "Pagos";
            // 
            // cancelacionesToolStripMenuItem
            // 
            this.cancelacionesToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_important_event_50;
            this.cancelacionesToolStripMenuItem.Name = "cancelacionesToolStripMenuItem";
            this.cancelacionesToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.cancelacionesToolStripMenuItem.Text = "Cancelaciones";
            // 
            // manetenimientoToolStripMenuItem
            // 
            this.manetenimientoToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_edificio_del_hotel_64__1_;
            this.manetenimientoToolStripMenuItem.Name = "manetenimientoToolStripMenuItem";
            this.manetenimientoToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.manetenimientoToolStripMenuItem.Text = "Manetenimiento";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.AutoSize = false;
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_analytics_64;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(137, 60);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.AutoSize = false;
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguridadToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_credenciales_de_usuario_30;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(137, 60);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = global::Hilton.Properties.Resources.icons8_grupo_de_usuario_48;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 450);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Hilton.Properties.Resources.LogoInicialHilton;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de convenciones HILTON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasDeMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manetenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

