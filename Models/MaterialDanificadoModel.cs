using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Paiol_EIBC;


namespace Paiol_EIBC.Models;

[Table("materialDanificado")]
public class MaterialDanificado{
    [Key]
    public int id {get;set;}

    [Column("material")]
    public string material {get; set;}

    [Column("observacao")]

    public string observacao {get;set;}

    [Column("qtd")]
    public int qtd {get;set;}
}