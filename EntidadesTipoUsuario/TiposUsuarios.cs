using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntidadesTipoUsuario
{
    public class TiposUsuarios
    {
        [Key]

        public string tipoUsuario { get; set; }
        public int usuarioID { get; set; }
    }
}
