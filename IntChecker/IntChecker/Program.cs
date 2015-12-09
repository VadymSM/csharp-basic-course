using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the number: ");
                int result = Int32.Parse(Console.ReadLine());

                Console.Write("Please enter the flag: ");
                int FlagA = Int32.Parse(Console.ReadLine());
                if ((result & FlagA) == FlagA)
                {
                    Console.WriteLine("Yes, they are equal");
                }
                else
                {
                    Console.WriteLine("No, they are not equal");
                }
            }
         

            Console.Read();
        }
    }
}