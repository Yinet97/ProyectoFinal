using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBll
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                BeautyBaseDb db = new BeautyBaseDb();
                db.Usuario.Add(usuario);
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
                    Usuarios user = (from c in db.Usuario where c.UsuarioId == id select c).FirstOrDefault();
                    db.Usuario.Remove(user);
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

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Usuario.ToList();
            return lista;
        }

        public static List<Usuarios> GetLista(int id)
        {
            List<Usuarios> lista = new List<Usuarios>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Usuario.Where(u => u.UsuarioId == id).ToList();
            return lista;
        }

        public static Usuarios Buscar(int id)
        {
            Usuarios user = new Usuarios();
            using (var db = new BeautyBaseDb())
            {
                user = db.Usuario.Find(id);
            }
            return user;
        }
    }
}
