using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
     //   public int Clienteid { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }

    }
}
