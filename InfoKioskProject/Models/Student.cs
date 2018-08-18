using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoKioskProject.Models
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string idNumber;
        private string gender;
        private string placeOfBirth;
        private string citizenship;
        private string address;
        private string telephone;
        private int studyProgramId;
        private int userID;
        private string yearOfStudy;
        private int numberOfAdmitions;
        private string status;
        private string payment;

        public Student(string firstName, string lastName, string dateOfBirth, string idNumber, string gender, string placeOfBirth, string citizenship, string address, string telephone, int studyProgramID, int userID, string yearOfStudy, int numberOfAdmitions, string status, string payment)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            IDNumber = idNumber;
            Gender = gender;
            PlaceOfBirth = placeOfBirth;
            Citizenship = citizenship;
            Address = address;
            Telephone = telephone;
            StudyProgramID = studyProgramID;
            UserID = userID;
            YearOfStudy = yearOfStudy;
            NumberOfAdmitions = numberOfAdmitions;
            Status = status;
            Payment = payment;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Име не смије бити празно.");

                if (value.Length > 32)
                    throw new Exception("Име не смије бити дуже од 32 карактера.");

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Презиме не смије бити празно.");

                if (value.Length > 32)
                    throw new Exception("Презиме не смије бити дуже од 32 карактера.");

                lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Датум не смије бити празан.");

                dateOfBirth = value;
            }
        }

        public string IDNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("ЈМБГ не смије бити празан.");

                idNumber = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Пол мора бити унесен.");

                gender = value;
            }
        }

        public string PlaceOfBirth
        {
            get
            {
                return placeOfBirth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Мјесто рођења не смије бити празно.");

                if (value.Length > 32)
                    throw new Exception("Мјесто рођења не смије бити дуже од 32 карактера.");

                placeOfBirth = value;
            }
        }

        public string Citizenship
        {
            get
            {
                return citizenship;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Држављанство не смије бити празно.");

                if (value.Length > 16)
                    throw new Exception("Држављанство не смије бити дуже од 16 карактера.");

                citizenship = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Адреса не смије бити празна.");

                if (value.Length > 128)
                    throw new Exception("Адреса не смије бити дужа од 128 карактера.");

                address = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Телефон мора бити унесен.");

                telephone = value;
            }
        }

        public int StudyProgramID
        {
            get
            {
                return studyProgramId;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Неисправан ид студијског програма.");

                studyProgramId = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Неисправан кориснички ид.");

                userID = value;
            }
        }

        public string YearOfStudy
        {
            get
            {
                return yearOfStudy;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Година студија не смије бити празна.");

                yearOfStudy = value;
            }
        }

        public int NumberOfAdmitions
        {
            get
            {
                return numberOfAdmitions;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Број уписа године мора бити бар 1.");

                numberOfAdmitions = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Статус студента не смије бити празан.");

                if (value.Length > 8)
                    throw new Exception("Статус студента не смије бити дужи од 8 карактера.");

                status = value;
            }
        }

        public string Payment
        {
            get
            {
                return payment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Начин финансирања не смије бити празан.");

                if (value.Length > 16)
                    throw new Exception("Начин финансирања не смије бити дужи од 16 карактера.");

                payment = value;
            }
        }
    }
}
