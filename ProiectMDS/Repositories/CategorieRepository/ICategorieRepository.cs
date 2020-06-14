using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.CategorieRepository
{
    public interface ICategorieRepository
    {
        List<Categorie> GetAll();
        Categorie Get(int Id);
        Categorie Create(Categorie Categorie);
        Categorie Update(Categorie Categorie);
        Categorie Delete(Categorie Categorie);

    }
}
