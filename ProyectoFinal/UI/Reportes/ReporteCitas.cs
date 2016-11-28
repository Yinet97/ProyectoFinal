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
    public partial class ReporteCitas : Form
    {
        public ReporteCitas()
        {
            InitializeComponent();
        }

        private void ReporteCitas_Load(object sender, EventArgs e)
        {

            this.CitasReportViewer.RefreshReport();

            CitasReportViewer.Reset();
            CitasReportViewer.ProcessingMode = ProcessingMode.Local;

            CitasReportViewer.LocalReport.ReportPath = @"C:\Users\Yinet Jaquez\Desktop\ProyectoFinal\ProyectoFinal\UI\Reportes\Citas.rdlc";

            ReportDataSource source = new ReportDataSource("CitaDataSet", CitasBll.GetLista());

            CitasReportViewer.LocalReport.DataSources.Add(source);
            this.CitasReportViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
