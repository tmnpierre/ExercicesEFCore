using Microsoft.EntityFrameworkCore;
using Exercice01Personnage.Models;

namespace Exercice01Personnage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Personnage> Personnages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Exercice01PersonnageDB;Trusted_Connection=True;");
        }
    }
}
