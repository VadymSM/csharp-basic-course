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
                        
            Console.WriteLine(food.ToString());


            Staff staff = new Staff();
            staff.AddStudent(new Student("Vadym", "Shmorgun", new DateTime(1990,8,2), 50000));
            staff.AddStudent(new Student("Denis", "Likon", new DateTime(1990, 10, 15), 5000));

            staff.RemovePerson(new Student("Vadym", "Shmorgun", new DateTime(1990, 8, 2), 50000));
            var trainer1 = new Trainer("Den", "Kit", new DateTime(1957, 5, 4), 100, new DateTime(2016, 11, 1));
            var trainer2 = new Trainer("Den", "Kit", new DateTime(1957, 5, 4), 100, new DateTime(2016, 11, 2));

            if (trainer1.Equals(trainer2))
            {
                Console.WriteLine("They are equal");
            }

            Person foundPerson = staff.GetByFullName("Denis", "Likon");
            Console.WriteLine(foundPerson);
            Console.WriteLine(staff.ToString());

            Console.ReadKey();
        }
    }
}
