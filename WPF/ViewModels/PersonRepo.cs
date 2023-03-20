using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;

namespace WPF.ViewModels
{
    public class PersonRepo
    {
        public static List<Person> Load()
        {
            //Variables & Properties
            List<Person> newPerson = new List<Person>();

            //Add
            newPerson.Add(new Person { FirstName = "Hanne", MiddleName = "Høgh", LastName = "Jensen", Id = 1});
            newPerson.Add(new Person { FirstName = "Kennet", MiddleName = "Høgh", LastName = "Jensen", Id = 2 });
            newPerson.Add(new Person { FirstName = "Niclas", MiddleName = "Høgh", LastName = "Jensen", Id = 3 });
            newPerson.Add(new Person { FirstName = "Matilde", MiddleName = "Høgh", LastName = "Jensen", Id = 4 });
            newPerson.Add(new Person { FirstName = "Karoline", MiddleName = "Mongol", LastName = "Unge", Id = 5 });

            return newPerson;
        }

        public Person SelectedPerson { get; set; }
    }
}
