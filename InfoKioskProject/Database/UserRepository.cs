using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoKioskProject.Models;
using System.Data.SqlServerCe;

namespace InfoKioskProject.Database
{
    class UserRepository
    {
        private static DatabaseConnection connection = DatabaseConnection.Instance;

        public static User Login(User user)
        {
            string sql = @"SELECT * FROM users WHERE username = @username AND password = @password";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", user.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);

            SqlCeParameter role = new SqlCeParameter("@role", user.Role);
            command.Parameters.Add(role);

            command.Prepare();

            Console.WriteLine(user.Password);

            SqlCeDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                user.Role = reader["role"].ToString();
                return user;
            }

            return null;
        }

        public static void AddUser(User user)
        {
            string sql = "INSERT INTO users(username, password, role) VALUES " +
                    "('" + user.Username + "', '" + user.Password + "', '" + user.Role + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }

        public static int GetUserId(string index)
        {
            int userID = 0;

            string sql = "SELECT * FROM users WHERE username = '" + index + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                userID = reader.GetInt32(0);
                return userID;
            }

            return 0;
        }
    }
}
