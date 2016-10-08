using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TiposUsuarios
    {
        [Key]
        public string tipoCategoria { get; set; }
        public int tipoID { get; set; }

    }
}
