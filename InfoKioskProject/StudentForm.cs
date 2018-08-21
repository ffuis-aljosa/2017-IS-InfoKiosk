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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            LoadProfile();
        }

        //load student profile
        private void LoadProfile()
        {
            Student student = StudentRepository.LoadStudentProfile(LoginForm.id);

            loadProfileLabel.Text = student.FirstName + " " + student.LastName + " (" + LoginForm.username + ")";

            loadDateOfBirthLabel.Text = student.DateOfBirth;
            loadIdNumberLabel.Text = student.IDNumber;
            loadGenderLabel.Text = student.Gender;
            loadPlaceOfBirthLabel.Text = student.PlaceOfBirth;
            loadCitizenshipLabel.Text = student.Citizenship;
            loadAddressLabel.Text = student.Address;
            loadTelephoneLabel.Text = student.Telephone;
            loadStudyProgramLabel.Text = GetStudyProgram(student.StudyProgramID);
            loadYearOfStudyLabel.Text = student.YearOfStudy;
            loadNumberOfAdmitionsLabel.Text = student.NumberOfAdmitions.ToString();
            loadStatusLabel.Text = student.Status;
            loadPaymentLabel.Text = student.Payment;
        }

        private string GetStudyProgram(int studyProgramID)
        {
            string studyProgram;

            if (studyProgramID == 1)
                studyProgram = "Математика и рачунарство";
            else if (studyProgramID == 2)
                studyProgram = "Српски језик и књижевност";
            else if (studyProgramID == 3)
                studyProgram = "Кинески и енглески језик и књижевност";
            else if (studyProgramID == 4)
                studyProgram = "Историја";
            else
                return null;

            return studyProgram;
        }
    }
}
