using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(sbyte).FullName  + " " + "The size of sbyte is {0}.", sizeof(sbyte));
            Console.WriteLine();
            Console.WriteLine(typeof(bool).FullName + " " + "The size of bool is {0}.", sizeof(bool));
            Console.WriteLine();
            Console.WriteLine(typeof(byte).FullName + " " + "The size of byte is {0}.", sizeof(byte));
            Console.WriteLine();
            Console.WriteLine(typeof(char).FullName + " " + "The size of char is {0}.", sizeof(char));
            Console.WriteLine();
            Console.WriteLine(typeof(decimal).FullName + " " + "The size of decimal is {0}.", sizeof(decimal));
            Console.WriteLine();
            Console.WriteLine(typeof(double).FullName + " " + "The size of double is {0}.", sizeof(double));
            Console.WriteLine();
            Console.WriteLine(typeof(float).FullName + " " + "The size of float is {0}.", sizeof(float));
            Console.WriteLine();
            Console.WriteLine(typeof(int).FullName + " " + "The size of int is {0}.", sizeof(int));
            Console.WriteLine();
            Console.WriteLine(typeof(long).FullName + " " + "The size of long is {0}.", sizeof(long));
            Console.WriteLine();
            Console.WriteLine(typeof(short).FullName + " " + "The size of short is {0}.", sizeof(short));
            Console.WriteLine();
            Console.WriteLine(typeof(uint).FullName + " " + "The size of uint is {0}.", sizeof(uint));
            Console.WriteLine();
            Console.WriteLine(typeof(ulong).FullName + " " + "The size of ulong is {0}.", sizeof(ulong));
            Console.WriteLine();
            Console.WriteLine(typeof(ushort).FullName + " " + "The size of ushort is {0}.", sizeof(ushort));
            Console.WriteLine();
            0000
            0001
            0010
            0011
            0100
            0101
            0110
            0111
            1000
            1001

            Console.Read();
        }
    }
}
