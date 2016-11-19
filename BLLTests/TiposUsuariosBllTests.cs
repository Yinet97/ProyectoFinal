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
    public class TiposUsuariosBllTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios c = new Usuarios();
            c.Tipo = "empleado";
            c.Nombre = "armando";
            c.Clave = "845";
            Assert.IsTrue(TiposUsuariosBll.Insertar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            Assert.IsFalse(TiposUsuariosBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(TiposUsuariosBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.AreEqual(TiposUsuariosBll.GetLista().Count, TiposUsuariosBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}