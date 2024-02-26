using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moura01.models
{
    [Table(name:"pessoas")]
    public class Pessoa
    {
        [Key]
        [Column( name:"codigo" )]
        [Required]
        public int Codigo { get; set; }

        [Required]
        [Column(name: "nome")]
        [StringLength(50)]
        public string? Nome { get; set; }

        [Required]
        [Column(name: "datanascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Column(name:"inativo")]
        public bool Inativo { get; set; }

        [Required]
        [Column(name:"nacionalidade")]
        public int Nacionalidade { get; set; }

        [Column(name:"rg")]
        [StringLength(20)]
        public string? RG { get; set; }

        [Column(name:"passaporte")]
        [StringLength(20)]
        public string? Passaporte { get; set; }
    }
}
