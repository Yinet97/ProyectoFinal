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

namespace ProyectoFinal
{
    public partial class RegistroEmpleada : Form
    {
        public RegistroEmpleada()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(CedulaTextBox.Text) || string.IsNullOrEmpty(ServicioTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Empleadas user = new Empleadas();
                

                user.Nombre = NombreTextBox.Text;
                user.Cedula = CedulaTextBox.Text;
                user.Telefono = TelefonoTextBox.Text;
                user.Direccion = DireccionTextBox.Text;
                user.Servicio = ServicioTextBox.Text;
                user.SueldoFijo = Convert.ToInt32(SueldoFijoTextBox.Text);
                user.FechaEntrada = FechaDateTimePicker.Value ;

                if (EmpleadasBll.Insertar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            EmpleadasBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            ServicioTextBox.Clear();
            CedulaTextBox.Clear();
            DireccionTextBox.Clear();
            SueldoFijoTextBox.Clear();
            ServicioTextBox.Clear();
            TelefonoTextBox.Clear();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Tienes el campo vacio");
            }
            else
            {
                BuscarID();
            }
        }

        public void BuscarID()
        {
            var emp = EmpleadasBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (emp != null)
            {
                NombreTextBox.Text = emp.Nombre;
                CedulaTextBox.Text = emp.Cedula;
                DireccionTextBox.Text = emp.Direccion;
                TelefonoTextBox.Text = emp.Telefono;
                ServicioTextBox.Text = emp.Servicio;
                FechaDateTimePicker.Text = emp.FechaEntrada.ToString();
                SueldoFijoTextBox.Text = emp.SueldoFijo.ToString();
            }
            else
            {
                MessageBox.Show("Este Cliente no Existe");
            }

        }


    }
}
