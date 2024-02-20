using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasJones.Server.Migrations
{
    public partial class agregandoCiudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Proveedores",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Clientes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "c52b835b-a790-44d2-bf70-475f760aaa84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "5315504b-171e-4dc6-bc9b-5570def5a054");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Clientes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "ff0da501-6f7c-44b4-9f24-6d7949fa4de8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "0b435f7a-c64d-4627-9c28-f6f67ff8eb1e");
        }
    }
}
