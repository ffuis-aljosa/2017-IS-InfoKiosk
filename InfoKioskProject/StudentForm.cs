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

        public static int courseID;

        public StudentForm()
        {
            InitializeComponent();

            LoadProfile();

            //load grades
            LoadGrades();
            loadTotalExamsLabel.Text = "";
            loadAverageGradeLabel.Text = "";
            LoadExamStatistics();

            LoadAttempts();
            LoadExamsPage();
            LoadUnfinishedExams();
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

        //grades
        private void LoadGrades()
        {
            int studentID = StudentRepository.GetStudentID(LoginForm.username); 

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

        private void LoadExamStatistics()
        {
            int studentID = StudentRepository.GetStudentID(LoginForm.username);
            int studyProgramID = StudentRepository.GetStudentStudyProgram(studentID);

            int totalExams = Repository.GetTotalExams(studyProgramID);
            int totalGrades = Repository.GetTotalGrades(studentID);
            loadTotalExamsLabel.Text = totalGrades + "/" + totalExams;

            int sumOfGrades = Repository.GetSumOfGrades(studentID);
            float averageGrade = (float) sumOfGrades / totalGrades;
            loadAverageGradeLabel.Text = Math.Round(averageGrade, 2).ToString();
        }

        //exam attempts
        private void LoadAttempts()
        {
            int studentID = StudentRepository.GetStudentID(LoginForm.username);
            
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

        //exam requests
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
                courseCodeLabel.Hide();
                loadCourseCodeLabel.Hide();
                attemptsLabel.Hide();
                loadAttemptsLabel.Hide();
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
                courseCodeLabel.Show();
                loadCourseCodeLabel.Hide();
                attemptsLabel.Show();
                loadAttemptsLabel.Hide();
                addExamRequestButton.Show();

                loadActiveExamsPeriodLabel.Text = activePeriod;
                loadActiveTermLabel.Text = activeTerm;
            }
        }
        
        private void LoadUnfinishedExams()
        {
            int studentID = StudentRepository.GetStudentID(LoginForm.username);
            int studyProgramID = StudentRepository.GetStudentStudyProgram(studentID);

            int year = GetYearOfStudy(studentID);
            string semester_range = (((year - 1) * 2) - 1) + ", " + ((year - 1) * 2) + ", " + ((year * 2) - 1) + ", " + (year * 2);

            List<int> indexes = Repository.LoadUnfinishedExams(studentID);

            int p = indexes.Count();

            string grade_index = "";

            for (int i = 0; i < p - 1; i++)
                grade_index += indexes[i] + ", ";
            grade_index += indexes[p - 1].ToString();

            string sql = "";

            if (p == 0)
            {
                sql = "SELECT course_code AS \"" + "ШИФРА" + "\", name AS \"" + "ПРЕДМЕТ" + "\" " +
                         "FROM courses WHERE study_program_id = " + studyProgramID + " AND semester IN (" + semester_range + ");";
            }
            else
            {
                sql = "SELECT course_code AS \"" + "ШИФРА" + "\", name AS \"" + "ПРЕДМЕТ" + "\" " +
                         "FROM courses " +
                         "WHERE study_program_id = " + studyProgramID + " AND semester IN (" + semester_range + ") " +
                         "AND id NOT IN(" + grade_index + ");";
            }

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            unfinishedExamsDataGridView.DataSource = dataTable;
            unfinishedExamsDataGridView.RowHeadersVisible = false;
            unfinishedExamsDataGridView.Columns[0].Width = 82;
            unfinishedExamsDataGridView.Columns[1].Width = 370;
        }

        private int GetYearOfStudy(int studentID)
        {
            string year = StudentRepository.GetYearOfStudy(studentID);
            int yearOfStudy = 0;

            if (year == "прва")
                yearOfStudy = 1;
            else if (year == "друга")
                yearOfStudy = 2;
            else if (year == "трећа")
                yearOfStudy = 3;
            else
                yearOfStudy = 4;

            return yearOfStudy;
        }
        
        private void unfinishedExamsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.unfinishedExamsDataGridView.Rows[e.RowIndex];
            
            if (e.RowIndex >= 0)
            {
                int studentID = StudentRepository.GetStudentID(LoginForm.username);
                string courseCode = row.Cells[0].Value.ToString();
                courseID = Repository.GetCourseID(courseCode);

                loadCourseCodeLabel.Text = courseCode;
                loadCourseCodeLabel.Show();
                loadAttemptsLabel.Text = Repository.GetAttempts(studentID, courseID).ToString();
                loadAttemptsLabel.Show();
            }
        }

        private void addExamRequestButton_Click(object sender, EventArgs e)
        {
            int studentID = StudentRepository.GetStudentID(LoginForm.username);
            int examRequestID = Repository.GetExamRequestID(studentID, courseID);
            
            if (examRequestID != 0)
            {
                MessageBox.Show("Одабрани испит је већ пријављен.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Repository.AddExamRequest(studentID, courseID);
                MessageBox.Show("Успјешно сте пријавили испит.", "ПРИЈАВА ИСПИТА", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                loadCourseCodeLabel.Text = "";
                loadCourseCodeLabel.Hide();
                loadAttemptsLabel.Text = "";
                loadAttemptsLabel.Hide();
            }
        }
    }
}
