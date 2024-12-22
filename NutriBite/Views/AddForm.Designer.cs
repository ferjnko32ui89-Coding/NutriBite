namespace NutriBite.Views
{
    partial class AddForm
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
            lblName = new Label();
            lblCalories = new Label();
            lblProtein = new Label();
            lblCarbs = new Label();
            lblFats = new Label();
            btnSubmit = new Button();
            txtName = new TextBox();
            txtCalories = new TextBox();
            txtProtein = new TextBox();
            txtCarbs = new TextBox();
            txtFats = new TextBox();
            lblTitle = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(64, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(63, 127);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 1;
            lblCalories.Text = "Calories";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(64, 172);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(60, 20);
            lblProtein.TabIndex = 2;
            lblProtein.Text = "Protein ";
            // 
            // lblCarbs
            // 
            lblCarbs.AutoSize = true;
            lblCarbs.Location = new Point(63, 221);
            lblCarbs.Name = "lblCarbs";
            lblCarbs.Size = new Size(72, 20);
            lblCarbs.TabIndex = 3;
            lblCarbs.Text = "Carbs (%)";
            // 
            // lblFats
            // 
            lblFats.AutoSize = true;
            lblFats.Location = new Point(64, 273);
            lblFats.Name = "lblFats";
            lblFats.Size = new Size(34, 20);
            lblFats.TabIndex = 4;
            lblFats.Text = "Fats";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(252, 336);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(268, 55);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 27);
            txtName.TabIndex = 6;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(252, 120);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(259, 27);
            txtCalories.TabIndex = 7;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(252, 165);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(259, 27);
            txtProtein.TabIndex = 8;
            // 
            // txtCarbs
            // 
            txtCarbs.Location = new Point(252, 214);
            txtCarbs.Name = "txtCarbs";
            txtCarbs.Size = new Size(259, 27);
            txtCarbs.TabIndex = 9;
            // 
            // txtFats
            // 
            txtFats.Location = new Point(252, 266);
            txtFats.Name = "txtFats";
            txtFats.Size = new Size(259, 27);
            txtFats.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(92, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(643, 35);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Add A New Food and It's Nutritional Values (Per Serving)";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 336);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 55);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(txtFats);
            Controls.Add(txtCarbs);
            Controls.Add(txtProtein);
            Controls.Add(txtCalories);
            Controls.Add(txtName);
            Controls.Add(btnSubmit);
            Controls.Add(lblFats);
            Controls.Add(lblCarbs);
            Controls.Add(lblProtein);
            Controls.Add(lblCalories);
            Controls.Add(lblName);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCalories;
        private Label lblProtein;
        private Label lblCarbs;
        private Label lblFats;
        private Button btnSubmit;
        private TextBox txtName;
        private TextBox txtCalories;
        private TextBox txtProtein;
        private TextBox txtCarbs;
        private TextBox txtFats;
        private Label lblTitle;
        private Button btnBack;
    }
}