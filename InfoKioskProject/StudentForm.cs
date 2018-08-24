using InfoKioskProject.Database;
using InfoKioskProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoKioskProject
{
    public partial class StudentForm : Form
    {
        private static DatabaseConnection connection = DatabaseConnection.Instance;

        public StudentForm()
        {
            InitializeComponent();

            LoadProfile();
            LoadGrades();
            LoadFails();

            //exams
            LoadExamsPage();
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

        //exams
        private void LoadExamsPage()
        {
            string activePeriod = Repository.GetActiveExamsPeriod();
            string activeTerm = Repository.GetActiveExamsTerm();

            if (activePeriod == "null")
            {
                noActivePeriodsLabel.Show();

                unfinishedExamsLabel.Hide();
                unfinishedExamsDataGridView.Hide();
                activeExamsPeriodLabel.Hide();
                loadActiveExamsPeriodLabel.Hide();
                activeTermLabel.Hide();
                loadActiveTermLabel.Hide();
                noteLabel.Hide();
                addExamRequestButton.Hide();
            }
            else
            {
                noActivePeriodsLabel.Hide();

                unfinishedExamsLabel.Show();
                unfinishedExamsDataGridView.Show();
                activeExamsPeriodLabel.Show();
                loadActiveExamsPeriodLabel.Show();
                activeTermLabel.Show();
                loadActiveTermLabel.Show();
                noteLabel.Show();
                addExamRequestButton.Show();

                loadActiveExamsPeriodLabel.Text = activePeriod;
                loadActiveTermLabel.Text = activeTerm;
            }
        }

        private void LoadGrades()
        {
            int studentID = StudentRepository.GetStudentId(LoginForm.username); 

            string sql = "SELECT c.name AS \"" + "ПРЕДМЕТ" + "\", p.title_short + ' ' + p.first_name + ' ' + p.last_name AS \"" + "ПРОФЕСОР" + "\", " +
                         "g.date AS \"" + "ДАТУМ" + "\", g.value AS \"" + "ОЦЈЕНА" + "\" " +
                         "FROM grades AS g JOIN courses AS c ON c.id = g.course_id " +
                         "JOIN professors AS p ON p.id = g.professor_id " +
                         "WHERE g.student_id = " + studentID + " " +
                         "ORDER BY g.date ASC;";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            gradesDataGridView.DataSource = dataTable;
            gradesDataGridView.RowHeadersVisible = false;
            gradesDataGridView.Columns[0].Width = 360;
            gradesDataGridView.Columns[1].Width = 167;
            gradesDataGridView.Columns[2].Width = 65;
            gradesDataGridView.Columns[3].Width = 60;
        }

        private void LoadFails()
        {
            int studentID = StudentRepository.GetStudentId(LoginForm.username);
            
            string sql = "SELECT c.name AS \"" + "ПРЕДМЕТ" + "\", COUNT(a.id) AS \"" + "БРОЈ ИЗЛАЗАКА" + "\" " +
                         "FROM attempts AS a JOIN courses AS c ON a.course_id = c.id " +
                         "WHERE a.student_id = " + studentID + " " +
                         "GROUP BY c.name;";
            
            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);
            
            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            attemptsDataGridView.DataSource = dataTable;
            attemptsDataGridView.RowHeadersVisible = false;
            attemptsDataGridView.Columns[0].Width = 469;
            attemptsDataGridView.Columns[1].Width = 200;
        }
    }
}
