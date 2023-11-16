using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Prorammer_Derived_From_Class_Employee
{
    class Employee
    {
        public int salary = 50000;
    }

    class Programmer:Employee
    {
        public int bonus = 15000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();

            Console.WriteLine("Salary : " + p.salary);
            Console.WriteLine("Bonus : " + p.bonus);

            Console.ReadKey();
        }
    }
}
