using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class FilmeController
{
    [HttpGet]
    public string Get()
    {
        return "Meu filme";
    }

}
