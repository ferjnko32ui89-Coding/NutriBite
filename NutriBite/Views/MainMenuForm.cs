using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriBite.Views
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogMeal_Click(object sender, EventArgs e)
        {
            LogMealForm logMealForm = new LogMealForm();
            logMealForm.Show();
            this.Hide();
        }

        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            ViewProgressForm viewProgressForm = new ViewProgressForm();
            viewProgressForm.Show();
            this.Hide();
        }

        private void btnSetGoals_Click(object sender, EventArgs e)
        {
            SetGoalsForm setGoalsForm = new SetGoalsForm();
            setGoalsForm.Show();
            this.Hide();
        }

        private void btnMealSuggestions_Click(object sender, EventArgs e)
        {
            MealSuggestionsForm mealSuggestionsForm = new MealSuggestionsForm();
            mealSuggestionsForm.Show();
            this.Hide();
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Hide();
        }

        private void btnAddFodd_Click(object sender, EventArgs e)
        {
            var addFoodForm = new AddForm();
            addFoodForm.Show();
        }
    }
}
