using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class TipClient
    {
        public int Id { get; set; }
        public string Descriere { get; set; }
        public int Discount { get; set; }

        public List<Client> Client { get; set; }

    }
}
