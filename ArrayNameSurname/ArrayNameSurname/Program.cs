using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNameSurname
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] name = new string[] { "Mike", "Ira", "Nick" };
                string[] surname = new string[] { "Smith", "Kiten", "Mitan" };

                for (int i = 0; i < name.Length; ++i)
                {
                    for (int j = 0; j < surname.Length; ++j)
                    {
                        Console.WriteLine(name[i] + " " + surname[j]);
                        
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
