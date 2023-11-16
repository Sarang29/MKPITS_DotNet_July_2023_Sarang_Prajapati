using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Class_Student_Deri_From_Class_Person_Protected_Internal
{
    class Person
    {
        string name;
        string address;

        protected internal void getpersondata(string name,string adress)
        {
            this.name = name;
            this.address = adress;
        }
        protected internal void displaypersondata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }

    class Student:Person
    {
        int rollno;
        int marks;

        public void getstudentdata(int roll,int marks)
        {
            this.rollno = roll;
            this.marks = marks;
        }

        public void displaystudentdata()
        {
            Console.WriteLine("Roll No : " + rollno);
            Console.WriteLine("Marks : " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.getpersondata("Sarang", "Nagpur");
            s1.getstudentdata(123, 85);
            s1.displaypersondata();
            s1.displaystudentdata();

            Console.ReadKey();
        }
    }
}
