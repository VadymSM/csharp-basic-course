using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_setter_of_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            while (true)
            {
                Console.Write("Enter flag (dex): ");
                int flag = Int32.Parse(Console.ReadLine());
                result = result | flag;
                Console.WriteLine("Your current number is: " + result);
                             


                
            }
        }
    }
}
