using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            AvailableFood food = new AvailableFood();
            food.AddCocaCola(new CocaCola(25));
            food.AddCocaCola(new CocaCola(50));
            food.AddFanta(new Fanta(51));
            food.AddTea(new Tea(22));
            food.AddCheeseBurger(new CheeseBurger(22));
            food.AddBurger(new Burger(20));

            food.RemoveProduct(new CocaCola(25));
                        
            
            Staff staff = new Staff();
            staff.AddStudent(new Student("Vadym", "Shmorgun", new DateTime(1990,8,2), 50000));
            staff.AddStudent(new Student("Denis", "Likon", new DateTime(1993, 10, 15), 5200));
            staff.AddStudent(new Student("Anastasia", "Simakova", new DateTime(1991, 7, 9), 4900));
            staff.AddStudent(new Student("Svetlana", "Lipova", new DateTime(1985, 4, 2), 5000));
            staff.AddTrainer(new Trainer("Alona", "Lisak", new DateTime(1996, 2, 15), 7210, new DateTime(2016,11,24)));
            staff.AddTrainer(new Trainer("Kirill", "Brukov", new DateTime(1992, 4, 25), 7000, new DateTime(2016, 11, 27)));
            staff.AddCleaner(new Cleaner("Anton", "Fedorov", new DateTime(1991, 5, 14), 5500, "Back Room"));
            staff.AddCleaner(new Cleaner("Ruslan", "Shun'ko", new DateTime(1981, 4, 7), 5100, "Manager's Room"));




            //staff.RemovePerson(new Student("Vadym", "Shmorgun", new DateTime(1990, 8, 2), 50000));


            Person foundPerson = staff.GetByFullName("Denis", "Likon");
            Console.WriteLine(foundPerson);
            //Console.WriteLine(staff.ToString());

            IEnumerable<Person> sortBy = staff.SortByLowToHigh();
            sortBy.ToList().ForEach(p => Console.WriteLine(p.ToString()));

            double averageSalary = staff.FindAverageSalary();
            Console.WriteLine();
            Console.WriteLine("The average salary is: " + averageSalary);

            DateTime oldestPerson = staff.FindOldestPerson();
            Console.WriteLine();
            Console.WriteLine(oldestPerson);
            

            Console.ReadKey();
        }
    }
}
