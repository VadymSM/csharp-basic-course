using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat(5);
            Console.WriteLine(flat);

            Console.ReadKey();
        }
    }
}
