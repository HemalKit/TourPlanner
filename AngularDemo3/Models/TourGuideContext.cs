using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class TourGuideContext :DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Tourist> Tourists { get; set; }

        public DbSet<Route> Routes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TourGuideDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .HasOne<City>(r => r.StartingPoint)
                .WithMany(c => c.StartingRoutes)
                .HasForeignKey(c => c.StartingPointId);

            modelBuilder.Entity<Route>()
                .HasOne<City>(r => r.EndPoint)
                .WithMany(c => c.EndingRoutes)
                .HasForeignKey(c => c.EndingPointId);
        }

    }
}
