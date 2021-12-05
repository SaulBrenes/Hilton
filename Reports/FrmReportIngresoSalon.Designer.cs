
namespace Hilton.Reports
{
    partial class FrmReportIngresoSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportIngresoSalon));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReportes = new Hilton.Reports.DataSetReportes();
            this.IngresosPorSalonAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IngresosPorSalonAñoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.IngresosPorSalonAñoTableAdapter();
            this.DetalleIngresosPorSalonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleIngresosPorSalonTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.DetalleIngresosPorSalonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosPorSalonAñoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIngresosPorSalonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IngresosPorSalonAñoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DetalleIngresosPorSalonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportIngresoSalon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IngresosPorSalonAñoBindingSource
            // 
            this.IngresosPorSalonAñoBindingSource.DataMember = "IngresosPorSalonAño";
            this.IngresosPorSalonAñoBindingSource.DataSource = this.DataSetReportes;
            // 
            // IngresosPorSalonAñoTableAdapter
            // 
            this.IngresosPorSalonAñoTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleIngresosPorSalonBindingSource
            // 
            this.DetalleIngresosPorSalonBindingSource.DataMember = "DetalleIngresosPorSalon";
            this.DetalleIngresosPorSalonBindingSource.DataSource = this.DataSetReportes;
            // 
            // DetalleIngresosPorSalonTableAdapter
            // 
            this.DetalleIngresosPorSalonTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportIngresoSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 501);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportIngresoSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte ingreso por salón";
            this.Load += new System.EventHandler(this.FrmReportIngresoSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosPorSalonAñoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIngresosPorSalonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IngresosPorSalonAñoBindingSource;
        private DataSetReportes DataSetReportes;
        private System.Windows.Forms.BindingSource DetalleIngresosPorSalonBindingSource;
        private DataSetReportesTableAdapters.IngresosPorSalonAñoTableAdapter IngresosPorSalonAñoTableAdapter;
        private DataSetReportesTableAdapters.DetalleIngresosPorSalonTableAdapter DetalleIngresosPorSalonTableAdapter;
    }
}