using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoKioskProject.Models;
using System.Data.SqlServerCe;

namespace InfoKioskProject.Database
{
    class AdminRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static Admins login(Admins admin)
        {
            string sql = @"SELECT * FROM admins WHERE username = @username AND password = @password";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", admin.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", admin.Password);
            command.Parameters.Add(password);

            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return admin;
            }

            return null;
        }
    }
}
