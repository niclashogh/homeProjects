using dataBase.ViewModels;
using dataBase.Models;

namespace dataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonRepo personRepo = new PersonRepo();

            var Mom = new Person("Mor >", "Mooar >", "Mo", Role.Roles.Mom);
            var Dad = new Person("Far >","Faaaaar >","daddy ;)", Role.Roles.Dad);
            var Child1 = new Person("barn", "nummer", "1", Role.Roles.Child);
            var Child2 = new Person("barn", "nummer", "2", Role.Roles.Child);

            personRepo.Add(Mom);
            personRepo.Add(Dad);

            Console.WriteLine($"{Mom.FirstName} {Mom.MiddleName} {Mom.LastName}");
            Console.WriteLine($"{Dad.FirstName} {Dad.MiddleName} {Dad.LastName}");
            Console.WriteLine($"{Child1.FirstName} {Child1.MiddleName} {Child1.LastName}");
            Console.WriteLine($"{Child2.FirstName} {Child2.MiddleName} {Child2.LastName}");

            personRepo.GetAll();

            Console.ReadLine();
        }
    }
}