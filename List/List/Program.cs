using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
         {
            List<string> sandwich = new List<string>();

            sandwich.Add("bacon");
            sandwich.Add("tomato");

            sandwich.Insert(1, "lettuce");

            foreach (string ingredient in sandwich)
            {
                System.Console.WriteLine(ingredient);
            }
            Console.ReadLine();
        }
    }
}
