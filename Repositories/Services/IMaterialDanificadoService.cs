using System;
using Paiol_EIBC.Models;

namespace Paiol_EIBC;

public class MaterialDanificadoService : IMaterialDanificado
{
    private readonly DatabaseContext _context;
    public MaterialDanificadoService(DatabaseContext context)
    {
        _context = context;

    }
    public void Create(MaterialDanificado materialDanificado)
    {
        if(materialDanificado != null){
            _context.materialDanificados.Add(materialDanificado);
            _context.SaveChanges();
        }else{
            throw new Exception("Error ao Criar Material Danificado!");
        }
    }

    public void Delete(MaterialDanificado materialDanificado)
    {
       if(materialDanificado != null)
       {
            _context.materialDanificados.Remove(materialDanificado);
            _context.SaveChanges();
       }else
       {
        throw new Exception("Error ao deletar Material Danificado!");
       }
    }

    public List<MaterialDanificado> GetAll()
    {
        var listMaterialDanificado = _context.materialDanificados.ToList();
        return listMaterialDanificado;
    }

    public MaterialDanificado GetId(int id)
    {
        var materialDanificado = _context.materialDanificados.Find(id);
        return materialDanificado;
    }

    public void Update(MaterialDanificado materialDanificado)
    {
        if(materialDanificado != null)
        {
            _context.materialDanificados.Update(materialDanificado);
            _context.SaveChanges();

        }else{
            throw new Exception("Error ao atualizar Material Danificado!");
        }
    }
}