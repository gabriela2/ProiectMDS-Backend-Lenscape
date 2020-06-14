using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ComenziRepository
{
    public interface IComenziRepository
    {
        List<Comenzi> GetAll();
        Comenzi Get(int Id);
        Comenzi Create(Comenzi Comenzi);
        Comenzi Update(Comenzi Comenzi);
        Comenzi Delete(Comenzi Comenzi);
    }
}
