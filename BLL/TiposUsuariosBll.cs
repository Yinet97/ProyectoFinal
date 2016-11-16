using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class TiposUsuariosBll
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

      /*  public static bool Buscar(int  id)
        public static bool Eliminar()
         public static bool Editar() */
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

        public static TiposUsuarios Buscar(int id)
        {
            TiposUsuarios user = new TiposUsuarios();
            using (var db = new BeautyBaseDb())
            {
                user = db.TipoUsuario.Find(id);
            }
            return user;
        }

    }
}
