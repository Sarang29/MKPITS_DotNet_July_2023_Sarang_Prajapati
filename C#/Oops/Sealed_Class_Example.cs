
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Example
{
    class Person
    {
        public string name;
        public string address;
    }

    sealed class Employee : Person
    {
        public int empno;
        public int salary;
    }
    class Part_Time_Employee 
    {
        public int No_Of_Hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 1;
            emp.name = "Sarang";
            emp.address = "Nagpur";
            emp.salary = 50000;

            Console.WriteLine("Employe Number : "+emp.empno);
            Console.WriteLine("Employee Name : " + emp.name);
            Console.WriteLine("Employee Location : " + emp.address);
            Console.WriteLine("Employee Salary : " + emp.salary);

            Part_Time_Employee p = new Part_Time_Employee();
            p.No_Of_Hours = 7;
            Console.WriteLine("No Of Working Hours : " + p.No_Of_Hours);

            Console.ReadKey();
        }
    }
}
