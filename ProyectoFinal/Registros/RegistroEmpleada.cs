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

            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCedula.Text) || string.IsNullOrEmpty(textBoxCargo.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Empleadas user = new Empleadas();

                user.empleadaID = Convert.ToInt32(textBoxID.Text);
                user.nombre = textBoxNombre.Text;
                user.cedula = textBoxCedula.Text;
                user.telefono = textBoxTelefono.Text;
                user.direccion = textBoxDireccion.Text;
                user.cargo = textBoxCargo.Text;
                user.sueldoFijo = Convert.ToInt32(textBoxSueldoFijo.Text);

                if (EmpleadasBll.Insertar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

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
            textBoxID.Clear();
            textBoxNombre.Clear();
            textBoxCargo.Clear();
            textBoxCedula.Clear();
            textBoxDireccion.Clear();
            textBoxSueldoFijo.Clear();
            textBoxCargo.Clear();
            textBoxTelefono.Clear();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if (string.IsNullOrEmpty(textBoxID.Text))
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
            int id = Convert.ToInt32(textBoxID.Text);

            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                try
                {
                    var name = (from c in db.Empleada
                                where c.empleadaID == id
                                select c.nombre).FirstOrDefault();

                    var sueldo = (from c in db.Empleada
                                    where c.empleadaID == id
                                    select c.sueldoFijo).FirstOrDefault();

                    var cargo = (from c in db.Empleada
                                  where c.empleadaID == id
                                  select c.cargo).FirstOrDefault();

                    var direccion = (from c in db.Empleada
                                     where c.empleadaID == id
                                     select c.direccion).FirstOrDefault();

                    var cedula = (from c in db.Empleada
                                  where c.empleadaID == id
                                  select c.cedula).FirstOrDefault();

                    var telefono = (from c in db.Empleada
                                  where c.empleadaID == id
                                  select c.telefono).FirstOrDefault();


                    textBoxNombre.Text = name;
                    textBoxSueldoFijo.Text = Convert.ToString(sueldo);
                    textBoxCargo.Text = cargo;
                    textBoxDireccion.Text = direccion;
                    textBoxCedula.Text = cedula;
                    textBoxTelefono.Text = telefono;

                    if (name == null || cargo == null)
                    {
                        MessageBox.Show("Este Usuario no esxiste");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Este usuario no existe");
                }

            }
        }
    }
}
