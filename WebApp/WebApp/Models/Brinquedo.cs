using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

[Table("TDS_TB_BRINQUEDOS")]
public class Brinquedo
{
    [Key]
    [Column("ID_BRINQUEDO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdBrinquedo { get; set; }

    [Required, StringLength(100)]
    [Column("NOME_BRINQUEDO")]
    public string NomeBrinquedo { get; set; } = string.Empty;

    [Required, StringLength(60)]
    [Column("TIPO_BRINQUEDO")]
    public string TipoBrinquedo { get; set; } = string.Empty;

    [Required, StringLength(30)]
    [Column("CLASSIFICACAO")]
    public string Classificacao { get; set; } = string.Empty;

    [Required, StringLength(30)]
    [Column("TAMANHO")]
    public string Tamanho { get; set; } = string.Empty;

    [Column("PRECO"), Precision(10, 2)]
    [Range(0, 9999999999.99)]
    public decimal Preco { get; set; }
}
