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
using System.Data.SqlClient;

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
                    CitaDateTimePicker.Text = cita.FechaHora.ToString();
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

            CitasBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
            LlenarLista();
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
            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                string var = (from c in db.Cliente where c.Nombre == ClienteTextBox.Text select c.Nombre).FirstOrDefault();
                if (var == ClienteTextBox.Text)
                {
                    date.NombreCliente = ClienteTextBox.Text;
                    date.FechaHora = CitaDateTimePicker.Value;

                    if (CitasBll.Guardar(date))
                    {
                        MessageBox.Show("Cita Guardada");
                        LlenarLista();
                    }
                }
                else
                {
                    MessageBox.Show("Este Cliente no esta registrado");
                }
            }
            
        }

        public void LlenarLista()
        {
            ListaCitaDataGridView.DataSource = null;
            ListaCitaDataGridView.DataSource = CitasBll.GetLista();
        }
        

        private void RegistroCitas_Load(object sender, EventArgs e)
        {
            AutoCompleteMode DataCollection = new AutoCompleteMode();
            AutoCompletarTxt(DataCollection);

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void AutoCompletarTxt(AutoCompleteMode AuMode)
        {
            BeautyBaseDb db = new BeautyBaseDb();

            ClienteTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ClienteTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            AutoCompleteStringCollection aColl = new AutoCompleteStringCollection();
            

            var cl = from obj in db.Cliente
                       select obj.Nombre;

            foreach (string c in cl)
            {
                aColl.Add(c);
            }
            ClienteTextBox.AutoCompleteCustomSource = aColl;
        }

        public void EliminarCitaAntigua()
        {
            BeautyBaseDb db = new BeautyBaseDb();
            DateTime hoy = DateTime.Now;

            var pastDate = from obj in db.Cita
                     select obj.FechaHora;

            foreach(DateTime d in pastDate)
            {
                if(d.Date < hoy)
                {
                    CitasBll.EliminarCitaPasada(d);
                }
                LlenarLista();
            }

        }

        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            EliminarCitaAntigua();
        }
    }
}
