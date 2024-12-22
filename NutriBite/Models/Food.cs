using System;
using System.Collections.Generic;

namespace NutriBite.Models;

public partial class Food
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Calories { get; set; }

    public double Protein { get; set; }

    public double Carbs { get; set; }

    public double Fats { get; set; }

    public string Category { get; set; } = null!;
}
