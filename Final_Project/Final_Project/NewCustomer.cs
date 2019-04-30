using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class NewCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public NewCustomer()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
            Gender = "";
            EmailAddress = "";
            Username = "";
            Password = "";
        }

        public NewCustomer(string firstname, string lastname, int age, string gender, string emailaddress, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Gender = gender;
            EmailAddress = emailaddress;
            Username = username;
            Password = password;
        }
    }
}
