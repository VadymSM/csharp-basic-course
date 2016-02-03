using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shape
{
    class Circle : Shape
    {
        private const float PI = 3.14f;
        private float _radius;
        
        public Circle(float radius, Color color)
            : base(color)
        {
            _radius = radius;
        }

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

      
        public override float CalcArea()
        {
            return PI * _radius * _radius;
        }

        

        public override void Draw()
        {
            Console.WriteLine("Draw Circle: ");
        }
        public override bool Equals(Object obj)
        {
            Circle other = obj as Circle;
            if (other == null)
            {
                return false;
            }
            else
                return this.Radius.Equals(other.Radius);
        }
        public override int GetHashCode()
        {
            return this.Radius.GetHashCode();
        }
    }
}