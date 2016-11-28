namespace ProyectoFinal.Reportes
{
    partial class ReporteEmpleadas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleadas));
            this.EmpleadasReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EmpleadasReportViewer
            // 
            reportDataSource1.Name = "DataSetEmpleadas";
            reportDataSource1.Value = null;
            this.EmpleadasReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.EmpleadasReportViewer.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Empleadas.rdlc";
            this.EmpleadasReportViewer.Location = new System.Drawing.Point(1, 0);
            this.EmpleadasReportViewer.Name = "EmpleadasReportViewer";
            this.EmpleadasReportViewer.Size = new System.Drawing.Size(832, 436);
            this.EmpleadasReportViewer.TabIndex = 0;
            this.EmpleadasReportViewer.Load += new System.EventHandler(this.EmpleadasReportViewer_Load);
            // 
            // ReporteEmpleadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 434);
            this.Controls.Add(this.EmpleadasReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteEmpleadas";
            this.Text = "Reporte Empleadas";
            this.Load += new System.EventHandler(this.ReporteEmpleadas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmpleadasReportViewer;
    }
}