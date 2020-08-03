using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class PagoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Pagos pago = new Pagos();
            bool paso = false;

            pago.PagoId = 0;
            pago.ClienteId = 1;
            pago.Monto = 1000;
            pago.Deuda= 10000;
            pago.Fecha = DateTime.Now;


            paso = PagoBLL.Guardar(pago);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Pagos pago = new Pagos();
            bool paso = false;

            pago.PagoId = 1;
            pago.ClienteId = 1;
            pago.Monto = 500;
            pago.Deuda = 11000;
            pago.Fecha = DateTime.Now;


            paso = PagoBLL.Modificar(pago);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = PagoBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Pagos pago = new Pagos();
            bool paso = false;

            pago = PagoBLL.Buscar(1);

            if (pago != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PagoBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Pagos> lista = PagoBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}