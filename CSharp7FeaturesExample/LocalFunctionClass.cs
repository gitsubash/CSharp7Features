using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7FeaturesExample
{
    class LocalFunctionClass
    {

        public void Init()
        {
            WriteLine($"Exploring local functions");
            Write("Enter Your Value: ");
            if (int.TryParse(ReadLine(), out int number))
            {
                WriteLine($"The fibonacci for {number} is {FindFibonacci()} .");
            }
            else
            {
                WriteLine($"Not valid input. Program exits!!!");
            }

            long FindFibonacci()
            {
                if (number < 2)
                {
                    return 1;
                }
                else
                {
                    return number-- * FindFibonacci();
                }

            }

        }


    }
}


 