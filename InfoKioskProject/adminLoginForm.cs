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
    public partial class adminLoginForm : Form
    {
        public adminLoginForm()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Admins admin = new Admins(adminUsernameTextBox.Text, adminPasswordTextBox.Text);

                if (AdminRepository.login(admin) != null)
                {
                    MessageBox.Show("Успјешно сте се пријавили.", "Пријава",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Console.WriteLine(admin.Password);

                    /*adminLoginForm adminLogin = new adminLoginForm();

                    ad adminForm = new adminForm();
                    adminForm.Show();

                    Hide();*/
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
    }
}
