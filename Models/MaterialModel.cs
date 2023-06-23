using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Paiol_EIBC;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;



namespace Paiol_EIBC.Models;

[Table("Material")]
public class Material{

    [Key]
     public  int id {get;set;}


[Required(ErrorMessage ="Este campo é obrigatório!")]
    [Column("nome_material")]
    
     public string nome_material {get;set;}  


[Required(ErrorMessage ="Este campo é obrigatório!")]   
     [Column("quantidade")]       
     public int quantidade {get;set;}
}