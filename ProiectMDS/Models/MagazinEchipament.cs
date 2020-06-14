using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class MagazinEchipament
    {
        public int Id { get; set; }
        public int MagazinId { get; set; }
        public int EchipamentId { get; set; }
        public float Stoc { get; set; }

        public virtual Magazin Magazin { get; set; }
        public virtual Echipament Echipament { get; set; }
    }
}
