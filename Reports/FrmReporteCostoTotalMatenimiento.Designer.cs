
namespace Hilton.Reports
{
    partial class FrmReporteCostoTotalMatenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCostoTotalMatenimiento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReportes = new Hilton.Reports.DataSetReportes();
            this.CostoTotalDeMantenimientoAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostoTotalDeMantenimientoAñoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.CostoTotalDeMantenimientoAñoTableAdapter();
            this.DetalleCostoMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleCostoMantenimientoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.DetalleCostoMantenimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoTotalDeMantenimientoAñoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCostoMantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CostoTotalDeMantenimientoAñoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DetalleCostoMantenimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportCostoMatenimientoAnual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(869, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CostoTotalDeMantenimientoAñoBindingSource
            // 
            this.CostoTotalDeMantenimientoAñoBindingSource.DataMember = "CostoTotalDeMantenimientoAño";
            this.CostoTotalDeMantenimientoAñoBindingSource.DataSource = this.DataSetReportes;
            // 
            // CostoTotalDeMantenimientoAñoTableAdapter
            // 
            this.CostoTotalDeMantenimientoAñoTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleCostoMantenimientoBindingSource
            // 
            this.DetalleCostoMantenimientoBindingSource.DataMember = "DetalleCostoMantenimiento";
            this.DetalleCostoMantenimientoBindingSource.DataSource = this.DataSetReportes;
            // 
            // DetalleCostoMantenimientoTableAdapter
            // 
            this.DetalleCostoMantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCostoTotalMatenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteCostoTotalMatenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReporteCostoTotalMatenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoTotalDeMantenimientoAñoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCostoMantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CostoTotalDeMantenimientoAñoBindingSource;
        private DataSetReportes DataSetReportes;
        private System.Windows.Forms.BindingSource DetalleCostoMantenimientoBindingSource;
        private DataSetReportesTableAdapters.CostoTotalDeMantenimientoAñoTableAdapter CostoTotalDeMantenimientoAñoTableAdapter;
        private DataSetReportesTableAdapters.DetalleCostoMantenimientoTableAdapter DetalleCostoMantenimientoTableAdapter;
    }
}