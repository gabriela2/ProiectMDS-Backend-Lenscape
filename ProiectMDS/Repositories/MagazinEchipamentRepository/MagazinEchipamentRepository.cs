using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.MagazinEchipamentRepository
{
    public class MagazinEchipamentRepository: IMagazinEchipamentRepository
    {
        public Context _context { get; set; }
        public MagazinEchipamentRepository(Context context)
        {
            _context = context;
        }

        public MagazinEchipament Create(MagazinEchipament magazinEchipament)
        {
            var result = _context.Add<MagazinEchipament>(magazinEchipament);
            _context.SaveChanges();
            return result.Entity;
        }

        public MagazinEchipament Get(int Id)
        {
            return _context.MagazinEchipament.SingleOrDefault(x => x.Id == Id);
        }

        public List<MagazinEchipament> GetAll()
        {
            return _context.MagazinEchipament.ToList();
        }

        public MagazinEchipament Update(MagazinEchipament MagazinEchipament)
        {
            _context.Entry(MagazinEchipament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return MagazinEchipament;
        }

        public MagazinEchipament Delete(MagazinEchipament MagazinEchipament)
        {
            var result = _context.Remove(MagazinEchipament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
