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
    public class UsuariosController : ControllerBase
    {
        ApplicationUser objUsers = new ApplicationUser();
        private readonly ApplicationDbContext context;
        public UsuariosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<ApplicationUser>>> Get()
        {
            //return await context.Marca.ToListAsync();
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ApplicationUser>> Get(string id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        //[HttpGet("buscar/{textoBusqueda}")]
        //[AllowAnonymous]
        //public async Task<ActionResult<List<ApplicationUser>>> Get(string textoBusqueda)
        //{
        //    if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<ApplicationUser>(); }
        //    textoBusqueda = textoBusqueda.ToLower();
        //    return await context.Users
        //    .Where(x => x.NombreyApellido.ToLower().Contains(textoBusqueda)).ToListAsync();
        //}
        // post
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<string>> Post(ApplicationUser applicationUser)
        {
            context.Add(applicationUser);
            await context.SaveChangesAsync();
            return applicationUser.Id;
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Put(string id, ApplicationUser updatedUser)
        {
            if (id != updatedUser.Id)
            {
                return BadRequest("El ID proporcionado en la URL no coincide con el ID del usuario.");
            }

            context.Entry(updatedUser).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return NoContent();
        }


        private bool UsuarioExists(Guid id)
        {
            return context.Users.Any(e => e.Id.Equals(id));
        }



    }
}