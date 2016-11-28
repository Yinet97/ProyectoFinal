using Microsoft.Reporting.WinForms;
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

namespace ProyectoFinal
{
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BeautyBaseDbDataSet1.Clientes' table. You can move, or remove it, as needed.

            this.ClientesReportViewer.RefreshReport();

            ClientesReportViewer.Reset();
            ClientesReportViewer.ProcessingMode = ProcessingMode.Local;

            ClientesReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinal\ProyectoFinal\UI\Reportes\Clientes.rdlc";

            ReportDataSource source = new ReportDataSource("ClienteDataSet", ClientesBll.GetLista());

            ClientesReportViewer.LocalReport.DataSources.Add(source);
            this.ClientesReportViewer.RefreshReport();
        }

        private void ReporteView_Load(object sender, EventArgs e)
        {
            
        }

        private void ClientesReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
