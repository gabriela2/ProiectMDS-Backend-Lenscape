using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.MagazinRepository
{
    public class MagazinRepository: IMagazinRepository
    {
        public Context _context { get; set; }
        public MagazinRepository(Context context)
        {
            _context = context;
        }

        public Magazin Create(Magazin magazin)
        {
            var result = _context.Add<Magazin>(magazin);
            _context.SaveChanges();
            return result.Entity;
        }

        public Magazin Get(int Id)
        {
            return _context.Magazin.SingleOrDefault(x => x.Id == Id);
        }

        public List<Magazin> GetAll()
        {
            return _context.Magazin.ToList();
        }

        public Magazin Update(Magazin Magazin)
        {
            _context.Entry(Magazin).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Magazin;
        }

        public Magazin Delete(Magazin Magazin)
        {
            var result = _context.Remove(Magazin);
            _context.SaveChanges();
            return result.Entity;
        }

    }
}
