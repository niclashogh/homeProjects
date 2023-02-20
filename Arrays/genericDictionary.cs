using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class genericDictionary
    {
        public static void GenericDictionary()
        {
            //Instances of class Car
            Car car1 = new Car() { Launched = "1978", Model = "Fiat" };
            Car car2 = new Car() { Launched = "2001", Model = "Wolvo" };

            //Better method of making a list
            Dictionary<string, Car> sDictionary = new Dictionary<string, Car>();
            sDictionary.Add(car1.Launched, car1);
            sDictionary.Add(car2.Launched, car2);

            Console.WriteLine("Liste (GenericDictionary):");

            //Printout
            Console.WriteLine(sDictionary["2001"].Model); //No casting again

        }
    }
}
