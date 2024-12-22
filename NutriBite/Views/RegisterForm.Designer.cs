namespace NutriBite.Views
{
    partial class RegisterForm
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblMemorableInfo = new Label();
            btnSubmit = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtMemorableInfo = new TextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(81, 168);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(82, 244);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(78, 325);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(78, 400);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblMemorableInfo
            // 
            lblMemorableInfo.AutoSize = true;
            lblMemorableInfo.Location = new Point(424, 168);
            lblMemorableInfo.Name = "lblMemorableInfo";
            lblMemorableInfo.Size = new Size(248, 20);
            lblMemorableInfo.TabIndex = 4;
            lblMemorableInfo.Text = "Memorable Information (one word):";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(497, 321);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(255, 73);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Create Account";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(200, 168);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(186, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(200, 244);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(186, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 400);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(200, 321);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(186, 27);
            txtUsername.TabIndex = 9;
            // 
            // txtMemorableInfo
            // 
            txtMemorableInfo.Location = new Point(677, 164);
            txtMemorableInfo.Margin = new Padding(3, 4, 3, 4);
            txtMemorableInfo.Name = "txtMemorableInfo";
            txtMemorableInfo.Size = new Size(211, 27);
            txtMemorableInfo.TabIndex = 10;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtMemorableInfo);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSubmit);
            Controls.Add(lblMemorableInfo);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblMemorableInfo;
        private Button btnSubmit;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtMemorableInfo;
    }
}