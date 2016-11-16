using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class EmpleadasBll
    {
        public static bool Insertar(Empleadas empleada)
        {
            bool retorno = false;
            try
            {
                BeautyBaseDb db = new BeautyBaseDb();
                db.Empleada.Add(empleada);
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
                    Empleadas user = (from c in db.Empleada where c.EmpleadaId== id select c).FirstOrDefault();
                    db.Empleada.Remove(user);
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

        /*  public static bool Buscar(int  id)
          public static bool Eliminar()
           public static bool Editar() */
        public static List<Empleadas> GetLista()
        {
            List<Empleadas> lista = new List<Empleadas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Empleada.ToList();
            return lista;
        }

        public static List<Empleadas> GetLista(int id)
        {
            List<Empleadas> lista = new List<Empleadas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Empleada.Where(u => u.EmpleadaId == id).ToList();
            return lista;
        }

        public static Empleadas Buscar(int id)
        {
            Empleadas emp = new Empleadas();
            using (var db = new BeautyBaseDb())
            {
                emp = db.Empleada.Find(id);
            }
            return emp;
        }
    }
}
