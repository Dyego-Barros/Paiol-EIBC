using Paiol_EIBC.Models;

namespace Paiol_EIBC.Repositories.Interfaces;
public interface ICautela{
     
     List<Cautela> Getall();
     Cautela GteId(int id);

     void Create(Cautela cautela);

     void Update(Cautela cautela);

     void Delete(Cautela cautela);
}