using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasJones.Server.Migrations
{
    public partial class agregandopreciodolares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Moneda",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioDolar",
                table: "DetalleVentas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "d19808c8-c9c7-4193-8d94-400c50f390ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "4290bfaf-0dc7-4267-a46b-8a864360f3ea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moneda",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "PrecioDolar",
                table: "DetalleVentas");

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
    }
}
