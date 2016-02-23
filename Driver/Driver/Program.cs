using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    class Program
    {
        class MyClass
        {
            private string _name;
            private int _id;

            protected MyClass()
            {
                this._name = "MyClass";
               
                // this.
            }
            public MyClass(int _name)
            {
                this._name = "MyClass";
            }
            public static MyClass Create()
            {
                return new MyClass();
            }

            public void GenerateId(out int newValue)
            {
                newValue = 100;
            }

            public void IncreaseId(ref int value)
            {
                value++;
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Sedan("Nissan", "Teeda", 160 /*max speed*/);
            Car myCar1 = new Sedan("Toyota", "Corrola", 190);
            MyClass m1 = MyClass.Create();
            int myId = 0;
            m1.GenerateId(out myId);
            m1.IncreaseId(ref myId);
            myCar.CompareTo(myCar1);
                       

            
            Console.WriteLine(myCar); // print Mark, Model, MaxSpeed of the car
            Console.WriteLine(myCar1);
            Console.WriteLine(myCar.Equals(myCar1));

            myCar.SpeedControl.IncreaseSpeedTo(60);
            Console.WriteLine(myCar.SpeedControl.CurrentSpeed); // print 60

            myCar.SpeedControl.DecreaseSpeedTo(40);
            Console.WriteLine(myCar.SpeedControl.CurrentSpeed); // print 20

            myCar.SpeedControl.Stop();
            Console.WriteLine(myCar.SpeedControl.CurrentSpeed); // print 0

            myCar.SteeringWheel.MoveLeft(30); // angle 0 - 90
            Console.WriteLine(myCar.SteeringWheel.MovementAngle); // print 30

            myCar.SteeringWheel.SetForward();
            Console.WriteLine(myCar.SteeringWheel.MovementAngle); // print 0

            myCar.SteeringWheel.MoveRight(-270); // angle 0 - 90 
            Console.WriteLine(myCar.SteeringWheel.MovementAngle); // print 270

            
            Console.ReadLine();
        }
    }
}
