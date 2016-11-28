using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;

namespace ProyectoFinal.Registros
{
    public partial class RegistroServicios : Form
    {
        public RegistroServicios()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TipoTextBox.Text) || string.IsNullOrEmpty(CostoTextBox.Text) )
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Servicios service = new Servicios();

                service.TipoServicio = TipoTextBox.Text;
                service.Costo = Convert.ToInt32(CostoTextBox.Text);

                if (ServiciosBll.Guardar(service))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            ServiciosBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
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
            var ser = ServiciosBll.Buscar(Convert.ToInt32(IDtextBox.Text));
            if (ser != null)
            {
                TipoTextBox.Text = ser.TipoServicio;
                CostoTextBox.Text = ser.Costo.ToString();
            }
            else
            {
                MessageBox.Show("Este Servicio no Existe");
            }
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            IDtextBox.Clear();
            TipoTextBox.Clear();
            CostoTextBox.Clear();
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text != null)
            {
                Servicios user = new Servicios();

                user.Costo = Convert.ToInt32(CostoTextBox.Text);
                user.TipoServicio = TipoTextBox.Text;


                if (ServiciosBll.Editar(Convert.ToInt32(IDtextBox.Text), user))
                {
                    MessageBox.Show("Modificado!!");
                }
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Necesitas el id para modificar");
            }
        }
    }
}
