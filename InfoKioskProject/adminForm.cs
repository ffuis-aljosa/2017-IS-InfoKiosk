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
    public partial class AdminForm : Form
    {
        private static DatabaseConnection connection = DatabaseConnection.Instance;

        public static int studentID;
        public static int courseID;
        public static int professorID;
        public static int examRequstID;

        public AdminForm()
        {
            InitializeComponent();

            //add new user
            passwordWarningLabel.Hide();

            //grades
            gLoadStudentLabel.Text = "";
            gLoadCourseLabel.Text = "";
            gLoadProfessorLabel.Text = "";
            LoadExamRequests();
            
            //exams
            LoadActiveExamsPeriod();

            //search database
            secondSearchTermComboBox.Hide();
            databaseDataGridView.Hide();
            hideSearchButton.Hide();
        }

        //add new user
        private void addUserButton_Click(object sender, EventArgs e)
        {
            int userID = UserRepository.GetUserID(usernameTextBox.Text);

            try
            {
                if (AreUserFieldsValid())
                {
                    if (userID != 0)
                    {
                        MessageBox.Show("Корисничко име је заузето.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        usernameTextBox.Text = "";
                        usernameTextBox.Focus();
                        passwordTextBox.Text = "";
                        repeatPasswordTextBox.Text = "";
                    }
                    else if (passwordTextBox.Text == repeatPasswordTextBox.Text)
                    {
                        User newUser = new User(usernameTextBox.Text, passwordTextBox.Text, "student");
                        UserRepository.AddUser(newUser);

                        MessageBox.Show("Корисник успјешно регистрован.", "РЕГИСТРАЦИЈА", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        passwordWarningLabel.Hide();
                        EmptyLoginFields();
                    }
                    else
                    {
                        passwordWarningLabel.Show();
                        passwordTextBox.Text = "";
                        repeatPasswordTextBox.Text = "";
                        passwordTextBox.Focus();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        //validate user
        private bool AreUserFieldsValid()
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || repeatPasswordTextBox.Text == "")
            {
                MessageBox.Show("Сва поља морају бити попуњена.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsUsernameValid())
            {
                usernameTextBox.Focus();
                return false;
            }
            else if (!IsPasswordValid())
            {
                passwordTextBox.Focus();
                return false;
            }
            else
                return true;
        }

        private bool IsUsernameValid()
        {
            string username = usernameTextBox.Text;
            string subUsername = username.Substring(0, 2);

            if (username.Length > 8)
            {
                MessageBox.Show("Број индекса не смије бити дужи од 8 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (subUsername != "МР" && subUsername != "СЈ" && subUsername != "КЕ" && subUsername != "ИС")
            {
                MessageBox.Show("Број индекса не задовољава формат.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private bool IsPasswordValid()
        {
            string password = passwordTextBox.Text;

            if (password.Length < 6)
            {
                MessageBox.Show("Лозинка мора имати бар 6 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (password.Length > 128)
            {
                MessageBox.Show("Лозинка не смије бити дужа од 128 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        
        //add new student
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreStudentFieldsValid())
                {
                    string date = GetDateString();
                    string gender = GetGender();
                    int studyProgramID = GetStudyProgramID(studyProgramComboBox.Text);
                    int userID = UserRepository.GetUserID(indexTextBox.Text);
                    int numberOfAdmitions = int.Parse(numberOfAdmitionsTextBox.Text);

                    Student newStudent = new Student(firstNameTextBox.Text, lastNameTextBox.Text, date, idNumberTextBox.Text,
                            gender, placeOfBirthTextBox.Text, citizenshipTextBox.Text, addressTextBox.Text, telephoneTextBox.Text,
                            studyProgramID, userID, yearOfStudyComboBox.Text, numberOfAdmitions, statusComboBox.Text, paymentComboBox.Text);

                    StudentRepository.AddStudent(newStudent);

                    MessageBox.Show("Успјешно додавање студента.", "УПИС СТУДЕНТА", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmptyStudentFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetDateString()
        {
            int day = 0;
            int.TryParse(dayTextBox.Text, out day);
            string month = monthComboBox.Text;
            int year = 0;
            int.TryParse(yearOfBirthTextBox.Text, out year);

            string date = day + ". " + month + " " + year + ".";

            return date;
        }

        private string GetGender()
        {
            if (maleCheckBox.Checked && femaleCheckBox.Checked)
            {
                MessageBox.Show("Није могуће означити оба поља за пол.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                maleCheckBox.Checked = false;
                femaleCheckBox.Checked = false;

                return null;
            }
            else if (maleCheckBox.Checked)
                return "мушко";
            else if (femaleCheckBox.Checked)
                return "женско";

            return null;

        }

        private int GetStudyProgramID(string studyProgram)
        {
            int studyProgramID = 0;

            if (studyProgram == "Математика и рачунарство")
                studyProgramID = 1;
            else if (studyProgram == "Српски језик и књижевност")
                studyProgramID = 2;
            else if (studyProgram == "Кинески и енглески језик и књижевност")
                studyProgramID = 3;
            else if (studyProgram == "Историја")
                studyProgramID = 4;
            else
                return 0;

            return studyProgramID;
        }

        //validate student
        private bool AreStudentFieldsValid()
        {
            int studyProgramID = GetStudyProgramID(studyProgramComboBox.Text);
            int userID = UserRepository.GetUserID(indexTextBox.Text);
            int numberOfAdmitions = 0;
            int.TryParse(numberOfAdmitionsTextBox.Text, out numberOfAdmitions);

            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" ||
                dayTextBox.Text == "" || monthComboBox.Text == "" || yearOfBirthTextBox.Text == "" ||
                idNumberTextBox.Text == "" || placeOfBirthTextBox.Text == "" || citizenshipTextBox.Text == "" ||
                addressTextBox.Text == "" || telephoneTextBox.Text == "" || studyProgramComboBox.Text == "" ||
                indexTextBox.Text == "" || yearOfStudyComboBox.Text == "" || numberOfAdmitionsTextBox.Text == "" ||
                statusComboBox.Text == "" || paymentComboBox.Text == "")
            {
                MessageBox.Show("Сва поља морају бити попуњена.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsFirstNameValid())
            {
                firstNameTextBox.Focus();
                MessageBox.Show("Име студента не смије бити дуже од 32 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsLastNameValid())
            {
                lastNameTextBox.Focus();
                MessageBox.Show("Презиме студента не смије бити дуже од 32 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsDateValid())
            {
                dayTextBox.Focus();
                return false;
            }
            else if (!IsIdNumberValid())
            {
                idNumberTextBox.Focus();
                MessageBox.Show("Неисправан јмбг.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsGenderValid())
            {
                MessageBox.Show("Није могуће означити оба поља за пол.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsCityValid())
            {
                placeOfBirthTextBox.Focus();
                MessageBox.Show("Мјесто рођења не смије бити дуже од 32 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsCitizenshipValid())
            {
                citizenshipTextBox.Focus();
                MessageBox.Show("Држављанство не смије бити дуже од 16 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsAddressValid())
            {
                addressTextBox.Focus();
                MessageBox.Show("Адреса не смије бити дужа од 64 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsTelephoneValid())
            {
                telephoneTextBox.Focus();
                MessageBox.Show("Телефон не смије бити дужи од 16 карактера.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (studyProgramID == 0)
            {
                MessageBox.Show("Морате изабрати један од понуђених студијских програма.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                studyProgramComboBox.Focus();
                return false;
            }
            else if (userID <= 1)
            {
                MessageBox.Show("Неисправан број индекса.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexTextBox.Focus();
                return false;
            }
            else if (!DoesIndexMatchStudyProgram())
            {
                MessageBox.Show("Број индекса не одговара студијском програму.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsYearOfStudyValid())
            {
                MessageBox.Show("Морате изабрати годину студија.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearOfStudyComboBox.Focus();
                return false;
            }
            else if (numberOfAdmitions < 1)
            {
                MessageBox.Show("Број уписа године није исправан.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfAdmitionsTextBox.Focus();
                return false;
            }
            else if (numberOfAdmitions > 4)
            {
                MessageBox.Show("Број уписа године не може бити већи од 4.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfAdmitionsTextBox.Focus();
                return false;
            }
            else if (!IsStatusValid())
            {
                MessageBox.Show("Морате изабрати један од понуђених типова статуса студента.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                statusComboBox.Focus();
                return false;
            }
            else if (!IsPaymentValid())
            {
                MessageBox.Show("Морате изабрати један од понуђених начина финансирања.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                paymentComboBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsFirstNameValid()
        {
            string firstName = firstNameTextBox.Text;

            if (firstName.Length > 32)
                return false;
            else
                return true;
        }

        private bool IsLastNameValid()
        {
            string lastName = lastNameTextBox.Text;

            if (lastName.Length > 32)
                return false;
            else
                return true;
        }

        private bool IsDateValid()
        {
            int year = 0;
            int.TryParse(yearOfBirthTextBox.Text, out year);

            int dayNumber = GetNumberOfDays(monthComboBox.Text, year);
            int day = 0;
            int.TryParse(dayTextBox.Text, out day);

            if (day < 1 || day > dayNumber)
            {
                MessageBox.Show("Датум није исправан.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (year < 1960 || year > 2000)
            {
                MessageBox.Show("Датум није исправан. Унесена година мора бити између 1960. и 2000.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsMonthValid())
            {
                MessageBox.Show("Датум није исправан.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private int GetNumberOfDays(string month, int year)
        {
            int days = 0;

            if (month == "јануар")
                days = 31;
            else if (month == "фебруар")
            {
                if (year % 4 == 0)
                    days = 29;
                else
                    days = 28;
            }
            else if (month == "март")
                days = 31;
            else if (month == "април")
                days = 30;
            else if (month == "мај")
                days = 31;
            else if (month == "јун")
                days = 30;
            else if (month == "јул")
                days = 31;
            else if (month == "август")
                days = 31;
            else if (month == "септембар")
                days = 30;
            else if (month == "октобар")
                days = 31;
            else if (month == "новембар")
                days = 30;
            else if (month == "децембар")
                days = 31;
            else
                return 0;

            return days;
        }

        private bool IsMonthValid()
        {
            string month = monthComboBox.Text;

            if (month == "јануар" || month == "фебруар" || month == "март" || month == "април" || month == "мај" || month == "јун" ||
                month == "јул" || month == "август" || month == "септембар" || month == "октобар" || month == "новембар" || month == "децембар")
                return true;
            else
                return false;
        }

        private bool IsIdNumberValid()
        {
            string idNumber = idNumberTextBox.Text;

            if (idNumber.Length != 13)
                return false;
            else
                return true;
        }

        private bool IsGenderValid()
        {
            if (maleCheckBox.Checked && femaleCheckBox.Checked)
            {
                maleCheckBox.Checked = false;
                femaleCheckBox.Checked = false;

                return false;
            }
            else
                return true;
        }

        private bool IsCityValid()
        {
            string city = placeOfBirthTextBox.Text;

            if (city.Length > 32)
                return false;
            else
                return true;
        }

        private bool IsCitizenshipValid()
        {
            string citizenship = citizenshipTextBox.Text;

            if (citizenship.Length > 16)
                return false;
            else
                return true;
        }

        private bool IsAddressValid()
        {
            string address = addressTextBox.Text;

            if (address.Length > 64)
                return false;
            else
                return true;
        }

        private bool IsTelephoneValid()
        {
            string telephone = telephoneTextBox.Text;

            if (telephone.Length > 16)
                return false;
            else
                return true;
        }

        private bool DoesIndexMatchStudyProgram()
        {
            int studyProgramID = GetStudyProgramID(studyProgramComboBox.Text);
            string index = indexTextBox.Text;
            string subIndex = index.Substring(0, 2);

            if (subIndex == "МР" && studyProgramID == 1)
                return true;
            else if (subIndex == "СЈ" && studyProgramID == 2)
                return true;
            else if (subIndex == "КЕ" && studyProgramID == 3)
                return true;
            else if (subIndex == "ИС" && studyProgramID == 4)
                return true;
            else
                return false;
        }

        private bool IsYearOfStudyValid()
        {
            string year = yearOfStudyComboBox.Text;

            if (year == "прва" || year == "друга" || year == "трећа" || year == "четврта")
                return true;
            else
                return false;
        }

        private bool IsStatusValid()
        {
            string status = statusComboBox.Text;

            if (status == "редован" || status == "ванредан")
                return true;
            else
                return false;
        }

        private bool IsPaymentValid()
        {
            string payment = paymentComboBox.Text;
            if (payment == "буџет" || payment == "самофинансирање" || payment == "суфинансирање")
                return true;
            else
                return false;
        }

        //empty fields
        private void EmptyLoginFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            repeatPasswordTextBox.Text = "";
        }

        private void EmptyStudentFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dayTextBox.Text = "";
            monthComboBox.Text = "";
            yearOfBirthTextBox.Text = "";
            idNumberTextBox.Text = "";
            maleCheckBox.Checked = false;
            femaleCheckBox.Checked = false;
            placeOfBirthTextBox.Text = "";
            citizenshipTextBox.Text = "";
            addressTextBox.Text = "";
            telephoneTextBox.Text = "";
            studyProgramComboBox.Text = "";
            indexTextBox.Text = "";
            yearOfStudyComboBox.Text = "";
            numberOfAdmitionsTextBox.Text = "";
            statusComboBox.Text = "";
            paymentComboBox.Text = "";
        }

        private void EmptyGradeFields()
        {
            gLoadStudentLabel.Text = "";
            gLoadCourseLabel.Text = "";
            gLoadProfessorLabel.Text = "";
            gGradeTextBox.Text = "";
            gDateTextBox.Text = "";
        }

        //search database
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (secondSearchTermComboBox.Visible.Equals(false))
            {
                if (searchTermsComboBox.SelectedIndex.Equals(0))
                    LoadUsersData();
                else if (searchTermsComboBox.SelectedIndex.Equals(1))
                    LoadStudentsData();
                else if (searchTermsComboBox.SelectedIndex.Equals(2))
                    LoadProfessorsData();
                else if (searchTermsComboBox.SelectedIndex.Equals(3))
                    LoadStudyProgramsData();
                else if (searchTermsComboBox.SelectedIndex.Equals(4))
                {
                    secondSearchTermComboBox.Show();
                    hideSearchButton.Show();
                }
                else
                {
                    MessageBox.Show("Морате изабрати услове претраге.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTermsComboBox.Text = "";
                    searchTermsComboBox.Focus();
                }
            } 
            else
            {
                int studyProgramID = GetStudyProgramID(secondSearchTermComboBox.Text);

                if (studyProgramID == 0)
                {
                    MessageBox.Show("Морате изабрати услове претраге.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    secondSearchTermComboBox.Text = "";
                    secondSearchTermComboBox.Focus();
                }   
                else
                {
                    LoadCoursesData(studyProgramID);
                    secondSearchTermComboBox.Text = "";
                    secondSearchTermComboBox.Hide();
                    hideSearchButton.Hide();
                }
            }
        }

        private void LoadUsersData()
        {
            string sql = "SELECT u.username AS \"КОРИСНИЧКО ИМЕ\", s.first_name + ' ' + s.last_name AS \"СТУДЕНТ\" " +
                         "FROM users AS u JOIN students AS s ON s.user_id = u.id " +
                         "WHERE role = 'student';";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            databaseDataGridView.DataSource = dataTable;
            databaseDataGridView.Show();

            databaseDataGridView.RowHeadersVisible = false;
            databaseDataGridView.Columns[0].Width = 200;
            databaseDataGridView.Columns[1].Width = 340;
        }

        private void LoadStudentsData()
        {
            string sql = "SELECT s.first_name AS \"ИМЕ\", s.last_name AS \"ПРЕЗИМЕ\", s.date_of_birth AS \"ДАТУМ РОЂЕЊА\", " +
                         "s.id_number AS \"ЈМБГ\", s.gender AS \"ПОЛ\", s.place_of_birth AS \"МЈЕСТО РОЂЕЊА\", " +
                         "s.citizenship  AS \"ДРЖАВЉАНСТВО\", s.address  AS \"АДРЕСА\", s.telephone AS \"ТЕЛЕФОН\", " +
                         "sp.name AS \"СТУДИЈСКИ ПРОГРАМ\", u.username AS \"БРОЈ ИНДЕКСА\", s.year_of_study AS \"ГОДИНА СТУДИЈА\", " +
                         "s.number_of_admitions AS \"БРОЈ УПИСА ГОДИНЕ\", s.status  AS \"СТАТУС\", s.payment AS \"НАЧИН ФИНАНСИРАЊА\" " +
                         "FROM students AS s JOIN study_programs AS sp ON sp.id = s.study_program_id " +
                         "JOIN users AS u ON s.user_id = u.id;";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            databaseDataGridView.DataSource = dataTable;
            databaseDataGridView.Show();
            databaseDataGridView.AutoResizeColumns();
        }

        private void LoadProfessorsData()
        {
            string sql = "SELECT p.title AS \"СТАТУС\", p.title_short AS \"ЗВАЊЕ\"," +
                         "p.first_name AS \"ИМЕ\", p.last_name AS \"ПРЕЗИМЕ\", d.name AS \"КАТЕДРА\" " +
                         "FROM professors AS p JOIN departments AS d ON p.department_id = d.id;";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            databaseDataGridView.DataSource = dataTable;
            databaseDataGridView.Show();

            databaseDataGridView.RowHeadersVisible = false;
            databaseDataGridView.Columns[0].Width = 120;
            databaseDataGridView.Columns[1].Width = 70;
            databaseDataGridView.Columns[2].Width = 100;
            databaseDataGridView.Columns[3].Width = 100;
            databaseDataGridView.Columns[4].Width = 170;
        }

        private void LoadStudyProgramsData()
        {
            string sql = "SELECT id AS \"РЕДНИ БРОЈ\", name AS \"НАЗИВ СТУДИЈСКОГ ПРОГРАМА\" FROM study_programs;";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            databaseDataGridView.DataSource = dataTable;
            databaseDataGridView.Show();

            databaseDataGridView.RowHeadersVisible = false;
            databaseDataGridView.Columns[0].Width = 100;
            databaseDataGridView.Columns[1].Width = 457;
        }

        private void LoadCoursesData(int id)
        {
            string sql = "SELECT course_code AS \"ШИФРА\", name AS \"НАЗИВ ПРРЕДМЕТА\", semester AS \"СЕМЕСТАР\", " +
                         "ects AS \"ЕСПБ\", p.title_short + ' ' + p.first_name + ' ' + p.last_name AS \"ПРОФЕСОР\" " +
                         "FROM courses AS c JOIN professors AS p ON c.professor_id = p.id " +
                         "WHERE c.study_program_id = " + id + ";";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            databaseDataGridView.DataSource = dataTable;
            databaseDataGridView.Show();

            databaseDataGridView.RowHeadersVisible = false;
            databaseDataGridView.AutoResizeColumns();
        }

        private void hideSearchButton_Click(object sender, EventArgs e)
        {
            secondSearchTermComboBox.Hide();
            hideSearchButton.Hide();
        }

        //set exams period
        private void startPeriodButton_Click(object sender, EventArgs e)
        {
            if (!IsPeriodValid())
            {
                MessageBox.Show("Морате изабрати један од понуђених испитних рокова.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                periodComboBox.Focus();
                periodComboBox.Text = "";
                termComboBox.Text = "";
            }
            else if (!IsTermValid())
            {
                MessageBox.Show("Морате изабрати један од понуђених термина.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                termComboBox.Focus();
                termComboBox.Text = "";
            }
            else
            {
                string period = periodComboBox.Text;
                string term = termComboBox.Text;

                Repository.SetExamsPeriod(period, term);

                LoadActiveExamsPeriod();
            }
        }
        
        private void endPeriodButton_Click(object sender, EventArgs e)
        {
            Repository.StopExamsPeriod();

            LoadActiveExamsPeriod();
            periodComboBox.Text = "";
            termComboBox.Text = "";
        }
        
        private void LoadActiveExamsPeriod()
        {
            string activePeriod = Repository.GetActiveExamsPeriod();
            
            if (activePeriod == "null")
                activePeriodLabel.Text = "Тренутно није активан ниједан испитни рок.";
            else
                activePeriodLabel.Text = "Тренутно је активан " + activePeriod + " испитни рок.";
        }

        //validate exam period
        private bool IsPeriodValid()
        {
            string period = periodComboBox.Text;

            if (period == "јануарско-фебруарски" || period == "априлски" || period == "јунско-јулски" || period == "септембарски" || period == "октобарски")
                return true;
            else
                return false;
        }

        private bool IsTermValid()
        {
            string term = termComboBox.Text;

            if (term == "први" || term == "други")
                return true;
            else
                return false;
        }

        //add grades
        private void LoadExamRequests()
        {
            string sql = "SELECT s.first_name + ' ' + s.last_name AS \"СТУДЕНТ\", " +
                         "u.username AS \"БРОЈ ИНДЕКСА\", c.name AS \"ПРЕДМЕТ\", " +
                         "p.title_short + ' ' + p.first_name + ' ' + p.last_name  AS \"ПРОФЕСОР\" " +
                         "FROM exam_requests AS er JOIN students AS s ON er.student_id = s.id " +
                         "JOIN users AS u ON u.id = s.user_id " +
                         "JOIN courses AS c ON er.course_id = c.id " +
                         "JOIN professors AS p ON c.professor_id = p.id " +
                         "WHERE er.is_request_done = 'false';";
            
            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter = new SqlCeDataAdapter(sql, connection.Connection);

            DataSet dataSet = new DataSet();
            dataSet.Reset();

            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];

            examRequestsDataGridView.DataSource = dataTable;
            examRequestsDataGridView.RowHeadersVisible = false;
            
            examRequestsDataGridView.Columns[0].Width = 150;
            examRequestsDataGridView.Columns[1].Width = 100;
            examRequestsDataGridView.Columns[2].Width = 250;
            examRequestsDataGridView.Columns[3].Width = 200;
        }

        private void examRequestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.examRequestsDataGridView.Rows[e.RowIndex];
                string index = row.Cells[1].Value.ToString();
                string studentShort = StudentRepository.GetStudentShort(index);
                string courseName = row.Cells[2].Value.ToString();
                string professor = Repository.GetCourseProfessor(courseName);

                studentID = StudentRepository.GetStudentID(index);
                courseID = Repository.GetCourseIDByName(courseName);
                professorID = Repository.GetProfessorID(courseName);

                gLoadStudentLabel.Text = studentShort;
                gLoadStudentLabel.Show();
                gLoadProfessorLabel.Text = professor;
                gLoadProfessorLabel.Show();
                gLoadCourseLabel.Text = courseName;
                gLoadCourseLabel.Show();
            }
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            int examRequestID = Repository.GetExamRequestID(studentID, courseID);
            int professorID = Repository.GetIDProfessor(courseID);

            int grade = 0;
            int.TryParse(gGradeTextBox.Text, out grade);

            if (!IsExamRequestSelected())
            {
                MessageBox.Show("Морате одабрати један од пријављених испита.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsGradeValid(grade))
            {
                MessageBox.Show("Оцјена није исправна.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gGradeTextBox.Text = "";
                gGradeTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(gDateTextBox.Text))
            {
                MessageBox.Show("Датум мора бити унесен.", "УПОЗОРЕЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gDateTextBox.Focus();
            }
            else
            {
                if (grade == 5)
                {
                    Repository.AddAttempt(studentID, courseID);
                    Repository.DisableExamRequest(examRequestID);
                    
                    LoadExamRequests();
                    EmptyGradeFields();
                }
                else
                {
                    try
                    {
                        string date = gDateTextBox.Text;

                        Repository.AddAttempt(studentID, courseID);
                        Repository.AddGrade(studentID, courseID, professorID, grade, date);
                        Repository.DisableExamRequest(examRequestID);
                        
                        LoadExamRequests();
                        EmptyGradeFields();
                    }
                    catch
                    {
                        MessageBox.Show("Дошло је до грешке. Провјерите унесене податке.", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //validate add grade
        private bool IsGradeValid(int grade)
        {
            if (grade > 4 && grade < 11)
                return true;
            else
                return false;
        }

        private bool IsExamRequestSelected()
        {
            if (gLoadStudentLabel.Text != "" && gLoadCourseLabel.Text != "" && gLoadProfessorLabel.Text != "")
                return true;
            else
                return false;
        }
    }
}
