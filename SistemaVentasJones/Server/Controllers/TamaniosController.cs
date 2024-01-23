using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasJones.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasJones.Server;
using SistemaVentasJones.Server.Data;
using Microsoft.AspNetCore.Authorization;

namespace SistemaVentasJones.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
    public class TamaniosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public TamaniosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tamanios>>> Get()
        {
            return await context.Tamanios
                 .Where(x => x.Estado == true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tamanios>>> GetBajas()
        {
            return await context.Tamanios
                 .Where(x => x.Estado == false)
                .ToListAsync();
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Tamanios>> Get(int id)
        {
            return await context.Tamanios.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tamanios>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Tamanios>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Tamanios
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Tamanios Tamanios)
        {

            context.Add(Tamanios);
            await context.SaveChangesAsync();
            return Tamanios.Id;
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Tamanios Tamanios)
        {
            context.Attach(Tamanios).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Tamanios.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Tamanios { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}