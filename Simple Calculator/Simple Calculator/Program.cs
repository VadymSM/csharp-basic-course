using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter the second number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Select your operation: ");
                Console.WriteLine();
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Quit Application");
                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Your result is:" + " " + (x + y));
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Your result is:" + " " + (x - y));
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Your result is:" + " " + (x * y));

                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Your result is:" + " " + (x / y));
                        break;
                    }
                Console.Read();
            }
        }
    }
}

