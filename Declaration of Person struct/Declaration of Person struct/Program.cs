using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarationOfPersonStruct
{
    class Program
    {
        

        
        
        static void Main(string[] args)
        {
            Person.Sex x = DeclarationOfPersonStruct.Person.Sex.Man;
            Person Person = new Person("Nikki", "Smith", new DateTime(1990,08,02), "Single", x);
            Console.WriteLine(Person._personName + " " + Person._personSurname + " " + Person._personBirthday + " " + Person._personMarriagestatus + " " + Person._personSex);
                             
            Console.Read();
        }
    }
}
