using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Inheritance_Example_Class_Person
{
    class Person
    {
        public string name;
    }

    class student:Person
    {
        public int rollno;
        public void getdata(string name, int rollno)
        {
            this.name = name;
            this.rollno = rollno;
        }

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll No : " + rollno);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();

            s.getdata("Sarang", 123);
            s.display();

            Console.ReadKey();
        }
    }
}
