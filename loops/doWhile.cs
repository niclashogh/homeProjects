using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public class doWhile
    {
        public static void DoWhile()
        {
            //Variables
            string input = "Jeg";
            int loop = 0;
            int loopEnd = 5;

            //Loop
            do //Goes thrugh one run and checks if it needs to run again.
            {
                Console.WriteLine(input);
                loop++;

                if (loop == loopEnd - 1)
                    input += " har brug for at du sætter mig i fucking stik-kontakten er det forstået din forpulede abeknepper?!";
            }
            while (loop < loopEnd);
        }
    }
}
