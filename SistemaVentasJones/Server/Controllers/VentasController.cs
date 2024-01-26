using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasJones.Server.Common;
using SistemaVentasJones.Server.Controllers;
using SistemaVentasJones.Server.Data;
using SistemaVentasJones.Shared;
using System.Security.Cryptography.X509Certificates;
using IdentityServer4.Extensions;

namespace SistemaVentasJones.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin, empleado")]
    public class VentasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public VentasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/ventas
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Venta>>> Get()
        {
            return await context.Ventas.Include(x => x.Cliente)
                .Include(x => x.ApplicationUser)
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo)
                .ToListAsync();
        }

        //GET: api/ventas/filtro/cliente&empleado&fecha
        [HttpGet("filtro")]
        [AllowAnonymous]
        // public async Task<ActionResult<List<Venta>>> Get([FromQuery] string empleado, [FromQuery] datetime fecha)
        public async Task<ActionResult<List<Venta>>> Get([FromQuery] string empleado, [FromQuery] string fecha) // para que funcione en rider
        {
            DateTime f = Convert.ToDateTime(fecha);

            var queryable = context.Ventas
                .Include(x => x.Cliente)
                .Include(x => x.ApplicationUser)
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo).AsQueryable();

            if (!string.IsNullOrEmpty(empleado))
            {
                queryable = queryable.Where(x => x.ApplicationUser.NombreyApellido.Contains(empleado));
            }
            if (f != DateTime.Today.AddDays(+1))
            {
                queryable = queryable.Where(x => x.Fecha.Day == f.Day &&
                                            x.Fecha.Month == f.Month &&
                                            x.Fecha.Year == f.Year);
            }
            return await queryable.OrderByDescending(x => x.Fecha).ToListAsync();
        }

        // GET: api/ventas/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Venta>> Get(int id)
        {
            return await context.Ventas.Include(x => x.Cliente)
                .Include(x => x.ApplicationUser)
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo)
                .FirstAsync(x => x.Id == id);
        }












        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Venta venta, [FromServices] ITasaCambioService tasaCambioService)
        {
            try
            {
                var userid = User.GetUserId();
                venta.EmpleadoId = userid;
                venta.Fecha = DateTime.Now;

                // Obtener la tasa de cambio desde el servicio
                venta.TasaCambio = await tasaCambioService.ObtenerTasaCambio();
                //  calcular el valor en dolares
                venta.TotalDolares = venta.Total / venta.TasaCambio;

                Console.WriteLine($"Tasa de Cambio para la Venta #{venta.Numero}: {venta.TasaCambio}");

                if (context.Ventas.IsNullOrEmpty())
                {
                    venta.Numero = 1;
                }
                else
                {
                    venta.Numero = context.Ventas.Max(x => x.Numero + 1);
                }

                Console.WriteLine($"En dólares: {venta.TasaCambio}");
                Console.WriteLine($"Número de la Venta: {venta.Numero}");

                context.Ventas.Add(venta);

                await context.SaveChangesAsync();

                await GuardarEnCaja(venta);
                await DecrementaStock(venta);

                Console.WriteLine("Venta creada exitosamente.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la venta: {ex.Message}");
                if (ex is DbUpdateException)
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }            
        }

            return venta.Id;
        }





























        // DELETE: api/ventas/5  
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Venta>> Delete(int id)
        {
            var venta = await context.Ventas.Include(x => x.DetalleVentas)
                .FirstAsync(x => x.Id == id);

            if (venta != null)
            {
                await IncrementaStock(venta);

                context.Ventas.Remove(venta);
                await context.SaveChangesAsync();

                return venta;
            }
            else
            {
                return NotFound();
            }
        }

        private bool Exists(int id)
        {
            return context.Ventas.Any(e => e.Id == id);

        }
        private async Task DecrementaStock(Venta venta)
        {
            var lista_articulo = await context.Articulos.ToListAsync();
            ArticulosController articulos = new ArticulosController(context);

            foreach (var detalle in venta.DetalleVentas)
            {
                var articulo = lista_articulo.First(x => x.Id == detalle.ArticuloId);
                articulo.StockActual = articulo.StockActual - detalle.Cantidad;
                await articulos.Put(articulo);
            }
        }

        private async Task IncrementaStock(Venta venta)
        {
            var lista_articulo = await context.Articulos.ToListAsync();

            ArticulosController articulos = new ArticulosController(context);
            foreach (var detalle in venta.DetalleVentas)
            {
                var articulo = lista_articulo.First(x => x.Id == detalle.ArticuloId);
                articulo.StockActual = articulo.StockActual + detalle.Cantidad;
                await articulos.Put(articulo);
            }
        }

        private async Task GuardarEnCaja(Venta venta)
        {
            CajaController cajaController = new CajaController(context);
            Caja cajas = new Caja()
            {
                // campo de caja |||| campo de venta correspondiente
                IdVenta = venta.Id,
                Fecha = venta.Fecha,
                Ingresos = Convert.ToDecimal(venta.Total),
            };
            await cajaController.Post(cajas);
        }
    }
}