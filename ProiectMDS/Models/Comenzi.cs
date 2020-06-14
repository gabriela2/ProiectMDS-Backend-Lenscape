using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Comenzi
    {
        public int Id { get; set; }
        public int MagazinId { get; set; }
        public int ClientId { get; set; }
        public float SumaTotala { get; set; }

        public virtual Client Client { get; set; }
        public virtual Magazin Magazin { get; set; }
        public List<ComandaEchipament> ComandaEchipament { get; set; }
    }
}
