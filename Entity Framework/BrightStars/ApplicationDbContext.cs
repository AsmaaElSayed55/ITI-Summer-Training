using BrightStars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightStars
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> departments {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
            base.OnConfiguring(optionsBuilder);
            // Connection String
            optionsBuilder.UseSqlServer("Server=.;Database=SkyHorizons;TrustServerCertificate=True;Trusted_Connection=True");

        }
    }
}
