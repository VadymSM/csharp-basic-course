using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Mike Tison", "Star", 60, 5);
            Console.WriteLine(song);


            Console.ReadLine();
        }
    }
}
