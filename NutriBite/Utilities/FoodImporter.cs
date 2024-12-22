using NutriBite.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NutriBite.Utilities
{
    /// <summary>
    /// Handles importing food data from a CSV file.
    /// </summary>
    public static class FoodImporter
    {
        public static List<Food> LoadFoodsFromCSV(string filePath)
        {
            var foods = new List<Food>();

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"CSV file not found at path: {filePath}");
            }

            // Read all lines from the CSV file
            var lines = File.ReadAllLines(filePath);

            // Skip the header row and process each line
            foreach (var line in lines.Skip(1))
            {
                var columns = line.Split(',');

                var food = new Food
                {
                    Name = columns[0],
                    Calories = double.Parse(columns[1]),
                    Protein = double.Parse(columns[2]),
                    Carbs = double.Parse(columns[3]),
                    Fats = double.Parse(columns[4]),
                    Category = columns[5]
                };

                foods.Add(food);
            }

            return foods;
        }
    }
}
