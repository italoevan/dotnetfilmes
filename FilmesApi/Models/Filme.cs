﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título deve ser obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O Genero deve ser obrigatório")]

        public string Genero { get; set; }

        [Required(ErrorMessage = "O Duracao deve ser obrigatório")]

        public int Duracao { get; set; }

     

    }
}
