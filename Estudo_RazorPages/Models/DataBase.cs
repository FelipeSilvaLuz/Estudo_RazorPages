using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Estudo_RazorPages.Models
{
    public class DataBase: DbContext
    {
        protected const string ConnectionString = "";

        public DataBase()
        {
        }

        public DbSet<Credit> Credit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credit>().ToTable("Credits");

            modelBuilder.Entity<Credit>().HasKey(x => x.Id);
            modelBuilder.Entity<Credit>().Property(x => x.Id).UseSqlServerIdentityColumn().IsRequired();
            modelBuilder.Entity<Credit>().Property(x => x.Description).HasMaxLength(50).IsRequired();
        } 
    }
}