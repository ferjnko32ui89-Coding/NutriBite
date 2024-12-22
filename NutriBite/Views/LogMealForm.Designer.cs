namespace NutriBite.Views
{
    partial class LogMealForm
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
            btnSubmit = new Button();
            btnBack = new Button();
            btnAddFood = new Button();
            lblMealName = new Label();
            lblNumberofServings = new Label();
            txtNumberofServings = new TextBox();
            comboFoodName = new ComboBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(270, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(265, 62);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 358);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 62);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(621, 359);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(168, 62);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add a Food if it's not there";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Location = new Point(80, 58);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(87, 20);
            lblMealName.TabIndex = 3;
            lblMealName.Text = "Food Name";
            // 
            // lblNumberofServings
            // 
            lblNumberofServings.AutoSize = true;
            lblNumberofServings.Location = new Point(74, 229);
            lblNumberofServings.Name = "lblNumberofServings";
            lblNumberofServings.Size = new Size(140, 20);
            lblNumberofServings.TabIndex = 4;
            lblNumberofServings.Text = "Number of Servings";
            // 
            // txtNumberofServings
            // 
            txtNumberofServings.Location = new Point(288, 222);
            txtNumberofServings.Name = "txtNumberofServings";
            txtNumberofServings.Size = new Size(222, 27);
            txtNumberofServings.TabIndex = 7;
            txtNumberofServings.TextChanged += txtNumberofServings_TextChanged;
            // 
            // comboFoodName
            // 
            comboFoodName.FormattingEnabled = true;
            comboFoodName.Location = new Point(288, 58);
            comboFoodName.Name = "comboFoodName";
            comboFoodName.Size = new Size(222, 28);
            comboFoodName.TabIndex = 8;
            comboFoodName.SelectedIndexChanged += comboFoodName_SelectedIndexChanged;
            // 
            // LogMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboFoodName);
            Controls.Add(txtNumberofServings);
            Controls.Add(lblNumberofServings);
            Controls.Add(lblMealName);
            Controls.Add(btnAddFood);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Name = "LogMealForm";
            Text = "LogMealForm";
            Load += LogMealForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnBack;
        private Button btnAddFood;
        private Label lblMealName;
        private Label lblNumberofServings;
        private TextBox txtNumberofServings;
        private ComboBox comboFoodName;
    }
}