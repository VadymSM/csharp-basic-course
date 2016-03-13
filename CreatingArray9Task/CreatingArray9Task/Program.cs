using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray9Task
{
        class Program
        {
            static void Main(string[] args)
            {
                int sum = 0;
                Console.WriteLine("Enter array size: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Enter element: ");
                    int number = int.Parse(Console.ReadLine());
                    array[i] = number;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    sum = sum + array[j];
                    
                }
                Console.WriteLine("Sum of all elements = " + sum);


            Console.ReadKey();
            }
        }
    }
