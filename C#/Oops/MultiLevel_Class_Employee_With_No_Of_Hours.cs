
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Class_Employee_With_No_Of_Hours
{
    class Person
    {
        string name;
        string address;

        public void getpersondata(string name,string address)
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

    class Employee : Person
    {
        int salary;
        string designation;

        public void getemployeedata(int salary, string designation)
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

    class Part_Time_Employee : Employee
    {
        int No_Of_Hours;

        public void getParttimeemployedata(int No_Of_Hours)
        {
            this.No_Of_Hours= No_Of_Hours;
        }

        public void displayparttimeemployedata()
        {
            Console.WriteLine("Working Hours : " + No_Of_Hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Part_Time_Employee p = new Part_Time_Employee();

            p.getpersondata("Sarang", "Nagpur");
            p.getemployeedata(50000, "Manager");
            p.getParttimeemployedata(8);

            p.displaypersondata();
            p.displayemployedata();
            p.displayparttimeemployedata();

            Console.ReadKey();

        }
    }
}
