using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public class @switch
    {
        public static void Switch()
        {
            Console.WriteLine("Røv eller patter?");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "Røv": case "røv":
                    Console.WriteLine("Godt valg!");
                    break;

                case "Patter": case "patter":
                    Console.WriteLine("Valg godt!");
                    break;

                default:
                    Console.WriteLine("Hvorfor er du sådan?");
                    break;
            }
        }

    }
}
