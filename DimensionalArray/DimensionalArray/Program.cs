using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = new int[2, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Enter the number for Row and Column: ", i + 1, j + 1);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("{0}.\t", i + 1);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}

