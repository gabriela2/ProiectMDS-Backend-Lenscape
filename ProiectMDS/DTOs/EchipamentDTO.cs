using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class EchipamentDTO
    {
        public string NumeEchipament { get; set; }
        public float Pret { get; set; }
        public string Descriere { get; set; }
        public int AnAparitie { get; set; }
        public string Specificatii { get; set; }
        public int ProducatorId { get; set; }  
        public string img { get; set; }
        
        public List<int> CategorieId { get; set; }
        public List<int> MagazinId { get; set; }

    }
}
