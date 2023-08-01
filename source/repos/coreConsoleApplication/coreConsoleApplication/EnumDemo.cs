using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    enum WeekDays
    {
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday, 
        Friday,
        Saturday,
        Sunday
    }

    internal class EnumDemo
    {
        public void display() 
        {
            Console.WriteLine(WeekDays.Monday);
        }
    }
}
