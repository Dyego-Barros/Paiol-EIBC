using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Paiol_EIBC;



namespace Paiol_EIBC.Models;

[Table("cautelaDevolvida")]
public class CautelaDevolvida {
        [Key]
        public int id {get;set;}
        [Column("OM")]
        public string ?OM {get;set;}
        [Column("missao")]
        public string ?missao {get;set;}

        [Column("secao")]
        public string ?secao {get;set;}

        [Column("contato")]
        public string ?contato {get;set;}
  [Column("item01")]
        public string  ?item01 {get;set;}
        [Column("qtd01")]
        public int  ?qtd01 {get;set;}
        [Column("item02")]
        public string ? item02 {get;set;}

        [Column("qtd02")]
        public int  ?qtd02 {get;set;}


        [Column("item03")]
        public string  ?item03 {get;set;}
        [Column("qtd03")]
        public int  ?qtd03 {get;set;}

        [Column("item04")]
        public string  ?item04 {get;set;}

        [Column("qtd04")]
        public int ? qtd04 {get;set;}
        [Column("item05")]
        public string  ?item05 {get;set;}
        [Column("qtd05")]
        public int  ?qtd05 {get;set;}

        [Column("item06")]
        public string ? item06 {get;set;}

        [Column("qtd06")]
        public int ? qtd06 {get;set;}
        [Column("item07")]
        public string  ?item07 {get;set;}

        [Column("qtd07")]
        public int  ?qtd07 {get;set;}
        [Column("item08")]
        public string ? item08 {get;set;}
        [Column("qtd08")]
        public int  ?qtd08 {get;set;}
        [Column("item09")]
        public string  ?item09 {get;set;}
        [Column("qtd09")]
        public int  ?qtd09 {get;set;}
        [Column("item10")]
        public string ?item10 {get;set;}
        [Column("qtd10")]
        public int ? qtd10 {get;set;}
        [Column("item11")]
        public string  ?item11 {get;set;}
        [Column("qtd11")]
        public int  ?qtd11 {get;set;}
        [Column("item12")]
        public string  ?item12 {get;set;}

        [Column("qtd12")]
        public int  ?qtd12 {get;set;}


        [Column("item13")]
        public string  ?item13 {get;set;}
        [Column("qtd13")]
        public int  ?qtd13 {get;set;}

        [Column("item14")]
        public string  ?item14 {get;set;}

        [Column("qtd14")]
        public int  ?qtd14 {get;set;}

        [Column("item15")]
        public string  ?item15 {get;set;}
        [Column("qtd15")]
        public int ?qtd15 {get;set;}

        [Column("item16")]
        public string  ?item16 {get;set;}
        [Column("qtd16")]
        public int ?qtd16 {get;set;}


        [Column("item17")]
        public string  ?item17 {get;set;}
        [Column("qtd17")]
        public int  ?qtd17 {get;set;}

        [Column("item18")]
        public string  ?item18 {get;set;}
        [Column("qtd18")]
        public int  ?qtd18 {get;set;}

        [Column("item19")]
        public string  ?item19 {get;set;}
        [Column("qtd19")]
        public int  ?qtd19 {get;set;}

        [Column("item20")]
        public string  ?item20 {get;set;}
        [Column("qtd20")]
        public int  ?qtd20 {get;set;}

        [Column("item21")]
        public string  ?item21 {get;set;}
        [Column("qtd21")]
        public int  ?qtd21 {get;set;}

        [Column("item22")]
        public string  ?item22 {get;set;}
        [Column("qtd22")]
        public int  ?qtd22 {get;set;}

        [Column("item23")]
        public string  ?item23 {get;set;}
        [Column("qtd23")]
        public int  ?qtd23 {get;set;}

        [Column("item24")]
        public string  ?item24 {get;set;}
        [Column("qtd24")]
        public int ? qtd24 {get;set;}

        [Column("item25")]
        public string ?item25 {get;set;}
        [Column("qtd25")]
        public int ? qtd25 {get;set;}

        [Column("item26")]
        public string  ?item26 {get;set;}
        [Column("qtd26")]
        public int ? qtd26 {get;set;}

        [Column("item27")]
        public string  ?item27 {get;set;}
        [Column("qtd27")]
        public int  ?qtd27 {get;set;}

        [Column("item28")]
        public string ? item28 {get;set;}
        [Column("qtd28")]
        public int ? qtd28 {get;set;}

        [Column("item29")]
        public string  ?item29 {get;set;}
        [Column("qtd29")]
        public int  ?qtd29 {get;set;}

        [Column("item30")]
        public string ? item30 {get;set;}
        [Column("qtd30")]
        public int  ? qtd30 {get;set;}

        [Column("item31")]
        public string ? item31 {get;set;}
        [Column("qtd31")]
        public int ? qtd31 {get;set;}

        [Column("item32")]
        public string  ?item32 {get;set;}
        [Column("qtd32")]
        public int ? qtd32 {get;set;}


        [Column("item33")]
        public string ? item33 {get;set;}
        [Column("qtd33")]
        public int ? qtd33 {get;set;}


        [Column("item34")]
        public string ? item34 {get;set;}
        [Column("qtd34")]
        public int ? qtd34 {get;set;}

        [Column("item35")]
        public string ? item35 {get;set;}
        [Column("qtd35")]
        public int ? qtd35 {get;set;}


        [Column("item36")]
        public string  ?item36 {get;set;}
        [Column("qtd36")]
        public int ? qtd36 {get;set;}

        [Column("item37")]
        public string ? item37 {get;set;}
        [Column("qtd37")]
        public int ? qtd37 {get;set;}

        [Column("item38")]
        public string  ?item38 {get;set;}
        [Column("qtd38")]
        public int ? qtd38 {get;set;}

        [Column("item39")]
        public string  ?item39 {get;set;}
        [Column("qtd39")]
        public int ? qtd39 {get;set;}

        [Column("item40")]
        public string ? item40 {get;set;}
        [Column("qtd40")]
        public int ? qtd40 {get;set;}

        [Column("item41")]
        public string ? item41 {get;set;}
        [Column("qtd41")]
        public int ? qtd41 {get;set;}

        [Column("item42")]
        public string  ? item42 {get;set;}
        [Column("qtd42")]
        public int ? qtd42 {get;set;}

        [Column("observacao")]
        public string ?observacao {get;set;}
        [Column("militar_devolvedor")]
        public string ?militar_devolvedor {get;set;}
        [Column("paioleiro_rebedor")]
        public string ?paioleiro_recebedor {get;set;}
        [Column("data_entrada")]
        public DateTime ?data_entrada {get;set;}
        [Column("ano")]
        public DateTime ?ano {get;set;} 

        [Column("status_devolucao")]
        public string ?status_devolucao {get;set;}

}