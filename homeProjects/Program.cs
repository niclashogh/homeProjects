namespace dataManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call Methods
            stringManipulation newString = new stringManipulation("Jeg har brug for medicinsk hjælp for at stoppe stemmerne i mit hovede!");
            Console.ReadLine();
            Console.Clear();

            intManipulation newInt = new intManipulation(6);
            Console.ReadLine();
            Console.Clear();

            dateTimeManipulation newDateTime = new dateTimeManipulation(DateTime.Now);
            Console.ReadLine();
            Console.Clear();

            charManipulation newChar = new charManipulation('1');

            //Await user interaction
            Console.ReadLine();
        }
    }
}