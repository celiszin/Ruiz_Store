using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ruiz_Store.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }  

    [Required(ErrorMessage = "Por favor, informe o nome" )]
    [StringLength(30, ErrorMessage = "O nome dever possuir no máximo 30 caracteres")]
    public string Nome { get; set; } 

    [StringLength(300)]
    public string Foto  { get; set; } 
}
