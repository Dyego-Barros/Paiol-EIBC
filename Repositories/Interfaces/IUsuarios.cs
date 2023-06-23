using System.Linq;
using System.Collections.Generic;
using Paiol_EIBC.Models;



namespace Paiol_EIBC;
public interface Usuario
{

    List<Login> GetAll();

    Login GetId(int id);

    void Create(Login login);
    void Update(int id, Login login);
    void Delete(int id, Login login);


}