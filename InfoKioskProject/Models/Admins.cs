using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InfoKioskProject.Models
{
    class Admins
    {
        private string username;
        private string password;

        public Admins(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Корисничко име не смије бити празно.");

                if (value.Length > 100)
                    throw new Exception("Корисничко име не смије бити дуже од 100 карактера.");

                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Лозинка мора имати бар 6 карактера.");

                using (SHA256 sha = new SHA256Managed())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                    byte[] hashedPassword = sha.ComputeHash(passwordBytes);

                    password = Convert.ToBase64String(hashedPassword);
                }
            }
        }
    }
}
