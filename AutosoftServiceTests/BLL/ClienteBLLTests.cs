using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class ClienteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

           Clientes clientes = new Clientes();
            bool paso = false;

            clientes.ClienteId = 0;
            clientes.Nombre = "Carlos";
            clientes.Cedula = "05800222864";
            clientes.Telefono = "8295698233";
            clientes.Direccion = "C/principal";
            clientes.Email = "jose@gmail.com";
            clientes.Fecha =DateTime.Now;
            clientes.Deuda = 50;
            


            paso = ClienteBLL.Guardar(clientes);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Clientes clientes = new Clientes();
            bool paso = false;

            clientes.ClienteId = 1;
            clientes.Nombre = "Cristian";
            clientes.Cedula = "05800222964";
            clientes.Telefono = "8295693333";
            clientes.Direccion = "C/principal";
            clientes.Email = "jose12@gmail.com";
            clientes.Fecha = DateTime.Now;
            clientes.Deuda = 5;



            paso = ClienteBLL.Guardar(clientes);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = ClienteBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Clientes clientes = new Clientes();
            bool paso = false;

            clientes = ClienteBLL.Buscar(1);

            if (clientes != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = ClienteBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;
            List<Clientes> lista = ClienteBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}