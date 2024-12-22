using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriBite.Models;

using System;
using System.Linq;
using System.Windows.Forms;
using NutriBite.Data;

namespace NutriBite.Views
{
    public partial class RegisterForm : Form
    {
        private LoginDbContext _context;

        public RegisterForm()
        {
            InitializeComponent();
            _context = new LoginDbContext();
        }

        // Event handler for the Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var memorableInfo = txtMemorableInfo.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(memorableInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if username already exists
            var existingUser = _context.Users.SingleOrDefault(u => u.Username == username);
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists. Please choose another username.");
                return;
            }

            // Create a new User object and populate fields
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password, // For simplicity, storing as plaintext
                MemorableInfo = memorableInfo
            };

            // Add the new user to the database context
            _context.Users.Add(user);
            _context.SaveChanges();

            // Show success message and redirect to login form
            MessageBox.Show("Registration successful! Please log in.");
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var memorableInfo = txtMemorableInfo.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(memorableInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if username already exists
            var existingUser = _context.Users.SingleOrDefault(u => u.Username == username);
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists. Please choose another username.");
                return;
            }

            // Create a new User object and populate fields
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password, // For simplicity, storing as plaintext
                MemorableInfo = memorableInfo
            };

            // Add the new user to the database context
            _context.Users.Add(user);
            _context.SaveChanges();

            // Show success message and redirect to login form
            MessageBox.Show("Registration successful! Please log in.");
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
