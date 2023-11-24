using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Stack_Class_Employee
{
    class Employee
    {
        public int empno;
        public string name;
        public string designation;
        public int salary;

        public Employee(int empno, string name, string designation, int salary)
        {
            this.empno = empno;
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"Sarang","Manager",50000);
            Employee e2 = new Employee(2, "Lucky", "Manager", 60000);
            Employee e3 = new Employee(3, "Akash", "Manager", 40000);

            Queue queue = new Queue();
            queue.Enqueue(e1);
            queue.Enqueue(e2);
            queue.Enqueue(e3);

            foreach(Employee e in queue)
            {
                Console.WriteLine("Employe Number : " + e.empno);
                Console.WriteLine("Employe Name : "+e.name);
                Console.WriteLine("Employe Designation : "+e.designation);
                Console.WriteLine("Employe Salary : " + e.salary);
            }
            Console.WriteLine();

            Console.WriteLine("Removed Items Below");
            Employee ep =(Employee)queue.Dequeue();
            Console.WriteLine("Empno : " + ep.empno + "\nName : " + ep.name + "\nDesignation : " + ep.designation + "\nSalary : " + ep.salary);
            Console.WriteLine();

            Console.WriteLine("Updated Details Of Employee : ");
            foreach(Employee e in queue)
            {
                Console.WriteLine("Employe Number : " + e.empno);
                Console.WriteLine("Employe Name : " + e.name);
                Console.WriteLine("Employe Designation : " + e.designation);
                Console.WriteLine("Employe Salary : " + e.salary);
            }

            Console.ReadLine();
        }
    }
}
