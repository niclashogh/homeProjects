using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamReader
{
    public class read
    {
        public static string TXTPath = "..\\..\\..\\Data.txt";
        public static string CSVPath = "..\\..\\..\\Data.csv";
        public static string EXCELPath = "..\\..\\..\\Data.xlsx";

        public static void ReadTXT()
        {
            //Variables
            string getContent;

            Console.WriteLine(".TXT Datasættet indeholder:");

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
                    StreamReader readConent = new StreamReader(TXTPath);

                    //Read the first line
                    getContent = readConent.ReadLine();

                    //Read-all
                    while (getContent != null)
                    {
                        Console.WriteLine(getContent);
                        getContent = readConent.ReadLine();
                    }
                    readConent.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /* =============================================================================================================================
                ReadCSV
        ============================================================================================================================= */

        public static void ReadCSV()
        {
            //Variables


            if (!File.Exists(CSVPath))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                //Instanciate method
                StreamWriter readContent = new StreamWriter(CSVPath);
            }
        }
    }
}
