using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]

        public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string tipoUsuario { get; set; }

    }
}
