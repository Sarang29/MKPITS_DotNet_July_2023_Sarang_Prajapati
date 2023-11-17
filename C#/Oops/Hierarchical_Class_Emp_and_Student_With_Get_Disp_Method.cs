using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Class_Emp_and_Student_With_Get_Disp_Method
{
    class Person
    {
        string name;
        string address;

        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void displaypersondata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }

    class Employe : Person
    {
        int salary;
        string designation;

        public void getemployedata(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }

        public void displayemployedata()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
    }

    class Student:Person
    {
        int rollno;
        int marks;

        public void getstudentdata(int rollno, int marks)
        {
            this.rollno = rollno;
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
            Employe emp = new Employe();
            Console.WriteLine("Employee Details");
            emp.getpersondata("Sarang", "Nagpur");
            emp.getemployedata(40000, "Manager");
            emp.displaypersondata();
            emp.displayemployedata();

            Student s1 = new Student();
            Console.WriteLine("\nStudent Detials");
            s1.getpersondata("Ashwin", "Mumbai");
            s1.getstudentdata(1, 85);
            s1.displaypersondata();
            s1.displaystudentdata();

            Console.ReadKey();

        }
    }
}
