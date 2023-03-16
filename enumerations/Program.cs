namespace enumerations
{
    //Enum
    enum TraficLight { Red, Yellow, Green };
    enum Family { Mom, Dad, Child }

    public class Program
    {
        static void Main(string[] args)
        {
            TraficLight light; //New instance of TraficLight
            light = TraficLight.Red; //Sets the instance to value TraficLight.Red

            TraficLight light2 = TraficLight.Green; //New instance and init

            //Casting
            string test = TraficLight.Yellow.ToString();
            int test2 = ((int)TraficLight.Red);

            Console.WriteLine("No .ToString: {0}, {1}", light, light2);
            Console.WriteLine("\nUsing .ToString: {0}", test);
            Console.WriteLine("\nCasting to int: {0}", test2); //Prints the selcted place of the acceptable values in the custom variable (0..)

            Console.ReadLine();
        }
    }
}