using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
          
    

        static void Main(string[] args)
        {
            Car vadym = new Car("Ford", "Focus", 220);
            vadym.PrintInfo();
            Car Tayota = new Car("Tayota", "Prius", 160);
            Tayota.PrintInfo();
            Tayota.MaxSpeed = 200;
            Tayota.PrintInfo();


            Console.ReadLine();
        }
    }
}
