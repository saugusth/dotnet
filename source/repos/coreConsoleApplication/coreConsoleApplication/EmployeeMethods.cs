using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal partial class Employee
    {
        public partial void DisplayDetials()
        {
            Console.WriteLine("Employee id:" + this.Empid);
            Console.WriteLine("Employee Name:" + this.EmpName);
        }
    }
}
