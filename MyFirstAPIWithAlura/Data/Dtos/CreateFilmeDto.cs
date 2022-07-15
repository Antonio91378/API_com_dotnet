using System.ComponentModel.DataAnnotations;

namespace MyFirstAPIWithAlura.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600)]
        public int Duracao { get; set; }
    }
}