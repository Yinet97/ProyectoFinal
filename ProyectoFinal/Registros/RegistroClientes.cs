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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) || string.IsNullOrEmpty(CedulaTextBox.Text) || string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Clientes user = new Clientes();

                user.nombre = NombretextBox.Text;
                user.cedula = CedulaTextBox.Text;
                user.direccion = DireccionTextBox.Text;
                user.telefono = TelefonoTextBox.Text;


                if (ClientesBll.Guardar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();

            }
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            if (string.IsNullOrEmpty(IDtextBox.Text))
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
            int id = Convert.ToInt32(IDtextBox.Text);

            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                try
                {
                    var name = (from c in db.Cliente
                                where c.clienteID == id
                                select c.nombre).FirstOrDefault();

                    var cedula = (from c in db.Cliente
                                    where c.clienteID == id
                                    select c.cedula).FirstOrDefault();

                    var dir = (from c in db.Cliente
                                  where c.clienteID == id
                                  select c.direccion).FirstOrDefault();

                    var telefono = (from c in db.Cliente
                                  where c.clienteID == id
                                  select c.telefono).FirstOrDefault();

                    NombretextBox.Text = name;
                    CedulaTextBox.Text = cedula;
                    DireccionTextBox.Text = dir;
                    TelefonoTextBox.Text = telefono;

                    if (name == null || cedula == null)
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

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            ClientesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            NombretextBox.Clear();
            DireccionTextBox.Clear();
            CedulaTextBox.Clear();
            IDtextBox.Clear();
            TelefonoTextBox.Clear();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
