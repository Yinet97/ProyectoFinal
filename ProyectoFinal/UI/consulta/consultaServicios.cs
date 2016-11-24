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
    public partial class consultaServicios : Form
    {
        public consultaServicios()
        {
            InitializeComponent();
        }
        List<Servicios> lista = new List<Servicios>();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = ServiciosBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = ServiciosBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }

        private void listadoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
