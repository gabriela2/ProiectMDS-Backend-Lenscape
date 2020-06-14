using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class EchipamentDetailsDTO
    {
        public string NumeEchipament { get; set; }
        public float Pret { get; set; }
        public string Descriere { get; set; }
        public int AnAparitie { get; set; }
        public string Specificatii { get; set; }
        public int ProducatorId { get; set; }
        public string img { get; set; }

        public List<string> NumeCategorie { get; set; }
        public List<string> Nume { get; set; }
    }
}
