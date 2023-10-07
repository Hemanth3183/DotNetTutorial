using System.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Data
{
    public class DataContextEF : DbContext              // Session with the database to execute queries.
    {
        public DbSet<Computer>? Computer {get; set;}    // Use "?" to make this property nullable.
        protected override void OnConfiguring(DbContextOptionsBuilder options)      // Used to connect to a DB.
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=DotNetCourse;TrustServerCertificate=true;Trusted_Connection=true;",
                    options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)          // Map to a table in the database.
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            modelBuilder.Entity<Computer>().HasKey(c => c.ComputerId); 
            // modelBuilder.Entity<Computer>().HasNoKey();           
        }
    }
}

