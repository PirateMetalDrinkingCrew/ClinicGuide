using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;


namespace WebAppTest.Services
{


    public class Context :DbContext
    {
        public DbSet<AnamnesisForm> Anamnese { get; set; }

        public DbSet<MasterDataForm> Stammdaten { get; set; }
        public DbSet<Language> Sprachen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.sql");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
