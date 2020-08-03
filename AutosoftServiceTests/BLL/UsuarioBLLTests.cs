using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutosoftService.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using AutosoftService.Model;

namespace AutosoftService.BLL.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario.UsuarioId = 0;
            usuario.Nombre = "Juan carlos";
            usuario.Apellidos= "Tavarez";
            usuario.Email = "juanT@gmail.com";
            usuario.Usuario = "JuanT";
            usuario.NivelUsuario = "Empleado";
            usuario.Contrasena = "123456789";
            usuario.ConfirmarContrasena = "123456789";
            usuario.FechaIngreso = DateTime.Now;


            paso = UsuarioBLL.Guardar(usuario);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario.UsuarioId = 1;
            usuario.Nombre = "Emerson";
            usuario.Apellidos = "Del Orbe Candelario";
            usuario.Email = "Emerson@gmail.com";
            usuario.Usuario = "Administrador";
            usuario.NivelUsuario = "Administrador";
            usuario.Contrasena = "Admin";
            usuario.ConfirmarContrasena = "Admin";
            usuario.FechaIngreso = DateTime.Now;
           

            paso = UsuarioBLL.Modificar(usuario);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = UsuarioBLL.Eliminar(2);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario = UsuarioBLL.Buscar(1);

            if (usuario != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = UsuarioBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Usuarios> lista = UsuarioBLL.GetList(l => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        
    }
}