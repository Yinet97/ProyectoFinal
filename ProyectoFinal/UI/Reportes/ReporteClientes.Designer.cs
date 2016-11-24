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
            this.BeautyBaseDbDataSet1 = new ProyectoFinal.BeautyBaseDbDataSet1();
            this.ReporteView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientesTableAdapter = new ProyectoFinal.BeautyBaseDbDataSet1TableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeautyBaseDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.BeautyBaseDbDataSet1;
            // 
            // BeautyBaseDbDataSet1
            // 
            this.BeautyBaseDbDataSet1.DataSetName = "BeautyBaseDbDataSet1";
            this.BeautyBaseDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteView
            // 
            this.ReporteView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientesBindingSource;
            this.ReporteView.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteView.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Clientes.rdlc";
            this.ReporteView.Location = new System.Drawing.Point(1, 0);
            this.ReporteView.Name = "ReporteView";
            this.ReporteView.Size = new System.Drawing.Size(742, 428);
            this.ReporteView.TabIndex = 0;
            this.ReporteView.Load += new System.EventHandler(this.ReporteView_Load);
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 428);
            this.Controls.Add(this.ReporteView);
            this.Name = "ReporteClientes";
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeautyBaseDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteView;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private BeautyBaseDbDataSet1 BeautyBaseDbDataSet1;
        private BeautyBaseDbDataSet1TableAdapters.ClientesTableAdapter ClientesTableAdapter;
    }
}