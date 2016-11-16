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
        public string TipoCategoria { get; set; }
        public int TipoId { get; set; }

    }
}
