using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_setter_of_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter flag (dex): ");
                int result = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your current number is: " + result);

                Console.Write("Enter flag (dex): ");
                int FlagA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your current number is: " + FlagA);
                int c = 0;
                c = result | FlagA;
                Console.WriteLine("Value of c is {0}", c);


                Console.Read();
            }
        }
    }
}
