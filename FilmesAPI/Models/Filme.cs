using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [MaxLength(500)]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "A duração é obrigatória.")]
        [Range(30, 280, ErrorMessage = "A duração deve ser entre 30 minutos e 280 minutos.")]
        public String Duracao { get; set; }

        [Required(ErrorMessage = "O Genêro é obrigatório.")]
        public String Genero { get; set; }
    }
}
