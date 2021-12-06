
namespace Hilton.Reports
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.ObtenerPagoDeEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFactura = new Hilton.Reports.DataSetFactura();
            this.SalonesEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServiciosEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ObtenerPagoDeEventoTableAdapter = new Hilton.Reports.DataSetFacturaTableAdapters.ObtenerPagoDeEventoTableAdapter();
            this.SalonesEventoTableAdapter = new Hilton.Reports.DataSetFacturaTableAdapters.SalonesEventoTableAdapter();
            this.ServiciosEventoTableAdapter = new Hilton.Reports.DataSetFacturaTableAdapters.ServiciosEventoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerPagoDeEventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonesEventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosEventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ObtenerPagoDeEventoBindingSource
            // 
            this.ObtenerPagoDeEventoBindingSource.DataMember = "ObtenerPagoDeEvento";
            this.ObtenerPagoDeEventoBindingSource.DataSource = this.DataSetFactura;
            // 
            // DataSetFactura
            // 
            this.DataSetFactura.DataSetName = "DataSetFactura";
            this.DataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalonesEventoBindingSource
            // 
            this.SalonesEventoBindingSource.DataMember = "SalonesEvento";
            this.SalonesEventoBindingSource.DataSource = this.DataSetFactura;
            // 
            // ServiciosEventoBindingSource
            // 
            this.ServiciosEventoBindingSource.DataMember = "ServiciosEvento";
            this.ServiciosEventoBindingSource.DataSource = this.DataSetFactura;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DatoGenrales";
            reportDataSource4.Value = this.ObtenerPagoDeEventoBindingSource;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.SalonesEventoBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.ServiciosEventoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(539, 529);
            this.reportViewer1.TabIndex = 0;
            // 
            // ObtenerPagoDeEventoTableAdapter
            // 
            this.ObtenerPagoDeEventoTableAdapter.ClearBeforeFill = true;
            // 
            // SalonesEventoTableAdapter
            // 
            this.SalonesEventoTableAdapter.ClearBeforeFill = true;
            // 
            // ServiciosEventoTableAdapter
            // 
            this.ServiciosEventoTableAdapter.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 529);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerPagoDeEventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonesEventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosEventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ObtenerPagoDeEventoBindingSource;
        private DataSetFactura DataSetFactura;
        private System.Windows.Forms.BindingSource SalonesEventoBindingSource;
        private System.Windows.Forms.BindingSource ServiciosEventoBindingSource;
        private DataSetFacturaTableAdapters.ObtenerPagoDeEventoTableAdapter ObtenerPagoDeEventoTableAdapter;
        private DataSetFacturaTableAdapters.SalonesEventoTableAdapter SalonesEventoTableAdapter;
        private DataSetFacturaTableAdapters.ServiciosEventoTableAdapter ServiciosEventoTableAdapter;
    }
}