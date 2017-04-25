using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CSharp7FeaturesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Hello C# 7");

            //#1 Out Variables: Can declare the out variable inline in the method call
            new OutClass().Init();

            //#2 Patterns with constant/Types and switch statments
            new Patternclass().Init();
           
            //#3 Workign with Tuples
            new TupleClass().Init();
            new TupleClass().Issue();

            //#4 Local Function explores
            new LocalFunctionClass().Init();
            ReadLine();
        }

 



    }
}
