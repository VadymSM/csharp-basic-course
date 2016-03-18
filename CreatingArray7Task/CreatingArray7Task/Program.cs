using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray7Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
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


                for (int i = 0, j = array.Length - 1; i < j; i++, j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                }

                for (int k = 0; k < array.Length; k++)
                {
                    Console.WriteLine("Reverse  array is: " + array[k]);
                }


                Console.ReadLine();
            }
        }
    }
}
