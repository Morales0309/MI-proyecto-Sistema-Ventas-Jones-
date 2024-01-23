using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaVentasJones.Server;
using SistemaVentasJones.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasJones.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        #region
        // Agregando los roles
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var roleAdmin = new IdentityRole()
            { Id = "89086180-b978-4f90-9dbd-a7040bc93f41", Name = "admin", NormalizedName = "admin" };

            var roleEmpleado = new IdentityRole()
            { Id = "65ade53a-ce03-411e-9d35-08fca7f47014", Name = "empleado", NormalizedName = "empleado" };

            modelBuilder.Entity<IdentityRole>().HasData(roleAdmin, roleEmpleado);

            // Especificar los tipos para las propiedades decimales
            modelBuilder.Entity<Caja>()
                .Property(c => c.Egresos)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Caja>()
                .Property(c => c.Ingresos)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Caja>()
                .Property(c => c.Saldo)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Retornos>()
                .Property(r => r.Precio)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Categoria> Categoria { get; set; }       
        public DbSet<Marcas> Marca { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Caja> Caja { get; set; }
        public DbSet<Retornos> Retornos { get; set; }
        public DbSet<Tamanios> Tamanios { get; set; }
    }
}
