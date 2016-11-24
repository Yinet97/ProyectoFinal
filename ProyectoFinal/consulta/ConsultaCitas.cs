﻿using System;
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
    public partial class ConsultaCitas : Form
    {
        public ConsultaCitas()
        {
            InitializeComponent();
        }

        List<Citas> lista = new List<Citas>();
        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                lista = CitasBll.GetLista(Utilidades.stringToInt(textBoxID.Text));
            }
            else
            {
                lista = CitasBll.GetLista();

            }
            listadoConsulta.DataSource = lista;

        }
    }
}
