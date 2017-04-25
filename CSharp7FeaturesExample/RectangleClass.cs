using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FeaturesExample
{
    class RectangleClass : ShapeClass
    {
        public double length { get; set; }
        public double breadth { get; set; }

        public RectangleClass(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double FindArea()
        {
            return length * breadth;
        }
    }
}
