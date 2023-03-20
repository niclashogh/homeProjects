using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase.Models
{
    public class Person
    {
        //Variables & Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Role.Roles Role { get; set; } 

        public Person(string firstName, string middleName, string lastName, Role.Roles role)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Role = role;
        }
    }
}
