using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class ClientesBll
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            try
            {
                BeautyBaseDb db = new BeautyBaseDb();
                db.Cliente.Add(cliente);
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
                    Clientes user = (from c in db.Cliente where c.clienteID == id select c).FirstOrDefault();
                    db.Cliente.Remove(user);
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

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Cliente.ToList();
            return lista;
        }

        public static List<Clientes> GetLista(int id)
        {
            List<Clientes> lista = new List<Clientes>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Cliente.Where(u => u.clienteID == id).ToList();
            return lista;
        }
    }
}
