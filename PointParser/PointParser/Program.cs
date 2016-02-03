using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PointParser
{
    class Program
    {
        struct Point
        {
            private int _x;
            private int _y;


            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }
            
            public Point(String inputString)
            {
                if (inputString == null)
                {
                    _x = 0;
                    _y = 0;

                    return;
                }

                String[] arr = inputString.Split(',');

                String localX = arr[0];
                char[] CharsToTrim = { ' ' };
                string result = localX.Trim(CharsToTrim);

                _x = Int32.Parse(localX);

                _y = Int32.Parse(arr[1]);
            }

            public override string ToString()
            {
                return "[" + _x + "," + _y + "]";
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please, enter coordinates: ");
                string input = Console.ReadLine();
                Point P = new Point(input);
                Console.WriteLine(P); // 1,2    [1,2]
            }
        
            Console.Read();
        }
    }
}
