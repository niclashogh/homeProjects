using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataBase.Models;

namespace dataBase.ViewModels
{
    public class PersonRepo
    {
        List<Person> PersonList = new List<Person>();

        public void Add(Person person)
        {
            PersonList.Add(person);
        }

        public List<Person> GetAll()
        {
            return PersonList;
        }
    }
}
