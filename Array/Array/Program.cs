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
            int[] strings = new int[10];
            for (int index = 0; index < strings.Length; index++)
            {
                strings[index] = index+1;
                
                Console.WriteLine(strings[index]);
            }
            

            Console.Read();
        }
    }
}
