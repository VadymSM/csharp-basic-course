using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Color mycolor = Color.FromArgb(255, 0, 0);
            Circle c = new Circle(5, mycolor);
            Circle c1 = new Circle(5, mycolor);          
            int result = c.CompareTo(c1);
            c.Draw();
            Console.WriteLine(c.CalcArea());
            Console.WriteLine(result);
            Console.WriteLine(c.Equals(c1));
                                  
            Square s = new Square(10, mycolor);
            Square s1 = new Square(11, mycolor);
            int result1 = s.CompareTo(s1);
            s.Draw();
            Console.WriteLine(s.CalcArea());
            Console.WriteLine(result1);
            Console.WriteLine(s.Equals(s1));
            
            
            Triangle t = new Triangle(10, 7, mycolor);
            Triangle t1 = new Triangle(15, 9, mycolor);
            int result2 = t.CompareTo(t1);
            t.Draw();
            Console.WriteLine(t.CalcArea());
            Console.WriteLine(result2);
            Console.WriteLine(t.Equals(t1));


            /*List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(254, mycolor));
            shapes.Add(new Circle(24, mycolor)); 
            shapes.Add(new Square(45, mycolor));
            shapes.Add(new Square(51, mycolor));
            shapes.Add(new Triangle(21, 49, mycolor));
            shapes.Add(new Triangle(30, 52, mycolor)); 

            shapes.Sort();*/
            
            

            
            Console.ReadLine();

        }
    }
}
