using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArrayFourthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element: ");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            for(int j = 0; j < array.Length; j++)
            {
                if(array[j] % 2 == 0)
                {
                    firstNumber = firstNumber + array[j];
                }
                else
                {
                    firstNumber = firstNumber - array[j];
                }

            }
            
                Console.WriteLine(firstNumber);
            


            Console.ReadKey();
        }
    }
}
