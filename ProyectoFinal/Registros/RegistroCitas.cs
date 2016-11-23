using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace ProyectoFinal.Registros
{
    public partial class RegistroCitas : Form
    {
        public RegistroCitas()
        {
            InitializeComponent();
        }

        private void BuscarClienteBoton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(IdClienteTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var client = ClientesBll.Buscar(Convert.ToInt32(IdClienteTextBox.Text));
                if (client != null)
                {
                    ClienteTextBox.Text = client.Nombre;
                }
                else
                {
                    MessageBox.Show("Este Cliente no Existe");
                }
            }
        }

        private void BuscarCitaBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCitaTextBox.Text);

            if (string.IsNullOrEmpty(IdCitaTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var cita = CitasBll.Buscar(Convert.ToInt32(IdCitaTextBox.Text));
                if (cita != null)
                {
                    CitaDateTimePicker.Text = cita.Fecha.ToString();
                    HoraDateTimePicker.Text = cita.Hora.ToString();
                    ClienteTextBox.Text = cita.NombreCliente;
                }
                else
                {
                    MessageBox.Show("Este Cliente no Existe");
                }
            }

        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdCitaTextBox.Text);

            ClientesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            ClienteTextBox.Clear();
            IdCitaTextBox.Clear();
            IdClienteTextBox.Clear();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            Citas date = new Citas();
            date.NombreCliente = ClienteTextBox.Text;
            date.Fecha = CitaDateTimePicker.Value.Date;
            date.Hora = HoraDateTimePicker.Value;

            if(CitasBll.Guardar(date))
            {
                MessageBox.Show("Cita Guardada");
                LlenarLista();
            }
            else
            {
                MessageBox.Show("No se pudo Guardar");
            }
        }

        public void LlenarLista()
        {
            ListaCitaDataGridView.DataSource = null;
            ListaCitaDataGridView.DataSource = CitasBll.GetLista();
        }

    /*    public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = LoadDataTable();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Nombre"]));
            }

            return stringCol;
        }

        private void ClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            ClienteTextBox.AutoCompleteCustomSource = DataHelper.LoadAutoComplete();
            ClienteTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ClienteTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        } */

        
    }
}
