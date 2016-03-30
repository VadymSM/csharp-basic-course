using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;


namespace CreateString
{
    class Program
    {
        static void Task1()
        {
            for (int i = 65, j = 97; i < 91; i++, j++)
            {
                Console.Write((char)i + " " + (char)j + " ");
            }
            Console.WriteLine();
            
        }

        static void Task2()
        {
            char symbol = '\u003E';

            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i + " " + symbol + " ");
            }
        }

        static void Task3()
        {
            string allStrings = "";

            do
            {
                Console.WriteLine("Please enter the string: ");
                string localString = Console.ReadLine();

                if (localString == "#END")
                {
                    break;
                }
                if(!string.IsNullOrEmpty(allStrings))
                {
                    allStrings += '\\';
                }
                allStrings += localString;
            }
            while (true);
            //allStrings = allStrings.Substring(0, allStrings.Length - 1);
            Console.WriteLine(allStrings);
            
        }

        static void Task4()
        {
            string allStrings = "";
            Console.WriteLine("Select separator: ");
            string separator = Console.ReadLine();

            do
            {
                
                Console.WriteLine("Please enter the string: ");
                string localString = Console.ReadLine();

                if (localString == "#END")
                {
                    break;
                }
                if (!string.IsNullOrEmpty(allStrings))
                {
                    allStrings += separator;
                }
                allStrings += localString;
            }
            while (true);
            Console.WriteLine(allStrings);

        }
        static void Task5()
        {
            Console.WriteLine("Enter the strings: ");
            string s = Console.ReadLine();

            Console.WriteLine("Select the separator: ");
            string separator = Console.ReadLine();

            string[] words = s.Split(separator.ToCharArray());
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }                          

        }

        static void Task6()
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate.ToString("g"));
            Console.WriteLine(localDate.ToString("D"));
            Console.WriteLine(localDate.ToString("d",
                  CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("Number of current day: " + localDate.ToString("dd"));
            Console.WriteLine(localDate.ToString("m"));
            Console.WriteLine("Number of current month: " + localDate.ToString("mm"));
            Console.WriteLine("Current time: " + localDate.ToString("t"));
        }

        static void Task7()
        {
            Console.WriteLine("Enter the number: ");
            int value = Int32.Parse(Console.ReadLine());
            float newValue = value / 100.0f;
            int newValue1 = value * 100000;

            Console.WriteLine(value.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));            
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                   "Float: {0:0.00}", newValue));
            Console.WriteLine("Percents: {0}%", value);            
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                 "Huge number: {0:0,0.00}", newValue1));
            Console.WriteLine("Hex: {0:X}", value);
        }

        static void Task8()
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter sequence: ");
            string toFind = Console.ReadLine();

            int i = 0;
            int counter = 0;

            while (i != -1)
            {
                i = str.IndexOf(toFind, i);

                if(i != -1)
                {
                    counter = counter + 1;
                    i++;
                }
                
            }
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            
            Task8();

            Console.ReadLine();

        }
        
    }
}
