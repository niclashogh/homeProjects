namespace streamReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            write.WriteTXT();
            Console.ReadLine();
            Console.Clear();

            read.ReadTXT();
            Console.ReadLine();
            Console.Clear();

            write.WriteCSV();
            Console.ReadLine();
            Console.Clear();

        }
    }
}