using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace XmlPerson
{
    
    public class Person
    {
        private int _birthDay;
        private string _name;
        private string _surname;
        private string _sex;
        
        public Person(int birthDay, string name, string surname, string sex)
        {
            _birthDay = birthDay;
            _name = name;
            _surname = surname;
            _sex = sex;
        }
        public Person()
        {

        }

        public int BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        [XmlElement("FirstName")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [XmlElement("LastName")]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        //[XmlIgnore]
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        
    }

    internal class XmlelementAttribute : Attribute
    {
    }
}
