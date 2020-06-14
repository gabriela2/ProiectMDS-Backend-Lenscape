using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ComenziRepository
{
    public class ComenziRepository:IComenziRepository
    {
        public Context _context { get; set; }
        public ComenziRepository(Context context)
        {
            _context = context;
        }

        public Comenzi Create(Comenzi comenzi)
        {
            var result = _context.Add<Comenzi>(comenzi);
            _context.SaveChanges();
            return result.Entity;
        }

        public Comenzi Get(int Id)
        {
            return _context.Comenzi.SingleOrDefault(x => x.Id == Id);
        }

        public List<Comenzi> GetAll()
        {
            return _context.Comenzi.ToList();
        }

        public Comenzi Update(Comenzi Comenzi)
        {
            _context.Entry(Comenzi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Comenzi;
        }

        public Comenzi Delete(Comenzi Comenzi)
        {
            var result = _context.Remove(Comenzi);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
