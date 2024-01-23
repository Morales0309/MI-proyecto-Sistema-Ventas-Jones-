using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasJones.Server.Migrations
{
    public partial class NuevaDos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Tallas_TallasId",
                table: "Articulos");

            migrationBuilder.DropTable(
                name: "Tallas");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_TallasId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "TallasId",
                table: "Articulos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "d2ad5acc-4b64-4beb-a9d4-ad608e8bc7e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "bed0405c-0160-4bfa-a653-f570f363a05a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TallasId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tallas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tallas", x => x.Id);
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
                name: "IX_Articulos_TallasId",
                table: "Articulos",
                column: "TallasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Tallas_TallasId",
                table: "Articulos",
                column: "TallasId",
                principalTable: "Tallas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
