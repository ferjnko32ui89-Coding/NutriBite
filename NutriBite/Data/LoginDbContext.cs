using Microsoft.EntityFrameworkCore;
using NutriBite.Models;

using Microsoft.EntityFrameworkCore;
using NutriBite.Models;

namespace NutriBite.Data
{
    public class LoginDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\lapto\OneDrive\School\NutriBite\NutriBite\login.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users"); // Ensure table name is "Users"
        }

    }
}
