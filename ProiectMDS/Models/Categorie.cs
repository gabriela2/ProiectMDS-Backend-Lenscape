using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string NumeCategorie { get; set; }
        public string Specificatii { get; set; }
        public string Descriere { get; set; }

        public List<EchipamentCategorie> EchipamentCategorie { get; set; }
    }
}
