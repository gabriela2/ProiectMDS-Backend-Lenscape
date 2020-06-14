using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public string Adresa { get; set; }

        public virtual TipClient TipClient { get; set; }
        public List<Comenzi> Comenzi { get; set; }
    }
}
