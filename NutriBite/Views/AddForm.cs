using NutriBite.Data;
using NutriBite.Models; 
using System;
using System.Windows.Forms;

namespace NutriBite.Views
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCalories.Text) ||
                string.IsNullOrWhiteSpace(txtProtein.Text) ||
                string.IsNullOrWhiteSpace(txtCarbs.Text) ||
                string.IsNullOrWhiteSpace(txtFats.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Create a Food object and save it to the database
            using (var context = new FoodDbContext())
            {
                var food = new Food // References NutriBite.Models.Food
                {
                    Name = txtName.Text,
                    Calories = double.Parse(txtCalories.Text),
                    Protein = double.Parse(txtProtein.Text),
                    Carbs = double.Parse(txtCarbs.Text),
                    Fats = double.Parse(txtFats.Text),
                    Category = "Uncategorized" // Optional default value
                };

                context.Foods.Add(food);
                context.SaveChanges(); // Save changes to the database

                MessageBox.Show("Food item added successfully!");
            }

            // Optionally clear the form fields
            txtName.Clear();
            txtCalories.Clear();
            txtProtein.Clear();
            txtCarbs.Clear();
            txtFats.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the Main Menu form
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();

            // Close the current form
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // Optional initialization logic
        }
    }
}
