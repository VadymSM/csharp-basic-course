using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape : IDrawable, IComparable<Shape>
    {
        private Color _color;
        

        public Shape(Color color)
        {
            _color = color;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public abstract float CalcArea();

        public int CompareTo(Shape other)
        {
            float areaOfFirstCicle = CalcArea();
            float areaOfSecondCicle = other.CalcArea();
            // return areaOfFirstCicle.CompareTo(areaOfSecondCicle);
            return (int)(areaOfFirstCicle - areaOfSecondCicle);
        }

        public abstract void Draw();
        
    }
}
