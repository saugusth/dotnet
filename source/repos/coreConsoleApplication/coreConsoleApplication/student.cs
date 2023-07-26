using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class student
    {
        int studentId;
        string StudentName;
        public void acceptDetails()
        {
            Console.WriteLine("Enter Student id:");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            StudentName = Console.ReadLine();
        }
        public void displayDetails()
        {
            Console.WriteLine("StudentId:" + studentId);
            Console.WriteLine("Student Name:" + StudentName);
        }

    }
}
