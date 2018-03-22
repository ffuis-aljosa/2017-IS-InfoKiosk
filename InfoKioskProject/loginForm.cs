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
using InfoKioskProject.Models;

namespace InfoKioskProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Users user = new Users(usernameTextBox.Text, passwordTextBox.Text);

            try
            {
                if (UserRepository.login(user) != null)
                {
                    if (user.Role == "admin")
                    {
                        adminForm admin = new adminForm();
                        admin.Show();
                        
                        admin.FormClosed += AdminForm_FormClosed;

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пријавили сте се као студент.", "Пријава", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        public void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm welcome = new welcomeForm();
            welcome.Show();
        }
    }
}
