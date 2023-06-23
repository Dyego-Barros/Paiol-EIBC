using Paiol_EIBC.Models;

namespace Paiol_EIBC.Repositories.Interfaces;

    public interface ICateutelaDevolvida
    {
        List<CautelaDevolvida> GetALL();
         CautelaDevolvida GetId(int id);
        void Create(CautelaDevolvida devolvida);

        void Update(CautelaDevolvida devolvida);

        void Delete(int id, CautelaDevolvida devolvida);
    }

