using Microsoft.EntityFrameworkCore;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer
{
    public class MovementDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Movement;Trusted_Connection=True")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InferenceTraversePieton>()
                .HasOne(i => i.BorneDepart)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TraversePieton>()
                .HasOne(i => i.BorneDepart)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TraversePieton>()
                .HasOne(i => i.BorneArrivee)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<ActionFeu> ActionsFeu { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<InferenceTraversePieton> InferencesTraversePieton { get; set; }
        public DbSet<InferenceTraverseVehicule> InferencesTraverseVehicules { get; set; }
        public DbSet<Intersection> Intersections { get; set; }
        public DbSet<TraversePieton> TraversesPieton { get; set; }
        public DbSet<TraverseVehicule> TraversesVehicule { get; set; }
        public DbSet<TypeTransport> TypesTransport { get; set; }
        public DbSet<TypeUtilisateur> TypesUtilisateur { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
