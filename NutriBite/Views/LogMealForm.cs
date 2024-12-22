using NutriBite.Data;
using NutriBite.Utilities;
using System;
using NutriBite.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriBite.Models;
using NutriBite.Data;
using NutriBite.Data;
using static System.Collections.Specialized.BitVector32;
using Microsoft.EntityFrameworkCore;
using NutriBite.Utilities;
using NutriBite.Models;
using NutriBite.Models;
namespace NutriBite.Views
{
    public partial class LogMealForm : Form
    {
        public LogMealForm()
        {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            // Open the AddForm to add new food
            var addForm = new AddForm();
            addForm.ShowDialog();

            // Refresh the ComboBox after the AddForm closes
            LogMealForm_Load(sender, e);



        }

        private void comboFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberofServings_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Input validation
            if (comboFoodName.SelectedValue == null)
            {
                MessageBox.Show("Please select a food item.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtNumberofServings.Text, out double servings) || servings <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for servings.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validate User Session
                using (var loginDbContext = new LoginDbContext())
                {
                    var user = loginDbContext.Users.SingleOrDefault(u => u.Id == Session.CurrentUserId);
                    if (user == null)
                    {
                        MessageBox.Show("User session is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Use FoodDbContext to fetch the selected food
                using (var foodContext = new FoodDbContext())
                {
                    int selectedFoodId = Convert.ToInt32(comboFoodName.SelectedValue);
                    var selectedFood = foodContext.Foods.FirstOrDefault(f => f.Id == selectedFoodId);

                    if (selectedFood == null)
                    {
                        MessageBox.Show("Selected food could not be found in the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Calculate nutritional values
                    double totalCalories = selectedFood.Calories * servings;
                    double totalProtein = selectedFood.Protein * servings;
                    double totalCarbs = selectedFood.Carbs * servings;
                    double totalFats = selectedFood.Fats * servings;

                    // Use MealLogDbContext to save the meal log
                    using (var mealLogContext = new MealLogDbContext())
                    {
                        var mealLog = new MealLog
                        {
                            FoodId = selectedFoodId,
                            UserId = Session.CurrentUserId,
                            Servings = servings,
                            TotalCalories = totalCalories,
                            TotalProtein = totalProtein,
                            TotalCarbs = totalCarbs,
                            TotalFats = totalFats,
                            LogDate = DateTime.Now
                        };

                        mealLogContext.MealLogs.Add(mealLog);
                        mealLogContext.SaveChanges();
                    }

                    MessageBox.Show("Meal logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear inputs
                    comboFoodName.SelectedIndex = -1;
                    txtNumberofServings.Clear();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"DbUpdateException: {dbEx.InnerException?.Message ?? dbEx.Message}");
                MessageBox.Show($"A database error occurred: {dbEx.InnerException?.Message ?? dbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
                MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the Main Menu form
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();

            // Close the current form
            this.Close();
        }

        private void LogMealForm_Load(object sender, EventArgs e)
        {
            using (var context = new FoodDbContext()) // Use FoodDbContext here
            {
                // Load all food items from the Food table
                var foodItems = context.Foods.ToList();
                comboFoodName.DataSource = foodItems;
                comboFoodName.DisplayMember = "Name";  // Show food name in the dropdown
                comboFoodName.ValueMember = "Id";     // Bind the Food Id to the dropdown
            }
        }


    }
}
