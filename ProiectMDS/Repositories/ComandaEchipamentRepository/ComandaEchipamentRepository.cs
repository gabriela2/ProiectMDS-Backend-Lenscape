using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ComandaEchipamentRepository
{
    public class ComandaEchipamentRepository:IComandaEchipamentRepository
    {
        public Context _context { get; set; }
        public ComandaEchipamentRepository(Context context)
        {
            _context = context;
        }

        public ComandaEchipament Create(ComandaEchipament comandaEchipament)
        {
            var result = _context.Add<ComandaEchipament>(comandaEchipament);
            _context.SaveChanges();
            return result.Entity;
        }

        public ComandaEchipament Get(int Id)
        {
            return _context.ComandaEchipament.SingleOrDefault(x => x.Id == Id);
        }

        public List<ComandaEchipament> GetAll()
        {
            return _context.ComandaEchipament.ToList();
        }

        public ComandaEchipament Update(ComandaEchipament ComandaEchipament)
        {
            _context.Entry(ComandaEchipament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return ComandaEchipament;
        }

        public ComandaEchipament Delete(ComandaEchipament ComandaEchipament)
        {
            var result = _context.Remove(ComandaEchipament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
