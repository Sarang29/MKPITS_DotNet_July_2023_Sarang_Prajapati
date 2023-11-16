using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Progammer_Deri_From_Emp_Protected_Example
{
    class Employee
    {
        protected int salary;
    }

    class Programmer : Employee
    {
        public int bonus;

        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public void display()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Bonus : " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();

            p.getdata(50000, 3000);
            p.display();

            Console.ReadKey();
        }
    }
}
