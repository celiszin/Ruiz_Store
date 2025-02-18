using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruiz_Store.Models;

    [Table("produto_foto")]
    public class ProdutoFoto
    {
    [Key]
     public int Id { get; set; }

     [Display (Name = "Produto")]
     [Required(ErrorMessage = "Por favor, informe o produto")]
     public int ProdutoId { get; set; }
     [ForeignKey("ProdutoId")]
     public int Produto { get; set; }   

     [Display (Name = "Foto")]
     [StringLength(200)]
     [Required(ErrorMessage = "Por favor, informe a foto")]
     public string ArquivoFoto { get; set; }

     [Display(Name = "Descrição")]
     [StringLength (100, ErrorMessage = "A descrição deve possuir noo máximo 100 caracteres")]
     public string Descricao { get; set; }
    }