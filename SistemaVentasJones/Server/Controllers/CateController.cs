﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasJones.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasJones.Server;
using SistemaVentasJones.Server.Data;
using Microsoft.AspNetCore.Authorization;
using SistemaVentasJones.Client.Pages;

namespace SistemaVentasJones.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
    public class CateController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CateController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await context.Categoria.
                Where(x => x.Estado == true).
                ToListAsync();
        }
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Categoria>>> GetBajas()
        {
            return await context.Categoria.
                Where(x => x.Estado != true).
                ToListAsync();
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            return await context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Categoria>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Categoria>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Categoria
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Categoria categorias)
        {

            context.Add(categorias);
            await context.SaveChangesAsync();
            return categorias.Id;
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Categoria categoria)
        {
            context.Attach(categoria).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Categoria.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Categoria { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}