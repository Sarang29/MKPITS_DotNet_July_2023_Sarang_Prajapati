using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Student_Deri_From_Class_Person
{
    abstract class Person
    {
        public abstract void display();

        public void showdata()
        {
            Console.WriteLine("Hello From Showdata");
        }
    }

    class Student : Person
    {
        public override void display()
        {
            Console.WriteLine("Hello From Display Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.showdata();
            s.display();

            Console.ReadKey();
        }
    }
}
