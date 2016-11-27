using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            
        }

        private void ReporteView_Load(object sender, EventArgs e)
        {
           /* ReporteView.LocalReport.DataSources.Clear();
            ReporteView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            ReporteView.LocalReport.ReportPath = @"Reportes\Clientes.rdlc";

            ReportDataSource source = new ReportDataSource("Clientes", ClientesBindingSource.) */
        }
    }
}
