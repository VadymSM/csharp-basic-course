using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] + i;
                if (i % 2 == 0)
                {
                    if (i == 10)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }              
            }
            Console.WriteLine("Do you want to continue (Y/N)?: ");
            key = Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}
