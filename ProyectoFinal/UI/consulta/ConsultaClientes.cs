﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ProyectoFinal.consulta
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        List<Clientes> lista = new List<Clientes>();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = ClientesBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = ClientesBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }

        private void ImprimirReporteBoton_Click(object sender, EventArgs e)
        {
            ReporteClientes rc = new ReporteClientes();
            rc.Show();
        }
    }
}
