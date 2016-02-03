using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(700, 4, "V9", 2014, "Corrola","Toyota");
            Console.WriteLine(sedan);

            Universal universal = new Universal(2500, 4, "V7", 2015, "Sport", "Range Rover");
            Console.WriteLine(universal);

            Crossover crossover = new Crossover(1500, 4, "V6", 2016, "Black Way", "Ford");
            Console.WriteLine(crossover);

            Console.ReadKey();
        }
    }
}
