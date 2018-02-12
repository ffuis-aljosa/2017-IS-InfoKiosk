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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            welcomeForm welcome = new welcomeForm();

            adminLoginForm adminLogin = new adminLoginForm();
            adminLogin.Show();

            adminLogin.FormClosed += AdminLoginForm_FormClosed;

            Hide();
        }

        private void AdminLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
