using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door(200,60, "Veneer");
            Console.WriteLine(door);

            Console.ReadLine();

        }
    }
}
