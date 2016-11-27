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

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            string username = usuarioTexBox.Text;
            string clave = claveTexBox.Text;

            if (String.IsNullOrEmpty(usuarioTexBox.Text) || String.IsNullOrEmpty(claveTexBox.Text))
            {
                MessageBox.Show("Dejaste campos Vacios");
            }
            else
            {
                using (BeautyBaseDb db = new BeautyBaseDb())
                {
                    var user = (from u in db.Usuario where u.Nombre == username select u.Nombre).FirstOrDefault();
                    var passw = (from u in db.Usuario where u.Clave == username select u.Clave).FirstOrDefault();

                    if (user == username || passw == clave)
                    {
                        Programa c = new Programa();
                        this.Hide();
                        c.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Los datos estan incompletos");
                    }
                }
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            RegistroTiposUsuarios rtu = new RegistroTiposUsuarios();
            rtu.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            
            //Asignar los asteriscos para la clave
            claveTexBox.Text = "";
            claveTexBox.PasswordChar = '*';
            claveTexBox.MaxLength = 14;
        }
    }
}
