using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray5Task
{
    class Program
    {
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

            int Minimum = 0;
            int Maximum = 0;

            Minimum = array[0];

            for(int j = 0; j < array.Length; j++)
            {
                if (Minimum > array[j])
                    Minimum = array[j];
            }
            Console.WriteLine();
            Console.WriteLine("Minimum = {0}", Minimum);

            for(int k = 0; k < array.Length; k++)
            {
                if (Maximum < array[k])
                    Maximum = array[k];
            }

            Console.WriteLine("Maximum = {0}\n", Maximum);

            Console.ReadKey();
        }
    }
}
