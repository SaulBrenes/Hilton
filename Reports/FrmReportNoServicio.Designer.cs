
namespace Hilton.Reports
{
    partial class FrmReportNoServicio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportNoServicio));
            this.NoServicioRealizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new Hilton.Reports.DataSetReportes();
            this.DetalleNoServicioRealizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NoServiciosRealizadosAñoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.NoServiciosRealizadosAñoTableAdapter();
            this.DetalleNoServiciosRealizadosTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.DetalleNoServiciosRealizadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NoServicioRealizadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleNoServicioRealizadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // NoEventosRealizadosSalonesBindingSource
            // 
            this.NoServicioRealizadosBindingSource.DataMember = "NoServiciosRealizadosAño";
            this.NoServicioRealizadosBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleNoEventosRealizadosSalonesBindingSource
            // 
            this.DetalleNoServicioRealizadosBindingSource.DataMember = "DetalleNoServiciosRealizados";
            this.DetalleNoServicioRealizadosBindingSource.DataSource = this.DataSetReportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NoServicioRealizadosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DetalleNoServicioRealizadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportNoServicio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // NoEventosRealizadosSalonesTableAdapter
            // 
            this.NoServiciosRealizadosAñoTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleNoEventosRealizadosSalonesTableAdapter
            // 
            this.DetalleNoServiciosRealizadosTableAdapter.ClearBeforeFill = true;
            // FrmReportNoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 474);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportNoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportNoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoServicioRealizadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleNoServicioRealizadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NoServicioRealizadosBindingSource;
        private DataSetReportes DataSetReportes;
        private System.Windows.Forms.BindingSource DetalleNoServicioRealizadosBindingSource;
        private DataSetReportesTableAdapters.NoServiciosRealizadosAñoTableAdapter NoServiciosRealizadosAñoTableAdapter;
        private DataSetReportesTableAdapters.DetalleNoServiciosRealizadosTableAdapter DetalleNoServiciosRealizadosTableAdapter;
    }
}