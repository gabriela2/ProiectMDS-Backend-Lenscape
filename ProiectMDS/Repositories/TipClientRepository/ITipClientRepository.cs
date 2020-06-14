using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.TipClientRepository
{
    public interface ITipClientRepository
    {
        List<TipClient> GetAll();
        TipClient Get(int Id);
        TipClient Create(TipClient TipClient);
        TipClient Update(TipClient TipClient);
        TipClient Delete(TipClient TipClient);
    }
}
