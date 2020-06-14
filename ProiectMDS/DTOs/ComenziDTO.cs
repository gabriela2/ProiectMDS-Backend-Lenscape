using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class ComenziDTO
    {
        public int ComenziId { get; set; }
        public int MagazinId { get; set; }
        public int ClientId { get; set; }
        public float SumaTotala { get; set; }
    }
}
