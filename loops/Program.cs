namespace loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            @while.While();
            Console.ReadLine();
            Console.Clear();

            doWhile.DoWhile();
            Console.ReadLine();
            Console.Clear();

            @switch.Switch();

            //Await user interaction
            Console.ReadLine();
        }
    }
}