using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverLoading_Class_Employe_With_Four_Parameters
{
    class Employe
    {
        int EmployeId;
        string EmployeName;
        string Designation;
        int Salary;

        public void getdata()
        {
            EmployeId = 1;
            EmployeName = "Sarang";
            Designation = "Manager";
            Salary = 50000;
        }

        public void getdata(int EmployeId)
        {
            this.EmployeId = EmployeId;
        }

        public void getdata(int EmployeId, string EmployeName)
        {
            this.EmployeId = EmployeId;
            this.EmployeName = EmployeName;
        }

        public void getdata(int EmployeId,string EmployeName,string Designation)
        {
            this.EmployeId = EmployeId;
            this.EmployeName=EmployeName;
            this.Designation = Designation;
        }

        public void getdata(int EmployeId,string EmployeName,string Designation,int Salary)
        {
            this.EmployeId = EmployeId;
            this.EmployeName = EmployeName;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public void display()
        {
            Console.WriteLine("Employe Id : " + EmployeId);
            Console.WriteLine("Employe Name : " + EmployeName);
            Console.WriteLine("Employe Designation : " + Designation);
            Console.WriteLine("Employe Salary : " + Salary+"\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe();
            employe1.getdata();
            employe1.display();

            Employe employe2 = new Employe();
            employe2.getdata(2);
            employe2.display();

            Employe employe3 = new Employe();
            employe3.getdata(3,"Lucky");
            employe3.display();

            Employe employe4 = new Employe();
            employe4.getdata(4, "Sujit", "Incharge");
            employe4.display();

            Employe employe5 = new Employe();
            employe5.getdata(5, "Chetan", "Fresher",40000);
            employe5.display();

            Console.ReadKey();

        }
    }
}
