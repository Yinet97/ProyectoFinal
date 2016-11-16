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
    public partial class RegistroTiposUsuarios : Form
    {
        public RegistroTiposUsuarios()
        {
            InitializeComponent();
            ListarTipo();
        }

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
           // string type = Tipos_ConmoBox.SelectedValue.ToString();

            if (string.IsNullOrEmpty(textBox_Nombre.Text) || string.IsNullOrEmpty(textBox_Clave.Text) || string.IsNullOrEmpty(textBox_ID.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Usuarios user = new Usuarios();

                user.Clave = textBox_Clave.Text;
                user.Nombre = textBox_Nombre.Text;
              //  user.Tipo = type;


                if (TiposUsuariosBll.Insertar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();

            }
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID.Text);

            TiposUsuariosBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            LimpiarCampos();
        }

        private void Boton_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            textBox_Nombre.Clear();
            textBox_Clave.Clear();
            textBox_ID.Clear();
        }

        private void Boton_Buscar_Click_1(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox_ID.Text);

            if (string.IsNullOrEmpty(textBox_ID.Text))
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
            int id = Convert.ToInt32(textBox_ID.Text);

            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                try
                {
                    var name = (from c in db.Usuario
                                where c.UsuarioId == id
                                select c.Nombre).FirstOrDefault();

                    var password = (from c in db.Usuario
                                    where c.UsuarioId == id
                                    select c.Clave).FirstOrDefault();

                    textBox_Nombre.Text = name;
                    textBox_Clave.Text = password;

                    if (name == null || password == null)
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

        BeautyBaseDb db = new BeautyBaseDb();
        private void ListarTipo()
        {
            var lista = db.TipoUsuario.ToList();

            if (lista.Count > 0)
            {
                Tipos_ConmoBox.DataSource = lista;
                Tipos_ConmoBox.DisplayMember = "tipoCategoria";
                Tipos_ConmoBox.ValueMember = "tipoID";

            }
        }
    }
}
