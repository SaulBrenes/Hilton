
namespace Hilton.Reports
{
    partial class FrmReporteSalon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetSalones = new Hilton.Reports.DataSetSalones();
            this.SalonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalonesTableAdapter = new Hilton.Reports.DataSetSalonesTableAdapters.SalonesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSalones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalonesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hilton.Reports.ReportSalon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSalones
            // 
            this.DataSetSalones.DataSetName = "DataSetSalones";
            this.DataSetSalones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalonesBindingSource
            // 
            this.SalonesBindingSource.DataMember = "Salones";
            this.SalonesBindingSource.DataSource = this.DataSetSalones;
            // 
            // SalonesTableAdapter
            // 
            this.SalonesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteSalon";
            this.Text = "FrmReporteSalon";
            this.Load += new System.EventHandler(this.FrmReporteSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSalones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalonesBindingSource;
        private DataSetSalones DataSetSalones;
        private DataSetSalonesTableAdapters.SalonesTableAdapter SalonesTableAdapter;
    }
}