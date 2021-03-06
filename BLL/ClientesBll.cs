﻿using System;
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
                using (var db = new BeautyBaseDb())
                {
                    db.Cliente.Add(cliente);
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

        public static bool Editar(int id, Clientes client)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyBaseDb())
                {
                    Clientes c = db.Cliente.Find(id);

                    c.Cedula = client.Cedula;
                    c.Nombre = client.Nombre;
                    c.Direccion = client.Direccion;
                    c.Telefono = client.Telefono;

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

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (BeautyBaseDb db = new BeautyBaseDb())
                {
                    Clientes user = (from c in db.Cliente where c.ClienteId == id select c).FirstOrDefault();
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

            lista = db.Cliente.Where(u => u.ClienteId == id).ToList();
            return lista;
        }

        public static Clientes Buscar(int id)
        {
            Clientes client = new Clientes();
            using (BeautyBaseDb db = new BeautyBaseDb())
            {
                client = db.Cliente.Find(id);
            }
            return client;
        }
    }
}
