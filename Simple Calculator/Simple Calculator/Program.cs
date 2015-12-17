using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Calculator
    {
        static void AskDataInput()
        {
        }
        static void PrintTitle()
        {
            Console.WriteLine("Select your operation: ");
            Console.WriteLine();
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Quit Application");
        }
        
        static void Main(string[] args)
        {
            float result = 0;
            bool condition = true;
            Calc calc = new Calc();

            while (condition)
            {
                Console.WriteLine("Enter the first number: ");
                float x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter the second number: ");
                float y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                PrintTitle();
                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        result = calc.Add(x, y);
                        break;
                    case 2:
                        result = calc.Sub(x, y);
                        break;
                    case 3:
                        result = calc.Multiplication(x, y);

                        break;
                    case 4:
                        result = calc.Division(x, y);
                        break;

                 }
                Console.WriteLine("Your Result is :  " + result);

                if (z == 5)
                {
                    condition = false;
                }
       
             }
        }
    }
}

