﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class BeautyBaseDb : DbContext
    {
        public BeautyBaseDb() : base("name = conStr")
        {

        }

        public virtual DbSet<Usuarios> Usuario { get; set; }
        public virtual DbSet<TiposUsuarios> TipoUsuario { get; set; }
        public virtual DbSet<Empleadas> Empleada { get; set; }
        public virtual DbSet<Clientes> Cliente { get; set; }
        public virtual DbSet<Servicios> Servicio { get; set; }
        public virtual DbSet<Citas> Cita { get; set; }
    }
}
