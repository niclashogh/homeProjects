using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamReader
{
    public class write
    {
        public static string TXTPath = "..\\..\\..\\Data.txt";
        public static string CSVPath = "..\\..\\..\\Data.csv";
        public static string EXCELPath = "..\\..\\..\\Data.xlsx";

        public static void WriteTXT()
        {
            if (!File.Exists(TXTPath))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                try
                {
                    //Instanciate method
                    StreamWriter passContent = new StreamWriter(TXTPath, true, Encoding.ASCII); //true = Don't replace data

                    //Write w/ newline
                    passContent.WriteLine("Hello there");

                    //Write w/ newline
                    passContent.WriteLine("(:^P)-I--<");

                    Console.WriteLine("Det lykkes at skrive til datasættet (.TXT)");

                    //Close StreamWriter
                    passContent.Close();
                }
                finally
                {
                    //
                }
            }
        }

        /* =============================================================================================================================
                WriteCSV
        ============================================================================================================================= */

        public static void WriteCSV()
        {
            //Variables


            if (!File.Exists(CSVPath))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                try
                {
                    //Instanciate method
                    StreamWriter passContent = new StreamWriter(CSVPath, true, Encoding.ASCII); //true = Don't replace data

                    //Write w/ newline
                    passContent.WriteLine("B003;Koyver");

                    Console.WriteLine("Det lykkes at skrive til datasættet (.CSV)");

                    //Close StreamWriter
                    passContent.Close();
                }
                finally
                {
                    //
                }
            }

        }
    }
}
