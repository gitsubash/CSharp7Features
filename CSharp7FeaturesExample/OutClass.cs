using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7FeaturesExample
{
    class OutClass
    {
        public void Init()
        {
            GetTime(out int hour, out int minutes, out int seconds);
            WriteLine($"{hour}:{minutes}:{seconds}");
        }
        public void GetTime(out int hour, out int minutes, out int seconds)
        {
            hour = 2;
            minutes = 30;
            seconds = 20;
        }
    }
}
