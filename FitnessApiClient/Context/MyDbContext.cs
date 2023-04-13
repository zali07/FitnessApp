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
        public DbSet<FitnessArena> FitnessArenas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("tcp:fitnessapp.database.windows.net;Persist Security Info=True;User ID=fitnessapp;Password=fitness123!");
        }
    }
}
