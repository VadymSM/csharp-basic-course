using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        private float _triangleBase;
        private float _height;

        public Triangle(float triangleBase, float height, Color color)
            : base(color)
        {
            _triangleBase = triangleBase;
            _height = height;
        }

        public float TriangleBase
        {
            get { return _triangleBase; }
            set { _triangleBase = value; }
        }
        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public override float CalcArea()
        {
            return 0.5f * _height * _triangleBase;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle: ");
        }
        public override bool Equals(Object obj)
        {
            Triangle other = obj as Triangle;
            if (other == null)
            {
                return false;
            }
            else
                return this.Height.Equals(other.Height);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode()^this.Height.GetHashCode()^this.TriangleBase.GetHashCode();
            
        }
    }
}
