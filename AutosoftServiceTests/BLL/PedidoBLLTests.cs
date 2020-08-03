using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class PedidoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Pedidos pedidos = new Pedidos();
            PedidoD pedidoD = new PedidoD();
            pedidos.PedidoId = 0;
            pedidos.ArticuloId = 1;
            pedidos.ProveedorId = 1;
            pedidos.Subtotal = 100;
            pedidos.Nota = "Pedido de Prioridad";
            pedidos.Fecha = DateTime.Now;
            pedidos.FechaEntrega= DateTime.Now.AddDays(15);


            pedidoD.Id = 0;
            pedidoD.ProveedorId = 1;
            pedidoD.ArticuloId = 1;
            pedidoD.Descripcion = "Mantenimiento Clear";
            pedidoD.Unidad = 2;
            pedidoD.Precio = 3000;
            paso = PedidoBLL.Guardar(pedidos);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Pedidos pedidos = new Pedidos();
            PedidoD pedidoD = new PedidoD();
            pedidos.PedidoId = 3;
            pedidos.ArticuloId = 1;
            pedidos.ProveedorId = 2;
            pedidos.Subtotal = 100;
            pedidos.Nota = "Pedido de Prioridad";
            pedidos.Fecha = DateTime.Now;
            pedidos.FechaEntrega = DateTime.Now.AddDays(15);


            pedidoD.Id = 0;
            pedidoD.ProveedorId = 2;
            pedidoD.ArticuloId = 1;
            pedidoD.Descripcion = "Mantenimiento Clear";
            pedidoD.Unidad = 2;
            pedidoD.Precio = 3000;
            paso = PedidoBLL.Modificar(pedidos);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = PedidoBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Pedidos pedidos = new Pedidos();
            bool paso = false;

            pedidos = PedidoBLL.Buscar(1);

            if (pedidos != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = FacturaBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Pedidos> lista = PedidoBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}