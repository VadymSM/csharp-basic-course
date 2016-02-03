using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat
{
    class Flat
    {
        private int _numberOfRooms;
       

        public Flat(int numberOfRooms)
        {
            _numberOfRooms = numberOfRooms;
            
        }

        public int NumberOfRooms
        {
            get { return _numberOfRooms; }
            set { _numberOfRooms = value; }
        }

        

        public override string ToString()
        {
            return _numberOfRooms.ToString();
        }
    }
}
