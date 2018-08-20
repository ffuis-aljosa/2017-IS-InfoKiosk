using InfoKioskProject.Database;
using InfoKioskProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoKioskProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            passwordWarningLabel.Hide();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextBox.Text == repeatPasswordTextBox.Text)
                {
                    User newUser = new User(usernameTextBox.Text, passwordTextBox.Text, "student");
                    UserRepository.AddUser(newUser);

                    MessageBox.Show("Корисник успјешно регистрован.", "РЕГИСТРАЦИЈА", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    passwordWarningLabel.Hide();
                    EmptyLoginFields();
                }
                else
                {
                    passwordWarningLabel.Show();
                    passwordTextBox.Text = "";
                    repeatPasswordTextBox.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void EmptyLoginFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            repeatPasswordTextBox.Text = "";
        }
    }
}
