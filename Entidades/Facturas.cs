using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Facturas
    {
        [Key]

        public int FacturaId { get; set; }
        public string NombreCliente { get; set; }
        public int MontoAdicional { get; set; }
        public int Descuento { get; set; }
        public string Comentario { get; set; }
        public int Impuesto { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; }
        public int ServicioId { get; set; }
        public double Total { get; set; }

        public List<Servicios> Service { get; set; }

        public Facturas()
        {
            this.Service = new List<Servicios>();
        }
    }
}
