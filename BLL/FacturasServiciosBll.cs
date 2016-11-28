using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class FacturasServiciosBll
    {
        public static bool Guardar(FacturasServicios lista)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyBaseDb())
                {
                    db.FacturaServicios.Add(lista);
                    db.SaveChanges();
                }
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
