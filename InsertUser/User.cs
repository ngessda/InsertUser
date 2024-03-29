﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertUser
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return "Name: " + name + 
                "\nSurname: " + surname + 
                "\nUsername: " + login + 
                "\nPassword: " + password;
        }
    }
}
