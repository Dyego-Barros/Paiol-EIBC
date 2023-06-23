using System;
using Paiol_EIBC.Models;
using Paiol_EIBC.Repositories;
using Paiol_EIBC.Repositories.Interfaces;

namespace Paiol_EIBC;

public class CautelaService : ICautela
{

    private readonly DatabaseContext _context;

    public CautelaService(DatabaseContext context)
    {
        _context = context;
    }
    public void Create(Cautela cautela)
    {
       if(cautela != null)
       {

        var createCautela  = _context.Add(cautela);
        _context.SaveChanges();

       }else{
        throw new Exception("Error ao Cadastrar Cautela no Sistema");
       }
    }

    public void Delete(Cautela cautela)
    {
        if(cautela != null)
        {
            var deleteCautela = _context.cautelas.Remove(cautela);
            _context.SaveChanges();
        }else{
            throw new Exception("Error ao Excluir Cautela do Banco de dados!");
        }
    }

    public List<Cautela> Getall()
    {
        var cautelaAll = _context.cautelas.ToList();
        return cautelaAll;
    }

    public Cautela GteId(int id)
    {
       if(id != null)
       {
        var getCautela = _context.cautelas.Find(id);
        return getCautela;

       }else{
         throw new Exception("Error nao consultar Cautela na Base de dados!");
       }
    }

    public void Update(Cautela cautela)
    {
        if(cautela != null)
        {
            var updateCautela = _context.cautelas.Update(cautela);
            _context.SaveChanges();
        }else{
            throw new Exception("Error ao Atualizar Cautela!");
        }
    }
}