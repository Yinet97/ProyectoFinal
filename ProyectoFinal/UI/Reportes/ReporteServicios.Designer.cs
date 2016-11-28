namespace ProyectoFinal.Reportes
{
    partial class ReporteServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteServicios));
            this.ServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyBaseDbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServiciosReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiciosBindingSource
            // 
            this.ServiciosBindingSource.DataMember = "Servicios";
            // 
            // ServiciosReportViewer
            // 
            reportDataSource1.Name = "Servicios";
            reportDataSource1.Value = this.ServiciosBindingSource;
            this.ServiciosReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ServiciosReportViewer.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Servicios.rdlc";
            this.ServiciosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ServiciosReportViewer.Name = "ServiciosReportViewer";
            this.ServiciosReportViewer.Size = new System.Drawing.Size(757, 423);
            this.ServiciosReportViewer.TabIndex = 0;
            this.ServiciosReportViewer.Load += new System.EventHandler(this.ServiciosReportViewer_Load);
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.ServiciosReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteServicios";
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource beautyBaseDbDataSet2BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer ServiciosReportViewer;
        private System.Windows.Forms.BindingSource ServiciosBindingSource;
    }
}