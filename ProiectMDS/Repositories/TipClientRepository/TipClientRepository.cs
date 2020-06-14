using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.TipClientRepository
{
    public class TipClientRepository:ITipClientRepository
    {
        public Context _context { get; set; }
        public TipClientRepository(Context context)
        {
            _context = context;
        }

        public TipClient Create(TipClient tipClient)
        {
            var result = _context.Add<TipClient>(tipClient);
            _context.SaveChanges();
            return result.Entity;
        }

        public TipClient Get(int IdTip)
        {
            return _context.TipClient.SingleOrDefault(x => x.Id == IdTip);
        }

        public List<TipClient> GetAll()
        {
            return _context.TipClient.ToList();
        }

        public TipClient Update(TipClient TipClient)
        {
            _context.Entry(TipClient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return TipClient;
        }

        public TipClient Delete(TipClient TipClient)
        {
            var result = _context.Remove(TipClient);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
