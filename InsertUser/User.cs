using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertUser
{
    public class User
    {
        public int id { get; set; }
        public string name { get; }
        public string surname { get; }
        public string login { get; }
        public string password { get; }
        public User()
        {
            id++;
            name = "None";
            surname = "None";
            login = "None";
            password = "None";
        }
        public User(string name, string surname, string login, string password)
        {
            id++;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
        }
        public override string ToString()
        {
            return "Name: " + name + 
                "\nSurname: " + surname + 
                "\nUsername: " + login + 
                "\nPassword: " + password;
        }
    }
}
