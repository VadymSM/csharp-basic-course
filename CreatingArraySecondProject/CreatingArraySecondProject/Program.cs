using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArraySecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
                    

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element: ");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
                            
            }

            for(int j = 0; j < array.Length - 1; j+=2)
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                
            }

            for(int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k] + " ");
            }


            Console.ReadKey();
        }
    }
}
