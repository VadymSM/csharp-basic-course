using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Shape
    {
        private float _side;

        public Square(float side, Color color)
            :base(color)
        {
            _side = side;
        }

        public float Side
        {
            get { return _side; }
            set { _side = value; }
        }
        public override float CalcArea()
        {
            return _side * _side;
        }

        
        public override void Draw()
        {
            Console.WriteLine("Draw Square: ");
        }
        public override bool Equals(Object obj)
        {
            Square other = obj as Square;
            if (other == null)
            {
                return false;
            }
                else
            return this.Side.Equals(other.Side);
        }
        
    }
}
