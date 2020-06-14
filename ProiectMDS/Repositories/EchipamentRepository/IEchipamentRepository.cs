using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.EchipamentRepository
{
    public interface IEchipamentRepository
    {
        List<Echipament> GetAll();
        Echipament Get(int Id);
        Echipament Create(Echipament Echipament);
        Echipament Update(Echipament Echipament);
        Echipament Delete(Echipament Echipament);
    }
}
