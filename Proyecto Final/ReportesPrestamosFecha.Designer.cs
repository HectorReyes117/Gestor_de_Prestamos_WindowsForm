namespace Proyecto_Final
{
    partial class ReportesPrestamosFecha
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
            this.PrestamosFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamosFechaTableAdapter = new Proyecto_Final.DatasetPrincipalTableAdapters.PrestamosFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrestamosFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.InformesPrestamosFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(846, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetPrincipal
            // 
            this.DatasetPrincipal.DataSetName = "DatasetPrincipal";
            this.DatasetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrestamosFechaBindingSource
            // 
            this.PrestamosFechaBindingSource.DataMember = "PrestamosFecha";
            this.PrestamosFechaBindingSource.DataSource = this.DatasetPrincipal;
            // 
            // PrestamosFechaTableAdapter
            // 
            this.PrestamosFechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesPrestamosFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesPrestamosFecha";
            this.Text = "ReportesPrestamosFecha";
            this.Load += new System.EventHandler(this.ReportesPrestamosFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosFechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrestamosFechaBindingSource;
        private DatasetPrincipal DatasetPrincipal;
        private DatasetPrincipalTableAdapters.PrestamosFechaTableAdapter PrestamosFechaTableAdapter;
    }
}