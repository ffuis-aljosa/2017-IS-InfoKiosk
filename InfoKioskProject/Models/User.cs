﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InfoKioskProject.Models
{
    class User
    {
        private string username;
        private string password;
        private string role;

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public User(string username, string password)
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
                    throw new Exception("Корисничко име (број индекса) не смије бити празно.");

                if (value.Length > 8)
                    throw new Exception("Корисничко име (број индекса) не смије бити дуже од 8 карактера.");

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

                if (value.Length > 128)
                    throw new Exception("Лозинка не смије бити дужа од 128 карактера.");

                using (SHA256 sha = new SHA256Managed())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                    byte[] hashedPassword = sha.ComputeHash(passwordBytes);

                    password = Convert.ToBase64String(hashedPassword);
                }
            }
        }

        public string  Role
        {
            get
            {
                return role;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Улога не смије бити празна.");
                if (value.Length > 8)
                    throw new Exception("Улога не смије бити дужа од 8 карактера.");

                role = value;
            }
        }
    }
}
