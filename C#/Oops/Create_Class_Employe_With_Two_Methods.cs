using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Employe_With_Two_Methods
{
    class Employe
    {
        int Emp_no;
        string Emp_name;
        string designation;
        int salary;
        public void getdata(int eno, string ename, string desig, int sal)
        {
            Emp_no = eno;
            Emp_name = ename;
            designation = desig;
            salary = sal;
        }

        public void displaydata()
        {
            Console.WriteLine("Employe Number = " + Emp_no);
            Console.WriteLine("Employe Name = " + Emp_name);
            Console.WriteLine("Designation = " + designation);
            Console.WriteLine("Salary = " + salary);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe();

            employe1.getdata(1, "Sarang", "Manager", 50000);
            employe1.displaydata();

            Console.ReadKey();
        }
    }
}
