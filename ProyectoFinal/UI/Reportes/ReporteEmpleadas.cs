using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.Reportes
{
    public partial class ReporteEmpleadas : Form
    {
        public ReporteEmpleadas()
        {
            InitializeComponent();
        }

        private void ReporteEmpleadas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautyBaseDbDataSet.Empleadas' table. You can move, or remove it, as needed.

            this.EmpleadasReportViewer.RefreshReport();
        }
    }
}
