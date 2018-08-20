using InfoKioskProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoKioskProject.Database
{
    class StudentRepository
    {
        private static DatabaseConnection connection = DatabaseConnection.Instance;

        public static void AddStudent(Student student)
        {
            string sql = "INSERT INTO students(first_name, last_name, date_of_birth, id_number, gender, place_of_birth," +
                         "citizenship, address, telephone, study_program_id, user_id, year_of_study, number_of_admitions, " +
                         "status, payment) VALUES " +
                         "('" + student.FirstName + "', '" + student.LastName + "', '" + student.DateOfBirth + "', '" +
                         student.IDNumber + "', '" + student.Gender + "', '" + student.PlaceOfBirth + "', '" + student.Citizenship
                         + "', '" + student.Address + "', '" + student.Telephone + "', " + student.StudyProgramID + ", " +
                         student.UserID + ", '" + student.YearOfStudy + "', " + student.NumberOfAdmitions + ", '" +
                         student.Status + "', '" + student.Payment + "');";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
