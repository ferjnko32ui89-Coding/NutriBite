namespace NutriBite.Views
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogMeal = new Button();
            btnSetGoals = new Button();
            btnViewProgress = new Button();
            btnMealSuggestions = new Button();
            btnProfileManagement = new Button();
            btnLogout = new Button();
            btnAddFodd = new Button();
            SuspendLayout();
            // 
            // btnLogMeal
            // 
            btnLogMeal.Location = new Point(39, 185);
            btnLogMeal.Margin = new Padding(3, 4, 3, 4);
            btnLogMeal.Name = "btnLogMeal";
            btnLogMeal.Size = new Size(152, 64);
            btnLogMeal.TabIndex = 0;
            btnLogMeal.Text = "Log Meal";
            btnLogMeal.UseVisualStyleBackColor = true;
            btnLogMeal.Click += btnLogMeal_Click;
            // 
            // btnSetGoals
            // 
            btnSetGoals.Location = new Point(415, 185);
            btnSetGoals.Margin = new Padding(3, 4, 3, 4);
            btnSetGoals.Name = "btnSetGoals";
            btnSetGoals.Size = new Size(152, 64);
            btnSetGoals.TabIndex = 1;
            btnSetGoals.Text = "Set Goals";
            btnSetGoals.UseVisualStyleBackColor = true;
            btnSetGoals.Click += btnSetGoals_Click;
            // 
            // btnViewProgress
            // 
            btnViewProgress.Location = new Point(225, 185);
            btnViewProgress.Margin = new Padding(3, 4, 3, 4);
            btnViewProgress.Name = "btnViewProgress";
            btnViewProgress.Size = new Size(152, 64);
            btnViewProgress.TabIndex = 2;
            btnViewProgress.Text = "View Progress";
            btnViewProgress.UseVisualStyleBackColor = true;
            btnViewProgress.Click += btnViewProgress_Click;
            // 
            // btnMealSuggestions
            // 
            btnMealSuggestions.Location = new Point(264, 421);
            btnMealSuggestions.Margin = new Padding(3, 4, 3, 4);
            btnMealSuggestions.Name = "btnMealSuggestions";
            btnMealSuggestions.Size = new Size(152, 64);
            btnMealSuggestions.TabIndex = 3;
            btnMealSuggestions.Text = "Meal Suggestions";
            btnMealSuggestions.UseVisualStyleBackColor = true;
            // 
            // btnProfileManagement
            // 
            btnProfileManagement.Location = new Point(683, 47);
            btnProfileManagement.Margin = new Padding(3, 4, 3, 4);
            btnProfileManagement.Name = "btnProfileManagement";
            btnProfileManagement.Size = new Size(152, 64);
            btnProfileManagement.TabIndex = 5;
            btnProfileManagement.Text = "Profile";
            btnProfileManagement.UseVisualStyleBackColor = true;
            btnProfileManagement.Click += btnProfileManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(705, 504);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 64);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAddFodd
            // 
            btnAddFodd.Location = new Point(615, 185);
            btnAddFodd.Margin = new Padding(3, 4, 3, 4);
            btnAddFodd.Name = "btnAddFodd";
            btnAddFodd.Size = new Size(152, 64);
            btnAddFodd.TabIndex = 7;
            btnAddFodd.Text = "Add Food";
            btnAddFodd.UseVisualStyleBackColor = true;
            btnAddFodd.Click += btnAddFodd_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAddFodd);
            Controls.Add(btnLogout);
            Controls.Add(btnProfileManagement);
            Controls.Add(btnMealSuggestions);
            Controls.Add(btnViewProgress);
            Controls.Add(btnSetGoals);
            Controls.Add(btnLogMeal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogMeal;
        private Button btnSetGoals;
        private Button btnViewProgress;
        private Button btnMealSuggestions;
        private Button btnProfileManagement;
        private Button btnLogout;
        private Button btnAddFodd;
    }
}