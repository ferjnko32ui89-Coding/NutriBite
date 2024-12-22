using NutriBite.Data;
using NutriBite.Utilities;
using System.Linq;
using System.Windows.Forms;

namespace NutriBite.Views
{
    public partial class LoginForm : Form
    {
        private LoginDbContext _context;

        public LoginForm()
        {
            InitializeComponent();
            _context = new LoginDbContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // Check if the user exists
            var user = _context.Users.SingleOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Username does not exist. Please register or try again.");
                return;
            }

            // Check if the password is correct
            if (user.Password != password)
            {
                MessageBox.Show("Incorrect password. Please try again.");
                return;
            }

            // Successful login
            Session.CurrentUserId = user.Id; // Fix: Assign the logged-in user's ID to the session
            MessageBox.Show($"Welcome, {user.FirstName}!");

            this.Hide();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Any initialization code you want here (or leave it empty)
        }

    }
}
