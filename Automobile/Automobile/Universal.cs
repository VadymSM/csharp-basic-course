using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Universal : Automobile
    {
        public Universal(int width,int doors, string cylinders, int year, string model, string mark)
            :base(doors, cylinders, year, model, mark)
        {
            Width = width;
        }
        public int Width
        { get; set; }
    }

}
