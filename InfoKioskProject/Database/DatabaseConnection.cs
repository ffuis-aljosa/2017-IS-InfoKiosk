using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace InfoKioskProject.Database
{
    class DatabaseConnection
    {
        private SqlCeConnection connection;

        private static DatabaseConnection instance;

        private DatabaseConnection(string connectionString)
        {
            connection = new SqlCeConnection(connectionString);
            connection.Open();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseConnection(@"Data Source=..\..\InfokioskProjectDatabase.sdf");

                return instance;
            }
        }

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
