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

        public static int GetCourseID(string courseCode)
        {
            int courseID = 0;

            string sql = "SELECT * FROM courses WHERE course_code = '" + courseCode + "';";

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


    }
}
