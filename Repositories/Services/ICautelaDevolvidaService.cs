using Paiol_EIBC.Repositories.Interfaces;
using Paiol_EIBC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Paiol_EIBC.Repositories.Services
{
 
    public class CautelaDevolvidaService : ICateutelaDevolvida
    {
        private readonly DatabaseContext _context;
        public CautelaDevolvidaService(DatabaseContext context)
        {
            _context = context;

        }
        public void Create(CautelaDevolvida devolvida)
        {
            if(devolvida != null)
            {
                _context.cautelaDevolvidas.Add(devolvida);
                _context.SaveChanges();
            }else
            {
                throw new Exception("Error ao Cadastrar Devolução de Material");
            }
        }

        public void Delete(int id, CautelaDevolvida devolvida)
        {
            if(id == devolvida.id)
            {
                _context.cautelaDevolvidas.Remove(devolvida);
                _context.SaveChanges();

            }
            else
            {
                throw new Exception("Error ao Deletar Material Envolvido");
            }
        }

        public List<CautelaDevolvida> GetALL()
        {
            var list = _context.cautelaDevolvidas.ToList();
            return list;
        }

        public CautelaDevolvida GetId(int id)
        {
            if(id != null)
            {

                return _context.cautelaDevolvidas.Find(id);
            }else
            {
                throw new Exception("Error ao Buscar Material Envolvido");
            }
        }

        public void Update(CautelaDevolvida devolvida)
        {
            if(devolvida != null)
            {
                _context.cautelaDevolvidas.Update(devolvida);
                _context.SaveChanges();

            }
            else
            {
                throw new Exception("Error ao Buscar Material Envolvido");
            }
        }
    }
}
