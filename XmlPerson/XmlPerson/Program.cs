using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace XmlPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(25,"Vadym","Shmorgun","Male");
            
            XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(person.GetType());
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Temp\\Person.xml"))
            {
                writer.Serialize(file, person);
            }
            Person person1 = null;
            XmlSerializer data = new XmlSerializer(person.GetType());
            using (System.IO.StreamReader file = new System.IO.StreamReader("c:\\Temp\\Person.xml"))
            {
                person1 = (Person)data.Deserialize(file);
            }

            
            List<Person> persons = new List<Person>();
            persons.Add(new Person(27, "Denis", "Kalinin", "Male"));
            persons.Add(new Person(29, "Kate", "Klarson", "Female"));
            persons.Add(new Person(21, "Mike", "Tkachuk", "Male"));

            XmlSerializer writer1 = new XmlSerializer(persons.GetType());
            using (System.IO.StreamWriter file1 = new System.IO.StreamWriter("c:\\Temp\\Persons.xml"))
            {
                writer1.Serialize(file1, persons);
            }
            List<Person> persons1 = null;
            XmlSerializer data1 = new XmlSerializer(persons.GetType());
            using (System.IO.StreamReader file2 = new System.IO.StreamReader("c:\\Temp\\Persons.xml"))
            {
                persons1 = (List<Person>)data1.Deserialize(file2);
            }

        }
    }
}
