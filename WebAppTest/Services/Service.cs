using System.Diagnostics;
using WebAppTest.Models;

namespace WebAppTest.Services
{
    public class Service
    {
        private readonly Context _database;

        public Service()
        {
            _database = new Context();
            _database.Database.EnsureCreated();
            FillDatabase();
        }
        private void FillDatabase()
        {
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
    }
}
