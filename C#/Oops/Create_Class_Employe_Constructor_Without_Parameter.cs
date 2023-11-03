using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Employe_Constructor_Without_Parameter
{
    class Employe
    {
        public int EmployeNo { get; set; }
        public string EmployeName { get; set; }
        public string EmployeDesignation { get; set; }
        public int EmployeSalary { get; set; }

        public Employe()
        {
            EmployeNo = 1;
            EmployeName = "Lucky";
            EmployeDesignation = "Manager";
            EmployeSalary = 800000;
        }

        public void display()
        {
            Console.WriteLine("Employe Number : " + EmployeNo);
            Console.WriteLine("Employe Name : " + EmployeName);
            Console.WriteLine("Employe Designation : " + EmployeDesignation);
            Console.WriteLine("Employe Salary : " + EmployeSalary);
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();

            employe.display();

            Console.ReadKey();
        }
    }
}
