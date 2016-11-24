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

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listadoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
