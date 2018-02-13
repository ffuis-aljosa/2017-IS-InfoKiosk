using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace InfoKioskProject.Database
{
    class DbConnection
    {
        private SqlCeConnection connection;

        private static DbConnection instance;

        private DbConnection(string connectionString)
        {
            connection = new SqlCeConnection(connectionString);
            connection.Open();
        }

        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbConnection(@"Data Source=..\..\Database.sdf");

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
