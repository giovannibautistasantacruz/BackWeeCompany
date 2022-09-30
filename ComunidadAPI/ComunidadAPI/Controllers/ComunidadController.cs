using ComunidadAPI.Entities;
using Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComunidadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComunidadController : ControllerBase
    {
        private ComunidadContext _context;

        public ComunidadController(ComunidadContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Personas> GetPersonas() => _context.Personas.ToList();

        [HttpPost]
        [EnableCors]
        public IActionResult CreatePerson(Persona persona)
        {
            Personas personas = new Personas();
            personas.Nombre = persona.Nombre;
            personas.Email = persona.Email;
            personas.Telefono = persona.Telefono;
            personas.Empresa = persona.Empresa;

            _context.Personas.Add(personas);
            _context.SaveChanges();
            Response res = new Response();
            res.Mensaje = "Persona Agregada con exito.";
            return Ok(res);
        }
    }
}
