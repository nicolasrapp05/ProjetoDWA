using System.ComponentModel.DataAnnotations;

namespace ProjetoDWA.Models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O máximo é de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O máximo é de 50 caracteres")]
        public string Tipo { get; set; }
    }
}