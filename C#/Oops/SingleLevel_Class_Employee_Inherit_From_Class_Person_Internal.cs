using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Employee_Deri_From_Class_Person_Internal
{
    class Person
    {
        string name;
        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("Name : " + name);
        }
    }

    class Employee : Person
    {
        int empno;

        internal void getemployedata(string name,int empno)
        {
            getpersondata(name);

            this.empno = empno;
            Console.WriteLine("Employe Number : " + empno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            e.getemployedata("Sarang", 123);

            Console.ReadKey();
        }
    }
}
