using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteFacturas : Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
            FacturaReportViewer.Reset();
            FacturaReportViewer.ProcessingMode = ProcessingMode.Local;

            FacturaReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinal\ProyectoFinal\UI\Reportes\Facturas.rdlc";

            ReportDataSource source = new ReportDataSource("FacturasDataSet", FacturasBll.GetLista());

            FacturaReportViewer.LocalReport.DataSources.Add(source);
            this.FacturaReportViewer.RefreshReport();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            
        }

        private void FacturaReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
