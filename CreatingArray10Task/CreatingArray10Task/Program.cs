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

                int[] array1 = new int[size];
                

                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine("Enter element: ");
                    int number = int.Parse(Console.ReadLine());
                    array1[i] = number;

                }

                Console.WriteLine("Enter array size: ");
                int size2 = int.Parse(Console.ReadLine());

                int[] array2 = new int[size2];

                for (int j = 0; j < array2.Length; j++)
                {
                    Console.WriteLine("Enter element: ");
                    int number = int.Parse(Console.ReadLine());
                    array2[j] = number;
                }

                int[] result = new int[array1.Length + array2.Length];
                
                for(int i = 0, current = 0; i < result.Length; i++, current++)
                {
                    if (current < array1.Length)
                    {
                        int value1 = array1[current];
                        result[i] = value1;
                        i++;
                    }
            
                    if (current < array2.Length)
                    {
                        int value2 = array2[current];
                        result[i] = value2;
                    }
                    
                }
                for (int i = 0;  i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }

                    Console.ReadLine();
            }
        }
    }
}
