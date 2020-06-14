using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.MagazinEchipamentRepository
{
    public interface IMagazinEchipamentRepository
    {
        List<MagazinEchipament> GetAll();
        MagazinEchipament Get(int Id);
        MagazinEchipament Create(MagazinEchipament MagazinEchipament);
        MagazinEchipament Update(MagazinEchipament MagazinEchipament);
        MagazinEchipament Delete(MagazinEchipament MagazinEchipament);
    }
}
