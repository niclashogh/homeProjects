using System.Runtime.CompilerServices;
using System.Xml;
using System.Diagnostics;
using System.Threading;

namespace threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method
            Thread meth = new Thread((object? obj) => method(obj));

            //Lambda
            Thread lamb = new Thread((object? obj) => lambda(obj));

            //Delegate
            Thread anon = new Thread(delegate (object? obj)
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(obj);
                }
            });

            //Start Threads
            meth.Start("Hello World (method)");
            meth.Join(); //'Join' gør at skaber rækkefølge | 'Start' starter processerne (i denne case med flere threads) hver for sig.
            lamb.Start("Hello World (lambda)");
            lamb.Join();
            anon.Start("Hello World (anonym)");
            anon.Join();

            //Await keypress
            Console.ReadKey();
        }

        //method Method
        public static void method(object obj)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(obj);
            }
        }

        //lambda Method
        public static void lambda(object obj)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(obj);
            }
        }
    }
}