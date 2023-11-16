using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Employee_Deri_From_Class_Person
{
    class Person
    {
        public string name;
        public string address;
    }

    class Employee:Person
    {
        public int empno;
        public int salary;
        public string desigantion;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.name = "Sarang";
            emp.empno = 123;
            emp.desigantion = "Manager";
            emp.salary = 60000;

            Console.WriteLine("Employee Name : " + emp.name);
            Console.WriteLine("Employee Number : " + emp.empno);
            Console.WriteLine("Employee Designation : " + emp.desigantion);
            Console.WriteLine("Employee Salary : " + emp.salary);

            Console.ReadKey();
        }
    }
}
