using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;


namespace WebAppTest.Service
{
    

    public class DbService : DbContext
    {
        private DbService _database;

        DbSet<Form> Forms { get; set; }
        DbSet<Sprache> Sprachen { get; set; }

        public DbService()
        {
            _database = new DbService();
            FillDatabase();
        }

        private void FillDatabase()
        {
            _database.Database.EnsureCreated();
            // Sprache
            Sprache deutsch = new Sprache();
            deutsch.Wert = "deutsch";
            Sprache franzoesisch = new Sprache();
            franzoesisch.Wert = "franzoesisch";
            Sprache italienisch = new Sprache();
            italienisch.Wert = "italienisch";
            Debug.WriteLine($"sprache: {deutsch.Wert} angelegt");
            // Forms
            Form stammdaten1 = new Form();
            stammdaten1.Value = "deutsch";
            stammdaten1.Key = "anrede";
            stammdaten1.Value = "Anrede";
            _database.Forms.Add(stammdaten1);
            Debug.WriteLine($"form: {stammdaten1.Value} angelegt");
            Form stammdaten2 = new Form();
            stammdaten2.Sprache = franzoesisch;
            stammdaten2.Key = "anrede";
            stammdaten2.Value = "Salutations";
            _database.Forms.Add(stammdaten2);

            Form stammdaten3 = new Form();
            stammdaten3.Sprache = italienisch;
            stammdaten3.Key = "anrede";
            stammdaten3.Value = "Saluto";
            _database.Forms.Add(stammdaten3);
            _database.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.sql");
        }
    }
}
