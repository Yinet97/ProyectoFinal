using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBllTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios c = new Usuarios();
            c.Nombre = "Fernando";
            c.Clave = "845";
            c.Tipo = "administrador";
            Assert.IsTrue(UsuariosBll.Insertar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 2;
            Assert.IsFalse(UsuariosBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(UsuariosBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.AreEqual(UsuariosBll.GetLista().Count, UsuariosBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1, id2 = 2;
            Assert.AreNotSame(UsuariosBll.Buscar(id).Nombre, UsuariosBll.Buscar(id2).Nombre);
        }
    }
}