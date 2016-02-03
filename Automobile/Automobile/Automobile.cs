using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Automobile
    {
        private int _doors;
        private string _cylinders;
        private int _year;
        private string _model;
        private string _mark;

        public Automobile(int doors, string cylinders, int year, string model,string mark)
        {
            _doors = doors;
            _cylinders = cylinders;
            _year = year;
            _model = model;
            _mark = mark;
        }

        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }

        public string Cylinders
        {
            get { return _cylinders; }
            set { _cylinders = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public override string ToString()
        {
            return _doors + " " + _cylinders + " " + _year + " " + _model + " " + _mark;
        }


    }
}
