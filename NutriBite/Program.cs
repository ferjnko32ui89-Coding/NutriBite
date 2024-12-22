using NutriBite.Data;
using NutriBite.Utilities;
using NutriBite.Views;

namespace NutriBite
{
    using NutriBite.Data;
    using NutriBite.Utilities;

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FoodDbContext())
            {
                // Provide the correct path to your CSV file
                string csvPath = @"C:\Users\lapto\OneDrive\School\NutriBite\NutriBite\foodData.csv";

                // Seed the database with food data
                FoodSeeder.SeedFoods(context, csvPath);
            }

            // Continue with application logic
            Application.Run(new LoginForm());
        }
    }

}