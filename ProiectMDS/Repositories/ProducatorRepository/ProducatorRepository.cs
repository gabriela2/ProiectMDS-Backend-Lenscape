using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ProducatorRepository
{
    public class ProducatorRepository:IProducatorRepository
    {
        public Context _context { get; set; }
        public ProducatorRepository(Context context)
        {
            _context = context;
        }

        public Producator Create(Producator producator)
        {
            var result = _context.Add<Producator>(producator);
            _context.SaveChanges();
            return result.Entity;
        }

        public Producator Get(int Id)
        {
            return _context.Producator.SingleOrDefault(x => x.Id == Id);
        }

        public List<Producator> GetAll()
        {
            return _context.Producator.ToList();
        }

        public Producator Update(Producator Producator)
        {
            _context.Entry(Producator).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Producator;
        }

        public Producator Delete(Producator Producator)
        {
            var result = _context.Remove(Producator);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
