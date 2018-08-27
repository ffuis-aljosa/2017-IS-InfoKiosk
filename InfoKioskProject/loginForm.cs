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
        public static string username;
        public static int id;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

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
                        username = usernameTextBox.Text;
                        id = UserRepository.GetUserID(username);

                        if (!IsStudentRegistered())
                        {
                            MessageBox.Show("Студент са унесеним бројем индекса није уписан.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Student newStudent = StudentRepository.LoadStudentProfile(LoginForm.id);
                            string studentProfile = newStudent.FirstName + " " + newStudent.LastName;

                            StudentForm student = new StudentForm();
                            student.Show();
                            student.Text = "ИНФО КИОСК - " + studentProfile;

                            student.FormClosed += StudentForm_FormClosed;

                            Hide();

                            EmptyLoginTextBoxes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Корисничко име и/или лозинка нису исправни.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTextBox.Focus();
                    }
                }
                else
                {
                    throw new Exception("Корисничко име и/или лозинка нису исправни.");
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

        public void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm welcome = new welcomeForm();
            welcome.Show();
        }

        private bool IsStudentRegistered()
        {
            int studentId = StudentRepository.GetStudentID(username);

            if (studentId == 0)
                return false;
            else
                return true;
        }

        private void EmptyLoginTextBoxes()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
