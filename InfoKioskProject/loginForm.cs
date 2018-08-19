using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoKioskProject.Models;
using InfoKioskProject.Database;

namespace InfoKioskProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User(usernameTextBox.Text, passwordTextBox.Text);

            try
            {
                if (UserRepository.Login(user) != null)
                {
                    if (user.Role == "admin")
                    {
                        AdminForm admin = new AdminForm();
                        admin.Show();

                        admin.FormClosed += AdminForm_FormClosed;

                        Hide();

                        EmptyLoginTextBoxes();
                    }
                    else if (user.Role == "student")
                    {
                        MessageBox.Show("Улоговали сте се као студент.");

                        EmptyLoginTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Корисничко име и/или лозинка нису исправни.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTextBox.Focus();
                    }
                }
                else
                {
                    throw new Exception("Корисничко име или лозинка нису исправни.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                usernameTextBox.Focus();
            }
        }

        public void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm welcome = new welcomeForm();
            welcome.Show();
        }
        
        private void EmptyLoginTextBoxes()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
