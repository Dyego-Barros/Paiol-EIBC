using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paiol_EIBC.Repositories.Interfaces;
using Paiol_EIBC.Models;

namespace Paiol_EIBC;



    public class MaterialService : IMaterial
    {

        private readonly DatabaseContext _context;


        public MaterialService(DatabaseContext context)
        {
            _context = context;
        }
        public void Create(Material material)
        {
            if(material != null)
            {
                var create = _context.materiais.Add(material);
                _context.SaveChanges();

            }else{
                throw new Exception("Error ao tentar Salvar Material!");
            }
        }

        public void Delete(int id, Material material)
        {
            if(id == material.id)
            {
                var deleteMaterial = _context.materiais.Remove(material);
                _context.SaveChanges();

            }else
            {
                throw new Exception("Error ao deletar Material!");
            }
        }

        public List<Material> GetAll()
        {
           var listMaterial = _context.materiais.ToList();
           return listMaterial;
        }

        public Material GetId(int id)
        {
            if(id != null)
            {
                var getMaterial = _context.materiais.Find(id);
                return getMaterial;
            }else
            {
                throw new Exception("Error Buscar Material!");
            }
        }

        public void Update(int id, Material material)
        {
           if(id == material.id)
           {
            _context.materiais.Update(material);
            _context.SaveChanges();

           }else
           {
                 throw new Exception("Error Editar Material!");
           }
        }
    }
