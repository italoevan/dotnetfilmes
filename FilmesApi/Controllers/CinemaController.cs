using FilmesApi.Data;
using FilmesApi.Data.Dtos.CinemaDto;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    public class CinemaController : ControllerBase
    {

        public CinemaController(FilmeContext context) {
            this._context = context;
        }

        private FilmeContext _context;


        [HttpPost]
        public IActionResult AdicionarCinema([FromBody] CreateCinemaDto dto)
        {
            var cinema = _context.Cinemas.Add(dto.ToCinema());

            return Ok(cinema);
        }

        [HttpGet]
        public IEnumerable<Cinema> GetCinemas() {

            return _context.Cinemas;
        }

    }
}
