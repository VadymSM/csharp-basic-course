using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Door
    {
        private int _height;
        private int _width;
        private string _typeOfMaterial;

        public Door(int height, int width, string typeOfMaterial)
        {
            _height = height;
            _width = width;
            _typeOfMaterial = typeOfMaterial;
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public string TypeOfMaterial
        {
            get { return _typeOfMaterial; }
            set { _typeOfMaterial = value; }
        }

        public override string ToString()
        {
            return _height + " " + _width + " " + _typeOfMaterial;
        }
    }
}
