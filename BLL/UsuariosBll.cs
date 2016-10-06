using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

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
    }
}
