using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class genericList
    {
        public static void GenericList()
        {
            //Instances of class Car
            Car car1 = new Car() { Launched = "1978", Model = "Fiat" };
            Car car2 = new Car() { Launched = "2001", Model = "Wolvo" };

            //Better method to making a list
            List<Car> sList = new List<Car>();
            sList.Add(car1);
            sList.Add(car2);

            Console.WriteLine("Liste (List):");

            //Foreach instance of the specific obj (Car).
            foreach (Car inst in sList) //Foreach instance of Car in sList. inst = variable to temp save the instances of Car(s).
            {
                Console.WriteLine("{0}, {1}", inst.Model, inst.Launched); //No casting required because we specified a generic list to Car.
            }

        }
    }
}
