using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(100, 200, 6);
            Console.WriteLine(table);

            Console.ReadLine();
        }
    }
}
