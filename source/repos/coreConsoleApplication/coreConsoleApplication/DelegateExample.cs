﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int CalculatorDelegate(int num);

namespace coreConsoleApplication
{
    internal class DelegateExample
    {
        static int number = 100;
        public static int addition(int num)
        {
            number = number + num;
            return number;
        }
        public static int multiplication(int num)
        {
            number = number * num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
    }
}
