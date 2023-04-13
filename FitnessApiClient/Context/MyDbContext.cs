using FitnessApiClient.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApiClient.Context
{
    public class MyDbContext : DbContext
    {
        //private readonly IConfiguration conf;

        //public MyDbContext(IConfiguration conf)
        //{
        //    this.conf = conf;
        //}

        public DbSet<FitnessArena> FitnessArenas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:fitnessapp.database.windows.net,1433;Initial Catalog=FitnessApp;Persist Security Info=False;User ID=fitnessapp;Password=fitness123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FitnessArena>()
                .ToTable("Arenas")
                .HasKey(a => a.arenaId);

            modelBuilder.Entity<FitnessArena>()
                .Property(a => a.name)
                .IsRequired();

            modelBuilder.Entity<FitnessArena>()
                .Property(a => a.isDeleted)
                .HasDefaultValue(false);
        }
    }
}
