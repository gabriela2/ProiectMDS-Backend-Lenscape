using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.CategorieRepository
{
    public class CategorieRepository:ICategorieRepository
    {
        public Context _context { get; set; }

        public CategorieRepository(Context context)
        {
            _context = context;
        }

        public Categorie Create(Categorie categorie)
        {
            var result = _context.Add<Categorie>(categorie);
            _context.SaveChanges();
            return result.Entity;
        }

        public Categorie Get(int Id)
        {
            return _context.Categorie.SingleOrDefault(x => x.Id == Id);
        }

        public List<Categorie> GetAll()
        {
            return _context.Categorie.ToList();
        }

        public Categorie Update( Categorie Categorie)
        {
            _context.Entry(Categorie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Categorie;
        }

        public Categorie Delete( Categorie Categorie)
        {
            var result = _context.Remove(Categorie);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
