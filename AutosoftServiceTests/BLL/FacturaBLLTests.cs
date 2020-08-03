using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class FacturaBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Facturas factura = new Facturas();
            FacturaD facturaDet = new FacturaD();

            factura.FacturaId = 0;
            factura.ClienteId = 1;
            factura.Fecha = DateTime.Now;
            factura.ArticuloId= 1;
            factura.VehiculoId= 1;
            factura.Servicios = "Reparacion";
            factura.SubTotal = 500;
            factura.Total = 590;
            factura.Itbis = 90;
            factura.FacturaCredito = false;
            factura.ProximoMantemiento = DateTime.Now;


            facturaDet.Id = 0;
            facturaDet.FacturaId = 0;
            facturaDet.Precio = 500;
            facturaDet.ArticuloId = 1;
            facturaDet.Cantidad = 2;
            facturaDet.Descripcion = "Gomas";
            facturaDet.Importe = 1000;
            factura.Factura_Detalle.Add(facturaDet);

            paso = FacturaBLL.Guardar(factura);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Facturas factura = new Facturas();
            FacturaD facturaDet = new FacturaD();

            factura.FacturaId = 1;
            factura.ClienteId = 1;
            factura.Fecha = DateTime.Now;
            factura.ArticuloId = 1;
            factura.VehiculoId = 1;
            factura.Servicios = "Reparaciones";
            factura.SubTotal = 500;
            factura.Total = 590;
            factura.Itbis = 90;
            factura.FacturaCredito = false;
            factura.ProximoMantemiento = DateTime.Now;


            facturaDet.Id = 0;
            facturaDet.FacturaId = 0;
            facturaDet.Precio = 500;
            facturaDet.ArticuloId = 1;
            facturaDet.Cantidad = 2;
            facturaDet.Descripcion = "Gomas";
            facturaDet.Importe = 1000;
            factura.Factura_Detalle.Add(facturaDet);

            paso = FacturaBLL.Modificar(factura);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = FacturaBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
           Facturas factura = new Facturas();
            bool paso = false;

            factura = FacturaBLL.Buscar(1);

            if (factura != null)
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

            List<Facturas> lista = FacturaBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}