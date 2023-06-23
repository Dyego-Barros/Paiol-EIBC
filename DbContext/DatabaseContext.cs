using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Paiol_EIBC.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
    {

    }



    public DbSet<Login> logins {get;set;}
    public DbSet<Cautela> cautelas {get;set;}
    public DbSet<Material> materiais {get;set;}
    public DbSet<CautelaDevolvida> cautelaDevolvidas{get;set;}
    public DbSet<MaterialDanificado> materialDanificados{get;set;}

}