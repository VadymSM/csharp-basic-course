using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Crossover : Automobile

    {
        public Crossover(int height, int doors, string cylinders, int year, string model, string mark)
            : base(doors, cylinders, year, model, mark)
        {
            Height = height;
        }
        public int Height
        { get; set; }
    }
}
