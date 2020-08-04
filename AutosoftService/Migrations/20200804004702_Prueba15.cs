using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutosoftService.Migrations
{
    public partial class Prueba15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulosConsults",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true),
                    Proveedor = table.Column<string>(nullable: true),
                    Costo = table.Column<decimal>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    ValorInventario = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulosConsults", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "facturasConsults",
                columns: table => new
                {
                    FacturaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Servicios = table.Column<string>(nullable: true),
                    Cliente = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturasConsults", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "pedidosConsults",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Articulo = table.Column<string>(nullable: true),
                    Proveedor = table.Column<string>(nullable: true),
                    Subtotal = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidosConsults", x => x.PedidoId);
                });

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaIngreso",
                value: new DateTime(2020, 8, 3, 20, 47, 1, 294, DateTimeKind.Local).AddTicks(8722));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articulosConsults");

            migrationBuilder.DropTable(
                name: "facturasConsults");

            migrationBuilder.DropTable(
                name: "pedidosConsults");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaIngreso",
                value: new DateTime(2020, 8, 1, 0, 29, 34, 997, DateTimeKind.Local).AddTicks(3074));
        }
    }
}
