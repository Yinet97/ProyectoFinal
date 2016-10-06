using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;
using DAL;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox_Nombre.Text) || string.IsNullOrEmpty(textBox_Clave.Text) || string.IsNullOrEmpty(textBox_ID.Text))
            {
                MessageBox.Show("Dejaste un campo vacio");

            }
            else
            {
                   Usuarios user = new Usuarios();

                    user.clave = textBox_Clave.Text;
                    user.nombre = textBox_Nombre.Text;
                    user.usuarioID = Convert.ToInt32(textBox_ID.Text);
                  string valor;

                  if (checkBox_Adm.Checked == true)
                   {
                       valor = "Administrador";
                       user.tipoUsuario = valor;

                       if (UsuariosBll.Insertar(user))
                       {
                           MessageBox.Show("Guardado !!");
                       }
                   }
                   else
                   {
                       valor = "Empleado";
                       user.tipoUsuario = valor;

                       if (UsuariosBll.Insertar(user))
                       {
                           MessageBox.Show("Guardado !!");
                       }
                   } 

                    textBox_Clave.Clear();
                    textBox_ID.Clear();
                    textBox_Nombre.Clear();
                    textBox1.Clear();

            }
        }

        private void Boton_Buscar_Click(object sender, EventArgs e)
        {

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
                                where c.usuarioID == id
                                select c.nombre).FirstOrDefault();

                    var password = (from c in db.Usuario
                                    where c.usuarioID == id
                                    select c.clave).FirstOrDefault();

                    var tipyUser = (from c in db.Usuario
                                    where c.usuarioID == id
                                    select c.tipoUsuario).FirstOrDefault();  

                    textBox_Nombre.Text = name;
                    textBox_Clave.Text = password;
                    textBox1.Text = tipyUser;

                }
                catch (Exception)
                {
                    MessageBox.Show("Este usuario no existe");
                }

            }
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID.Text);

            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                Usuarios u = (from user in db.Usuario where user.usuarioID == id select user).FirstOrDefault();
                db.Usuario.Remove(u);
                db.SaveChanges();

                MessageBox.Show("Eliminado !");
                textBox_Clave.Clear();
                textBox_ID.Clear();
                textBox_Nombre.Clear();
                textBox1.Clear();
            }
        }

        private void Boton_Nuevo_Click(object sender, EventArgs e)
        {
            textBox_Nombre.Clear();
            textBox_Clave.Clear();
            textBox_ID.Clear();
            textBox1.Clear();
        }
    }
}
