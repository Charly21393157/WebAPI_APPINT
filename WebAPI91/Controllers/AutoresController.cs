﻿using Domain.DTO;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

using WebAPI_APPINT.Services.Interfaces;

namespace WebAPI_APPINT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorServices _autorServices;
        public AutoresController(IAutorServices autorServices)
        {
            _autorServices = autorServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAutores()
        {
            var result = await _autorServices.GetAutores();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CrearAutor([FromBody] AutorResponsive request)
        {
            var result = await _autorServices.Crear(request);
            return Ok(result);
        }
    }
}
