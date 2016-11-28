namespace ProyectoFinal
{
    partial class ReporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteClientes));
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            // 
            // ClientesReportViewer
            // 
            this.ClientesReportViewer.Location = new System.Drawing.Point(-2, -1);
            this.ClientesReportViewer.Name = "ClientesReportViewer";
            this.ClientesReportViewer.Size = new System.Drawing.Size(743, 428);
            this.ClientesReportViewer.TabIndex = 0;
            this.ClientesReportViewer.Load += new System.EventHandler(this.ClientesReportViewer_Load);
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 428);
            this.Controls.Add(this.ClientesReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteClientes";
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer ClientesReportViewer;
    }
}