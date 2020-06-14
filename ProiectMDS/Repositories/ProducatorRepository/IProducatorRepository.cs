using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ProducatorRepository
{
    public interface IProducatorRepository
    {
        List<Producator> GetAll();
        Producator Get(int Id);
        Producator Create(Producator Producator);
        Producator Update(Producator Producator);
        Producator Delete(Producator Producator);
    }
}
