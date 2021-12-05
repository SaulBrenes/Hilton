
namespace Hilton.Reports
{
    partial class FrmReportCostoMantenimientoSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportCostoMantenimientoSalon));
            this.CostoMantenimientoSalonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new Hilton.Reports.DataSetReportes();
            this.DetalleCostoMantenimientoSalonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CostoMantenimientoSalonAñoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.CostoMantenimientoSalonAñoTableAdapter();
            this.DetalleCostoMantenimientoSalonTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.DetalleCostoMantenimientoSalonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CostoMantenimientoSalonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCostoMantenimientoSalonBindingSource)).BeginInit();
            this.SuspendLayout();

            // 
            // CostoMantenimientoSalonBindingSource
            // 
            this.CostoMantenimientoSalonBindingSource.DataMember = "CostoMantenimientoSalonAño";
            this.CostoMantenimientoSalonBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleCostoMantenimientoSalonBindingSource
            // 
            this.DetalleCostoMantenimientoSalonBindingSource.DataMember = "DetalleCostoMantenimientoSalon";
            this.DetalleCostoMantenimientoSalonBindingSource.DataSource = this.dataSetReportes;

            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CostoMantenimientoSalonBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DetalleCostoMantenimientoSalonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportCostoMantenimientoSalon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(887, 489);
            this.reportViewer1.TabIndex = 0;

            // VentasMensualesDelAñoTableAdapter
            // 
            this.CostoMantenimientoSalonAñoTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleVentasMensualesTableAdapter
            // 
            this.DetalleCostoMantenimientoSalonTableAdapter.ClearBeforeFill = true;

            // 
            // FrmReportCostoMantenimientoSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 489);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportCostoMantenimientoSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportCostoMantenimientoSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostoMantenimientoSalonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCostoMantenimientoSalonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        // ia 1
        private System.Windows.Forms.BindingSource CostoMantenimientoSalonBindingSource;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource DetalleCostoMantenimientoSalonBindingSource;
        private DataSetReportesTableAdapters.CostoMantenimientoSalonAñoTableAdapter CostoMantenimientoSalonAñoTableAdapter;
        private DataSetReportesTableAdapters.DetalleCostoMantenimientoSalonTableAdapter DetalleCostoMantenimientoSalonTableAdapter;
        //fa 1
    }
}