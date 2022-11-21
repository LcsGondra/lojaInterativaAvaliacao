using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaInterativaAval.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Id")]
        [Required]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }
        [Column("Fabricante")]
        [Display(Name = "Fabricante")]
        [Required]
        public string Fabricante { get; set; }
        [Column("Categoria")]
        [Display(Name = "Categoria")]
        [Required]
        public string Categoria { get; set; }
        [Column("Preco")]
        [Display(Name = "Preco")]
        [Required]
        public int Preco { get; set; }
    }
}
