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
    }
}
