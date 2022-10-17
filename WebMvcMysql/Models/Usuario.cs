using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvcMysql.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Idade")]
        [Column("Idade")]
        [Required(ErrorMessage = "Idade é obrigatória.")]
        public int Idade { get; set; }

        [Display(Name = "Posição")]
        [Column("Posicao")]
        [Required(ErrorMessage = "Posição é obrigatória.")]
        public string Posicao { get; set; }


        [Display(Name = "Salário")]
        [Column("Salario")]
        [Required(ErrorMessage = "Valor é obrigatório.")]
        [Range(0.01, 999999999, ErrorMessage = "Valor deve ser maior que 0. ")]
        public double Salario { get; set; }

    }
}
