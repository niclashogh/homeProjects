using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataManipulation
{
    public class dateTimeManipulation
    {
        public dateTimeManipulation(DateTime rawInput) //Constructor
        {
            Console.WriteLine($"Tids input : {rawInput}");

            CurrentDate(rawInput);
            RelativeDate(rawInput);
            SpanDate(rawInput);
        }

        /* =============================================================================================================================
                CurrentDate
        ============================================================================================================================= */

        public static void CurrentDate(DateTime rawInput)
        {
            Console.WriteLine($"\nRå : {rawInput.ToString()}\nDag, kort format : {rawInput.ToLongDateString()}\nMåned : {rawInput.Month.ToString()}\nDag på året : {rawInput.DayOfYear.ToString()}");
        }

        /* =============================================================================================================================
                RelativeDate
        ============================================================================================================================= */

        public static void RelativeDate(DateTime rawInput)
        {
            //Variables
            DateTime addDays = rawInput.AddDays(1);
            DateTime addHours = rawInput.AddHours(12);

            Console.WriteLine($"\nI morgen er det : {addDays.DayOfWeek.ToString()}, {addDays.ToLongDateString()}");
            Console.WriteLine($"\nOm 12 timer er det : {addHours.DayOfWeek.ToString()}, {addHours.ToShortTimeString()}, {addHours.ToLongDateString()}");
        }

        /* =============================================================================================================================
                SpanDate
        ============================================================================================================================= */

        public static void SpanDate(DateTime rawInput)
        {
            //Variables
            DateTime bDay = DateTime.Parse("9/12/1999");
            TimeSpan age = rawInput.Subtract(bDay);

            Console.WriteLine($"\nFødselsdag : {bDay.ToShortDateString()}");
            Console.WriteLine("Det er {0} år siden, tilsvarende {1} dage", (age.Days / 365), age.Days);
        }
    }
}
