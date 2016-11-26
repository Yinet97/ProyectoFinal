﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Servicios
    {
        [Key]

        public int ServicioId { get; set; }
        public string TipoServicio { get; set; }
        public int Costo { get; set; }
        public int PorcientoAdicional { get; set; }

        public List<Facturas> Facturas { get; set; }

        public Servicios()
        {
            this.Facturas = new List<Facturas>();
        }

        public Servicios(int ServicioId, string TipoServicio)
        {
            this.ServicioId = ServicioId;
            this.TipoServicio = TipoServicio;
            this.Facturas = new List<Facturas>();
        }
    }
}
