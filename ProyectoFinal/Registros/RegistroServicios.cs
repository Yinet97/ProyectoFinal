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
            if (string.IsNullOrEmpty(TipotextBox.Text) || string.IsNullOrEmpty(CostotextBox.Text) )
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Servicios service = new Servicios();

                service.TipoServicio = TipotextBox.Text;
                service.Costo = Convert.ToInt32(CostotextBox.Text);

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
            int id = Convert.ToInt32(IDtextBox.Text);

            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                try
                {
                    var service = (from c in db.Servicio
                                where c.ServicioId == id
                                select c.TipoServicio).FirstOrDefault();

                    var costo = (from c in db.Servicio
                                  where c.ServicioId == id
                                  select c.Costo).FirstOrDefault();
                    


                    TipotextBox.Text = service;
                    CostotextBox.Text = Convert.ToString(costo);

                    if (service == null || costo.ToString() == null)
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

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            IDtextBox.Clear();
            TipotextBox.Clear();
            CostotextBox.Clear();
        }
    }
}
