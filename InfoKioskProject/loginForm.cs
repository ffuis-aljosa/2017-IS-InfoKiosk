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

                    Console.WriteLine("proslo");

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
                        // user.Username
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

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if enter then 
            // loginButton_Click(object sender, EventArgs e)
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
