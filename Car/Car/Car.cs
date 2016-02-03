using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private string _mark;
        private string _model;
        private int _maxSpeed;


        public Car(string mark, string model, int maxspeed)
        {
            _mark = mark;
            _model = model;
            _maxSpeed = maxspeed;
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }

        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} has model {1} with maxspeed {2}", _mark, _model, _maxSpeed);
        }
    }
}
