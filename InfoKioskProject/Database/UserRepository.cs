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

        public static User login(User user)
        {
            //Console.WriteLine("proslo ovdje");

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
    }
}
