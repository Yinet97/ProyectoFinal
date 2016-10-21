using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Empleadas
    {
        [Key]
        public int empleadaID { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string cargo { get; set; }
        public int sueldoFijo { get; set; }
    }
}
