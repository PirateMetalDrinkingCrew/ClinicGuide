using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;


namespace WebAppTest.Services
{


    public class Context :DbContext
    {
        public string DbPath { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<AnamnesisForm> AnamnesisForm { get; set; }
        public DbSet<MasterDataForm> MasterDataForm { get; set; }
        public DbSet<Anamnesis> Anamnesis { get; set; }
        public DbSet<MasterData> MasterData { get; set; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "data.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=data.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
