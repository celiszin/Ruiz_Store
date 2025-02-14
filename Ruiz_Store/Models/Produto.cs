using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruiz_Store.Models;

    [Table("produto")]
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Por favor, informe a categoria")]
        public int CategoriaId { get; set; }
        [ForeignKey ("Categoria")]
        public Categoria Categoria { get; set; }


        [Required(ErrorMessage = "Por favor, informe p nome")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(1000, ErrorMessage = "Por favor, informe a descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Por favor, informe a quantidade em estoque")]
        public int QtdeEstoque { get; set; } = 0;

        [Required(ErrorMessage =  "Por favor, informe o valor do custo")]
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorVenda { get; set; }
    }