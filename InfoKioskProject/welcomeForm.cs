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

        private void loginButton_Click(object sender, EventArgs e)
        {
            welcomeForm welcome = new welcomeForm();

            loginForm login = new loginForm();
            login.Show();

            login.FormClosed += loginForm_FormClosed;

            Hide();
        }
        
        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
