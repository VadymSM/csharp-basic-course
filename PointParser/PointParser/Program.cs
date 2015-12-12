using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointParser
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;


            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
           
            static void Main(string[] args)
            {
                Console.Write("Please, enter coordinates: ");
                int result = Int32.Parse(Console.ReadLine());
                

                Console.WriteLine("You entered the following coordinates: ");

                Console.Read();
            }
        }
    }
}
