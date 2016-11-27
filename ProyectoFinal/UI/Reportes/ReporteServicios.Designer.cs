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
            this.beautyBaseDbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beautyBaseDbDataSet2
            // 
            // 
            // beautyBaseDbDataSet2BindingSource
            // 
            this.beautyBaseDbDataSet2BindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Servicios";
            reportDataSource1.Value = this.ServiciosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Servicios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // ServiciosBindingSource
            // 
            this.ServiciosBindingSource.DataMember = "Servicios";
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteServicios";
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource beautyBaseDbDataSet2BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ServiciosBindingSource;
    }
}