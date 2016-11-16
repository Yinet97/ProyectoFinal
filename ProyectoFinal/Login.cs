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

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaUsuarios c = new consultaUsuarios();
            c.Show();
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
                        consultaUsuarios c = new consultaUsuarios();
                        c.Show();
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

        private void regEmpleadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleada re = new RegistroEmpleada();
            re.Show();
        }

        private void empleadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta.ConsultaEmpleadas ce = new consulta.ConsultaEmpleadas();
            ce.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroClientes rc = new Registros.RegistroClientes();
            rc.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulta.ConsultaClientes cc = new consulta.ConsultaClientes();
            cc.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroServicios rS = new Registros.RegistroServicios();
            rS.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulta.consultaServicios cS = new consulta.consultaServicios();
            cS.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteClientes re = new ReporteClientes();
            re.Show();
        }

        private void empleadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteEmpleadas report = new Reportes.ReporteEmpleadas();
            report.Show();
        }

        private void serviciosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteServicios reporte = new Reportes.ReporteServicios();
            reporte.Show();
        }
    }
}
