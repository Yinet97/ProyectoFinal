using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace ProyectoFinal.consulta
{
    public partial class ConsultaEmpleadas : Form
    {
        public ConsultaEmpleadas()
        {
            InitializeComponent();
        }

        List<Empleadas> lista = new List<Empleadas>();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = EmpleadasBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = EmpleadasBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }

        private void ImprimirReporteBoton_Click(object sender, EventArgs e)
        {
            Reportes.ReporteEmpleadas re = new Reportes.ReporteEmpleadas();
            re.Show();
        }
    }
}
