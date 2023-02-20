using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public class @while
    {
        public static void While()
        {
            //Variables
            int loop = 0;
            string inputString = "";

            //GetInput
            Console.Write("Skive en sætning/ord: ");
            inputString = Console.ReadLine();

            //Loop
            while (loop < inputString.Length) //If While = false, then skip while-method
            {
                Console.WriteLine(inputString[loop]);
                System.Threading.Thread.Sleep(500);
                loop++;
            }

        }
    }
}
