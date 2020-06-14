using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Echipament
    {
        public int Id { get; set; }
        public int ProducatorId { get; set; }
        public string NumeEchipament { get; set; }
        public float Pret { get; set; }
        public string Descriere { get; set; }
        public int AnAparitie { get; set; }
        public string Specificatii { get; set; }
        public string img { get; set; }

        public List<EchipamentCategorie> EchipamentCategorie { get; set; }
        public List<ComandaEchipament> ComandaEchipament { get; set; }
        public virtual Producator Producator { get; set; }

    }
}
