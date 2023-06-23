
using System;
using Paiol_EIBC.Models;
using  System.Collections.Generic;


public interface IMaterialDanificado
{
    List<MaterialDanificado> GetAll();
    MaterialDanificado GetId(int id);

    void Create(MaterialDanificado materialDanificado);

    void Update(MaterialDanificado materialDanificado);

    void Delete(MaterialDanificado materialDanificado);
}