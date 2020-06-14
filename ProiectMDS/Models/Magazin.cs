using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Magazin
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }

        public List<Comenzi> Comenzi { get; set; }
        public List<MagazinEchipament> MagazinEchipament { get; set; }
    }
}
