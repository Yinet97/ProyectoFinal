using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ServiciosBll
    {
        public static bool Guardar(Servicios servicio)
        {
            bool retorno = false;
            try
            {
                BeautyBaseDb db = new BeautyBaseDb();
                db.Servicio.Add(servicio);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (BeautyBaseDb db = new BeautyBaseDb())
                {
                    Servicios user = (from c in db.Servicio where c.servicioID== id select c).FirstOrDefault();
                    db.Servicio.Remove(user);
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

        public static List<Servicios> GetLista()
        {
            List<Servicios> lista = new List<Servicios>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Servicio.ToList();
            return lista;
        }

        public static List<Servicios> GetLista(int id)
        {
            List<Servicios> lista = new List<Servicios>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Servicio.Where(u => u.servicioID == id).ToList();
            return lista;
        }
    }
}
