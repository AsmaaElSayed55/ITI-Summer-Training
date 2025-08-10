using BrightStars.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightStars.Data
{
    public class ApplicationDbContext :DbContext
    {
       
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=BrightStars;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
