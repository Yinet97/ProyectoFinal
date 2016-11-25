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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            // agregarle esto despues que haga el detalle  || string.IsNullOrEmpty(ServiciosDataGridView.DataSource.ToString())
            if (string.IsNullOrEmpty(NombreClienteTextBox.Text) 
                 )
            {
                MessageBox.Show("Dejaste campos importantes Vacios");
            }
            else
            {
                Facturas f = new Facturas();
                f.Fecha = DateTime.Now;
                f.Comentario = ComentarioRichTextBox.Text;
                f.Descuento = Convert.ToInt32(DescuentoTextBox.Text);
                f.Impuesto = Convert.ToInt32(ImpuestoTextBox.Text);
                f.ServicioId = 1;
                f.NombreCliente = NombreClienteTextBox.Text;
                f.MontoAdicional = Convert.ToInt32(MontoAdicionalTextBox.Text);
                f.TipoPago = TipoPagoTextBox.Text;
                f.Total = 200.00f;

                if(FacturasBll.Guardar(f))
                {
                    MessageBox.Show("Guardado");
                }
            }
        }


        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var fact = FacturasBll.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (fact != null)
                {
                    NombreClienteTextBox.Text = fact.NombreCliente;
                    FechaActualDateTimePicker.Text = fact.Fecha.ToString();
                    MontoAdicionalTextBox.Text = fact.MontoAdicional.ToString();
                    ImpuestoTextBox.Text = fact.Impuesto.ToString();
                    DescuentoTextBox.Text = fact.Descuento.ToString();
                    ComentarioRichTextBox.Text = fact.Comentario;
                    ServiciosDataGridView.DataSource = fact.ServicioId.ToString();
                    TipoPagoTextBox.Text = fact.TipoPago;
                    TotalTextBox.Text = fact.Total.ToString();
                }
                else
                {
                    MessageBox.Show("Esta Factura no Existe");
                }
            }
        }
    }
}
