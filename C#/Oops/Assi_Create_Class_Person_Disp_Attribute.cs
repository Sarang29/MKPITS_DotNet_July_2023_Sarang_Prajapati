using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Create_Class_Person_Disp_Attribute
{
    class Person
    {
        string name;
        int age;
        string address;

        public void getdata(string name,int age,string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void displaydata()
        {
            Console.WriteLine("Person Name = " + name);
            Console.WriteLine("Person Age = " + age);
            Console.WriteLine("Person Address = " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.WriteLine("Enter Name,Age & Address");
            string pname=Console.ReadLine();
            int ag = Convert.ToInt32(Console.ReadLine());
            string add=Console.ReadLine();

            person1.getdata(pname, ag, add);

            person1.displaydata();

            Console.ReadKey();
        }
    }
}
