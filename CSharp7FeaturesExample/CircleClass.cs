using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FeaturesExample
{
    class CircleClass : ShapeClass
    {
        public double radius { get; set; }

        public  CircleClass(double radius)
        {
            this.radius = radius;
        }
        public double FindArea()
        {
            return (double)22 / 7 * radius * radius;
        }
    }
}
