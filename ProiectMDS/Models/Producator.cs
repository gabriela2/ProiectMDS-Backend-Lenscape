using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Producator
    {
        public int Id { get; set; }
        public string NumeProducator { get; set; }
        public string TaraOrigine { get; set; }

        public List<Echipament> Echipament { get; set; }
    }
}
