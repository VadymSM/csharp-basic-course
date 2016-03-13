using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray8Task
{
    class Program
    {
        static int[] RemoveElement(int[] array, int indexOfRemoved)
        {
            int[] newArray = new int[array.Length - 1];
            for(int i = array.Length - 1, j = newArray.Length - 1; i >= 0; i--)
            {
                if(i == indexOfRemoved)
                {
                    continue;
                }
                newArray[j--] = array[i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element: ");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            
            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[j] % 3 == 0)
                {
                    array = RemoveElement(array, j);
                }
                

            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(" " + array[k]);
            }

            
            Console.ReadKey();
        }
    }
}