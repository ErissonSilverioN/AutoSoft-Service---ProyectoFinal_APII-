using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class VehiculoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vehiculos vehiculo = new Vehiculos();
            bool paso = false;

            vehiculo.VehiculoId= 0;
            vehiculo.ClienteId = 1;
            vehiculo.TipoVehiculo = "Quad";
            vehiculo.Descripcion = "Toyota";
            vehiculo.Placa = "11313rg";
            vehiculo.Año= 2016;
            vehiculo.Fecha = DateTime.Now;

            paso = VehiculoBLL.Guardar(vehiculo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Vehiculos vehiculo = new Vehiculos();
            bool paso = false;

            vehiculo.VehiculoId = 1;
            vehiculo.ClienteId = 1;
            vehiculo.TipoVehiculo = "Quad";
            vehiculo.Descripcion = "Toyota";
            vehiculo.Placa = "11313rg";
            vehiculo.Año = 2020;
            vehiculo.Fecha = DateTime.Now;

            paso = VehiculoBLL.Modificar(vehiculo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = VehiculoBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Vehiculos vehiculo = new Vehiculos();
            bool paso = false;

            vehiculo = VehiculoBLL.Buscar(1);

            if (vehiculo != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = VehiculoBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Vehiculos> lista = VehiculoBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}