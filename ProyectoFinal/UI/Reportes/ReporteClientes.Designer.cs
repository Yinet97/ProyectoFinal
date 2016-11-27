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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuspendLayout();
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            // 
            // BeautyBaseDbDataSet1
            // 
            // 
            // ReporteView
            // 
            // ClientesTableAdapter
            // 
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 428);
            this.Name = "ReporteClientes";
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.BindingSource ClientesBindingSource;
    }
}