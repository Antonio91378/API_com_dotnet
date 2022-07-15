using System.ComponentModel.DataAnnotations;

namespace MyFirstAPIWithAlura.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600)]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
    //Posso fazer coisas diferentes para cada ação, usando o padrão DTO
}