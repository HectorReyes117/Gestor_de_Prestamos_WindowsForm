namespace Proyecto_Final
{
    partial class ReportesMovimientosId
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
            this.MovimientosIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientosIdTableAdapter = new Proyecto_Final.DatasetPrincipalTableAdapters.MovimientosIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MovimientosIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.InformesMovimientoId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetPrincipal
            // 
            this.DatasetPrincipal.DataSetName = "DatasetPrincipal";
            this.DatasetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MovimientosIdBindingSource
            // 
            this.MovimientosIdBindingSource.DataMember = "MovimientosId";
            this.MovimientosIdBindingSource.DataSource = this.DatasetPrincipal;
            // 
            // MovimientosIdTableAdapter
            // 
            this.MovimientosIdTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesMovimientosId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesMovimientosId";
            this.Text = "ReportesMovimientosId";
            this.Load += new System.EventHandler(this.ReportesMovimientosId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimientosIdBindingSource;
        private DatasetPrincipal DatasetPrincipal;
        private DatasetPrincipalTableAdapters.MovimientosIdTableAdapter MovimientosIdTableAdapter;
    }
}