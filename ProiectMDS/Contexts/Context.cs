using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectMDS.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Client> Client{ get; set; }
        public DbSet<ComandaEchipament> ComandaEchipament { get; set; }
        public DbSet<Comenzi> Comenzi { get; set; }
        public DbSet<Echipament> Echipament { get; set; }
        public DbSet<EchipamentCategorie> EchipamentCategorie { get; set; }
        public DbSet<Magazin> Magazin { get; set; }
        public DbSet<MagazinEchipament> MagazinEchipament { get; set; }
        public DbSet<Producator> Producator { get; set; }
        public DbSet<TipClient> TipClient{ get; set; }

        public static bool isMigration = true;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
            {
                optionsBuilder.UseSqlServer(@"Server=.\; Database=DBProiectMDS; Trusted_Connection=true;");
            }
        }

        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


    }
}
