using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piloto.Entities;

namespace Piloto.Controllers
{
    [Route("api/Prueba")]
    public class PruebaController : Controller
    {
        [HttpGet]
        public IEnumerable<Persona> GetPersonas()
        {
            return new List<Persona>() { new Persona() { Nombre = "Majo", Id = 1, FechaNacimiento = new DateTime(1994,3,4) }
        };

        }
    }
}