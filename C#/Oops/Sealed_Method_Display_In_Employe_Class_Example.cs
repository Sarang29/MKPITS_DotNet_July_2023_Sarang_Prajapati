using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_Display_In_Employe_Class_Example
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From Person Class");
        }
    }

    class Employee : Person
    {
        sealed public override void display()
        {
            base.display();
            Console.WriteLine("Hello From Employee Class");
        }
    }

    class Part_Time_Employee : Employee
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Part_Time_Employee p = new Part_Time_Employee();
            p.display();

            Console.ReadKey();
        }
    }
}
