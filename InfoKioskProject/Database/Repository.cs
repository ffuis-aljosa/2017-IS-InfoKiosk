using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoKioskProject.Database
{
    class Repository
    {
        private static DatabaseConnection connection = DatabaseConnection.Instance;

        //exam periods
        public static string GetActiveExamsPeriod()
        {
            string activePeriod;

            string sql = "SELECT name FROM exam_periods;";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                activePeriod = reader.GetString(0);
                return activePeriod;
            }

            return null;
        }

        public static string GetActiveExamsTerm()
        {
            string activeTerm;

            string sql = "SELECT term FROM exam_periods;";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                activeTerm = reader.GetString(0);
                return activeTerm;
            }

            return null;
        }

        public static void SetExamsPeriod(string period, string term)
        {
            string sql_period = "UPDATE exam_periods SET name = '" + period + "' WHERE id = 1;";
            string sql_term = "UPDATE exam_periods SET term = '" + term + "' WHERE id = 1;";

            SqlCeCommand command_period = new SqlCeCommand(sql_period, connection.Connection);
            command_period.ExecuteNonQuery();

            SqlCeCommand command_term = new SqlCeCommand(sql_term, connection.Connection);
            command_term.ExecuteNonQuery();
        }

        public static void StopExamsPeriod()
        {
            string sql_period = "UPDATE exam_periods SET name = 'null' WHERE id = 1;";
            string sql_term = "UPDATE exam_periods SET term = 'null' WHERE id = 1;";

            SqlCeCommand command_period = new SqlCeCommand(sql_period, connection.Connection);
            command_period.ExecuteNonQuery();

            SqlCeCommand command_term = new SqlCeCommand(sql_term, connection.Connection);
            command_term.ExecuteNonQuery();
        }

        //unfinished exams
        public static List<int> LoadUnfinishedExams(int student_id)
        {
            List<int> index = new List<int>();

            string sql = "SELECT course_id FROM grades WHERE student_id =" + student_id + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                index.Add(id);
            }
            
            return index;
        }

        //exam requests
        public static void AddExamRequest(int studentID, int courseID)
        {
            string sql = "INSERT INTO exam_requests(student_id, course_id, is_request_done) VALUES " +
                         "(" + studentID + ", " + courseID + ", 'false');";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }

        public static void DisableExamRequest(int examRequestID)
        {
            string sql = "UPDATE exam_requests SET is_request_done = 'true' WHERE id = " + examRequestID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }

        //attempts
        public static int GetAttempts(int studentID, int courseID)
        {
            int attempts = 0;

            string sql = "SELECT COUNT(id) FROM attempts WHERE student_id = " + studentID + " AND course_id = " + courseID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                attempts = reader.GetInt32(0);
                return attempts;
            }

            return 0;
        }

        public static void AddAttempt(int studentID, int courseID)
        {
            string sql = "INSERT INTO attempts(student_id, course_id) VALUES " +
                         "(" + studentID + ", " + courseID + ");";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }

        //grades
        public static void AddGrade(int studentID, int courseID, int professorID, int value, string date)
        {
            string sql = "INSERT INTO grades(student_id, course_id, professor_id, value, date) VALUES " +
                         "(" + studentID + ", " + courseID + ", " + professorID + ", " + value + ", '" + date + "');";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }

        public static int GetTotalExams(int studyProgramID)
        {
            int totalExams = 0;

            string sql = "SELECT COUNT(id) FROM courses WHERE study_program_id = " + studyProgramID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                totalExams = reader.GetInt32(0);
                return totalExams;
            }

            return 0;
        }

        public static int GetTotalGrades(int studentID)
        {
            int totalGrades = 0;

            string sql = "SELECT COUNT(id) FROM grades WHERE student_id = " + studentID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                totalGrades = reader.GetInt32(0);
                return totalGrades;
            }

            return 0;
        }

        public static int GetSumOfGrades(int studentID)
        {
            int sum = 0;

            string sql = "SELECT SUM(value) FROM grades WHERE student_id = " + studentID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                sum = reader.GetInt32(0);
                return sum;
            }

            return 0;
        }

        //get data
        public static string GetCourseProfessor(string courseName)
        {
            string professor;

            string sql = "SELECT p.title_short + ' ' + p.first_name + ' ' + p.last_name AS professor " +
                         "FROM courses AS c JOIN professors AS p ON c.professor_id = p.id " +
                         "WHERE c.name = '" + courseName + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                professor = reader.GetString(0);
                return professor;
            }

            return null;
        }

        public static int GetIDProfessor(int courseID)
        {
            int professorID = 0;

            string sql = "SELECT p.id FROM courses AS c JOIN professors AS p ON p.id = c.professor_id WHERE c.id = " + courseID + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                professorID = reader.GetInt32(0);
                return professorID;
            }

            return 0;
        }

        public static int GetCourseIDByName(string courseName)
        {
            int courseID = 0;

            string sql = "SELECT id FROM courses WHERE name = '" + courseName + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                courseID = reader.GetInt32(0);
                return courseID;
            }

            return 0;
        }

        public static int GetProfessorID(string courseName)
        {
            int professorID = 0;

            string sql = "SELECT p.id FROM professors AS p JOIN courses AS c ON c.professor_id = p.id " +
                         "WHERE c.name = '" + courseName + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                professorID = reader.GetInt32(0);
                return professorID;
            }

            return 0;
        }

        public static int GetCourseID(string courseCode)
        {
            int courseID = 0;

            string sql = "SELECT id FROM courses WHERE course_code = '" + courseCode + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                courseID = reader.GetInt32(0);
                return courseID;
            }

            return 0;
        }

        public static int GetExamRequestID(int studentID, int courseID)
        {
            int examRequestID = 0;

            string sql = "SELECT id FROM exam_requests WHERE student_id = " + studentID + " AND course_id = " + courseID + " " +
                         "AND is_request_done = 'false';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                examRequestID = reader.GetInt32(0);
                return examRequestID;
            }

            return 0;
        }
    }
}
