using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.EchipamentCategorieRepository
{
    public interface IEchipamentCategorieRepository
    {
        List<EchipamentCategorie> GetAll();
        EchipamentCategorie Get(int Id);
        EchipamentCategorie Create(EchipamentCategorie EchipamentCategorie);
        EchipamentCategorie Update(EchipamentCategorie EchipamentCategorie);
        EchipamentCategorie Delete(EchipamentCategorie EchipamentCategorie);
    }
}
