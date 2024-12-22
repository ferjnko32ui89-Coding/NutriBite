using System;

namespace NutriBite.Models;

public partial class MealLog
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int FoodId { get; set; }
    public double Servings { get; set; }
    public double TotalCalories { get; set; }
    public double TotalProtein { get; set; }
    public double TotalCarbs { get; set; }
    public double TotalFats { get; set; }
    public DateTime LogDate { get; set; } // Correct type
    public virtual Food Food { get; set; }
    public virtual User User { get; set; }
}
