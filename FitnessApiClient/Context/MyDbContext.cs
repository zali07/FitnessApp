using FitnessApiClient.Api;
using Microsoft.EntityFrameworkCore;
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
            var Server = "myServerName\myInstanceName; Database = myDataBase; User Id = myUsername; Password = myPassword"
            optionsBuilder.UseSqlServer(Server);
        }
    }
}
