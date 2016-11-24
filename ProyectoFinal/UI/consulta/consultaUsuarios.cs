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

namespace ProyectoFinal
{
    public partial class consultaUsuarios : Form
    {
        public consultaUsuarios()
        {
            InitializeComponent();
        }

        List<Usuarios> lista = new List<Usuarios>();

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
                {
                    lista= TiposUsuariosBll.GetLista(Utilidades.stringToInt(textBox1.Text));
                }
            else
            {
               lista= TiposUsuariosBll.GetLista();

            }
            listadoConsulta.DataSource = lista;
        }
    }
}
