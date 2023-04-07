using System.ComponentModel.DataAnnotations;
using FilmesApi.Models;

namespace FilmesApi.Data.Dtos.CinemaDto
{
    public class CreateCinemaDto
    {

        [Required(ErrorMessage = "O campo de nome é obrigatorio")]

        public string Nome { get; set; }

        public Cinema ToCinema()
        {
            return new Cinema() {
                Nome = this.Nome;
            };
        }
    }
}
