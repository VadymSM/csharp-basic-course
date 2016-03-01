using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // define array size
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            // create array
            int[] array = new int[size];

            // define first number
            Console.WriteLine("Enter first number: ");
            int number = int.Parse(Console.ReadLine());
            array[0] = number;

            // calculate value of array item and setup it
            for (int i = 1; i < array.Length; i++)
            {
                int prevPrevEl = 0;
                if (i != 1)
                {
                    prevPrevEl = array[i - 2];
                }
                int sum = array[i - 1] + prevPrevEl;
                array[i] = sum;
                
                Console.WriteLine(" " + array[i]);
                
            }

            Console.ReadLine();
        }
    }
}