using System;
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
    }
}
