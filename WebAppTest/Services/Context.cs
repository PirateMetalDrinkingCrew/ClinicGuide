﻿using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;


namespace WebAppTest.Services
{
    

    public class Context :DbContext
    {
        public string DbPath { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Sprache> Sprachen { get; set; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "data.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
