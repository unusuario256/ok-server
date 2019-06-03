﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servidor.Datos;
using Servidor.Transbank.Models;

namespace Servidor.Transbank.Controllers
{
    [Produces("application/json")]
    [Route("tbk/MedioPago")]
    public class MedioPagoController : Controller
    {
        //GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ConexionOracle.GetAll<MedioPago>());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(ConexionOracle.Get<MedioPago>(id));
        }
        //POST
        [HttpPost]
        public IActionResult Post([FromBody]String nombre)
        {
            var m = new MedioPago
            {
                Nombre = nombre
            };
            if (ConexionOracle.Insert(m))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ConexionOracle.Delete(new MedioPago { Id_medio = id }))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}