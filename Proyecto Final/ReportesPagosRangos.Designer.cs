namespace Proyecto_Final
{
    partial class ReportesPagosRangos
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
            this.DatasetPrincipal = new Proyecto_Final.DatasetPrincipal();
            this.PagosRangosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagosRangosTableAdapter = new Proyecto_Final.DatasetPrincipalTableAdapters.PagosRangosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosRangosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PagosRangosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.InformesPagosRangos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetPrincipal
            // 
            this.DatasetPrincipal.DataSetName = "DatasetPrincipal";
            this.DatasetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagosRangosBindingSource
            // 
            this.PagosRangosBindingSource.DataMember = "PagosRangos";
            this.PagosRangosBindingSource.DataSource = this.DatasetPrincipal;
            // 
            // PagosRangosTableAdapter
            // 
            this.PagosRangosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesPagosRangos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesPagosRangos";
            this.Text = "ReportesPagosRangos";
            this.Load += new System.EventHandler(this.ReportesPagosRangos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosRangosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagosRangosBindingSource;
        private DatasetPrincipal DatasetPrincipal;
        private DatasetPrincipalTableAdapters.PagosRangosTableAdapter PagosRangosTableAdapter;
    }
}