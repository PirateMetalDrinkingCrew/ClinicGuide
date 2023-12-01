using Microsoft.EntityFrameworkCore;


namespace WebAppTest.Service
{
    

    public class DbService : DbContext
    {
        private DbService _database;

        public DbService()
        {
            _database = new DbService();
            _database.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.sql");
        }
    }
}
