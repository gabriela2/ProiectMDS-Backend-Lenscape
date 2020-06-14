using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.EchipamentCategorieRepository
{
    public class EchipamentCategorieRepository: IEchipamentCategorieRepository
    {
        public Context _context { get; set; }
        public EchipamentCategorieRepository(Context context)
        {
            _context = context;
        }

        public EchipamentCategorie Create(EchipamentCategorie echipamentCategorie)
        {
            var result = _context.Add<EchipamentCategorie>(echipamentCategorie);
            _context.SaveChanges();
            return result.Entity;
        }

        public EchipamentCategorie Get(int Id)
        {
            return _context.EchipamentCategorie.SingleOrDefault(x => x.Id == Id);
        }

        public List<EchipamentCategorie> GetAll()
        {
            return _context.EchipamentCategorie.ToList();
        }

        public EchipamentCategorie Update(EchipamentCategorie EchipamentCategorie)
        {
            _context.Entry(EchipamentCategorie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return EchipamentCategorie;
        }

        public EchipamentCategorie Delete(EchipamentCategorie EchipamentCategorie)
        {
            var result = _context.Remove(EchipamentCategorie);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
