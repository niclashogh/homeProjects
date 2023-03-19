using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Person
    {
        //Variables & Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonRepo
    {
        public static List<Person> Load()
        {
            //Variables & Properties
            List<Person> newPerson = new List<Person>();

            //Add
            newPerson.Add(new Person { FirstName = "Hanne", MiddleName = "Høgh", LastName = "Jensen" }) ;
            newPerson.Add(new Person { FirstName = "Kennet", MiddleName = "Høgh", LastName = "Jensen" });
            newPerson.Add(new Person { FirstName = "Niclas", MiddleName = "Høgh", LastName = "Jensen" });
            newPerson.Add(new Person { FirstName = "Matilde", MiddleName = "Høgh", LastName = "Jensen" });
            newPerson.Add(new Person { FirstName = "Karoline", MiddleName = "Mongol", LastName = "Unge" });

            return newPerson;
        }
    }
}