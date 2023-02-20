using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataManipulation
{
    public class charManipulation
    {
        public charManipulation(char rawInput)
        {
            Console.WriteLine($"Bruger input : {rawInput}");

            CharValidation(rawInput);
            FindChar();
        }

        /* =============================================================================================================================
                CharValidation
        ============================================================================================================================= */

        public static void CharValidation(char rawInput)
        {
            //Variables
            //rawInput = Console.ReadKey(true).KeyChar; //Sets the rawInput = a new user input

            if (Char.IsDigit(rawInput))
            {
                Console.WriteLine($"Du trykkede '{rawInput}' hvilket er et tal.");
            }
            else
                Console.WriteLine($"Du trykkede '{rawInput}' hvilket er et bokstav.");
        }

        /* =============================================================================================================================
                FindChar
        ============================================================================================================================= */

        public static void FindChar()
        {
            //Variables
            string dummy = "abcdefghijklmnopqrstuvxyz";

            Console.WriteLine("\nDet 20. bokstav i alfabetet er '{0}'.", dummy[20]);
        }

    }
}
