using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasJones.Server.Migrations
{
    public partial class Nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devoluciones");

            migrationBuilder.AddColumn<int>(
                name: "TamanioId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TamaniosId",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Retornos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    DetalleVentaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retornos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retornos_DetalleVentas_DetalleVentaId",
                        column: x => x.DetalleVentaId,
                        principalTable: "DetalleVentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tamanios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "0e2046ff-a0d7-422c-8e12-1d1a2e03186c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "56a32da5-7f52-467f-ab74-add37c7051fe");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_TamaniosId",
                table: "Articulos",
                column: "TamaniosId");

            migrationBuilder.CreateIndex(
                name: "IX_Retornos_DetalleVentaId",
                table: "Retornos",
                column: "DetalleVentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Tamanios_TamaniosId",
                table: "Articulos",
                column: "TamaniosId",
                principalTable: "Tamanios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Tamanios_TamaniosId",
                table: "Articulos");

            migrationBuilder.DropTable(
                name: "Retornos");

            migrationBuilder.DropTable(
                name: "Tamanios");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_TamaniosId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "TamanioId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "TamaniosId",
                table: "Articulos");

            migrationBuilder.CreateTable(
                name: "Devoluciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleVentaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "0459ad1c-c94c-4657-b117-5e3bb9605eb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "5b851d3e-ce3b-4931-932c-af000ee820d7");
        }
    }
}
