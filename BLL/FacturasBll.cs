﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class FacturasBll
    {
        public static bool Guardar(Facturas fact)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyBaseDb())
                {
                    db.Factura.Add(fact);
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

        public static Facturas Buscar(int id)
        {
            Facturas date = new Facturas();
            using (var db = new BeautyBaseDb())
            {
                date = db.Factura.Find(id);
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
                    Facturas fact = (from c in db.Factura where c.FacturaId== id select c).FirstOrDefault();
                    db.Factura.Remove(fact);
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

        public static List<Facturas> GetLista()
        {
            List<Facturas> lista = new List<Facturas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Factura.ToList();
            return lista;
        }

        public static List<Facturas> GetLista(int id)
        {
            List<Facturas> lista = new List<Facturas>();
            BeautyBaseDb db = new BeautyBaseDb();

            lista = db.Factura.Where(u => u.FacturaId == id).ToList();
            return lista;
        }
    }
}
