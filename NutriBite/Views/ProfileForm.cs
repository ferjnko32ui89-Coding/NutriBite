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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the Main Menu form
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();

            // Close the current form
            this.Close();

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
