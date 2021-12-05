
namespace Hilton.Reports
{
    partial class FrmReporteIngresoMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteIngresoMensual));
            this.VentasMensualesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new Hilton.Reports.DataSetReportes();
            this.DetalleVentasMensualesEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasMensualesDelAñoTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.VentasMensualesDelAñoTableAdapter();
            this.DetalleVentasMensualesTableAdapter = new Hilton.Reports.DataSetReportesTableAdapters.DetalleVentasMensualesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VentasMensualesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentasMensualesEventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasMensualesBindingSource
            // 
            this.VentasMensualesBindingSource.DataMember = "VentasMensualesDelAño";
            this.VentasMensualesBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleVentasMensualesEventoBindingSource
            // 
            this.DetalleVentasMensualesEventoBindingSource.DataMember = "DetalleVentasMensuales";
            this.DetalleVentasMensualesEventoBindingSource.DataSource = this.dataSetReportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VentasMensualesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DetalleVentasMensualesEventoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportIngresoMensual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(990, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // VentasMensualesDelAñoTableAdapter
            // 
            this.VentasMensualesDelAñoTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleVentasMensualesTableAdapter
            // 
            this.DetalleVentasMensualesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteIngresoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 483);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteIngresoMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ingreso mensual";
            this.Load += new System.EventHandler(this.FrmReporteIngresoMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasMensualesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentasMensualesEventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        // ia 1
        private System.Windows.Forms.BindingSource VentasMensualesBindingSource;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource DetalleVentasMensualesEventoBindingSource;
        private DataSetReportesTableAdapters.VentasMensualesDelAñoTableAdapter VentasMensualesDelAñoTableAdapter;
        private DataSetReportesTableAdapters.DetalleVentasMensualesTableAdapter DetalleVentasMensualesTableAdapter;
        //fa 1

    }
}