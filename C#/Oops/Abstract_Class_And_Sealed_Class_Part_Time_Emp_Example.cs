using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_And_Sealed_Class_Part_Time_Emp_Example
{
    abstract class Person
    {
        public string name;
    }

    class Employee : Person
    {
        public int empno;
    }

    sealed class Part_Time_Employee : Employee
    {
        public int No_Of_Hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Part_Time_Employee p = new Part_Time_Employee();
            p.empno = 1;
            p.name = "Sarang";
            p.No_Of_Hours = 8;

            Console.WriteLine("Employee Number : " + p.empno);
            Console.WriteLine("Employee Name : " + p.name);
            Console.WriteLine("No Of Working Hours : " + p.No_Of_Hours);

            Console.ReadKey();
        }
    }
}
