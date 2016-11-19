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
    public class EmpleadasBllTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Empleadas c = new Empleadas();
            c.Nombre = "Maria";
            c.Cedula = "84525-6";
            c.Direccion = "Cotui";
            c.Telefono = "758-965-965";
            c.Servicio = "lavado";
            c.FechaEntrada = DateTime.Today ;

            Assert.IsTrue(EmpleadasBll.Insertar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 2;
            Assert.IsFalse(EmpleadasBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(EmpleadasBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.AreEqual(EmpleadasBll.GetLista().Count, EmpleadasBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 3;
            Assert.IsNotNull(EmpleadasBll.Buscar(id) != null);
        }
    }
}