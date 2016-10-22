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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmpleadasReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.beautyBaseDbDataSet = new ProyectoFinal.BeautyBaseDbDataSet();
            this.empleadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadasTableAdapter = new ProyectoFinal.BeautyBaseDbDataSetTableAdapters.EmpleadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadasReportViewer
            // 
            reportDataSource1.Name = "DataSetEmpleadas";
            reportDataSource1.Value = this.empleadasBindingSource;
            this.EmpleadasReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.EmpleadasReportViewer.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Empleadas.rdlc";
            this.EmpleadasReportViewer.Location = new System.Drawing.Point(1, -1);
            this.EmpleadasReportViewer.Name = "EmpleadasReportViewer";
            this.EmpleadasReportViewer.Size = new System.Drawing.Size(708, 436);
            this.EmpleadasReportViewer.TabIndex = 0;
            // 
            // beautyBaseDbDataSet
            // 
            this.beautyBaseDbDataSet.DataSetName = "BeautyBaseDbDataSet";
            this.beautyBaseDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadasBindingSource
            // 
            this.empleadasBindingSource.DataMember = "Empleadas";
            this.empleadasBindingSource.DataSource = this.beautyBaseDbDataSet;
            // 
            // empleadasTableAdapter
            // 
            this.empleadasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 434);
            this.Controls.Add(this.EmpleadasReportViewer);
            this.Name = "ReporteEmpleadas";
            this.Text = "Reporte Empleadas";
            this.Load += new System.EventHandler(this.ReporteEmpleadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyBaseDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmpleadasReportViewer;
        private BeautyBaseDbDataSet beautyBaseDbDataSet;
        private System.Windows.Forms.BindingSource empleadasBindingSource;
        private BeautyBaseDbDataSetTableAdapters.EmpleadasTableAdapter empleadasTableAdapter;
    }
}