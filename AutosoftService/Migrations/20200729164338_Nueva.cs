using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutosoftService.Migrations
{
    public partial class Nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true),
                    ProveedorId = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Ganancias = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "entradaArt",
                columns: table => new
                {
                    EntradasArtId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticuloId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entradaArt", x => x.EntradasArtId);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiculoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Servicios = table.Column<string>(nullable: true),
                    TipoPago = table.Column<bool>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Itbis = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    ProximoMantemiento = table.Column<DateTime>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(nullable: false),
                    MontoPago = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagos", x => x.PagoId);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticuloId = table.Column<int>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false),
                    Nota = table.Column<string>(nullable: true),
                    Subtotal = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    RNC = table.Column<string>(nullable: false),
                    CantidadPedidos = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 75, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    NivelUsuario = table.Column<string>(nullable: false),
                    Contrasena = table.Column<string>(maxLength: 30, nullable: false),
                    ConfirmarContrasena = table.Column<string>(maxLength: 30, nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(nullable: false),
                    TipoVehiculo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Año = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_vehiculos_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "facturaD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacturaId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Importe = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturaD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facturaD_facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "facturas",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidoD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoId = table.Column<int>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Unidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidoD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedidoD_pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "UsuarioId", "Apellidos", "ConfirmarContrasena", "Contrasena", "Email", "FechaIngreso", "NivelUsuario", "Nombre", "Usuario" },
                values: new object[] { 1, "Del Orbe", "Admin", "Admin", "Emerson@gmail.com", new DateTime(2020, 7, 29, 12, 43, 37, 379, DateTimeKind.Local).AddTicks(3386), "Administrador", "Emerson", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_facturaD_FacturaId",
                table: "facturaD",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidoD_PedidoId",
                table: "pedidoD",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_ClienteId",
                table: "vehiculos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articulos");

            migrationBuilder.DropTable(
                name: "entradaArt");

            migrationBuilder.DropTable(
                name: "facturaD");

            migrationBuilder.DropTable(
                name: "pagos");

            migrationBuilder.DropTable(
                name: "pedidoD");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
