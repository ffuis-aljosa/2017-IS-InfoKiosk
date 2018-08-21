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

        public static Student LoadStudentProfile(int id)
        {
            string sql = "SELECT * FROM students WHERE user_id = " + id + ";";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string firstName = reader.GetString(1);
                string lastName = reader.GetString(2);
                string dateOfBirth = reader.GetString(3);
                string idNumber = reader.GetString(4);
                string gender = reader.GetString(5);
                string placeOfBirth = reader.GetString(6);
                string citizenship = reader.GetString(7);
                string address = reader.GetString(8);
                string telephone = reader.GetString(9);
                int studyProgramID = reader.GetInt32(10);
                int userID = reader.GetInt32(11);
                string yearOfStudy = reader.GetString(12);
                int numberOfAdmitions = reader.GetInt32(13);
                string status = reader.GetString(14);
                string payment = reader.GetString(15);

                Student newStudent = new Student(firstName, lastName, dateOfBirth, idNumber, gender, placeOfBirth, citizenship,
                                                 address, telephone, studyProgramID, userID, yearOfStudy, numberOfAdmitions,
                                                 status, payment);

                return newStudent;
            }

            return null;
        }

        public static int GetStudentId(string index)
        {
            int studentID = 0;

            string sql = "SELECT * FROM students AS s JOIN users AS u ON u.id = s.user_id WHERE u.username = '" + index + "';";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                studentID = reader.GetInt32(0);
                return studentID;
            }

            return 0;
        }
    }
}
