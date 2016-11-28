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
            string type = TiposComboBox.SelectedValue.ToString();

            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                Usuarios user = new Usuarios();

                user.Clave = ClaveTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Tipo = type;


                if (TiposUsuariosBll.Insertar(user))
                {
                    MessageBox.Show("Guardado !!");
                }
                LimpiarCampos();

            }
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

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
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            IdTextBox.Clear();
        }

        private void Boton_Buscar_Click_1(object sender, EventArgs e)
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
            var user = UsuariosBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (user != null)
            {
                NombreTextBox.Text = user.Nombre;
                ClaveTextBox.Text = user.Clave;
            }
            else
            {
                MessageBox.Show("Este Usuario no Existe");
            }
        }

        BeautyBaseDb db = new BeautyBaseDb();
        private void ListarTipo()
        {
            var lista = db.TipoUsuario.ToList();

            if (lista.Count > 0)
            {
                TiposComboBox.DataSource = lista;
                TiposComboBox.DisplayMember = "tipoCategoria";
                TiposComboBox.ValueMember = "tipoID";

            }
        }

        private void RegistroTiposUsuarios_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text != null)
            {
                Usuarios user = new Usuarios();

                user.Clave = ClaveTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Tipo = TiposComboBox.SelectedValue.ToString();

                if (UsuariosBll.Editar(Convert.ToInt32(IdTextBox.Text), user))
                {
                    MessageBox.Show("Modificado!!");
                }
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Necesitas el id de la cita para modificar");
            }
        }
    }
}
