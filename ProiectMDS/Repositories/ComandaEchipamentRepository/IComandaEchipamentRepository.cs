using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ComandaEchipamentRepository
{
    public interface IComandaEchipamentRepository
    {
        List<ComandaEchipament> GetAll();
        ComandaEchipament Get(int Id);
        ComandaEchipament Create(ComandaEchipament ComandaEchipament);
        ComandaEchipament Update(ComandaEchipament ComandaEchipament);
        ComandaEchipament Delete(ComandaEchipament ComandaEchipament);
    }
}
