using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Modifiers_Example
{
    class Person
    {
        protected string name;
        protected long pno;
        protected string email;
    }
    class Employee : Person
    {
        public void getdata(string name, long pno,string email)
        {
            this.name = name;
            this.pno = pno;
            this.email = email;
        }
        public void display()
        {
            Console.WriteLine("Employe Name : " + name);
            Console.WriteLine("Employe Number : " + pno);
            Console.WriteLine("Employe Email : " + email);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.getdata("Sarang", 7378875024, "Sarangprajapati81@gmail.com");
            emp.display();

            Console.ReadKey();
        }
    }
}
