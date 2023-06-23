using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paiol_EIBC.Models;

namespace Paiol_EIBC.Repositories.Interfaces
{
    public interface IMaterial
    {
        List<Material> GetAll();
         Material GetId(int id);

         void Create(Material material);

         void Update(int id, Material material);

         void Delete(int id, Material material);
        
    }
}