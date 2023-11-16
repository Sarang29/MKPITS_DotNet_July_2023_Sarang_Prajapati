using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Student_Deri_From_Class_Person
{
    class Person
    {
        public string name;
        public string address;
    }

    class Student:Person
    {
        public int rollno;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.name = "Sarang";
            s1.rollno = 1;
            s1.address = "Nagpur";
            s1.marks = 74;

            Console.WriteLine("Name : " + s1.name);
            Console.WriteLine("Roll No : " + s1.rollno);
            Console.WriteLine("Address : " + s1.address);
            Console.WriteLine("Marks : " + s1.marks);

            Console.ReadKey();

        }
    }
}
