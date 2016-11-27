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
            Citas date = new Citas();
            using (var db = new BeautyBaseDb())
            {
                date = db.Cita.Find(id);
            }
            return date;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (BeautyBaseDb db = new BeautyBaseDb())
                {
                    Citas date = (from c in db.Cita where c.CitaId == id select c).FirstOrDefault();
                    db.Cita.Remove(date);
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

        public static bool EliminarCitaPasada(DateTime cita)
        {
            bool retorno = false;

            try
            {
                using (BeautyBaseDb db = new BeautyBaseDb())
                {
                    Citas date = (from c in db.Cita where c.FechaHora == cita select c).FirstOrDefault();
                    db.Cita.Remove(date);
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

        public static List<Citas> GetLista()
        {
            List<Citas> lista = new List<Citas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Cita.ToList();
            return lista;
        }

        public static List<Citas> GetLista(int id)
        {
            List<Citas> lista = new List<Citas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Cita.Where(u => u.CitaId == id).ToList();
            return lista;
        }

     /*   public static List<Citas> GetListaFecha(DateTime fecha)
        {
            List<Citas> lista = new List<Citas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Cita.Where(u => u.FechaHora.Date > fecha.Date).ToList();
            return lista;
        } */
    }
}
