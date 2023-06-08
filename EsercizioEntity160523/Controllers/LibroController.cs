using EsercizioEntity160523.DB;
using EsercizioEntity160523.DB.Entities;
using EsercizioEntity160523.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EsercizioEntity160523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly RepositoryLibro repository;

        public LibroController(RepositoryLibro repository)
        {
            this.repository = repository;
        }

        [HttpPost("InsertLibro")]
        public async Task<IActionResult> InsertLibro([FromBody] LibreriaModel model)
        {
            Libro libro = new Libro();
            libro.Nome = model.NomeL;
            libro.NumeroPagine = model.NumeroDiPagine;
            libro.NomeA = model.NomeA;
            this.repository.InsertLibri(libro);
            return Ok(200);
        }

        [HttpGet("GetLibro")]
        public async Task<Libro> GetLibro()
        {
           
            
            Libro libro = new Libro()
            {
                IDLibro = System.Guid.NewGuid(),
                Nome = "pipo",
                NumeroPagine = 100,
                NomeA = "Maria"

            };
            return libro;
        }
    }
}
