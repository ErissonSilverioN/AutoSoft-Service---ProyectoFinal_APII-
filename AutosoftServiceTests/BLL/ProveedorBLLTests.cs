using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class ProveedorBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Proveedores Proveedor = new Proveedores();
            bool paso = false;

            Proveedor.ProveedorId = 0;
            Proveedor.Nombre = "Toyota";
            Proveedor.Telefono = "8097653322";
            Proveedor.Email = "Toyota@gmail.com";
            Proveedor.Direccion = "Calle/principal/#21";
            Proveedor.RNC = "8912921-i";
            Proveedor.CantidadPedidos = 10;
            Proveedor.Fecha = DateTime.Now;


            paso = ProveedorBLL.Guardar(Proveedor);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Proveedores Proveedor = new Proveedores();
            bool paso = false;

            Proveedor.ProveedorId = 1;
            Proveedor.Nombre = "Nissan";
            Proveedor.Telefono = "8097651122";
            Proveedor.Email = "Nissan@gmail.com";
            Proveedor.Direccion = "Calle/principal/#256";
            Proveedor.RNC = "89178-i";
            Proveedor.CantidadPedidos = 19;
            Proveedor.Fecha = DateTime.Now;


            paso = ProveedorBLL.Modificar(Proveedor);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {

            bool paso = false;

            paso = ProveedorBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Proveedores proveedor = new Proveedores();
            bool paso = false;

            proveedor = ProveedorBLL.Buscar(1);

            if (proveedor != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = ProveedorBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Proveedores> lista = ProveedorBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}