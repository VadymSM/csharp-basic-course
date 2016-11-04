using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    public class Staff
    {
        private List<Person> _person = new List<Person>();

        public void AddStudent(Person person)
        {
            _person.Add(person);
        }

        public void AddTrainer(Person person)
        {
            _person.Add(person);
        }

        public void AddCleaner(Person person)
        {
            _person.Add(person);
        }

        public void RemovePerson(Person person)
        {
            _person.Remove(person);
        }

        public Person GetByFullName(string name, string surname)
        {
            /*for(int i = 0; i < _person.Count; i++)
            {
                if(name.Equals(_person[i].Name) && surname.Equals(_person[i].Surname))
                {
                    return _person[i];
                }
                  
            }
            return null;*/

            return _person.FirstOrDefault(person => person.Name == name && person.Surname == surname);
        }

        public override string ToString()
        {
            string result = "Staff:\n";
            _person.ForEach(i => result += i.ToString() + "\n");
            return result;
        }

    }

    abstract public class Person
    {
        

        private string _name;

        private string _surname;

        private DateTime _age;

        private int _salary;



        public Person(string name, string surname, DateTime age, int salary)
        {
            
            _name = name;
            _surname = surname;
            _age = age;
            _salary = salary;
        }

        
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Salary
        {
            get { return _salary; }

            set { _salary = value; }
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (person == null)
            {
                return false;
            }

            return this.Name == person.Name &&
                   this.Surname == person.Surname &&
                   this.Age == person.Age && 
                   this.Salary == person.Salary;
        }

        


    }

    public class Student : Person
    {
        
        public Student(string name, string surname, DateTime age, int salary)
            :base(name, surname, age, salary)
        {

        }

        
    }

    public class Trainer : Person
    {
        private DateTime _teachTime;
        public Trainer(string name, string surname, DateTime age, int salary, DateTime teachTime)
            :base(name, surname, age, salary)
        {
            _teachTime = teachTime;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(_teachTime);
        }



    }

    public class Cleaner : Person
    {
        private string _cleanArea;
        public Cleaner(string name, string surname, DateTime age, int salary, string cleanArea)
            :base(name, surname, age, salary)
        {
            _cleanArea = cleanArea;
        }

        public override bool Equals(object obj)
        {
            Cleaner cleaner = obj as Cleaner;
            if(cleaner == null)
            {
                return false;
            }
            if (base.Equals(cleaner))
            {
                return this._cleanArea == cleaner._cleanArea;
            }
            return false;
        }


    }
}
