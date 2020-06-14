using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.EchipamentRepository
{
    public class EchipamentRepository: IEchipamentRepository
    {
        public Context _context { get; set; }
        public EchipamentRepository(Context context)
        {
            _context = context;
        }

        public Echipament Create(Echipament echipament)
        {
            var result = _context.Add<Echipament>(echipament);
            _context.SaveChanges();
            return result.Entity;
        }

        public Echipament Get(int Id)
        {
            return _context.Echipament.SingleOrDefault(x => x.Id == Id);
        }

        public List<Echipament> GetAll()
        {
            return _context.Echipament.ToList();
        }

        public Echipament Update(Echipament Echipament)
        {
            _context.Entry(Echipament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Echipament;
        }

        public Echipament Delete(Echipament Echipament)
        {
            var result = _context.Remove(Echipament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
