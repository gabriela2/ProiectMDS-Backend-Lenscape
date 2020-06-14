using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class ComandaEchipament
    {
        public int Id { get; set; }
        public int ComenziId { get; set; }
        public int EchipamentId { get; set; }
        public int Cantitate { get; set; }

        public virtual Comenzi Comenzi { get; set; }
        public virtual Echipament Echipament { get; set; }
    }
}
