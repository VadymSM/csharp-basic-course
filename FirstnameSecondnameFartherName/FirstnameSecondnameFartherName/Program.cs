using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstnameSecondnameFartherName
{
    class Program
    {
        static void Use3Arrays()
        {
            string[] name = new string[] { "Mike", "Ira", "Nick" };
            string[] surname = new string[] { "Smith", "Kiten", "Mitan" };
            string[] farthername = new string[] { "Taylor", "Kitty", "Mick" };

            for (int i = 0; i < name.Length; ++i)
            {
                for (int j = 0; j < surname.Length; ++j)
                {
                    for (int k = 0; k < farthername.Length; ++k)
                    {
                        Console.WriteLine(name[i] + " " + surname[j] + " " + farthername[k]);
                    }
                }
            }
        }
        static void Use3DArray()
        {
            string[] name = new string[] { "Mike", "Ira", "Nick" };
            string[] surname = new string[] { "Smith", "Kiten", "Mitan" };
            string[] farthername = new string[] { "Taylor", "Kitty", "Mick" };

            string[,,] names = new string[3,3,3];


            for (int i = 0; i < name.Length; ++i)
            {
                for (int j = 0; j < surname.Length; ++j)
                {
                    for (int k = 0; k < farthername.Length; ++k)
                    {
                        names[i, j, k] = name[i] + " " + surname[j] + " " + farthername[k];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
           // Use3Arrays();
            Use3DArray();      
            Console.ReadLine();
        }
    }
}
