using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutosoftService.Model;
using AutosoftService.Model.Consultas;

namespace AutosoftService.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<EntradasArticulos> entradaArt { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Facturas> facturas { get; set; }
        public DbSet<FacturaD> facturaD { get; set; }
        public DbSet<Pedidos> pedidos { get; set; }
        public DbSet<PedidoD> pedidoD { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Vehiculos> vehiculos { get; set; }
        public DbSet<Pagos> pagos { get; set; }

        public DbSet<FacturasConsult> facturasConsults { get; set; }
        public DbSet<ArticulosConsult> articulosConsults { get; set; }
        public DbSet<PedidosConsult> pedidosConsults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlite(@"Data Source=Data\Autoservice10.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
             UsuarioId = 1,
                Nombre = "Emerson",
                Apellidos = "Del Orbe",
                 Email = "Emerson@gmail.com",
               Usuario = "Administrador",
               NivelUsuario = "Administrador",
               Contrasena = "Admin",
               ConfirmarContrasena = "Admin",
               FechaIngreso = DateTime.Now


           });
        }
    }
}
