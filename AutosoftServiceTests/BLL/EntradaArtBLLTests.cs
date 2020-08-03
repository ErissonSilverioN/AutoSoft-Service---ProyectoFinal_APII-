using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class EntradaArtBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            EntradasArticulos entradasArticulos = new EntradasArticulos();
            entradasArticulos.EntradasArtId = 0;
            entradasArticulos.ArticuloId = 1;
            entradasArticulos.Cantidad = 1;
            entradasArticulos.Fecha = DateTime.Now;
            paso = EntradaArtBLL.Guardar(entradasArticulos);

            Assert.AreEqual(paso, true);
        }

     

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            EntradasArticulos entradasArticulos = new EntradasArticulos();
            entradasArticulos.EntradasArtId = 1;
            entradasArticulos.ArticuloId = 1;
            entradasArticulos.Cantidad = 3;
            entradasArticulos.Fecha = DateTime.Now;
            paso = EntradaArtBLL.Guardar(entradasArticulos);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = EntradaArtBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            EntradasArticulos Entrada = new EntradasArticulos();
            bool paso = false;

            Entrada = EntradaArtBLL.Buscar(1);

            if (Entrada != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = EntradaArtBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<EntradasArticulos> lista = EntradaArtBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}