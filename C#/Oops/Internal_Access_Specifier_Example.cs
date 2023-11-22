using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_Specifier_Example
{
    class Person
    {
        internal string name;
        internal int age;
        internal string location;
    }

    class Employe : Person
    {
        internal int salary;

        public void getemployedata(string name,int age,string location,int salary)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            this.salary = salary;
        }

        public void dispay()
        {
            Console.WriteLine("Employe Name : " + name);
            Console.WriteLine("Employe Age : " + age);
            Console.WriteLine("Employe Location : " + location);
            Console.WriteLine("Employe Salary : " + salary+"\n");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new Employe();
            emp.getemployedata("Sarang", 22, "Nagpur", 50000);
            emp.dispay();

            Employe emp1 = new Employe();
            emp1.name = "Lucky";
            emp1.age = 24;
            emp1.location = "Nagpur";
            emp1.salary = 60000;
            emp1.dispay();

            Console.ReadKey();


        }
    }
}
