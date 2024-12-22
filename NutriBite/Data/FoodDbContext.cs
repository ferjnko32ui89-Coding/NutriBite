using Microsoft.EntityFrameworkCore;
using NutriBite.Models;
using Microsoft.EntityFrameworkCore;
using NutriBite.Models;

namespace NutriBite.Data
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\lapto\OneDrive\School\NutriBite\NutriBite\login.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().ToTable("Foods"); // Explicitly map to the existing "Foods" table
        }
    }
}
