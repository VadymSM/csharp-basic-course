using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] strings = new int[1000];
            for (int i = 1; i < strings.Length; i++)
            {
                i = i + 9;
                Console.WriteLine(i);
            }
            

            Console.Read();
        }
    }
}
