using NutriBite.Data;
using NutriBite.Models;

namespace NutriBite.Utilities
{
    /// <summary>
    /// Handles seeding the Food table in the database.
    /// </summary>
    public static class FoodSeeder
    {
        public static void SeedFoods(FoodDbContext context, string filePath)
        {
            // Output to indicate the seeding process has started
            Console.WriteLine("Seeding food data...");

            // Check if the Foods table is empty
            if (!context.Foods.Any())
            {
                // Load food data from CSV
                var foods = FoodImporter.LoadFoodsFromCSV(filePath);

                // Add all food items to the database
                context.Foods.AddRange(foods);

                // Commit changes to the database
                context.SaveChanges();

                Console.WriteLine("Food data seeded successfully.");
            }
            else
            {
                Console.WriteLine("Foods table already populated. Skipping seeding.");
            }
        }
    }
}
