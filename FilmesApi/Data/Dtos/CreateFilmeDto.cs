using FilmesApi.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {


        [Required(ErrorMessage = "O título deve ser obrigatório")]
        [StringLength(50, ErrorMessage = "Tamanho máximo de 50 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O Genero deve ser obrigatório")]

        public string Genero { get; set; }

        [Required(ErrorMessage = "O Duracao deve ser obrigatório")]

        public int Duracao { get; set; }

       public Filme ToFilme()
        {
            return new Filme { Title = Title,Genero = Genero, Duracao= Duracao };
        }

    }
}
