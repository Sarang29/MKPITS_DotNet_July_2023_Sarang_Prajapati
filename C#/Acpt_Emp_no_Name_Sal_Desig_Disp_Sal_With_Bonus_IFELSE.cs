using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Emp_no_Name_Sal_Desig_Disp_Sal_With_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;
            string name;
            int basicsalary;
            string designation;
            float bonus = 0;
            float total;

            Console.WriteLine("Enter Employe No.");
            no=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employe Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employe Basic Salary");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employe Designation");
            designation = Console.ReadLine();

           

            if (designation == "Manager")
            {
                bonus = basicsalary * 0.55f;
            }
            else if (designation == "Clerk")
            {
                bonus = basicsalary * 0.25f;
            }
            else if (designation == "Peon")
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                Console.WriteLine("Invalid Designation");
            }
            total = basicsalary + bonus;

            Console.WriteLine("Employe No = {0},\n Employe Name = {1},\n Basic Salary = {2},\n Designation = {3}", no, name, basicsalary, designation);
            Console.WriteLine(" Total Salary = {0},\n Bonus = {1}",total,bonus);
            Console.ReadKey();
        }
    }
}
