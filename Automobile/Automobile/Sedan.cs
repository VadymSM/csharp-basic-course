using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Sedan : Automobile
    {
        public Sedan(float weight,int doors, string cylinders, int year, string model, string mark)
            : base(doors,cylinders,year,model, mark)
        {
            Weight = weight;
        }

        public float Weight
        { get; set; }


        public override string ToString()
        {
            string text = base.ToString();
            return Weight + " " + text;
        }
    }
}
