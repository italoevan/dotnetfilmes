using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        this._context = context;
    }


    [HttpGet]
    public IEnumerable<Filme> Get([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Filmes.Skip(skip).Take(take);
    }


    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        var filme = filmeDto.ToFilme();
        _context.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetByid), new { id = filme.Id }, filme);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme=> filme.Id == id);

        if (filme == null) return NotFound();

        filme = filmeDto.ToFilme();
        _context.SaveChanges();

        return Ok(
            filme);
    }
    [HttpGet("{id}")]
    public IActionResult GetByid([FromRoute] int id)
    {

        var filme = _context.Filmes.FirstOrDefault(x => x.Id == id);

        if (filme != null)
        {
            return Ok(filme);
        }

        return NotFound($"{id}");


    }

}
