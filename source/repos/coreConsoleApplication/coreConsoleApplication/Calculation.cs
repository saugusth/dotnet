﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Calculation
    {
        int result = 0;
        public void calculate(int num1, int num2)
        {
            try 
            {
                result = num1/num2;
                Console.WriteLine(result);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
                Console.WriteLine(result);
            }
        }
    }
}
