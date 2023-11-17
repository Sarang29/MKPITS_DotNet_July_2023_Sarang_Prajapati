using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Class_Emp_and_Student_Inhert_From_Class_Person
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

    class Employee : Person
    {
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.name = "Sarang";
            emp.address = "Nagpur";
            emp.designation = "Manager";
            emp.salary = 60000;

            Console.WriteLine("--------Employee Details-------");
            Console.WriteLine("Employe Name : " + emp.name);
            Console.WriteLine("Employe Address : "+emp.address);
            Console.WriteLine("Employe Designation : " + emp.designation);
            Console.WriteLine("Employe Salary : " + emp.salary);

            Student s1 = new Student();
            s1.rollno = 123;
            s1.name = "Ashwin";
            s1.address = "Mumbai";
            s1.marks = 90;

            Console.WriteLine("\n-------Student Details-------");
            Console.WriteLine("Student Roll No : " + s1.rollno);
            Console.WriteLine("Student Name : " + s1.name);
            Console.WriteLine("Student Address : " + s1.address);
            Console.WriteLine("Student marks : " + s1.marks);

            Console.ReadKey();
        }
    }
}
