using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7FeaturesExample
{
    class Patternclass
    {
        public void Init()
        {
            //: Checking with Constant and Type patterns
            PrintSum("5");

            //Patterns with conditional switch cases
            callShape();
        }
       


        public void PrintSum(Object obj)
        {
            if (obj is int i || ( obj is string s && int.TryParse(s,out i) ) )
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += j;
                }
                WriteLine($"The Sum of 1 to {i} is {sum}");
            }
            return;
        }

        public void callShape()
        {
            ShapeClass shapeObject;
            shapeObject = new ShapeClass();
            //shapeObject= new CircleClass(2);
            //shapeObject = new RectangleClass(2,2);
            //shapeObject = new RectangleClass(3, 2);

            switch (shapeObject)
            {
                default:
                    WriteLine("Shape Not Applicable");
                    break;
                case CircleClass ci:
                    WriteLine($"Shape is Circel with area {ci.FindArea()} ");
                    break;
                case RectangleClass sq when (sq.length == sq.breadth):
                    WriteLine($"Shape is Square with area {sq.FindArea()}");
                    break;
                case RectangleClass re:
                    WriteLine($"Shape is Rectangle with area {re.FindArea()}");
                    break;
                case null:
                    throw new ArgumentException("The shape is null");
            }
        }

    }


   
}
