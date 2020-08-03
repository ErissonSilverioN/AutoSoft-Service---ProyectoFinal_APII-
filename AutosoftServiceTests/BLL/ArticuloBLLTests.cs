using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulo = new Articulos();
            bool paso = false;
          
            articulo.ArticuloId = 0;
            articulo.Descripcion = "Goma";
            articulo.ProveedorId = 1;
            articulo.Categoria = "Piezas Estructurales";
            articulo.Costo = 500;
            articulo.Precio = 550;
            articulo.Existencia = 10;
            articulo.Ganancias =50;
            articulo.Fecha = DateTime.Now;


            paso = ArticuloBLL.Guardar(articulo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Articulos articulo = new Articulos();
            bool paso = false;

            articulo.ArticuloId = 2;
            articulo.Descripcion = "Gomas";
            articulo.ProveedorId = 1;
            articulo.Categoria = "Piezas Estructurales";
            articulo.Costo = 500;
            articulo.Precio = 550;
            articulo.Existencia = 10;
            articulo.Ganancias = 50;
            articulo.Fecha = DateTime.Now;


            paso = ArticuloBLL.Guardar(articulo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = ArticuloBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
           Articulos articulos = new Articulos();
            bool paso = false;

            articulos = ArticuloBLL.Buscar(1);

            if (articulos != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = ArticuloBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Articulos> lista = ArticuloBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}

namespace AutosoftServiceTests.BLL
{
    class ArticuloBLLTests
    {
    }
}
