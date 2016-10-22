using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Servicios
    {
        [Key]

        public int servicioID { get; set; }
        public string tipoServicio { get; set; }
        public int costo { get; set; }

    }
}
