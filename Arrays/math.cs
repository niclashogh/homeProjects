using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class math
    {
        public static void Avg()
        {
            //Variables
            int loop = 6;
            int sum = 0;

            //Create array
            int[] array = new int[loop];

            //For-loop
            for (int i = 0; i < loop; i++)
            {
                Console.Write("Angiv et tal: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            //Print avg
            Console.WriteLine("\nGennemsnittet : {0}.", (sum / loop));
        }
    }
}
