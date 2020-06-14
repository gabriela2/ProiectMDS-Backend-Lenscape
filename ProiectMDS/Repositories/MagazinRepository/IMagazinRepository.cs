using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.MagazinRepository
{
    public interface IMagazinRepository
    {
        List<Magazin> GetAll();
        Magazin Get(int Id);
        Magazin Create(Magazin Magazin);
        Magazin Update(Magazin Magazin);
        Magazin Delete(Magazin Magazin);
    }
}
