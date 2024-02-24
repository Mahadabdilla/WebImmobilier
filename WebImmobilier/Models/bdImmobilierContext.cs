using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace WebImmobilier.Models
{
    public class bdImmobilierContext : DbContext
    {
        public bdImmobilierContext() : base("connImmobilier")
        {
        }
        public DbSet<Bien> biens { get; set; }
        public DbSet<Maison> maisons { get; set; }
        public DbSet<Proprietaire> proprietaire {get; set; }

        public DbSet<Utilisateur> utilisateurs { get; set; }

        public DbSet<Terrain> terrains { get; set; }

        public DbSet<Appartement> appartements { get; set; }
        public DbSet<Studio> studio { get; set; }

        
    }
}