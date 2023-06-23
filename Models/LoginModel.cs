using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Paiol_EIBC;

namespace Paiol_EIBC.Models;

[Table("Users")]
public class Login{

    [Key]
    public int id {get; set;}

    [Required(ErrorMessage ="Este campo é Obrigatório!")]
   
    [Column("posto_graduacao")]
    public string posto_graduacao   {get; set;}

   [Required(ErrorMessage ="Este campo é Obrigatório!")]
    [Column("nip")]
    public string nip {get;set;}

   [Required(ErrorMessage ="Este campo é Obrigatório!")]
    [Column("nome_guerra")]
    public string nome_guerra {get;set;}

   [Required(ErrorMessage ="Este campo é Obrigatório!")]
    [Column("password")]
    public string password {get; set;}

}