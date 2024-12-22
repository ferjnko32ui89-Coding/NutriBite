using Microsoft.EntityFrameworkCore;
using NutriBite.Models;

namespace NutriBite.Data
{
    public class MealLogDbContext : DbContext
    {
        public DbSet<MealLog> MealLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\lapto\OneDrive\School\NutriBite\NutriBite\login.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealLog>(entity =>
            {
                entity.HasKey(m => m.Id);

                // Map User relationship
                entity.HasOne(m => m.User)
                      .WithMany()
                      .HasForeignKey(m => m.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                // Map Food relationship
                entity.HasOne(m => m.Food)
                      .WithMany()
                      .HasForeignKey(m => m.FoodId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}
