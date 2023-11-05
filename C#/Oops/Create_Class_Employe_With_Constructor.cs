using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Employe_With_Constructor
{
    class Employe
    {
        int EmployeNo;
        string EmployeName;
        string Designation;
        int Salary;

        public Employe()
        {
            EmployeNo = 1;
            EmployeName = "Sarang";
            Designation = "Manager";
            Salary = 90000;
        }
        public Employe(int EmployeNo,string EmployeName,string Designation,int Salary)
        {
            this.EmployeNo = EmployeNo;
            this.EmployeName=EmployeName; ;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public  void display()
        {
            Console.WriteLine("Employe Number : "+EmployeNo);
            Console.WriteLine("Employe Name : "+EmployeName);
            Console.WriteLine("Employe Designation : "+Designation);
            Console.WriteLine("Employe Salary : "+Salary);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new Employe();
            emp.display();

            Console.WriteLine();
            Console.Write("Enter Employe Number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employe Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Employe Designation : ");
            string designation = Console.ReadLine();

            Console.Write("Enter Employe Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employe emp1 = new Employe(no,name,designation,salary);

            emp1.display();

            Console.ReadKey();

            
        }
    }
}
