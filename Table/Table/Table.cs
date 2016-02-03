using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Table
    {
        private int _weight;
        private int _height;
        private int _numberOfLegs;

        public Table(int weight, int height, int numberOfLegs)
        {
            _weight = weight;
            _height = height;
            _numberOfLegs = numberOfLegs;
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int NumberOfLegs
        {
            get { return _numberOfLegs; }
            set { _numberOfLegs = value; }
        }

        public override string ToString()
        {
            return _weight + " " + _height + " " + _numberOfLegs;
        }
    }
}
