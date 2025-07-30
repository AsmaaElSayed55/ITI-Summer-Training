using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment_One
{
    public class Application : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=Assignment;TrustServerCertificate=True;Trusted_Connection=True");
            }
        }
    }
}
