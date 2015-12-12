using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration_of_Person_struct
{
    class Person
    {
        public string personName;
        public string personSurname;
        public int personBirthday;
        public string personMarriagestatus;
        public string personSex;

        public Person(string name, string surname, int birthday, string marriagestatus, string sex)
        {
            personName = name;
            personSurname = surname;
            personBirthday = birthday;
            personMarriagestatus = marriagestatus;
            personSex = sex;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Surname: {1}, Birthday: {2}, Marriagestatus: {3}, Sex: {4}", personName, personSurname, personBirthday, personMarriagestatus, personSex);

        }

        
        static void Main(string[] args)
        {
            Person Person = new Person("Nikki", "Smith", 1990, "Single", "Male");
            Console.WriteLine(Person.personName + " " + Person.personSurname + " " + Person.personBirthday + " " + Person.personMarriagestatus + " " + Person.personSex);
                             
            Console.Read();
        }
    }
}
