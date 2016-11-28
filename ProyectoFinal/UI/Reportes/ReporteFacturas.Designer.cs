namespace ProyectoFinal.UI.Reportes
{
    partial class ReporteFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFacturas));
            this.FacturaReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturaReportViewer
            // 
            this.FacturaReportViewer.Location = new System.Drawing.Point(-1, -1);
            this.FacturaReportViewer.Name = "FacturaReportViewer";
            this.FacturaReportViewer.Size = new System.Drawing.Size(811, 465);
            this.FacturaReportViewer.TabIndex = 0;
            this.FacturaReportViewer.Load += new System.EventHandler(this.FacturaReportViewer_Load);
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 462);
            this.Controls.Add(this.FacturaReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteFacturas";
            this.Text = "Reporte Facturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FacturaReportViewer;
    }
}