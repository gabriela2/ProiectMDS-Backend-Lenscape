using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.DTOs
{
    public class ClientDTO
    {
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public int TipId { get; set; }

        public List<int> ComenziId{ get; set; }
    }
}
