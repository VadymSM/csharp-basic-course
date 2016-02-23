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
                int sum = array[i - 1] + array[i - 2];
                array[i] = sum;
                if (array.Length < 0)
                {
                    array[i] = 0;
                }
                Console.WriteLine(" " + array);
                
            }

            Console.ReadLine();
        }
    }
}