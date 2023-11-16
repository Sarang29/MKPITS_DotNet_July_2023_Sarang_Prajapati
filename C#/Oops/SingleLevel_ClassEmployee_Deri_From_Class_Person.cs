using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_ClassEmployee_Deri_From_Class_Person
{
    class Person
    {
        string Name;
        string Address;

        public void getpersondata(string Name,string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Employe Name : " + Name);
            Console.WriteLine("Employe Address : " + Address);
        }
    }

    class Employee : Person
    {
        int Id;
        int Salary;

        public void getemployedata(int Id,int Salary)
        {
            this.Id = Id;
            this.Salary = Salary;
        }
        public void displayemployedata()
        {
            Console.WriteLine("Employe Id : " + Id);
            Console.WriteLine("Employe Salary : " + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.getpersondata("Akash", "Nagpur");
            e1.getemployedata(123, 40000);
            e1.displaypersondata();
            e1.displayemployedata();

            Console.ReadKey();
        }
    }
}
