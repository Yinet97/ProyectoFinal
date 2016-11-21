using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
   public class CitasBll
    {
        public static bool Guardar(Citas date)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyBaseDb())
                {
                    db.Cita.Add(date);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static Citas Buscar(int id)
        {

        }
    }
}
