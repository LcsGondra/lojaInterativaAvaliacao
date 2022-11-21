using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaInterativaAval.Models
{
    [Table("Fabricante")]
    public class Fabricante
    {
        [Column("Id")]
        [Display(Name = "Id")]
        [Required]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }
        [Column("Categoria1")]
        [Display(Name = "Categoria 1")]
        [Required]
        public string Categoria1 { get; set; }
        [Column("Categoria2")]
        [Display(Name = "Categoria 2")]
        public string Categoria2 { get; set; }
        [Column("Categoria3")]
        [Display(Name = "Categoria 3")]
        public string Categoria3 { get; set; }
    }
}
