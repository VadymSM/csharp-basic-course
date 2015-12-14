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
            public Point(String str)
            {
                str.Split(' ');
                X = 0;
                Y = 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please, enter coordinates: ");
            string input = Console.ReadLine();
            string[] ar = input.Split(',');
            Console.Write(ar[0]);
            Console.Write(ar[1]);
            Console.Read();
        }
    }
}
