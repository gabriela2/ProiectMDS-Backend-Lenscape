using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class EchipamentCategorie
    {
        public int Id { get; set; }
        public int EchipamentId { get; set; }
        public int CategorieId { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual Echipament Echipament { get; set; }
    }
}
